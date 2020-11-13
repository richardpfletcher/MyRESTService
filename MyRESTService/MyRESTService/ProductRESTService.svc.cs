using System.Collections;
using System.Collections.Generic;

namespace MyRESTService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductRESTService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProductRESTService.svc or ProductRESTService.svc.cs at the Solution Explorer and start debugging.
    public class ProductRESTService : IProductRESTService
    {
        //http://localhost:17476/ProductRESTService.svc/GetProductList/
        //http://www.evolutionrevolutionoflove.com/MyRESTService/ProductRESTService.svc/GetProductList/

        public List<CIDR> GetProductList()
        {
            return CIDRs.Instance.CIDRList;
        }

        public IEnumerable<string> HelloData()
        {
            //http://localhost:17476/ProductRESTService.svc/HelloData/
            //http://www.evolutionrevolutionoflove.com/MyRESTService/ProductRESTService.svc/HelloData/
            IEnumerable<string> m_oEnum = new List<string>() { "Hello", "2", "3" };
            return m_oEnum;
        }
    }
}