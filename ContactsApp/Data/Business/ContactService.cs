using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactsApp.Business;
using ContactsApp.Data.Entities;

namespace Data.Business
{
    public class ContactService : IContactService

    {

        private readonly IContactRepository _repo;



        public ContactService(IContactRepository repo)

        {

            _repo = repo;

        }



        public IEnumerable<Contact> ListarContactos()

        {

            // podrías aplicar paginación, filtros, ordenamientos... 

            return _repo.GetAll();

        }



        public void AddContact(Contact c)

        {

            if (string.IsNullOrWhiteSpace(c.Name))

                throw new ArgumentException("El nombre es obligatorio");

            _repo.Add(c);

        }



        public void UpdateContact(Contact c)

        {

            if (c.Id <= 0)

                throw new ArgumentException("Id no válido");

            _repo.Update(c);

        }



        public void DeleteContact(int id)

        {

            _repo.Delete(id);

        }

    }
}
