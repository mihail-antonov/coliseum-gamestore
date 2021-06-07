namespace Repositories.DetailRepository
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class DetailRepository : IDetailRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public DetailRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Detail> GetAllDetails => _appDbContext.Details.ToList();

        public Detail GetDetailByName(string name) => _appDbContext.Details
                   .Include(b => b.GameDetails)
                   .AsNoTracking()
                   .SingleOrDefault(x => x.Name == name);
    }
}