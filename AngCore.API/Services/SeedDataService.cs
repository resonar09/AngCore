using AngCore.API.Data;
using AngCore.API.Models;
using System;
using System.Threading.Tasks;

namespace AngCore.API.Services
{
    public class SeedDataService : ISeedDataService
    {
        public async Task Initialize(DataContext context)
        {
            context.Database.EnsureCreated();
            context.Values.Add(new Value() {Id= 1,Name="Value 1"});
            context.Values.Add(new Value() {Id= 2,Name="Value 2"});
            context.Values.Add(new Value() {Id= 3,Name="Value 3"});

            await context.SaveChangesAsync();
        }
    }
}
