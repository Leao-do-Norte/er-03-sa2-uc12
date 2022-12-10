// See https://aka.ms/new-console-template for more information

using er_02_sa2_uc12.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.cpf = "123.456.789-00";
novaPF.dataNasc = DateTime.Now;
novaPF.rendimento = 4230.49f;

Console.WriteLine($"Pessoa Fisica -----------------------");
Console.WriteLine($"CPF: {novaPF.cpf}");
Console.WriteLine($"Data de Nascimento: {novaPF.dataNasc}");
float resultado = novaPF.CalcularImposto(novaPF.rendimento);
Console.WriteLine($"Imposto a pagar: {resultado.ToString("C")}");

PessoaJuridica novaPJ = new PessoaJuridica();

novaPJ.razaoSocial = "Magazine Luiza S/A";
novaPJ.cnpj = "47.960.950/0001-21";

Console.WriteLine($"Pessoa Juridica ---------------------");
Console.WriteLine($"CNPJ: {novaPJ.cnpj}");
Console.WriteLine($"Razão Social: {novaPJ.razaoSocial}");
float impostoPagar = novaPJ.CalcularImposto(57890.76f);
Console.WriteLine($"Imposto a pagar: {impostoPagar.ToString("C")}");