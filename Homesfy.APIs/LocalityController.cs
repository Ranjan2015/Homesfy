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
    public class LocalityController : ApiController
    {
        admin_homesfyEntities dbContext = new admin_homesfyEntities();
       
        /// <summary>
        /// This method is 
        /// </summary>
        /// <param name="cityID"></param>
        /// <returns></returns>
        public IEnumerable<mLocality> GetAllLocalityByCityID(Int64 cityID)
        {
            return dbContext.mLocalities.Where(p => p.mCityId == cityID).ToList();
        }

       
    }
}
