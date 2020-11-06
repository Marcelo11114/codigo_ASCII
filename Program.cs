using System;


namespace codigo_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Clear();
             
            string Masc = "000.##",nchar ;
            Console.WriteLine("                    Tabela ASCII - Caracteres Imprimíveis");

            int l=0, n;
           Console.WriteLine("|Dec Char Oct  Hex |Dec Char Oct  Hex |Dec Char Oct  Hex |Dec Char Oct  Hex |");
           Console.WriteLine("|--- ---- ---  --- |--- ---- ---  --- |--- ---- ---  --- |--- ---- ---  --- |");
            for (int i = 32 ; i <=127 ;i++)
            {
                Console.Write($"|{i.ToString(Masc)} ");       // decimal
                System.Console.Write($" {(char)i}   ");      // Caracter
                nchar= Convert.ToString(i,8);n=Convert.ToInt16(nchar);// ficou feia essa solução
                Console.Write($"{n.ToString(Masc)}  ");  // oct
                Console.Write($"{Convert.ToString(i, 16)}  ");// Hex
                if (l==3){ l=0; Console.WriteLine("|");}
                  else {l++;}               
            }
            Console.Write("\nQqr Tecla P/ Sair");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
