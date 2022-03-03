using DataBase.SupplyData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SupplyProgarmOperations
{
    public class Adminuser : IAdminPermission, IUserPremissions
    {

        public string AddLocationToDatabase(string location)
        {
            using (var db = new SuplyProgramContext())
            {
                if (location == "")
                {
                    return "Please fill the location";
                }
                else
                {
                    var qurl = db.Locations.ToList();
                    foreach (var item in qurl)
                    {
                        if (location == item.Location1) { return "Location Allready exist"; }
                    }
                    var newlocation = new Location() { Location1 = location };
                    db.Locations.Add(newlocation);
                    db.SaveChanges();
                    return $"the Location {newlocation.Location1} added Succesfuly to database";
                }


            }
        }

        public string AddPackageToDatabase(string package, string scale)
        {
            using (var db = new SuplyProgramContext())
            {
                if (package == "")
                {
                    return "Please fill the all the package and scale field";
                }
                else
                {
                    var qurls = db.ScaleValues.ToList();
                    var qurlp = db.Packages.ToList();
                    foreach (var item in qurlp)
                    {
                        if (package == item.PackageType) { return "Product All ready exist"; }
                    }
                    int scaleid = 0;
                    foreach (var item in qurls)
                    {
                        if (item.ScalesTypes == scale) { scaleid = item.ScaleId; break; }
                    }

                    var newpackage = new Package() { PackageType = package, ScaleId = scaleid };
                    db.Packages.Add(newpackage);
                    db.SaveChanges();
                    return $"the Package {newpackage.PackageType} added Succesfuly to database";
                }


            }

        }

        public string AddProductToDatabase(string product)
        {
            using (var db = new SuplyProgramContext())
            {
                if (product == "")
                {
                    return "Please fill the Product name";
                }
                else
                {

                    if (UserStatus.ProductExist(product)) { return "Product All ready exist"; }
                    var newproduct = new Product() { ProductName = product };
                    db.Products.Add(newproduct);
                    db.SaveChanges();
                    return $"the Product {newproduct.ProductName} added Succesfuly to database";
                }


            }
        }

        public string AddProductToStorage(string location, string product, string package, int stock, int order)
        {
            using (var db = new SuplyProgramContext())
            {
                try
                {
                    ProductFluentBuilder productFluentBuilder = new ProductFluentBuilder();
                    ProductStatus1 productStatus = productFluentBuilder
                        .setProductname(product)
                        .setLocationname(location)
                        .setpackagename(package)
                        .setUnitInstock(stock)
                        .setUnitInorder(order).Build();
                    var checkEx = db.ProductStatus1s.Where(p => p.ProductId == productStatus.ProductId && p.LocationId == productStatus.LocationId && p.PackageId == productStatus.PackageId).Any();
                    if (checkEx) { return $"Product with the same prameters exist in storage '{location}'"; }
                    else
                    {
                        db.ProductStatus1s.Add(productStatus);
                        db.SaveChanges();
                        return $"Product: {product} has added succesfuly to storage: {location}";
                    }
                }
                catch
                {
                    return "Check your prarameters";
                }
            }
        }

        public string AddUserToDataBase(string username, string password, string email, string usertype)
        {
            Regex emailcheck = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var mailcheck = emailcheck.IsMatch(email);
            using (var db = new SuplyProgramContext())
            {
                if (username == "" || password == "" || usertype == "" || !mailcheck)
                {
                    return "Please fill all the fields";
                }
                else
                {
                    if (!UserStatus.UserExist(username))
                    {
                        var user = new User() { Username = username, Password = password, Admin = bool.Parse(usertype), Email = email };
                        db.Users.Add(user);
                        db.SaveChanges();
                        return $"user: {user.Username} has added succesfuly to database";
                    }
                    return "The username is already exist";
                }


            }

        }

        public string DeleteUserToDataBase(string username)
        {
            using (var db = new SuplyProgramContext())
            {
                if (UserStatus.UserExist(username))
                {
                    User user = db.Users.Where(u => u.Username == username).Select(u => u).First();
                    db.Users.Remove(user);
                    db.SaveChanges();

                    return $"user: {user.Username} has erased succesfully";
                }
                return "The username is not exist";
            }


        }


        public string RemoveLocationFromDatabase(string location)
        {
            using (var db = new SuplyProgramContext())
            {
                if (UserStatus.LocationExist(location))
                {

                    var exlocation = db.Locations.Where(u => u.Location1 == location).Select(u => u).First();
                    var MainExist = db.ProductStatus1s.Where(u => u.LocationId == exlocation.LocationId).Any();
                    if (MainExist)
                    {
                        return $"please erase Location: {exlocation.Location1} from the main storage list first";
                    }
                    db.Locations.Remove(exlocation);
                    db.SaveChanges();

                    return $"Location: {exlocation.Location1} has erased succesfully";
                }
                return "The Location is not exist";
            }
        }

        public string RemovePackageFromDatabase(string package)
        {
            using (var db = new SuplyProgramContext())
            {
                if (UserStatus.PackageExist(package))
                {
                    var expackage = db.Packages.Where(u => u.PackageType == package).Select(u => u).First();
                    var MainExist = db.ProductStatus1s.Where(u => u.PackageId == expackage.PackageId).Any();
                    if (MainExist)
                    {
                        return $"please erase Package: {expackage.PackageType} from the main storage list first";
                    }
                    db.Packages.Remove(expackage);
                    db.SaveChanges();

                    return $"Package: {expackage.PackageType} has erased succesfully";
                }
                return "The Package is not exist";
            }
        }

        public string RemoveProductfromDatabase(string product)
        {
            using (var db = new SuplyProgramContext())
            {
                if (UserStatus.ProductExist(product))
                {
                    Product exproduct = db.Products.Where(u => u.ProductName == product).Select(u => u).First();
                    var MainExist = db.ProductStatus1s.Where(u => u.ProductId == exproduct.ProductId).Any();
                    if (MainExist)
                    {
                        return $"please erase Product: {exproduct.ProductName} from the main storage list first";
                    }
                    db.Products.Remove(exproduct);
                    db.SaveChanges();

                    return $"Product: {exproduct.ProductName} has erased succesfully";
                }
                return "The Product is not exist";
            }
        }

        public string RemoveProductfromStorage(string product, string location, string package)
        {
            if (product != "" && location != "" && package != "")
            {

                using (var db = new SuplyProgramContext())
                {
                    var exproduct = db.Products.Where(p => p.ProductName == product).Select(p => p.ProductId).First();
                    var exlocation = db.Locations.Where(l => l.Location1 == location).Select(l => l.LocationId).First();
                    var expackage = db.Packages.Where(pa => pa.PackageType == package).Select(pa => pa.PackageId).First();

                    var checkEx = db.ProductStatus1s.Where(p => p.ProductId == exproduct && p.LocationId == exlocation && p.PackageId == expackage).Select(p => p).First();
                    db.ProductStatus1s.Remove(checkEx);
                    db.SaveChanges();
                    return $"{product} with package {package} has removed succesfuly from storage {location}";

                }
            }
            return "Plesae fill all the text boxes";
        }

        public string SearchinProductStockfull(string product, string location, string package, ref int stock, ref int order)
        {

            var list = GetFullProductStorageTable();
            foreach (var item in list)
            {
                if (item.Location == location && item.Product == product && item.Package == package)
                {
                    stock = Convert.ToInt32(item.UnitInStock);
                    order = Convert.ToInt32(item.UnitInOrder);
                    return "Found Product";

                }
            }
            return string.Empty;

        }

        public string SaveEditedChanges(string product, string location, string package, int stock, int order)
        {
            if (product != "" && location != "" && package != "")
            {

                using (var db = new SuplyProgramContext())
                {
                    var exproduct = db.Products.Where(p => p.ProductName == product).Select(p => p.ProductId).First();
                    var exlocation = db.Locations.Where(l => l.Location1 == location).Select(l => l.LocationId).First();
                    var expackage = db.Packages.Where(pa => pa.PackageType == package).Select(pa => pa.PackageId).First();

                    ProductStatus1 Temppro = db.ProductStatus1s.Where(p => p.ProductId == exproduct && p.LocationId == exlocation && p.PackageId == expackage).First();
                    Temppro.UnitInstock = stock;
                    Temppro.UnitinOrder = order;
                    db.SaveChanges();
                    return $"Product updated suucesfuly";


                }
            }
            return $"please fill all the changes";
        }
        public string SaveEditedUserChanges(string username, string email, string password, string admin)
        {
            Regex emailcheck = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            var mailcheck = emailcheck.IsMatch(email);
            if (username != "" && mailcheck && password != "" && admin != "")
            {
                if (UserStatus.UserExist(username))
                {
                    using (var db = new SuplyProgramContext())
                    {
                        User TempUser = db.Users.Where(u => u.Username == username).First();
                        TempUser.Password = password;
                        TempUser.Email = email;
                        TempUser.Admin = bool.Parse(admin);
                        db.SaveChanges();
                        return $"User {TempUser.Username} updated successfuly";
                    }
                }
                return $"username is not exist";
            }
            return $"please fill all the boxes or search first";
        }


        public string SearchUserinDataBase(string username, ref string email, ref string outpassword, ref string admin)
        {
            using (var db = new SuplyProgramContext())
            {
                if (username == "")
                {
                    return "Please fill username";
                }
                else
                {
                    if (UserStatus.UserExist(username))
                    {
                        User user = db.Users.Where(u => u.Username == username).Select(u => u).First();
                        outpassword = user.Password;
                        admin = user.Admin.ToString();
                        email = user.Email;
                        return $"user: {user.Username} has been found";
                    }
                    return "The username is not exist";
                }


            }
        }

        public List<FullProductclass> GetFullProductStorageTable()
        {
            using (var db = new SuplyProgramContext())
            {

                var qur = from l in db.ProductStatus1s
                          join l1 in db.Locations on l.LocationId equals l1.LocationId
                          join l2 in db.Products on l.ProductId equals l2.ProductId
                          join l3 in db.Packages on l.PackageId equals l3.PackageId
                          join l4 in db.ScaleValues on l3.ScaleId equals l4.ScaleId
                          select new FullProductclass
                          {
                              Id = l.StatusId,
                              Location = l1.Location1,
                              Product = l2.ProductName,
                              Package = l3.PackageType,
                              Scale = l4.ScalesTypes,
                              UnitInStock = l.UnitInstock,
                              UnitInOrder = l.UnitinOrder
                          };
                var listProduct = qur.ToList();

                return listProduct;

            }
        }


    }

    public class Normaluser : IUserPremissions
    {
        Adminuser admin = new Adminuser();
        public string AddProductToStorage(string location, string product, string package, int stock, int order)
        {
            var result = admin.AddProductToStorage(location, product, package, stock, order);
            return result;
        }

        public List<FullProductclass> GetFullProductStorageTable()
        {
            var result = admin.GetFullProductStorageTable();
            return result;
        }

        public string RemoveProductfromStorage(string product, string location, string package)
        {
            var result = admin.RemoveProductfromStorage(product, location, package);
            return result;
        }

        public string SaveEditedChanges(string product, string location, string package, int stock, int order)
        {
            var result = admin.SaveEditedChanges(product, location, package, stock, order);
            return result;

        }

        public string SearchinProductStockfull(string product, string location, string package, ref int stock, ref int order)
        {
            var result = admin.SearchinProductStockfull(product, location, package, ref stock, ref order);
            return result;
        }




    }
}
