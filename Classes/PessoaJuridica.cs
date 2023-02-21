using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ProgBackend.Interfaces;

namespace ProgBackend.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica  
    {
        public string? cnpj {get; set;}

        public string? razaoSocial {get; set;}

        public string caminho {get; private set;} = "Database/PessoaJuridica.csv";

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 3000)
            {
                return  rendimento * 0.03f;
            }
            else if (rendimento > 3000 && rendimento <=6000)
            {
                 return  rendimento * 0.05f;
            }
             else if (rendimento > 6000 && rendimento <=9000)
            {
                 return  rendimento * 0.07f;          
            }
            else
            {
                 return  rendimento * 0.09f;
            }
            
            throw new NotImplementedException();
        }

        public bool ValidarCnpj(string cnpj)
        {
           bool retornoCnpjValido = Regex.IsMatch(cnpj,@"^\d{14}|(\d{2}.\d{3}.\d{3}/d{4}-\{2})$");

           if (retornoCnpjValido)
           {
                string SubstringCnpj14 = cnpj.Substring(8, 4);

                if (SubstringCnpj14 == "0001")
                {
                return true;
                }
           }
                string SubstringCnpj18 = cnpj.Substring(11, 4);
                
                if (SubstringCnpj18 == "0001")
                {
                return true;
                }
            return false;
        }

        public void Inserir (PessoaJuridica PJ)
        {
            VerificarPastaArquivo(caminho);
            string[] PJString = {$"{PJ.nome}, {PJ.cnpj}, {PJ.razaoSocial}, {PJ.rendimento}, {PJ.endereco.Logradouro}, {PJ.endereco.numero}, {PJ.endereco.complemento}, {PJ.endereco.endComercial}"};

            File.AppendAllLines(caminho, PJString);
        }

        public List<PessoaJuridica> Ler()
        {
            List<PessoaJuridica> ListaPJ = new List<PessoaJuridica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPJ = new PessoaJuridica();

                cadaPJ.nome = atributos[0];
                cadaPJ.cnpj = atributos[1];
                cadaPJ.razaoSocial = atributos[2];

                ListaPJ.Add(cadaPJ);
            }
            return ListaPJ;
        }
    }
}