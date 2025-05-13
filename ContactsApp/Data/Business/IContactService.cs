using System;

using System.Collections.Generic;

using ContactsApp.Data;

using ContactsApp.Data.Entities;
using Data;



namespace ContactsApp.Business

{

    public interface IContactService

    {

        IEnumerable<Contact> ListarContactos();

        void AddContact(Contact c);

        void UpdateContact(Contact c);

        void DeleteContact(int id);

    }



 

}