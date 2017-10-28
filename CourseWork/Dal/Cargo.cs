using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork.Dal
{
    /// <summary>
    /// Груз
    /// </summary>
    public class Cargo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }
        /// <summary>
        ///Вес в кг одной единицы
        /// </summary>
        public float Weight { get; set; }
        /// <summary>
        /// Кол-во единиц груза
        /// </summary>
        public int Quantity { get; set; }

        public int? TrafficId { get; set; }
        public Traffic Traffic { get; set; }


        public override bool Equals(object obj)
        {
            var that = obj as Cargo;
            if (that == null)
                return base.Equals(obj);

            return Name == that.Name
                && Weight == that.Weight
                && Quantity == that.Quantity;
        }

       
    }
}
