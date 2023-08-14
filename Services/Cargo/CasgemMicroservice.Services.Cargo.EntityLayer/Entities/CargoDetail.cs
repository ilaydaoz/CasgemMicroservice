using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Cargo.EntityLayer.Entities
{
    public class CargoDetail
    {
        public int CargoDetailId { get; set; }
        public int OrderId { get; set; }
        public string CargoStateId { get; set; }
        public CargoState CargoStates { get; set; }
    }
}
