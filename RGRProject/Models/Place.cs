using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RGRProject.Models
{
    public class Place
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Lattitude { get; set; }
        public double Longitude { get; set; }
        public int Rating { get; set; }
        public string[] Images { get; set; }
        public string Description { get; set; }
        public string[] Facilities { get; set; }
        public string Phone { get; set; }
        public string Site { get; set; }
        public int Status { get; set; }
    }
}
