using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDaL;

        public ContactManager(IContactDal contactDaL)
        {
            _contactDaL = contactDaL;
        }

        public void TAdd(Contact entity)
        {
            _contactDaL.Add(entity);
        }

        public void TDelete(Contact entity)
        {
           _contactDaL.Delete(entity);
        }

        public Contact TGetByID(int id)
        {
            return _contactDaL.GetByID(id);
        }

        public List<Contact> TGetListAll()
        {
           return _contactDaL.GetListAll();
        }

        public void TUpdate(Contact entity)
        {
            _contactDaL.Update(entity);
        }
    }
}
