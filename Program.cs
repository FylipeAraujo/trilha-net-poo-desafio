using System;

class Program
{
    static void Main()
    {
        // Testando a classe Nokia
        Console.WriteLine("Testando a classe Nokia:");
        Nokia nokia = new Nokia("123456789", "Nokia ModeloX", "NOK123", 32);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Testando a classe Iphone
        Console.WriteLine("Testando a classe Iphone:");
        Iphone iphone = new Iphone("987654321", "iPhone Modelo12", "IPHONE456", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        // Aguarda a entrada do usuário antes de encerrar o programa
        Console.ReadLine();
    }
}
