using MoviesRepository.Data.Models;
using System.Collections.Generic;

namespace MoviesRepository.Data.Repositories
{
    public interface ICategoryRepository
    {
        long Count();

        Category Find(int id);

        IEnumerable<Category> FindAll();

        Category FindByName(string name);

        bool Save(Category category);
    }
}