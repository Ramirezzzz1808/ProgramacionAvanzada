using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp.Data.Entities;

namespace Data
{
    public interface IContactRepository

    {

        IEnumerable<Contact> GetAll();

        Contact GetById(int id);

        void Add(Contact contact);

        void Update(Contact contact);

        void Delete(int id);

    }
}
