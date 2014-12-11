using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.OData;
using Microsoft.WindowsAzure.Mobile.Service;
using mosheMposService.DataObjects;
using mosheMposService.Models;

namespace mosheMposService.Controllers
{
    public class mPoosInstallationCodeController : TableController<mPosInstallatCoode>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            mosheMposContext context = new mosheMposContext();
            DomainManager = new EntityDomainManager<mPosInstallatCoode>(context, Request, Services);
        }

        // GET tables/TodoItem
        public IQueryable<mPosInstallatCoode> GetAllmPoosInstallationCodes()
        {
            return Query();
        }

        // GET tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<mPosInstallatCoode> GetmPoosInstallationCode(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<mPosInstallatCoode> PatchmPoosInstallationCode(string id, Delta<mPosInstallatCoode> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/TodoItem
        public async Task<IHttpActionResult> PostmPoosInstallationCode(mPosInstallatCoode item)
        {
            mPosInstallatCoode current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeletemPoosInstallationCode(string id)
        {
            return DeleteAsync(id);
        }
    }
}