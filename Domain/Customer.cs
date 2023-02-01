using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "EmailAddress is not valid")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "PhoneNumber is not valid")]
        public string PhoneNumber { get; set; }
        public virtual List<Address> Address { get; set; }
    }
}
