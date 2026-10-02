using MaktabTaha.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Domain.Entites.BaseEntities
{
    public class Area : BaseEntity<int>
    {
        public string AreaName { get; set; }
    }
}
