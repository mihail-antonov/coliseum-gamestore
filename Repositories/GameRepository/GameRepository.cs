﻿namespace Repositories.GameRepository
{
    using Data;
    using Models;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    class GameRepository : IGameRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        public GameRepository(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Game> GetAllGames => _appDbContext.Games.Include(x => x.Studio)
                                                                    .Include(x => x.GameDetails).ThenInclude(x => x.Detail)
                                                                    .AsNoTracking().ToList();

        public Game GetGameById(int id) => _appDbContext.Games.Include(x => x.Studio)
                                                                    .Include(x => x.GameDetails).ThenInclude(x => x.Detail)
                                                                    .AsNoTracking().SingleOrDefault(x => x.Id == id);

        public void Add(Game game)
        {
            _appDbContext.Games.Add(game);
            _appDbContext.SaveChanges();
        }

        public void Update(Game game)
        {
            Game oldGame = _appDbContext.Games.Single(x => x.Id == game.Id);
            oldGame.Title = game.Title;
            oldGame.Price = game.Price;
            oldGame.Released = game.Released;
            _appDbContext.Entry(oldGame).State = EntityState.Modified;
            _appDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            Game game = _appDbContext.Games.Find(id);
            _appDbContext.Games.Remove(game);
            _appDbContext.SaveChanges();
        }

        public void Delete(Game game)
        {
            throw new System.NotImplementedException();
        }
    }
}