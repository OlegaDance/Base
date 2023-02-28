using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Diagnostics;

namespace BASA2
{
    internal class Order
    {

        [Key] public int id { get; set; }
        [Key]
        public string surname;
        public string name;
        public string numberphone;
        public string city;
        public string street;
        public string goods;
        public string count;

        public string SurName
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string NumberPhone
        {
            get { return numberphone; }
            set { numberphone = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string Goods
        {
            get { return goods; }
            set { goods = value; }
        }
        public string Count
        {
            get { return count; }
            set { count = value; }
        }

        public Order() { }

        public Order(  string surname,
         string name,
         string numberphone,
         string city,
         string street,
         string goods,
         string count)

        {
            this.surname= surname;
            this.name= name;
            this.numberphone= numberphone;
            this.city= city;
            this.street= street;
            this.goods= goods;
            this.count= count;


        }
        public override string ToString()
        {
            return $" {surname}   {name}   {numberphone}   {city}   {street}   {goods}   {count}";
        }
    }
}
