using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using er_02_sa2_uc12.Interfaces; 

namespace er_02_sa2_uc12.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf {get;set;}

        public DateTime dataNasc {get;set;}

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                float resultado = (rendimento*0.02f);
                return resultado;
            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                float resultado = (rendimento*0.035f);
                return resultado;
            }
            else
            {
                float resultado = (rendimento*0.05f);
                return resultado;
            }

            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}