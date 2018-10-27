using CodeAndCloud.Core;
using CodeAndCloud.Core.Entities;
using CodeAndCloud.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CodeAndCloud.Services.ContactService
{
    public class ContactService : IContactService
    {
        public void Add(AddContactViewModel model)
        {
            var db = new DataContext();

            var contact = new ContactModel()
            {
                CreatedDate = DateTime.Now,
                Email = model.Email,
                Name = model.Name,
                PhoneNumber = model.PhoneNumber
            };

            db.Add<ContactModel>(contact);
            db.SaveChanges();
        }
    }
}