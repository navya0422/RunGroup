using RunGroup.Models;

namespace RunGroup.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var serviceProvider = serviceScope.ServiceProvider;
                var context = serviceProvider.GetService<ApplicationDbContext>();

                if (context != null)
                {
                    context.Database.EnsureCreated();
                

                    if (!context.Clubs.Any())
                    {
                    context.Clubs.AddRange(new List<Club>()
                    {
                        new Club()
                        {
                            Title= "Running Club 1",
                            Image = "https://www.bing.com/ck/a?!&&p=5d2e375fc78cdfc7JmltdHM9MTY4NzEzMjgwMCZpZ3VpZD0xNjQ1ZDA4ZC1hZmMxLTZlZDctMDI2MC1jMmUwYWVhZTZmNDEmaW5zaWQ9NTY2Nw&ptn=3&hsh=3&fclid=1645d08d-afc1-6ed7-0260-c2e0aeae6f41&u=a1L2ltYWdlcy9zZWFyY2g_cT1ydW5uaW5nIGltYWdlcyZGT1JNPUlRRlJCQSZpZD01NUQ3RjJCMUZCRTg0QTYwMTBFQzJCRkFGRDg0NzNGNjY0REFDMTUx&ntb=1",
                            Description=" Description of first cinema",
                            ClubCategory = Enum.ClubCategory.City,
                            Address = new Address()
                            {
                                Street = "123 Main st",
                                City = "Charolette",
                                State ="NC"
                            }
                        },
                        new Club()
                        {
                            Title= "Running Club 2",
                            Image = "https://www.bing.com/ck/a?!&&p=5d2e375fc78cdfc7JmltdHM9MTY4NzEzMjgwMCZpZ3VpZD0xNjQ1ZDA4ZC1hZmMxLTZlZDctMDI2MC1jMmUwYWVhZTZmNDEmaW5zaWQ9NTY2Nw&ptn=3&hsh=3&fclid=1645d08d-afc1-6ed7-0260-c2e0aeae6f41&u=a1L2ltYWdlcy9zZWFyY2g_cT1ydW5uaW5nIGltYWdlcyZGT1JNPUlRRlJCQSZpZD01NUQ3RjJCMUZCRTg0QTYwMTBFQzJCRkFGRDg0NzNGNjY0REFDMTUx&ntb=1",
                            Description=" Description of sec cinema",
                            ClubCategory = Enum.ClubCategory.Endurance,
                            Address = new Address()
                            {
                                Street = "123 Main st",
                                City = "Charolette",
                                State ="NC"
                            }
                        },
                        new Club()
                        {
                            Title= "Running Club 3",
                            Image = "https://www.bing.com/ck/a?!&&p=5d2e375fc78cdfc7JmltdHM9MTY4NzEzMjgwMCZpZ3VpZD0xNjQ1ZDA4ZC1hZmMxLTZlZDctMDI2MC1jMmUwYWVhZTZmNDEmaW5zaWQ9NTY2Nw&ptn=3&hsh=3&fclid=1645d08d-afc1-6ed7-0260-c2e0aeae6f41&u=a1L2ltYWdlcy9zZWFyY2g_cT1ydW5uaW5nIGltYWdlcyZGT1JNPUlRRlJCQSZpZD01NUQ3RjJCMUZCRTg0QTYwMTBFQzJCRkFGRDg0NzNGNjY0REFDMTUx&ntb=1",
                            Description=" Description of third cinema",
                            ClubCategory = Enum.ClubCategory.Trail,
                            Address = new Address()
                            {
                                Street = "123 Main st",
                                City = "Charolette",
                                State ="NC"
                            }
                        }

                    });
                    context.SaveChanges();
                }
                    //Race
                    if (!context.Races.Any())
                    {
                        context.Races.AddRange(new List<Race>()
                    {
                        new Race()
                        {
                            Title= "Running Club 1",
                            Image = "https://www.bing.com/ck/a?!&&p=5d2e375fc78cdfc7JmltdHM9MTY4NzEzMjgwMCZpZ3VpZD0xNjQ1ZDA4ZC1hZmMxLTZlZDctMDI2MC1jMmUwYWVhZTZmNDEmaW5zaWQ9NTY2Nw&ptn=3&hsh=3&fclid=1645d08d-afc1-6ed7-0260-c2e0aeae6f41&u=a1L2ltYWdlcy9zZWFyY2g_cT1ydW5uaW5nIGltYWdlcyZGT1JNPUlRRlJCQSZpZD01NUQ3RjJCMUZCRTg0QTYwMTBFQzJCRkFGRDg0NzNGNjY0REFDMTUx&ntb=1",
                            Description=" Description of first cinema",
                            RaceCategory = Enum.RaceCategory.Marathon,
                            Address = new Address()
                            {
                                Street = "123 Main st",
                                City = "Charolette",
                                State ="NC"
                            }
                        },
                        new Race()
                        {
                            Title= "Running Club 2",
                            Image = "update",
                            Description=" Description of sec cinema",
                            RaceCategory = Enum.RaceCategory.Ultra,
                            Address = new Address()
                            {
                                Street = "123 Main st",
                                City = "Charolette",
                                State ="NC"
                            }
                        }


                    });
                        context.SaveChanges();

                    }
                    }
            }
        }
    }
}

