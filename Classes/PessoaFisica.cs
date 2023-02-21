using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProgBackend.Interfaces;

namespace ProgBackend.Classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf {get; set;}
        
        public string? dataNasc {get; set;}

        public string caminho {get; private set;} = "Database/PessoaFisica.csv";

        public override float CalcularImposto(float rendimento)
        {
            if (rendimento <= 1500)
            {
                return  0;
            }
            else if (rendimento > 1500 && rendimento <=3500)
            {
                float resultado = (rendimento / 100) * 2f;
                return resultado;
            }
             else if (rendimento > 3500 && rendimento <=6000)
            {
                float resultado = (rendimento / 100) * 3.5f; 
                return resultado;           
            }
            else
            {
                float resultado = (rendimento / 100) * 5f;
                return resultado;
            }
            
            
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataNasc).TotalDays / 365;

            // Console.WriteLine(anos);

            if (anos >= 18)
            {
                return true;
            }
            return false;
        }
        public bool ValidarDataNasc(string dataNasc)
        {
           if (DateTime.TryParse(dataNasc, out DateTime dataConvertida))
           {
            DateTime dataAtual = DateTime.Today;
            double anos = (dataAtual - dataConvertida).TotalDays / 365;

            Console.WriteLine(anos);

            if (anos >= 18)
            {
                return true;
            }
            
           }
           
            return false;
        }
        public void Inserir (PessoaFisica PF)
        {
            VerificarPastaArquivo(caminho);
            string[] PFString = {$"{PF.nome}, {PF.cpf}, {PF.dataNasc}, {PF.endereco.Logradouro}, {PF.endereco.numero}, {PF.endereco.endComercial}, {PF.CalcularImposto(PF.rendimento)}"};

            File.AppendAllLines(caminho, PFString);
        }

        public List<PessoaFisica> Ler()
        {
            List<PessoaFisica> ListaPF = new List<PessoaFisica>();

            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas)
            {
                string[] atributos = cadaLinha.Split(",");

                PessoaFisica cadaPF = new PessoaFisica();

                cadaPF.nome = atributos[0];
                cadaPF.cpf = atributos[1];
                cadaPF.dataNasc = atributos[2];

                ListaPF.Add(cadaPF);
            }
            return ListaPF;
        }
    }
}