namespace Repositories.StudioRepository
{
    using Models;
    using System.Collections.Generic;

    public interface IStudioRepository
    {
        Studio GetStudioById(int id);

        IEnumerable<Studio> GetAllStudios { get; }
    }
}