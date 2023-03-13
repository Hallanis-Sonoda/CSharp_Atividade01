using System;

namespace ControleCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            float valPag;
                Console.WriteLine("Informar Nome");
                string varNome = Console.ReadLine();

                Console.WriteLine("Informar Endereço");
                string varEndereco = Console.ReadLine();

                Console.WriteLine("Pessoa Fisica(f) ou Jurídica(j)?");
                string varTipo = Console.ReadLine();
                if(varTipo == "f")
                {
                    PessoaFisica pf = new PessoaFisica();
                    pf.nome = varNome;
                    pf.endereco = varEndereco;
                    Console.WriteLine("Informar o CPF:");
                    pf.cpf = Console.ReadLine();
                    Console.WriteLine("Informar o RG:");
                    pf.rg = Console.ReadLine();
                    Console.WriteLine("Informar o valor de compra:");
                    valPag = float.Parse(Console.ReadLine());
                    pf.pagarImposto(valPag);
                    Console.WriteLine("--------Pessoa Fisíca--------");
                    Console.WriteLine("Nome ..........: "+pf.nome);
                    Console.WriteLine("Endereço ......: "+pf.endereco);
                    Console.WriteLine("CPF ...........: "+pf.cpf);
                    Console.WriteLine("RG ............: "+pf.rg);
                    Console.WriteLine("Valor de Compra: "+pf.valor.ToString("C"));
                    Console.WriteLine("Imposto .......: "+pf.valorImposto.ToString("C"));
                    Console.WriteLine("Total a pagar .: "+pf.total.ToString("C"));
                }
                if(varTipo == "j")
                {
                    PessoaJuridica pj = new PessoaJuridica();
                    pj.nome = varNome;
                    pj.endereco = varEndereco;
                    Console.WriteLine("Informar o CNPJ:");
                    pj.cnpj = Console.ReadLine();
                    Console.WriteLine("Informar o IE:");
                    pj.ie = Console.ReadLine();
                    Console.WriteLine("Informar o valor de compra:");
                    valPag = float.Parse(Console.ReadLine());
                    pj.pagarImposto(valPag);
                    Console.WriteLine("--------Pessoa Jurídica--------");
                    Console.WriteLine("Nome ..........: "+pj.nome);
                    Console.WriteLine("Endereço ......: "+pj.endereco);
                    Console.WriteLine("CNPJ ..........: "+pj.cnpj);
                    Console.WriteLine("Valor de Compra: "+pj.valor.ToString("C"));
                    Console.WriteLine("Imposto .......: "+pj.valorImposto.ToString("C"));
                    Console.WriteLine("Total a pagar .: "+pj.total.ToString("C"));
                }
            
        }
    }
}