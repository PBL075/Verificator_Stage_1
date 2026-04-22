using System;

namespace verificator_stage_1
{
    class Program
    {
        static void Main()
        {
            string masina = "RS3";
            int cp = 425;
            double razgon = 3.8 ;

            int putereStage1 = 50;

            int totalPutere = cp + putereStage1;

            Console.WriteLine("RS3 stock : " + cp + "HP");
            Console.WriteLine(masina + " stage1 " + totalPutere + "HP" + " cu razgon de " + razgon + " sec ");

        }
    }
}
