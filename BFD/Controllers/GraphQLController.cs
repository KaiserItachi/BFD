using System.Threading.Tasks;
using BFD.Proxy;
using BFD.Query;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace BFD.Controllers
{
    [DisableCors]
    [Route("graphql")]
    [ApiController]
    public class GraphQLController: Controller
    {
        private readonly AccountDetailProxy _accountDetailsProxy;
        private readonly CashFlowProxy _cashFlowProxy;
        
        public GraphQLController(AccountDetailProxy accountDetailProxy, CashFlowProxy cashFlowProxy)
        {
            _accountDetailsProxy = accountDetailProxy;
            _cashFlowProxy = cashFlowProxy;
        }

        public async Task<IActionResult> Post ([FromBody] GraphQLQuery query)
        {
            var inputs = query.Variables.ToInputs();

            var schema = new Schema
            {
                Query = new BFDQuery(_accountDetailsProxy, _cashFlowProxy)
            };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = query.Query;
                _.OperationName = query.OperationName;
                _.Inputs = inputs;
            });

            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
