using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp.Data.Entities;

namespace Data
{
    
        public class InMemoryContactRepository : IContactRepository

        {

            private readonly List<Contact> _store = new List<Contact>();

        private int _nextId = 1;



            public IEnumerable<Contact> GetAll() => _store;



            public Contact GetById(int id) =>

                _store.FirstOrDefault(c => c.Id == id);



            public void Add(Contact contact)

            {

                contact.Id = _nextId++;

                _store.Add(contact);

            }



            public void Update(Contact contact)

            {

                var existing = GetById(contact.Id);

                if (existing == null) return;

                existing.Name = contact.Name;

                existing.Email = contact.Email;

                existing.Phone = contact.Phone;

            }



            public void Delete(int id)

            {

                var existing = GetById(id);

                if (existing != null)

                    _store.Remove(existing);

            }

        }

    }

