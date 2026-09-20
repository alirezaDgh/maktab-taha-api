using MaktabTaha.Application.Helpers;
using MaktabTaha.Application.Interfaces.Repositories;
using MediatR;

namespace MaktabTaha.Application.Features.user.Command.delete
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, OperationResult<bool>>
    {
        private readonly IUserRepository _repository;

        public DeleteUserHandler(IUserRepository repository)
        {
            _repository = repository;
        }


        public async Task<OperationResult<bool>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var operation = new OperationResult<bool>();

            var user = await _repository.GetBy(request.Id);

            if (user == null) return operation.Failure("کاربر یافت نشد");
            await _repository.Delete(user);

            return operation.Succedded(true);
        }
    }
}
