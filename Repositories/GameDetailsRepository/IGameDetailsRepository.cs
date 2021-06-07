namespace Repositories.GameDetailsRepository
{
    using Models;
    using System.Collections.Generic;
    public interface IGameDetailsRepository
    {
        void Add(GameDetail gamedetail);
        ICollection<GameDetail> GetGameDetail(int gameId);
    }
}