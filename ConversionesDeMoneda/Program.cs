namespace ConversionesDeMoneda
{
    internal class Program
    {
        //este es el metodo principale
        static void Main(string[] args)
        {
            //creamos un sico infinito
            while (true)
            {

                //llamamos al metodo MostrarMenu
                MostrarMenu();

                string respuestaUsuario = Console.ReadLine();

                switch (respuestaUsuario)
                {
                    case "1":
                        ConvertirPesosADolares();
                        break;
                    case "2":
                        ConvertirDolaresAPesos();
                    case "3":
                        ConvertirPesosAEuros();
                    case "4":
                        ConvertirEurosAPesos();
                        break;
                    case "5":
                        Console.WriteLine("Opcion incorrecta");
                        break;


                }

                Console.ReadLine();
            }

        }

        //este es un metodoq m imprime las opciones para el usuario
        static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Conversiones");
            Console.WriteLine("1) Pesos a Dolares");
            Console.WriteLine("2) Dolares a Pesos");
            Console.WriteLine("3) Pesos a euros");
            Console.WriteLine("4) euros a Pesos");
            Console.WriteLine("");

        }
        static void ConvertirPesosADolares()
        {
            Console.WriteLine("pesos a dolares");
            Console.WriteLine("introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(Console.ReadLine(), out decimal tipoDeCambio);



            Console.WriteLine("introducir la cantidad de pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(Console.ReadLine(), out decimal pesos);

            decimal dolares = PesosADolares(tipoDeCambio, pesos);
            Console.WriteLine($"cantidad de dolares:{dolares.ToString("N2")}");


        }
        static void ConvertirDolaresAPesos()
        {
            Console.WriteLine("Dolares a pesos");
            Console.WriteLine("introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(respuestaUsuario, out decimal tipoDeCambio);

            Console.WriteLine("Introducir la cantidad en dolares");
            respuestaUsuario = Console.ReadLine();

            decimal.TryParse(respuestaUsuario, out decimal dolares);


            decimal pesos = DolaresAPesos(tipoDeCambio, dolares);
            Console.WriteLine($"la cantidad en pesos es: {pesos.ToString("N2")}");
        }
        static void ConvertirPesosAEuros()
        {
            Console.WriteLine("pesos a euros");
            Console.WriteLine("introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(Console.ReadLine(), out decimal tipoDeCambio);



            Console.WriteLine("introducir la cantidad de pesos");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(Console.ReadLine(), out decimal pesos);

            decimal euros = PesosAEuros(tipoDeCambio, pesos);
            Console.WriteLine($"cantidad de euros:{euros.ToString("N2")}");


        }
        static void ConvertirEurosAPesos()
        {
            Console.WriteLine("euros a pesos");
            Console.WriteLine("introducir tipo de cambio");

            string respuestaUsuario = Console.ReadLine();
            decimal.TryParse(Console.ReadLine(), out decimal tipoDeCambio);



            Console.WriteLine("introducir la cantidad de euros");
            respuestaUsuario = Console.ReadLine();
            decimal.TryParse(Console.ReadLine(), out decimal euros);

            decimal pesos = EurosAPesos(tipoDeCambio, pesos);
            Console.WriteLine($"cantidad de pesos:{pesos.ToString("N2")}");


        }
        //funcion que recibe un tipo de cambio y cantodad de pesos
        //y regresa el resultado de la division
        static decimal PesosADolares(decimal tipoCambio, decimal pesos)
        {
            decimal dolares = 0.00m;
            dolares = pesos / tipoCambio;
            return dolares;
        }


        static decimal DolaresAPesos(decimal tipocambio, decimal dolares)
        {
            decimal pesos = 0.00m;
            pesos = tipocambio * dolares;
            return pesos;

        }
        static decimal PesosAEuros(decimal tipocambio, decimal pesos)
        {
            decimal euros = 0.00m;
            pesos = tipocambio * euros;
            return euros;

        }
        static decimal EurosAPesos(decimal tipocambio, decimal euros)
        {
            decimal pesos = 0.00m;
            euros = tipocambio * pesos;
            return pesos;

        }




    }
}
