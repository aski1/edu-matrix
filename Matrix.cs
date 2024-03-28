namespace Edu
{
    class Matrix
    {
        public double[,] Items { get; private set; }


        public int RowCount
        {
            get
            {
                return Items.GetLength(0);
            }
        }

        public int ColCount
        {
            get
            {
                return Items.GetLength(1);
            }
        }


        public Matrix(int row_count, int col_count) 
        {
            Items = new double[row_count, col_count];
        }


        public void FillRandomValues()
        {
            Random rnd = new Random();

            for(int row = 0; row < Items.GetLength(0); row++)
            {
                for(int col = 0; col < Items.GetLength(1); col++)
                {
                    Items[row, col] = rnd.Next(-10, 10);
                }
            }
        }

        public static Matrix GetRandomMatrix(int row_count, int col_count)
        {
            Random rnd = new Random();

            Matrix m = new Matrix(row_count, col_count);
            for(int row = 0; row < m.Items.GetLength(0); row++)
            {
                for(int col = 0; col < m.Items.GetLength(1); col++)
                {
                    m.Items[row, col] = rnd.Next(-10, 10);
                }
            }

            return m;
        }

        public void Print()
        {
            for(int row = 0; row < Items.GetLength(0); row++)
            {
                for(int col = 0; col < Items.GetLength(1); col++)
                    Console.Write($"{Items[row, col], 5}");
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            string res = "";

            for(int row = 0; row < Items.GetLength(0); row++)
            {
                for(int col = 0; col < Items.GetLength(1); col++)
                    res += $"{Items[row, col], 5}";
                res += "\r\n";
            }

            return res;
        }

        public Matrix Multipl(double n)
        {
            Matrix res = new Matrix(RowCount, ColCount);

            for(int row = 0; row < res.RowCount; row++)
            {
                for(int col = 0; col < res.ColCount; col++)
                    res.Items[row, col] = Items[row, col] * n;
            }

            return res;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            if(m1.ColCount != m2.RowCount)
                return null;
            
            Matrix res = new Matrix(m1.RowCount, m2.ColCount);

            for(int row = 0; row < res.RowCount; row++){
                for(int col = 0; col < res.ColCount; col++){
                    for(int i = 0; i < m1.ColCount; i++){
                        res.Items[row, col] += m1.Items[row, i] * m2.Items[i, col];
                    }
                }
            }

            return res;
        }


        public static Matrix operator *(Matrix m, double n)
        {
            Matrix res = new Matrix(m.RowCount, m.ColCount);

            for(int row = 0; row < res.RowCount; row++)
            {
                for(int col = 0; col < res.ColCount; col++)
                    res.Items[row, col] = m.Items[row, col] * n;
            }

            return res;
        }

        public static Matrix operator *(double n, Matrix m)
        {
            return m * n;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if(m1.RowCount != m2.RowCount || m1.ColCount != m2.ColCount)
                return null;

            Matrix res = new Matrix(m1.RowCount, m1.ColCount);

            for(int row = 0; row < res.RowCount; row++)
            {
                for(int col = 0; col < res.ColCount; col++)
                    res.Items[row, col] = m1.Items[row, col] + m2.Items[row, col];
            }

            return res;
        }

        public static Matrix operator -(Matrix m)
        {
            Matrix res = new Matrix(m.RowCount, m.ColCount);

            for(int row = 0; row < res.RowCount; row++)
            {
                for(int col = 0; col < res.ColCount; col++)
                {
                    res.Items[row, col] = -m.Items[row, col];
                }
            }

            return res;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            if(m1.RowCount != m2.RowCount || m1.ColCount != m2.ColCount)
                return null;

            Matrix res = new Matrix(m1.RowCount, m1.ColCount);

            for(int row = 0; row < m1.RowCount; row++)
            {
                for(int col = 0; col < m1.ColCount; col++)
                {
                    res.Items[row, col] = m1.Items[row, col] - m2.Items[row, col];
                }
            }

            return res;
        }
    }   
}