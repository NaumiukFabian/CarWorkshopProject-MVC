using CarWorkshop.Domain.Entities;
using CarWorkshop.Domain.Interfaces;
using CarWorkshop.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWorkshop.Infrastructure.Repositories
{
    public class CarWorkshopServiceRepository : ICarWorkshopServiceRepository
    {
        private readonly CarWorkshopDbContext _dbcontext;
        public CarWorkshopServiceRepository(CarWorkshopDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task Create(CarWorkshopService carWorkshopService)
        {
            _dbcontext.Services.Add(carWorkshopService);
            await _dbcontext.SaveChangesAsync();
        }
    }
}
