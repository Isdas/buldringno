using BuldringNo.Entities;
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
                string[] _images = Directory.GetFiles(Path.Combine(imagesPath, "images"));

                var _boulder1 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Barnehageveggen",
                        Description = "Veggen rett ved barnehagen."
                    }).Entity;
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Kruse",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "5B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Kulturell elite",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "6B+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Kulturell elite - Definert start",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "7A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "White trash",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "6A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "White trash - Definert start",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "7A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "White trash II",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "6B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Mens vi venter på Godoffe",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "7B+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Kardemomme by (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "7B+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Herkules",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "7A+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "David",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "6A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "David (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "6C+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Påskråriss",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "6C"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Saft suse",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "5A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Markjordbær",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "6B+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Blåbær",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         Grade = "3B"
                     });

                var _boulder2 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Dallsteinen",
                        Description = "Liten slopete stein."
                    }).Entity;
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Indisk dall (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[1]),
                         Boulder = _boulder2,
                         Grade = "7A"
                     });

                var _boulder3 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Hullet",
                        Description = "Lang stein med god landing."
                    }).Entity;
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Hullsag",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         Grade = "3B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Hullsag (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         Grade = "5C"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Risset",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         Grade = "6B+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Hullet",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         Grade = "6C+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Hullet (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         Grade = "7B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Bråthen safe",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         Grade = "7B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Rednecks",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         Grade = "7A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Sofa slækking",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         Grade = "7A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Tja",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         Grade = "5C"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Høyre prassel",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         Grade = "3B"
                     });

                var _boulder4 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Islas Canarias",
                        Description = "Stein litt inn fra stien."
                    }).Entity;
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Islas Canarias",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[3]),
                         Boulder = _boulder4,
                         Grade = "7A+"
                     });

                var _boulder5 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Pølse i lompe",
                        Description = "Stein rett ved et mygghøl."
                    }).Entity;
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Death Star canteen",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         Grade = "5A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "OL i mantling",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         Grade = "7A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Jernbanen",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         Grade = "3C"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Country Man",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         Grade = "5B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Lompe",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         Grade = "6A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Lompe (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         Grade = "7A+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Pølse i lompe",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         Grade = "6C+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Pølse i lompe (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         Grade = "7B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Kebab",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         Grade = "3B"
                     });

                _boulders.Add(_boulder1);
                _boulders.Add(_boulder2);
                _boulders.Add(_boulder3);
                _boulders.Add(_boulder4);
                _boulders.Add(_boulder5);

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
                    Name="Developer"
                },
                new Role()
                {
                    Name="Admin"
                }
                });

                context.SaveChanges();
            }
        }
    }
}
