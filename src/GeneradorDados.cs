using System;

namespace GeneradorDados
{
    public class Dados
    {
        private static readonly Random random = new Random();

        public static int LanzarDado(int caras)
        {
            if (caras != 6 && caras != 10 && caras != 20)
                throw new ArgumentException("Solo se permiten dados de 6, 10 o 20 caras.");

            return random.Next(1, caras + 1);
        }

        public static int LanzarDado12()
        {
            return random.Next(1, 13);
        }
    }
}


