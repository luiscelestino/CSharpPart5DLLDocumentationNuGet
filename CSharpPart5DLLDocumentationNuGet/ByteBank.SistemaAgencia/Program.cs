using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataFimPagamento = new DateTime(2019, 09, 25);
            DateTime dataCorrente = DateTime.Now;

            //TimeSpan diferenca = dataFimPagamento - dataCorrente;
            TimeSpan diferenca = TimeSpan.FromMinutes(60);

            string mensagem = "Vencimento em " + Humanizer.TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);
            

            Console.ReadKey();
        }

    }
}
