using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProgBackend.Interfaces;

namespace ProgBackend.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? nome {get; set;}

        public float rendimento {get; set;}

        public Endereco? endereco {get; set;}

        public abstract float CalcularImposto (float rendimento);
    }
}