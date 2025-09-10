using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10._3.Models
{
    public class Dealership
    {
        [Key]
        public int DealershipID { get; set; }
        public string DealershipName { get; set; }
        public string Location { get; set; }
        public virtual ObservableCollectionListSource<Car> Cars { get; set; }
    }
}
