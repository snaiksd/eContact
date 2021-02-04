using eContact.Data.Entities.Core;
using System;

namespace eContact.Data.Entities
{
    public class Contact: BaseEntity
    {
        public int ContactId { get; set; }
        public int SourceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
        public int Status { get; set; }
    }
}