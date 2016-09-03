using BuldringNo.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BuldringNo.Infrastructure
{
    public static class DbInitializer
    {
        private static BuldringNoContext context;
        public static void Initialize(IServiceProvider serviceProvider, string imagesPath)
        {
            context = (BuldringNoContext)serviceProvider.GetService(typeof(BuldringNoContext));

            InitializeUserRoles();
            InitializeProblemBoulders(imagesPath);
        }

        private static void InitializeProblemBoulders(string imagesPath)
        {
            if (!context.Boulders.Any())
            {
                List<Boulder> _boulders = new List<Boulder>();

                var _boulder1 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Boulder 1",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                    }).Entity;
                var _boulder2 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Boulder 2",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                    }).Entity;
                var _boulder3 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Boulder 3",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                    }).Entity;
                var _boulder4 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Boulder 4",
                        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."
                    }).Entity;

                _boulders.Add(_boulder1); _boulders.Add(_boulder2); _boulders.Add(_boulder3); _boulders.Add(_boulder4);

                string[] _images = Directory.GetFiles(Path.Combine(imagesPath, "images"));
                Random rnd = new Random();

                foreach (string _image in _images)
                {
                    int _selectedBoulder = rnd.Next(1, 4);
                    string _fileName = Path.GetFileName(_image);

                    context.Problems.Add(
                        new Problem()
                        {
                            Title = _fileName,
                            DateUploaded = DateTime.Now,
                            Uri = _fileName,
                            Boulder = _boulders.ElementAt(_selectedBoulder)
                        }
                        );
                }

                context.SaveChanges();
            }
        }

        private static void InitializeUserRoles()
        {
            if (!context.Roles.Any())
            {
                context.Roles.AddRange(new Role[]
                {
                new Role()
                {
                    Name="Admin"
                }
                });

                context.SaveChanges();
            }

            if (!context.Users.Any())
            {
                context.UserRoles.AddRange(new UserRole[] {
                new UserRole() {
                    RoleId = 1,
                    UserId = 1
                }
            });
                context.SaveChanges();
            }
        }
    }
}
