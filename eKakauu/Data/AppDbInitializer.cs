using eKakauu.Data.Enums;
using eKakauu.Models;

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

                if (!context.Cocoas.Any())
                {
                    context.Cocoas.AddRange(new List<Cocoa>()
                    {
                        new Cocoa()
                        {

                             Type = "Paraense",
                             Origin = "Para Medicilandia",
                             Description = "O cacau do Para e considerado um dos melhores do mundo." +
                             "Ele e descrito como mais suave, devido ao processo de fermentacao da amendoa",
                             CocoaType = CocoaType.Forasteiro,
                             Harvest = "outubro de 2023"
                        },
                        new Cocoa()
                        {

                            Type = "Bahiano",
                            Origin = "ilheus Baiha",
                            Description = "O cacau da Bahia e conhecido como Bahia Superior ou Tipo 1 de cacau." +
                            "E tambem e considerado um dos melhores do mundo junto com o Para.",
                            CocoaType = CocoaType.Forasteiro,
                            Harvest = "outubro de 2023"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.chocolates.Any())
                {
                    context.chocolates.AddRange(new List<Chocolate>()
                    {
                        new Chocolate()
                        {
                            imageURL = "ImageKakauu/chocolate.jpg",
                            Name = "Incrivel KakauDark",
                            ChocolateProcessing = "80%",
                            Flavor = "Kakau Amargo",
                            Validity = "20/01/2025",
                            price = 9.00,
                            ChocolateTypek = ChocolateType.Amargo,
                            CocoaId = 2,
                        },
                        new Chocolate()
                        {
                            imageURL = "ImageKakauu/ChocolateBranco.jpeg",
                            Name = "Incrivel KakauWhite",
                            ChocolateProcessing = "",
                            Flavor = "Kakau Branco",
                            Validity = "20/01/2025",
                            price = 9.00,
                            ChocolateTypek = ChocolateType.Branco,
                            CocoaId = 1,
                        },
                        new Chocolate()
                        {
                            imageURL = "ImageKakauu/ChocolateMaracuja.jpeg",
                            Name = "Kakau Ao Leite Com Maracuja Cremoso",
                            ChocolateProcessing = "40%",
                            Flavor = "Maracuja",
                            Validity = "20/01/2025",
                            price = 12.00,
                            ChocolateTypek = ChocolateType.AoLeite,
                            CocoaId = 1,
                        },
                    });
                    context.SaveChanges();
                }
            }
        }

    }
}
