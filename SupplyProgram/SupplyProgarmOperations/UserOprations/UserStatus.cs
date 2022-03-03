using DataBase.SupplyData;
using System.Linq;

namespace SupplyProgarmOperations
{
    public class UserStatus
    {
        public static bool UserExist(string username)
        {
            using (var db = new SuplyProgramContext())
            {
                var Userlist = db.Users.ToList();
                foreach (var user in Userlist)
                {
                    if (user.Username == username)
                    {
                        return true;
                    }
                }
            }
                return false;

        }
        public static bool UserLogin(string username,string password)
        {
            using (var db = new SuplyProgramContext())
            {
                var Userlist = db.Users.ToList();
                foreach (var user in Userlist)
                {
                    if (user.Username == username&&user.Password== password)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        public static bool AdminOrUser(string username, string password)
        {
            using (var db = new SuplyProgramContext())
            {
                var User = (db.Users.Where(u => u.Username == username && u.Password == password && u.Admin == true).Select(c => c.Admin)).Any();
                if (User)
                {
                    return true;
                }
                return false;                        
            }
        }
        public static bool ProductExist(string product)
        {
            using (var db = new SuplyProgramContext())
            {
                var Productlist = db.Products.ToList();
                foreach (var Product in Productlist)
                {
                    if (Product.ProductName == product)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        public static bool LocationExist(string location)
        {
            using (var db = new SuplyProgramContext())
            {
                var Locationlist = db.Locations.ToList();
                foreach (var Location in Locationlist)
                {
                    if (Location.Location1 == location)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        public static bool PackageExist(string package)
        {
            using (var db = new SuplyProgramContext())
            {
                var Packagelist = db.Packages.ToList();
                foreach (var Package in Packagelist)
                {
                    if (Package.PackageType == package)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        public static bool ScaleExist(string scale)
        {
            using (var db = new SuplyProgramContext())
            {
                var Scalelist = db.ScaleValues.ToList();
                foreach (var Scale in Scalelist)
                {
                    if (Scale.ScalesTypes == scale)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
      
    }



}

