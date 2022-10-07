using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDI2.Entities;


namespace CRUDI2.Services
{
    public interface IBaseCrudService<TPerson>{

        List<TPerson> Get();

        IQueryable<TPerson> Query();

        TPerson GetById(int id);

        TPerson Create(TPerson person);

        TPerson Update(TPerson person);

        bool Delete(int id);

    }

    public class BaseCrudServices<TPerson>: IBaseCrudService<TPerson> where TPerson: Base
    {
        private List<TPerson> _ListPeople;

        private int _id;

        public BaseCrudServices()
        {
            _ListPeople = new List<TPerson>();
            _id = 1;
        }

        public IQueryable<TPerson> Query()
        {
            return _ListPeople.AsQueryable().Where(x => x.Delete == false);
        }

        public List<TPerson> Get()
        {
            return Query().ToList();
        }

        public TPerson GetById(int id)
        {
            return Query().FirstOrDefault(item => item.Id == id);
        }

        public TPerson Create(TPerson Person)
        {
            Person.Id = _id;
            _ListPeople.Add(Person);
            _id++;
            return Person;
        }

        public TPerson Update(TPerson Person)
        {
            var SearchPerson = GetById(Person.Id);
            SearchPerson = Person;
            return Person;
        }

        public bool Delete(int id)
        {
            var PersonDelete = GetById(id);
            PersonDelete.Delete = true;
            return true;
        }

    }
}
