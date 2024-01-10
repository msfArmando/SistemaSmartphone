using System;
using SistemaSmartphone.Models;

namespace SistemaSmartphone{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", iMEI: "11111111", memoria: 64);
            nokia.Ligar();
            nokia.InstalarAplicativo("Whatsapp");

            Console.WriteLine("\n");

            Console.WriteLine("Smartphone IPhone:");
            Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", iMEI: "22222222", memoria: 128);
            nokia.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");
        }
    }
}