using System;
using System.Configuration;
using System.Data;
using System.Threading.Tasks;
using System.Web.Http;
using Marten;
using Website.Models;

namespace Website.Controllers
{
    public class FridgeController : ApiController
    {
        private readonly IDocumentStore _store;
        private readonly IDocumentSession _session;

        public FridgeController() {
            var connectionString = ConfigurationManager.ConnectionStrings["Fridge.Database"].ConnectionString;
            _store = DocumentStore.For(_ => {
                _.Connection(connectionString);
                _.AutoCreateSchemaObjects = AutoCreate.CreateOrUpdate;
                _.Schema.For<FridgeRequestModel>();
            });
            _session = _store.LightweightSession(IsolationLevel.ReadCommitted);
        }

        protected override void Dispose(Boolean disposing) {
            base.Dispose(disposing);

            if (disposing) {
                _session.Dispose();
                _store.Dispose();
            }
        }

        public async Task<IHttpActionResult> Post([FromBody]FridgeRequestModel model) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            _session.Store(model);
            await _session.SaveChangesAsync();

            return Ok(new FridgeResponseModel());
        }
    }
}
