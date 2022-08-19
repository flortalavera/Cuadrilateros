using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase16_Cuadrilateros.Modelos
{
    public abstract class Cuadrilatero
    {
        private int _valorX1;
        private int _valorX2;
        private int _valorX3;
        private int _valorX4;
        private int _valorY1;
        private int _valorY2;
        private int _valorY3;
        private int _valorY4;
        protected int ValorX1 { get { return _valorX1; } set { _valorX1 = value; } }
        protected int ValorX2 { get { return _valorX2; } set { _valorX2 = value; } }
        protected int ValorX3 { get { return _valorX3; } set { _valorX3 = value; } }
        protected int ValorX4 { get { return _valorX4; } set { _valorX4 = value; } }
        protected int ValorY1 { get { return _valorY1; } set { _valorY1 = value; } }
        protected int ValorY2 { get { return _valorY2; } set { _valorY2 = value; } }
        protected int ValorY3 { get { return _valorY3; } set { _valorY3 = value; } }
        protected int ValorY4 { get { return _valorY4; } set { _valorY4 = value; } }

        public Cuadrilatero(int valorX1, int valorY1, int valorX2, int valorY2, int valorX3, int valorY3, int valorX4, int valorY4)
        {
            ValorX1 = valorX1;
            ValorX2 = valorX2;
            ValorX3 = valorX3;
            ValorX4 = valorX4;
            ValorY1 = valorY1;
            ValorY2 = valorY2;
            ValorY3 = valorY3;
            ValorY4 = valorY4;
        }

        public abstract int Area();

        protected int Mayor(int[] vector)
        {
            int largest = vector[3];
            for (int i = 0; i < vector.Length; i++)
            {

                if (vector[i] > largest)
                {
                    largest = vector[i];

                }
            }

            return largest;
        }

        protected int Menor(int[] vector)
        {
            int smallest = vector[0];
            for (int i = 0; i < vector.Length; i++)

            {
                if (vector[i] < smallest)
                {
                    smallest = vector[i];

                }
            }

            return smallest;
        }

        protected int[] Sort(int[] vector)
        {
            int[] tempVector = new int[4];
            int tempValor;

            for (int i = 0; i < vector.Length; i++)
            {
                tempVector[i] = vector[i];
            }

            for (int i = 0; i < tempVector.Length - 1; i++)

                for (int j = i + 1; j < tempVector.Length; j++)

                    if (tempVector[i] > tempVector[j])
                    {
                        tempValor = tempVector[i];
                        tempVector[i] = tempVector[j];
                        tempVector[j] = tempValor;
                    }

            return tempVector;
        }

    }
}
