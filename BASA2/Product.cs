using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BASA2
{
    internal class Product
    {

        [Key] public int id { get; set; }
        [Key]
        public string name;
        public string sort;
        public string price;
        public string count;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Sort
        {
            get { return sort; }
            set { sort = value; }
        }
        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Count
        {
            get { return count; }
            set { count = value; }
        }

        public Product() { }
        public Product(string name, string sort, string price, string count)
        {
            this.name = name;
            this.sort = sort;
            this.price = price;
            this.count = count;
        }
        public override string ToString()
        {
            return $" {name}   {sort}   {price}   {count}";
        }
    }
}
