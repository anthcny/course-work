using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Dal
{
    public class Airplane
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int MaxDistance { get; set; }

        [Required]
        public int Carrying { get; set; }

        public override bool Equals(object obj)
        {
            var that = obj as Airplane;
            if (that == null)
                return base.Equals(obj);

            return Name == that.Name
                && MaxDistance == that.MaxDistance
                && Carrying == that.Carrying;
        }

        public override string ToString()
        {
            return String.Format("{0} (макс. груз: {1} кг.)", Name , Carrying);
        }
    }
}
