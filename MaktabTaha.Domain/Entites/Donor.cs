using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Domain.Entites
{
    public class Donor
    {
        public int DonorId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; } 
        public string FatherName { get; set; } 
        public string? NationalCode { get; set; }
        public string Address { get; set; }
    }
}
