//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Earth.Api.Models.Foundations.Countries;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Earth.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Country> Countries { get; set; }

        public async ValueTask<Country> InsertCountryAsync(Country country)=>
            await InsertAsync(country);
       
        public async ValueTask<IQueryable<Country>> SelectAllCountriesAsync()=>
            await SelectAllAsync<Country>();
       
        public async ValueTask<Country> SelectCountryByIdAsync(int id)=>
            await SelectAsync<Country>(id);
        
        public async ValueTask<Country> UpdateCountryAsync(Country country)=>
            await UpdateAsync(country);
     
        public async ValueTask<Country> DeleteCountryAsync(Country country)=>
            await DeleteAsync(country);
    }
}
