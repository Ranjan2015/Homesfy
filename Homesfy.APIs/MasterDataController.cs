using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net.Http;
using Homesfy.Entities;


namespace Homesfy.APIs
{
    /// <summary>
    /// This controller is being using like a API to fetch all masters
    /// </summary>
    public class MasterDataController : ApiController
    {
        admin_homesfyEntities dbContext = new admin_homesfyEntities();

        /// <summary>
        /// This method is used to fetch all active master Cities
        /// </summary>
        /// <returns></returns>
        public IEnumerable<mCity> GetAllCities()
        {
            return dbContext.mCities.Where(p => p.Status == true).ToList();
        }




    }
}
