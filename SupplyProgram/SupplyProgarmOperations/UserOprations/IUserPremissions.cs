using System.Collections.Generic;


namespace SupplyProgarmOperations
{
    interface IUserPremissions
    {
        public string AddProductToStorage(string product, string location, string package, int stock, int order);
        public string RemoveProductfromStorage(string product, string location, string package);
        public string SearchinProductStockfull(string product,string location,string package, ref int stock, ref int order);
        public string SaveEditedChanges(string product, string location, string package, int stock, int order);
        public List<FullProductclass> GetFullProductStorageTable();
        
    }
    interface IAdminPermission
    {
        public string AddUserToDataBase(string username, string password, string email, string usertype);
        public string SearchUserinDataBase(string username, ref string email, ref string outpassword, ref string admin);
        public string DeleteUserToDataBase(string username);
        public string SaveEditedUserChanges(string username, string email, string password, string admin);
        public string AddProductToDatabase(string product);
        public string RemoveProductfromDatabase(string product);
        public string AddLocationToDatabase(string location);
        public string RemoveLocationFromDatabase(string location);
        public string AddPackageToDatabase(string package, string scale);
        public string RemovePackageFromDatabase(string package);
    }
    
}
