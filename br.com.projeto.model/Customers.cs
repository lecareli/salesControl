using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salesControl.br.com.projeto.model
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string postalCode { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string Neighborhood {  get; set; }
        public string City { get; set; }
        public string UF { get; set; }
    }
}
