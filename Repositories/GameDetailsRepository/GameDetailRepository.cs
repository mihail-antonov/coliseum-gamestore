namespace Repositories.GameDetailsRepository
{
    using Data;
    using Microsoft.EntityFrameworkCore;
    using Models;
    using System.Collections.Generic;
    using System.Linq;

    public class GameDetailsRepository : IGameDetailsRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public GameDetailsRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public void Add(GameDetail gamedetail)
        {
            _appDbContext.Entry(gamedetail).State = EntityState.Detached;
            _appDbContext.GameDetails.Add(gamedetail);
            _appDbContext.SaveChanges();
        }
        public ICollection<GameDetail> GetGameDetail(int gameId) => _appDbContext.GameDetails.Include(x => x.Game)
                                                                                      .Include(x => x.Detail)
                                                                                      .Where(x => x.GameId == gameId).ToList();
    }
}