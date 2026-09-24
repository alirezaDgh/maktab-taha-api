using MaktabTaha.Domain.Entites.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Domain.Entites
{
    public class InitialRequest
    {
        public int RequestNumber { get; set; }
        public DateTime RequestDate { get; set; }
        public string RequestDescription { get; set; }

        public int RequestTypeId { get; set; }
        public RequestType requestType { get; set; }

        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }

        public int HouseHeadStatusId { get; set; }
        public HouseHeadStatusDesc houseHeadStatus { get; set; }

        public string Gender { get; set; }

        public int RefererId { get; set; }
        public Donor Referer { get; set; }

        public int NationaltyId { get; set; }
        public Nationalty nationalty { get; set; }

        public int ProvinceId { get; set; }
        public Province province { get; set; }

        public int CityId { get; set; }
        public City city { get; set; }

        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string HomeNumber { get; set; }

        public int AreaId { get; set; }
        public Area area { get; set; }

        public int ReligonId { get; set; }
        public Religon religon { get; set; }

        // Approve
        public string? Status { get; set; }
        public string? StatusReason { get; set; }
        public DateTime? ApproveDate { get; set; }
        public string? OfficerDescription { get; set; }
        public byte[]? Attachment { get; set; }

    }
}
