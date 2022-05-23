using Bootcamp.Teleperformance.Hafta1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Teleperformance.Hafta1.DataManager
{
    public class CategoryManager : IDataManager
    {
        public bool Add(IModel product)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<IModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<IModel> GetById(int v, int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, IModel newProduct)
        {
            throw new NotImplementedException();
        }

        IModel IDataManager.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
