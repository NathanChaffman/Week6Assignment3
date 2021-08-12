using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StatuesRepository
{
    public interface CRUD
    {
        void Create(StatueTable obj);
        ICollection<StatueTable> Read();
        void Update(StatueTable obj);
        void Delete(StatueTable obj);
    }
    public class StatueDepot : CRUD
    {
        Week6Assignment3StatuesEntities entities;
        public StatueDepot()
        {
            entities = new Week6Assignment3StatuesEntities();
        }
        public void Create(StatueTable obj)
        {
            entities.StatueTables.Add(obj);
            entities.SaveChanges();
        }
        public void Delete(StatueTable obj)
        {
            entities.StatueTables.Remove(obj);
            entities.SaveChanges();
        }
        public ICollection<StatueTable> Read()
        {
            return entities.StatueTables.ToList();
        }
        public void Update(StatueTable obj)
        {

        }
        public void Save()
        {
            entities.SaveChanges();
        }
    }
}
