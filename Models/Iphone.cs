using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Qualquer lógica adicional necessária para inicialização específica do iPhone
        }

        // Sobrescreve o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone.");
            // Lógica adicional específica para a instalação de aplicativos em um iPhone, se necessário
        }

        // Métodos adicionais específicos para o iPhone, se necessário
    }
}
