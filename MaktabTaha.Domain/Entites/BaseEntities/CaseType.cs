using MaktabTaha.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Domain.Entites.BaseEntities
{
    public class CaseType : BaseEntity<int>
    {
        public string CaseTypeName { get; set; }
    }
}
