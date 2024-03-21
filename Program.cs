using System; 
namespace C_
{
    class Program
    {
        public static void Main() {
            Matrix m1 = new Matrix(4, 4);
            m1.FillRandomValues();
            Console.WriteLine(m1);

            Matrix m2 = Matrix.GetRandomMatrix(4, 4);
            Console.WriteLine(m2);


            Matrix res = m1 + m2;
            Console.WriteLine(res);
            res = m1 * m2;
            Console.WriteLine(res);

            // Matrix m2 = Matrix.GetRandomMatrix(3, 4);
            // Console.WriteLine(m2);
        }

    }
}