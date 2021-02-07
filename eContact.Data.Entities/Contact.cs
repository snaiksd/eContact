using eContact.Data.Entities.Core;
using System;

namespace eContact.Data.Entities
{
    public partial class Contact : BaseEntity
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
    }
}

//Design-Santosh Naik