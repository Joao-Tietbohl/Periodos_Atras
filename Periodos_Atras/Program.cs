using System;

namespace Periodos_Atras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string dataString = "12.12.2000";
            DateTime dataInput = Convert.ToDateTime(dataString);

          //  String dataString2 = "24.03.2022 10.30.15";
          //  DateTime dataInput2 = Convert.ToDateTime(dataString);

            TimeSpan diferencaDatas = DateTime.Now.Subtract(dataInput);
          //  TimeSpan diferencaDatas2 = DateTime.Now.Subtract(dataInput2);

            int contadorAnos = 0;
            int contadorMeses = 0;
            int contadorSemanas = 0;
            int contadorDias = 0;


            int diasDiferenca = diferencaDatas.Days;

            
            CalculaMaiorQueUmDia(ref dataInput, ref contadorAnos, ref contadorMeses, ref contadorSemanas, ref contadorDias, ref diasDiferenca);
            PrintMaiorQueUmDia(contadorAnos, contadorMeses, contadorSemanas, contadorDias);

            

           



        }

        public static void PrintMaiorQueUmDia(int contadorAnos, int contadorMeses, int contadorSemanas, int contadorDias)
        {
            if (contadorAnos > 0)
            {
                Console.Write(contadorAnos + " anos ");

            }

            if (contadorMeses > 0)
            {
                if (contadorAnos > 0)
                { E(); }
                Console.Write(contadorMeses + " meses ");

            }

            if (contadorSemanas > 0)
            {
                if (contadorMeses > 0)
                { E(); }
                Console.Write(contadorSemanas + " semanas ");

            }

            if (contadorDias > 0)
            {
                if (contadorSemanas > 0)
                { E(); }
                Console.Write(contadorDias + " dias ");
            }

            Console.Write("atrás");
        }

        private static void CalculaMaiorQueUmDia(ref DateTime data, ref int contadorAnos, ref int contadorMeses, ref int contadorSemanas, ref int contadorDias, ref int diasDiferenca)
        {
            Console.WriteLine();
            Console.Write(data.ToShortDateString() + " -> ");
            
            while (diasDiferenca >= 365)
            {
                diasDiferenca = diasDiferenca - 365;
                contadorAnos++;
            }
            //Calcula meses
            while (diasDiferenca >= 30 && diasDiferenca < 365)
            {
                diasDiferenca = diasDiferenca - 30;
                contadorMeses++;
            }
            //Calcula semanas
            while (diasDiferenca < 30 && diasDiferenca >= 7)
            {
                diasDiferenca = diasDiferenca - 7;
                contadorSemanas++;
            }
            //Calcula dias
            while (diasDiferenca < 7 && diasDiferenca > 0)
            {
                diasDiferenca = diasDiferenca - 1;
                contadorDias++;
            }
        }

        public static void E()
        {

            Console.Write("e ");

        }

    }
}
