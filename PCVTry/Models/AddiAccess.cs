using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PCVTry.Models
{
    public partial class AddiAccess
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddiAccessId { get; set; }
        public bool? Pci { get; set; }
        public bool? Fdic { get; set; }
        public bool? Crm { get; set; }
        public string CopyOf { get; set; }

        public ICollection<Applicationaccess> Applicationaccess { get; set; }
        public AddiAccess()
        {
            Applicationaccess = new HashSet<Applicationaccess>();
            
        }
    }
}
