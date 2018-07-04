using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AngularASPNETCore2WebApiAuth.Data;
using AngularASPNETCore2WebApiAuth.Models.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AngularASPNETCore2WebApiAuth.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]/[action]")]
  public class GridController : Controller
    {
        private readonly ClaimsPrincipal _caller;
        private readonly ApplicationDbContext _appDbContext;

        public GridController(UserManager<AppUser> userManager, ApplicationDbContext appDbContext, IHttpContextAccessor httpContextAccessor)
        {
            _caller = httpContextAccessor.HttpContext.User;
            _appDbContext = appDbContext;
        }

        // GET: api/Grid
        [HttpGet]
        public IEnumerable<TblMaster> GetEquipment()
        {
            return _appDbContext.TblMasters.ToList();
        }

        // GET: api/Grid/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<TblDetail> GetEquipmentDetail(int id)
        {
            return _appDbContext.TblDetails.Where(x => x.EquipmentID == id).ToList();
        }
        
        // POST: api/Grid
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Grid/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
