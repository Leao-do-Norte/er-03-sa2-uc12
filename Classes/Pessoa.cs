using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using er_02_sa2_uc12.Interfaces;

namespace er_02_sa2_uc12.Classes
{
    public abstract class Pessoa : IPessoa
    {
        public string? nome {get; set;}

        public float rendimento {get;set;}

        public string? endereco {get;set;}

        public abstract float CalcularImposto (float rendimento);
    }
}