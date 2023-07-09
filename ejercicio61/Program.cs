namespace ejercicio61
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numero = pedirmetodo("Ingrese un numero decimal=");

            string NumeroBinario = ConvertirBinario(numero);
            Console.WriteLine($"El numero binario es: { NumeroBinario } ");
            
        }

        private static string ConvertirBinario(int numero)
        {
            if (numero==0)
            {
                return "0";
            }
            string binario = "";
            while (numero>0)
            {
                int resisuo = numero % 2;
                binario = resisuo + binario;
                numero = numero / 2;
            }
            return binario;
        }

        private static int pedirmetodo(string mensaje)
        {
            int nro = 0;
            do
            {
                Console.Write(mensaje);
                string strconsole = Console.ReadLine();
                if (!int.TryParse(strconsole,out nro))
                {
                    Console.WriteLine("numero mal ingresado");

                }
                else
                {
                    break;
                }
            } while (true);
            return nro;
        }
    }
}