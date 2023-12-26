using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        // Construtor da classe Nokia
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Qualquer lógica adicional necessária para inicialização específica do Nokia
        }

        // Sobrescreve o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia.");
        }

        // Métodos adicionais específicos para o Nokia, se necessário
    }
}
