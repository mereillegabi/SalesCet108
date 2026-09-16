using Microsoft.EntityFrameworkCore;
using SalesCet108.Web.Data.Entities;

namespace SalesCet108.Web.Data
{
    public class CountryRepository : GenericRepository<Country>, ICountryRepository
    {
        private readonly DataContext _context;

        public CountryRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<bool> CountryExistsByNameAsync(Country country) => await _context.Countries.AnyAsync(c => c.Id != country.Id && c.Name == country.Name);
    }
}
