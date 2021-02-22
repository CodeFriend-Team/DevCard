using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.Models
{
    public class Services
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Services(int id,string name)
        {
            Id = id;
            Name = name;
        }
    }
}
