using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgBackend.Classes
{
    public class Endereco
    {
        public string? Logradouro {get; set;}
        public int numero {get; set;}
        public string? complemento { get; set; }
        public bool endComercial { get; set; }
        
        
    }
}