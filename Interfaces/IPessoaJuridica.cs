using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace er_02_sa2_uc12.Interfaces
{
    public interface IPessoaJuridica
    {
        bool ValidarCnpj (string cnpj);
    }
}