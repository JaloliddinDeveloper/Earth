//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Earth.Api.Models.Foundations.Countries;
using Microsoft.EntityFrameworkCore;

namespace Earth.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Country> Countries { get; set; }
    }
}
