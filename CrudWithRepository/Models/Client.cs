using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudWithRepository.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Address { get; set; }
        public int City { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
    }
}
