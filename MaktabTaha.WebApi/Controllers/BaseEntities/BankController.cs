using MaktabTaha.Application.Features.BaseEntities.Bank;
using Microsoft.AspNetCore.Mvc;

namespace MaktabTaha.WebApi.Controllers.BaseEntities;

[ApiController]
[Route("api/[controller]")]
public class BankController : BaseApiController
{
    [HttpGet]
    public async Task<IActionResult> GetBanksList()
    {
        return Ok(await Mediator.Send(new GetBankListCommand()));
    }
}
