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
    public class mPosAllListController : TableController<mPosAllList>
    {
        protected override void Initialize(HttpControllerContext controllerContext)
        {
            base.Initialize(controllerContext);
            mosheMposContext context = new mosheMposContext();
            DomainManager = new EntityDomainManager<mPosAllList>(context, Request, Services);
        }

        // GET tables/TodoItem
        public IQueryable<mPosAllList> GetAllmPosAllLists()
        {
            return Query();
        }

        // GET tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public SingleResult<mPosAllList> GetmPosAllList(string id)
        {
            return Lookup(id);
        }

        // PATCH tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task<mPosAllList> PatchmPosAllList(string id, Delta<mPosAllList> patch)
        {
            return UpdateAsync(id, patch);
        }

        // POST tables/TodoItem
        public async Task<IHttpActionResult> PostmPosAllList(mPosAllList item)
        {
            mPosAllList current = await InsertAsync(item);
            return CreatedAtRoute("Tables", new { id = current.Id }, current);
        }

        // DELETE tables/TodoItem/48D68C86-6EA6-4C25-AA33-223FC9A27959
        public Task DeletemPosAllList(string id)
        {
            return DeleteAsync(id);
        }
    }
}