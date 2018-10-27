using System;
using System.Collections.Generic;
using System.Text;
using CodeAndCloud.ViewModel;

namespace CodeAndCloud.Services.ContactService
{
    class FakeService : IContactService
    {
        public void Add(AddContactViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
