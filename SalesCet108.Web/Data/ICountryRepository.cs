using SalesCet108.Web.Data.Entities;

namespace SalesCet108.Web.Data
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        public Task<bool> CountryExistsByNameAsync(Country country);
    }
}
