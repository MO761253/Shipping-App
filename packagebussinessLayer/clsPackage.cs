using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using packageDataLayer;
using System.Data;
namespace packagebussinessLayer
{
    public class clsPackage
    {
        private static List<clsPackage> Packages = new List<clsPackage>();
        public string packageType { get; set; }
        public string PackageSize { get; set; }
        public string description { get; set; }
        public decimal declaredvalue { get; set; }
        public bool isfragile { get; set; }
        public clsPackage(string packagetype,string PackageSize,string description,decimal declaredvalue,bool isfragile)
        {
            this.packageType = packagetype;
            this.PackageSize = PackageSize;
            this.description = description;
            this.declaredvalue = declaredvalue;
            this.isfragile = isfragile;
        }
        public static void Add_Package_ToList(clsPackage pack)
        {
            Packages.Add(pack);
        }
        public static decimal Get_Packages_Prices_By_ShipID(int shipID)
        {
            List<decimal> packagesprices = PackageDataLayer.Get_Packages_Prices_By_ShipID(shipID);
            decimal totalprice = 0;
            foreach(decimal Packprice in packagesprices)
            {
                totalprice += Packprice;
            }
            return totalprice;
        }
        public static decimal GetTotalPackagesPriceFromList()
        {
            decimal totalprice = 0;
            foreach(clsPackage package in Packages)
            {
                totalprice += package.declaredvalue;
            }
            return totalprice;
        }
        public static bool AddPackages(int ShipID)
        {
            foreach(clsPackage package in Packages)
            {
                if (!PackageDataLayer.Add_New_Package(ShipID, package.packageType, package.PackageSize, package.description, package.declaredvalue, package.isfragile))
                    return false;
            }
            return true;
        }
        public static DataTable Get_Packages_By_ShipID(int shipID)
        {
            return PackageDataLayer.Get_Packages_By_ShipID(shipID);
        }
        public static clsPackage Get_Package_By_PackID(int packID)
        {
            
            string packagesize = "", packagetype = "", description = "";
            decimal declaredvalue = 0;
            bool isfragile = false;
            if(PackageDataLayer.Get_Package_By_PackID(packID,ref packagetype,ref packagesize,ref description,ref declaredvalue,ref isfragile))
            {
                return new clsPackage(packagetype, packagesize, description, declaredvalue, isfragile);
            }
            return null;
        }
        public static bool Update_Package(int packageID, string packagesize, string packagetype, decimal declaredvalue, bool isfragile, string desc)
        {
            return PackageDataLayer.Update_Package(packageID, packagesize, packagetype, declaredvalue, isfragile, desc);
        }
    }
}
