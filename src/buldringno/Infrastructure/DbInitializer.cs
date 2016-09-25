using BuldringNo.Entities;
using System;
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
                string[] _images = Directory.GetFiles(Path.Combine(imagesPath, "images"));

                var _area1 = context.Areas.Add(
                    new Area
                    {
                        DateCreated = DateTime.Now,
                        Title = "Filmplaneten nord",
                        DescriptionMain = "Hovedforklaring av Filmplaneten nord",
                        DescriptionSecondary = "Utfyllende tekst om Filmplaneten nord"
                    }).Entity;
                var _area2 = context.Areas.Add(
                    new Area
                    {
                        DateCreated = DateTime.Now,
                        Title = "Filmplaneten sør",
                        DescriptionMain = "Hovedforklaring av Filmplaneten sør",
                        DescriptionSecondary = "Utfyllende tekst om Filmplaneten sør"
                    }).Entity;
                var _area3 = context.Areas.Add(
                    new Area
                    {
                        DateCreated = DateTime.Now,
                        Title = "Lia",
                        DescriptionMain = "Hovedforklaring av Lia",
                        DescriptionSecondary = "Utfyllende tekst om Lia"
                    }).Entity;

                var _boulder1 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Barnehageveggen",
                        DescriptionMain = "Veggen rett ved barnehagen.",
                        Area = _area1
                    }).Entity;
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Kruse",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "5B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Kulturell elite",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "6B+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Kulturell elite - Definert start",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "7A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "White trash",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "6A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "White trash - Definert start",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "7A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "White trash II",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "6B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Mens vi venter på Godoffe",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "7B+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Kardemomme by (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "7B+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Herkules",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "7A+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "David",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "6A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "David (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "6C+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Påskråriss",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "6C"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Saft suse",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "5A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Markjordbær",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "6B+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Blåbær",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[0]),
                         Boulder = _boulder1,
                         GradeStandingStart = "3B"
                     });

                var _boulder2 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Dallsteinen",
                        DescriptionMain = "Liten slopete stein.",
                        Area = _area1
                    }).Entity;
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Indisk dall (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[1]),
                         Boulder = _boulder2,
                         GradeStandingStart = "7A"
                     });

                var _boulder3 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Hullet",
                        DescriptionMain = "Lang stein med god landing.",
                        Area = _area1
                    }).Entity;
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Hullsag",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         GradeStandingStart = "3B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Hullsag (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         GradeStandingStart = "5C"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Risset",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         GradeStandingStart = "6B+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Hullet",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         GradeStandingStart = "6C+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Hullet (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         GradeStandingStart = "7B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Bråthen safe",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         GradeStandingStart = "7B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Rednecks",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         GradeStandingStart = "7A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Sofa slækking",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         GradeStandingStart = "7A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Tja",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         GradeStandingStart = "5C"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Høyre prassel",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[2]),
                         Boulder = _boulder3,
                         GradeStandingStart = "3B"
                     });

                var _boulder4 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Islas Canarias",
                        DescriptionMain = "Stein litt inn fra stien.",
                        Area = _area3
                    }).Entity;
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Islas Canarias",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[3]),
                         Boulder = _boulder4,
                         GradeStandingStart = "7A+"
                     });

                var _boulder5 = context.Boulders.Add(
                    new Boulder
                    {
                        DateCreated = DateTime.Now,
                        Title = "Pølse i lompe",
                        DescriptionMain = "Stein rett ved et mygghøl.",
                        Area = _area2
                    }).Entity;
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Death Star canteen",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         GradeStandingStart = "5A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "OL i mantling",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         GradeStandingStart = "7A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Jernbanen",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         GradeStandingStart = "3C"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Country Man",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         GradeStandingStart = "5B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Lompe",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         GradeStandingStart = "6A"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Lompe (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         GradeStandingStart = "7A+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Pølse i lompe",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         GradeStandingStart = "6C+"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Pølse i lompe (SS)",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         GradeStandingStart = "7B"
                     });
                context.Problems.Add(
                     new Problem()
                     {
                         Title = "Kebab",
                         DateUploaded = DateTime.Now,
                         Uri = Path.GetFileName(_images[4]),
                         Boulder = _boulder5,
                         GradeStandingStart = "3B"
                     });

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
