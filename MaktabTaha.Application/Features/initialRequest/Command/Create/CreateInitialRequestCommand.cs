using MaktabTaha.Application.Helpers;
using MaktabTaha.Domain.Entites;
using MaktabTaha.Domain.Entites.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.initialRequest.Command.Create
{
    public class CreateInitialRequestCommand : IRequest<OperationResult<InitialRequest>>
    {
        public DateTime RequestDate { get; set; }
        public string RequestDescription { get; set; }

        public int RequestTypeId { get; set; }

        public string ClientFirstName { get; set; }
        public string ClientLastName { get; set; }

        public int HouseHeadStatusId { get; set; }

        public string Gender { get; set; }

        public int RefererId { get; set; }

        public int NationaltyId { get; set; }

        public int ProvinceId { get; set; }
        public int CityId { get; set; }

        public string Address { get; set; }
        public string MobileNumber { get; set; }
        public string HomeNumber { get; set; }

        public int AreaId { get; set; }

        public int ReligonId { get; set; }
    }
}
