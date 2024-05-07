using API.Data.DataBase;
using API.Data.Entities.DesignPattern.Entities;
using Microsoft.AspNetCore.Components.Web;

namespace API.Data.Entities
{
    public static class DbInitializer
    {
        public static void Initialize(DataPulseContext context)
        {
            // if (context.DesignPattern.Any()) return;
            
            var designPatterns = new List<DesignPatternEntity>
            {
                new DesignPatternEntity
                { 
                    Title = "asd",
                    Body = "asd"
                }
            };

            context.DesignPatterns.AddRange(designPatterns);
            context.SaveChangesAsync();
        }
    }
}