using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31.Models
{
    internal class VegetableFruitsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string color { get; set; }
        public int calories { get; set; }
        public override string ToString()
        {
            return string.Format($"{Id} {Name} {Type} {color} {calories}");
        }
    }
}
