using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace Costinas_Vlad_Lab10.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        [OneToMany]
        public List<ListProduct> ListProducts { get; set; }
    }
}