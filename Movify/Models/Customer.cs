using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Movify.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required] // using data annotations namespace
        [StringLength(255)]
        public string Name { get; set; }
        public string Birthdate { get; set; }
        public bool IsSubbedToNewsLetter { get; set; }
        // navigation prop => it allows to navigate from one type to another (useful for loading an obj and its related obj from a db)
        public MembershipType MembershipType { get; set; }
        // MembershipTypeId is the foreign key to MembershipType class id
        public byte MembershipTypeId { get; set; }
    }
}