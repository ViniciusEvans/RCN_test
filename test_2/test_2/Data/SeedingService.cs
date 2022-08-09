using test_2.Models;

namespace test_2.Data
{
    public class SeedingService
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<Context>();

                if (context.Pets.Any() || context.People.Any())
                {
                    return;
                }
            Person p1 = new ("Rafael", 18, 1);
            Person p2 = new ("Victor",15, 2);
            Person p3 = new ("Aline",19,0);
            Person p4 = new ("Rayssa",23, 0);
            Person p5 = new ("Bruno",45, 0);
            Person p6 = new ("Francisco",55, 0);
            Person p7 = new ("Daniel",30, 4);
            Person p8 = new ("Euclides",33, 3); 
            Person p9 = new ("Maria",25, 2);
            Person p10 = new ("paula",22, 1);

            Pet pt1 = new ("Félix",false, null);
            Pet pt2 = new ("Simba",false, null);
            Pet pt3 = new ("Nora", false, null);
            Pet pt4 = new ("Rajah", false, null);
            Pet pt5 = new ("Mingau",  false, null);
            Pet pt6 = new ("Garfield", false, null);
            Pet pt7 = new ("Goose", false, null);
            Pet pt8 = new ("Tom", false, null);
            Pet pt9 = new ("Frajola", true, p1);
            Pet pt10 = new ("Cruel", true, p1);
            Pet pt11 = new ("Marie" ,true, p2);
            Pet pt12 = new ("Luna", true, p2);
            Pet pt13 = new("Tigrão", true, p3);
            Pet pt14 = new ("Frajuto", true, p3);

            context.People.AddRange(p1, p2, p3, p4, p5, p6, p7, p8, p9, p10);
            context.Pets.AddRange(pt1, pt2, pt3, pt4, pt5, pt6, pt7, pt8, pt9, pt10, pt11, pt12, pt13, pt14);
            context.SaveChanges();
            }
   

        }
    }
}
