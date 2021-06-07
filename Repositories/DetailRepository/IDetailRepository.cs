namespace Repositories.DetailRepository
{
    using Models;
    using System.Collections.Generic;

    public interface IDetailRepository
    {
        IEnumerable<Detail> GetAllDetails { get; }
        Detail GetDetailByName(string name);
    }
}