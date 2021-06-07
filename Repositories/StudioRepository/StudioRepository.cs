namespace Repositories.StudioRepository
{
    using Data;
    using Models;
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;

    public class StudioRepository : IStudioRepository
    {
        private readonly ApplicationDbContext _appDbContext;

        public StudioRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Studio> GetAllStudios => _appDbContext.Studios.Include(x => x.Games)
            .ToList();

        public Studio GetStudioById(int id) => _appDbContext.Studios
                    .AsNoTracking()
                    .SingleOrDefault(x => x.Id == id);
    }
}
