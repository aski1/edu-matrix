namespace Edu
{
    class Program
    {
        public static void Main() {
            Matrix m1 = new Matrix(2, 4);
            m1.FillRandomValues();
            
            Console.WriteLine("m1:");
            Console.WriteLine(m1);

            Matrix m2 = Matrix.GetRandomMatrix(4, 3);
            Console.WriteLine("m2:");
            Console.WriteLine(m2);

            Matrix res = m1 + m2;
            Console.WriteLine("Сумма матриц: (если не указана, значит размеры матриц не равны)");
            Console.WriteLine(res);

            res = -m1;
            Console.WriteLine("Унарный минус для m1:");
            Console.WriteLine(res);

            res = m1 - m2;
            Console.WriteLine("Разность матриц: (если не указана, значит размеры матриц не равны)");
            Console.WriteLine(res);
            
            res = m1 * m2;
            Console.WriteLine("Произведение матриц: (если не указана, значит размеры матриц не равны)");
            Console.WriteLine(res);
        }

    }
}