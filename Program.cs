using System;

namespace konsol_uyg_sayi_Tahmin_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("sayı tahmin oyunu");
            Console.WriteLine("Tahmin oyunumuza hoşgeldiniz!");

            int prediction;
            int memory;
            int counter = 0;

            Random random = new Random();
            memory = random.Next(0, 100);

            do
            {
                counter += 1;

                Console.WriteLine("sayı girin");
                prediction = Convert.ToInt32(Console.ReadLine());

                if (prediction < memory)
                {
                    Console.WriteLine("daha büyük");
                }
                else if (prediction > memory)
                {
                    Console.WriteLine("daha küçük!");
                }
            }
            while (prediction != memory);

            Console.WriteLine("*****TEBRİKLERRR*****");
            Console.WriteLine("{0}. denemede" , counter);
            Console.Read();
            
        }
    }
}
