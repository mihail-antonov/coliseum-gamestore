namespace Repositories.GameRepository
{
    using Models;
    using System.Collections.Generic;

    public interface IGameRepository
    {
        Game GetGameById(int id);
        Game GetGameByTitle(string title);
        IEnumerable<Game> GetAllGames { get; }
        int Add(Game car);
        void Update(Game car);
        void Delete(int car);
    }
}