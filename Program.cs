using System;


namespace codigo_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Clear();
             
            string Masc = "000.##";

            for (int i = 0 ; i <=255 ;i++)
            {
                //Console.Write($"{i} = ");
                System.Console.Write($"| {i.ToString(Masc)} - {(char)i} ");
                if (i%10==0){Console.WriteLine("");}

            }
        }
    }
}
