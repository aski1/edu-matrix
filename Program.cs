namespace Edu
{
    class Program
    {
        public static void Main() {
            Matrix m1 = new Matrix(3, 4);
            m1.FillRandomValues();
            Console.WriteLine(m1);

            Matrix m2 = Matrix.GetRandomMatrix(4, 4);
            Console.WriteLine(m2);

            Matrix res = null;
            try { 
                res = m1 + m2;
            }
            catch(Exception ex) {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.WriteLine(res.Items[0,0]);

            

            Console.WriteLine("!!!");

            // Matrix m2 = Matrix.GetRandomMatrix(3, 4);
            // Console.WriteLine(m2);
        }

    }
}