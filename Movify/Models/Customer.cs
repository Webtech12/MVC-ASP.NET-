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
        [Required] // using dataannotations namespace
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubbedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}