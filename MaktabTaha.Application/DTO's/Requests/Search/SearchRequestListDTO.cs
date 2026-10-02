using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.DTO_s.Requests.Search
{
    public class SearchRequestListDTO
    {
        public int? RequestId { get; set; }
        public string? ClientFirstName { get; set; }
        public string? ClientLastName { get; set; }
        public int? RequestTypeId { get; set; }
        public int? RequestStatusId { get; set; }
        public DateTime? FromApproveDate { get; set; }
        public DateTime? ToApproveDate { get; set; }
    }
}
