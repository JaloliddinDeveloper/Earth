//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Earth.Api.Models.Foundations.Countries;
using System.Linq;
using System.Threading.Tasks;

namespace Earth.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Country> InsertCountryAsync(Country country); 
        ValueTask<IQueryable<Country>> SelectAllCountriesAsync();   
        ValueTask<Country> SelectCountryByIdAsync(int id);
        ValueTask<Country> UpdateCountryAsync(Country country);
        ValueTask<Country> DeleteCountryAsync(Country country);
    }
}
