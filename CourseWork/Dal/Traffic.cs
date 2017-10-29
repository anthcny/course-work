using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Dal
{
    public class Traffic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public ICollection<Cargo> Cargos { get; set; } = new List<Cargo>();

        public int IdAirportFrom { get; set; }
        public int IdAirportTo { get; set; }
        public int IdAirplane { get; set; }
    }
}
