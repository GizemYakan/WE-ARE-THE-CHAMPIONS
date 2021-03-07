using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsData.Models
{
   [Table("Colors")]
    public class Color
    {
        public int Id { get; set; }

        [Required]
        public string ColorName { get; set; }

        [Required, Range(0, 255)]
        public int ColorRed { get; set; }

        [Required, Range(0, 255)]
        public int ColorGreen { get; set; }

        [Required, Range(0, 255)]
        public int ColorBlue { get; set; }

        public virtual ICollection<Team> Teams { get; set; }

        public override string ToString()
        {
            return ColorName;
        }
    }

}
