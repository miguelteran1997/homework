using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OffPractice.Data
{
    public class Players
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PID { get; set; }
        public string PN { get; set; }
        public string PL { get; set; }
         
        //foreign key
        public int CID { get; set; }

        [ForeignKey("CID")]
        public Coach Coaches { get; set; }

        //foreign key
        public int TID { get; set; }

        [ForeignKey("TID")]
        public Team Teams { get; set; }


    }
}
