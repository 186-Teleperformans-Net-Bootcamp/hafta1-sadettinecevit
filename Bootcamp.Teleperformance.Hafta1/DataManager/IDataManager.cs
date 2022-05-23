using Bootcamp.Teleperformance.Hafta1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Teleperformance.Hafta1.DataManager
{
    public interface IDataManager
    {
        public List<IModel> GetAll();
        public IModel GetById(int id);
        public bool Add(IModel product);
        public bool Update(int id, IModel newProduct);
        public bool Delete(int id);
    }
}
