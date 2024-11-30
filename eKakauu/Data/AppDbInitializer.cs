using eKakauu.Data.Enums;
using eKakauu.Models;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace eKakauu.Data
{
    public class AppDbInitializer
    {
        public static void Seed(WebApplication app)
        {
            using (var serviceScope = app.Services.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                // É aonde vamos adicionar os dados.
                context.Database.EnsureCreated();

                if (!context.Brands.Any())
                {
                    context.Brands.AddRange(new List<Brand>()
                    {
                        new Brand()
                        {
                            Name = "Kakauu",
                            Description = "Kakauu é uma marca brasileira comprometida em apoiar pequenos e médios"+ 
                                           "produtores de cacau, valorizando não apenas a excelência na qualidade da produção,"+
                                           "mas também o respeito ao meio ambiente e a preservação das tradições agrícolas locais."+
                                           "Com foco na sustentabilidade e no sabor único, Kakauu busca oferecer aos consumidores uma"+
                                           "experiência inigualável, ao mesmo tempo em que contribui para o crescimento e fortalecimento"+ 
                                           "da agricultura familiar."
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Users.Any())
                {
                    context.Users.AddRange(new List<User>()
                    {
                        new User()
                        {
                            Username = "UserA",
                            Email = "usera@example.com",
                            Password = "Password123"
                        },
                        new User()
                        {
                            Username = "UserB",
                            Email = "userb@example.com",
                            Password = "Password123"
                        },
                        new User()
                        {
                            Username = "UserC",
                            Email = "userc@example.com",
                            Password = "Password123"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Chocolates.Any())
                {
                    context.Chocolates.AddRange(new List<Chocolate>()
                    {
                        new Chocolate()
                        {
                            Name = "Incrivel KakauDark",
                            ChocolateProcessing = "80",
                            Flavor = "Kakau Amargo",
                            Validity = "20/01/2025",
                            price = 9.00,
                            imageURL = "ImageKakauu/chocolate.jpg",
                            ChocolateTypek = ChocolateType.Amargo,
                            BrandId = 1 
                        },
                        new Chocolate()
                        {
                            Name = "Incrivel KakauWhite",
                            ChocolateProcessing = "",
                            Flavor = "Kakau Branco",
                            Validity = "20/01/2025",
                            price = 9.00,
                            imageURL = "ImageKakauu/ChocolateBranco.jpeg",
                            ChocolateTypek = ChocolateType.Branco,
                            BrandId = 1 
                        },
                        new Chocolate()
                        {
                            Name = "Kakau Ao Leite Com Maracuja Cremoso",
                            ChocolateProcessing = "40",
                            Flavor = "Maracuja",
                            Validity = "20/01/2025",
                            price = 12.00,
                            imageURL = "ImageKakauu/ChocolateMaracuja.jpeg",
                            ChocolateTypek = ChocolateType.AoLeite,
                            BrandId = 1 
                        },
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
