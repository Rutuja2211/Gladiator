using OnlineShoppingWebAPIProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OnlineShoppingWebAPIProject.Controllers
{
    [EnableCors("*","*","*")]public class RetailerController : ApiController
    {
        OnlineShoppingEntities db = new OnlineShoppingEntities();
        
        [HttpPost]
        public async Task<bool> AddRetailer([FromBody]User user)
        {
            try
            {
                await Task.Run(() =>db.proc_add_retailer(user.UserName,user.UserEmail,user.UserPhone));
                return true;
            }
            catch
            {
                return false;
            }
        }
        [HttpDelete]
        public async Task<IHttpActionResult> DeleteRetailer(int id)
        {
            Retailer retailer = await db.Retailers.FindAsync(id);
            if (retailer == null)
            {
                return NotFound();
            }

            db.Retailers.Remove(retailer);
            User user = await db.Users.FindAsync(id);
            db.Users.Remove(user);
            await db.SaveChangesAsync();

            return Ok();
        }
    }
}
