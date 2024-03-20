namespace Edu
{
    class Program
    {
        public static void Main() {
            Matrix m1 = Matrix.GetRandomMatrix(3, 3);
            Console.WriteLine(m1);

            Matrix m2 = Matrix.GetRandomMatrix(3, 3);
            Console.WriteLine(m2);

            Matrix res = null;
            try { 
                res = m1 * m2;
                Console.WriteLine("произведение матриц:");
            }
            catch(Exception ex) {
                Console.WriteLine("Ошибка: " + ex.Message);
                res = null;
            }
            finally{
                
                Console.WriteLine(res);
            }
            
            try { 
                res = m1 + m2;
                Console.WriteLine("сумма матриц:");
            }
            catch(Exception ex) {
                Console.WriteLine("Ошибка: " + ex.Message);
                res = null;
            }
            finally{
                
                Console.WriteLine(res);
            }

            try { 
                res = m1 - m2;
                Console.WriteLine("разность матриц:");
            }
            catch(Exception ex) {
                Console.WriteLine("Ошибка: " + ex.Message);
                res = null;
            }
            finally{
                
                Console.WriteLine(res);
            }
            
            res = -m1;
            Console.WriteLine("-m1:");
            Console.WriteLine(res);

            Console.WriteLine("!!!");

        }

    }
}