namespace espacioCalculadora
{

    public class Calculadora()
    {
        private double dato = 0;
        public double resultado {get => dato;}


        public void sumar(double X)
        {
            dato += X;
        }

        public void restar(double X)
        {
            dato -= X;
        }

        public void multiplicar(double X)
        {
            dato *= X;
        }

        public void dividir(double X)
        {
            if (X != 0)
            {
                dato /= X;
            }
            else
            {
                Console.WriteLine("\nERROR: No se puede dividir en 0\n");
            }
        }

        public void limpiar()
        {
            dato = 0;
        }
    }

}