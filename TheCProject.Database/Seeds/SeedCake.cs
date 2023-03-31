using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheCProject.Database.DbEntities;
using TheCProject.Database.Seeds.Base;

namespace TheCProject.Database.Seeds
{
    public static class SeedCake
    {
        public static void PopulateCakes(IApplicationBuilder app)
        {

            var dbCtx = SeedBase.DbContext(app);
            if (!dbCtx.Cake.Any())
            {
                List<Cake> lst = new List<Cake>()
                {
                    new Cake
                    {
                        Name = "GENOISE CAKE",
                        Description= "Fluffy Genoise sponge houses a delightful layer of Chantilly cream and the cake is complete with lashings of vanilla buttercream. Delicately decorated with our bestselling colored granules and confetti, serve it as a centrepiece at your next dinner party, or enjoy a slice with your morning coffee for a delicious start to your day. This cake is a true celebration of all things!",
                        Author = "Uknown",
                        ImageURL = "/Img/Grupo-1964.png"
                    },
                    new Cake
                    {
                        Name = "BUTTERY CAKE",
                        Description= "Indulge in the rich, velvety goodness of our Caramel and Chocolate Cake! This divine creation features layers of decadent sponge cake generously filled with a luscious chocolate mousse and pink caramel sauce. The cake is topped with smooth buttercream, chantilli and an extra sprinkling of pink granules, donuts and oreos. Each bite is a heavenly combination of rich, intense chocolate and gooey, buttery caramel! Our Caramel and Chocolate Cake is the perfect treat for any occasion, experience the ultimate indulgence in every bite.",
                        Author = "Uknown",
                        ImageURL = "/Img/Grupo-1967.png"
                    },
                    new Cake
                    {
                        Name = "VELVET CHIFFON",
                        Description= "A perfect combination of delicious velvet sponge filled with pink berry buttercream and jam housed in yet more mouth-watering berry buttercream. The toppings on this cake are really quite something and will add a touch of luxury to any celebration, cherries, pink chantilli and granules. A cake fit for royalty, spoil them this special occasion…",
                        Author = "Uknown",
                        ImageURL = "/Img/Grupo-1966.png"
                    },
                    new Cake
                    {
                        Name = "YOGURT & MERINGUE (WITHOUT FLOUR)",
                        Description = "Classic French tartlets of yogurt dough filled with meringue and fresh strawberries. Divine for dessert or just as a treat any time.",
                        Author = "Uknown",
                        ImageURL = "/Img/Grupo-1965.png"
                    },
                    new Cake
                    {
                        Name = "CHOCOLAT & CARROT CAKE",
                        Description= "Crafted from the softest of sponges, our Classic Carrot Cake will leave you wanting more! Three indulgent layers of carrot cake are generously filled with sweetened vanilla cream cheese. This cake is beautifully finished with chocolat all over and a smothering of Colored granules and pecan nuts for the ultimate crunch. A fabulous centrepiece for any occasion or simply a treat with a cup of tea, add a personalised message for an extra special touch.",
                        Author = "Uknown",
                        ImageURL = "/Img/Grupo-1968.png"
                    },
                    new Cake
                    {
                        Name = "CHOCOLAT WITH PINK FROSTING",
                        Description= "Indulge yourself with layers of chocolate sponge filled with chocolate buttercream and strawberry jam. This ultimate chocolate cake is housed in additional chocolate buttercream and beautifully finished with a dripping pink chocolate glaze.",
                        Author = "Uknown",
                        ImageURL = "/Img/Grupo-1963.png"
                    },
                    new Cake
                    {
                        Name = "LOT BREAD WITH STRAWBERRIES",
                        Description = "Crafted from a combination of beautifully soft lot breadwith sponge filled with vanilla buttercream and strawberry, the cake is housed in lashings of delicious vanilla buttercream. Fabulous for any occasion or simply a treat with a cup of tea.",
                        Author = "Uknown",
                        ImageURL = "/Img/Grupo-1962.png"
                    }

                };

                lst.ForEach(entity =>
                {
                    SeedBase.PopulateBase(entity);
                });

                dbCtx.Cake.AddRange(lst);

                try
                {
                    dbCtx.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    throw;
                }
            }
        }
    }
}
