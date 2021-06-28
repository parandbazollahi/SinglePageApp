using SinglePageApp.Data;
using SinglePageApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SinglePageApp.Controllers
{
    public class PeopleController : ApiController
    {
        SinglePageAppContext db = new SinglePageAppContext();

        public IEnumerable<Person> GetPeople()
        {
            return db.People;
        }
        public Person GetById(int id)
        {
            return db.People.Find(id);
        }

        public void PostPerson( Person person)
        {
            db.People.Add(person);
            _ = db.SaveChanges();
        }

        public void PutPerson(int id, Person person)
        {
            if(id== person.ID)
            {
                db.Entry(person).State = System.Data.Entity.EntityState.Modified;
                _ = db.SaveChanges();
            }
        }

        public void DeletePerson(int id)
        {
            var person = GetById(id);
            db.Entry(person).State = System.Data.Entity.EntityState.Deleted;
            _ = db.SaveChanges();

        }
    }
}


