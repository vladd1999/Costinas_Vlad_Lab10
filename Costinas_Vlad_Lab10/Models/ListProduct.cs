using SQLite;
using SQLiteNetExtensions.Attributes;
namespace Costinas_Vlad_Lab10.Models
{
    public class ListProduct
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(Costinas_Vlad_Lab10.Models.ShopList))]
        public int ShopListID { get; set; }
        public int ProductID { get; set; }
    }
}