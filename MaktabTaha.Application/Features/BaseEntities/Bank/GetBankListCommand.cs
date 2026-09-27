using MaktabTaha.Application.DTOs.BaseEntities.Bank.List;
using MaktabTaha.Application.Helpers;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Bank
{
    public class GetBankListCommand : IRequest<OperationResult<List<BankListDTO>>>
    {
    }
}
