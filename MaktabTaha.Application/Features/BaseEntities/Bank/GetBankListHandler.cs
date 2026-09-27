using AutoMapper;
using MaktabTaha.Application.DTOs.BaseEntities.Bank.List;
using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces;
using MaktabTaha.Application.Interfaces.Repositories.BaseEntities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaktabTaha.Application.Features.BaseEntities.Bank
{
    public class GetBankListHandler : IRequestHandler<GetBankListCommand, OperationResult<List<BankListDTO>>>
    {
        private readonly IBankRepository _repository;
        private readonly IMapper _mapper;
        public GetBankListHandler(IBankRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<OperationResult<List<BankListDTO>>> Handle(GetBankListCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<List<BankListDTO>>();

            var Banks = await _repository.List();
            var mappedData = _mapper.Map<List<BankListDTO>>(Banks);
            return operation.Succedded(mappedData);
        }
    }
}
