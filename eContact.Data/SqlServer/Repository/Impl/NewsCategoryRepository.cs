using eNews.Data.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace eNews.Data.SqlServer.Repository
{
    public class NewsCategoryRepository : IBaseRepository<NewsCategory>
    {
        private static List<NewsCategory> newsCategories =
              new List<NewsCategory>()
              {
                new NewsCategory
                {
                     CategoryId = 1,
                     CatogryName = "World"
                },
                new NewsCategory
                {
                     CategoryId = 2,
                     CatogryName = "Political"
                },
                new NewsCategory
                {
                     CategoryId = 3,
                     CatogryName = "Sports"
                },
                new NewsCategory
                {
                     CategoryId = 4,
                     CatogryName = "Travel"
                },
                new NewsCategory
                {
                     CategoryId = 5,
                     CatogryName = "Advertisements"
                },
                new NewsCategory
                {
                     CategoryId = 6,
                     CatogryName = "Business"
                },
                new NewsCategory
                {
                     CategoryId = 7,
                     CatogryName = "Finance"
                },
                new NewsCategory
                {
                     CategoryId = 8,
                     CatogryName = "Entertainment"
                },
                new NewsCategory
                {
                     CategoryId = 9,
                     CatogryName = "Lifestyle"
                },
                new NewsCategory
                {
                     CategoryId = 10,
                     CatogryName = "Technology"
                }
          };
        public NewsCategoryRepository()
        {
        }

        public void Delete(NewsCategory entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NewsCategory> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable Get(IDbCommand dbCommand)
        {
            throw new NotImplementedException();
        }

        public List<NewsCategory> GetAllNewsCategories()
        {
            return newsCategories;
        }

        public NewsCategory GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public NewsCategory GetNewsCategory(int categoryId)
        {
            return newsCategories.Where(c => c.CategoryId == categoryId).FirstOrDefault();
        }

        public IEnumerable GetWithRawSql(string query, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public void Insert(NewsCategory entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void SetUnitWork(IUnitOfWork unitOfWork)
        {
            throw new NotImplementedException();
        }

        public void Update(NewsCategory entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
