using DataBase.SupplyData;
using System.Linq;


namespace SupplyProgarmOperations
{
    public class ProductFluentBuilder
    {
        private ProductStatus1 productStatus = new ProductStatus1();
        public ProductStatus1 Build() => productStatus;

        public ProductFluentBuilder setProductname(string productName)
        {
            using (var db = new SuplyProgramContext())
            {
             var productid = db.Products.Where(p=>p.ProductName==productName).Select(p=>p.ProductId).FirstOrDefault();
             productStatus.ProductId= productid;
            }
            return this;
        }
        public ProductFluentBuilder setLocationname(string locationName)
        {
            using (var db = new SuplyProgramContext())
            {
                var locationid = db.Locations.Where(l => l.Location1 == locationName).Select(p => p.LocationId).FirstOrDefault();
                productStatus.LocationId = locationid;
            }
            return this;
        }
        public ProductFluentBuilder setpackagename(string packageName)
        {
            using (var db = new SuplyProgramContext())
            {
                var packageid = db.Packages.Where(p => p.PackageType == packageName).Select(p => p.PackageId).FirstOrDefault();
                productStatus.PackageId = packageid;
            }
            return this;
        }
        public ProductFluentBuilder setUnitInstock(int unitStock)
        {
            productStatus.UnitInstock = unitStock;
            return this;
        }
        public ProductFluentBuilder setUnitInorder(int unitOrder)
        {
            productStatus.UnitinOrder = unitOrder;
            return this;
        }
    }
}
