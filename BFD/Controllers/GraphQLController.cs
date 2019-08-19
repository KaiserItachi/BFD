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
        private readonly CustomerProxy _customerProxy;
        
        public GraphQLController(AccountDetailProxy accountDetailProxy, CashFlowProxy cashFlowProxy, CustomerProxy customerProxy)
        {
            _accountDetailsProxy = accountDetailProxy;
            _cashFlowProxy = cashFlowProxy;
            _customerProxy = customerProxy;
        }

        public async Task<IActionResult> Post ([FromBody] GraphQLQuery query)
        {
            var inputs = query.Variables?.ToInputs();

            var schema = new Schema
            {
                Query = new BFDQuery(_accountDetailsProxy, _cashFlowProxy, _customerProxy)
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
