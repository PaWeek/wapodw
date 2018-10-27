using System;
using System.Collections.Generic;
using System.Text;
using CodeAndCloud.ViewModel;

namespace CodeAndCloud.Services.ContactService
{
    public interface IContactService
    {
        void Add(AddContactViewModel model);
    }
}
