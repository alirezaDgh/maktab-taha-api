using MaktabTaha.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Domain.Entites.BaseEntities
{
    public class City : BaseEntity<int>
    {
        public int CityCode { get; set; }
        public string CityName { get; set; }
        public int ProvinceId { get; set; }
        public Province province { get; set; }
    }
}
