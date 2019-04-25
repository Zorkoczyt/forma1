using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace forma1.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Foundation { get; set; }
        public int NumberOfWcs { get; set; }
        public bool isEntryFee { get; set; }
    }
}
