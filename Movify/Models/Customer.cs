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
        [Required(ErrorMessage = "Enter Name")] // using data annotations namespace
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name="D.O.B")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
        public bool IsSubbedToNewsLetter { get; set; }
        // navigation prop => it allows to navigate from one type to another (useful for loading an obj and its related obj from a db)
        public MembershipType MembershipType { get; set; }

        [Display(Name="Membership Type")]
        // MembershipTypeId is the foreign key to MembershipType class id
        public byte MembershipTypeId { get; set; }
    }
}