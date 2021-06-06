namespace Repositories.GameRepository
{
    using Models;
    using System.Collections.Generic;

    public interface IGameRepository
    {
        Game GetGameById(int id);
        Game GetGameByStudio(string studio);

        IEnumerable<Game> GetAllGames { get; }

        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
