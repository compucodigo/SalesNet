
using Sales.Shared.Entities;

namespace Sales.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _dataContext;

        public SeedDb(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();
            await CheckCountriosAsync();

        }

        private async Task CheckCountriosAsync()
        {
            if (!_dataContext.Countries.Any())
            {
                _dataContext.Countries.AddRange(new List<Country>()
                {
                    new Country() { Name = "Brazil" },
                    new Country() { Name = "USA" },
                    new Country() { Name = "Canada" },
                    new Country() { Name = "Argentina" },
                    new Country() { Name = "Colombia" },
                    new Country() { Name = "Chile" },
                    new Country() { Name = "Peru" },
                    new Country() { Name = "Venezuela" },
                    new Country() { Name = "Ecuador" },
                    new Country() { Name = "Paraguay" }
                });
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
