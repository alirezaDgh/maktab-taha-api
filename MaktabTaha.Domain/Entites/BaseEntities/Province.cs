using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Domain.Entites.BaseEntities
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<City> cities { get; set; } = new List<City>();
    }
}
