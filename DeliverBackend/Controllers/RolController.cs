using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.Azure.Mobile.Server;
using DeliverBackend.Models;

namespace DeliverBackend.Controllers
{
    public class RolController : TableController<Rol>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            var context = new DeliverBackendContext();
            DomainManager = new EntityDomainManager<Rol>(context, Request);
        }

        // GET tables/Rol
        public IQueryable<Rol> GetAllRol()
        {
            return Query(); 
        }

        // GET tables/Rol/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<Rol> GetRol(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/Rol/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<Rol> PatchRol(string id, Delta<Rol> patch)
        {
             return UpdateAsync(id, patch);
        }

        // POST tables/Rol
        public async Task<IHttpActionResult> PostRol(Rol item)
        {
            Rol current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/Rol/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeleteRol(string id)
        {
             return DeleteAsync(id);
        }
    }
}
