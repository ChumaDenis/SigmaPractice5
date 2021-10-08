using System;

namespace ConsoleApp6
{
    class Matrix
    {
        bool[][][] A;
        int m, n, p;
        public Matrix( int m, int n, int p)
        {
            this.m = m;
            this.n = n;
            this.p = p;

            A = new bool[m][][];
            for(int i=0; i<m; i++)
            {
                A[i] = new bool[n][];
                for(int j=0; j<n; j++)
                {
                    A[i][j] = new bool[p];
                    for(int k=0; k<p; k++)
                    {
                        A[i][j][k] = false;
                    }
                }
            }

            A[1][1][1] = true;
            A[1][1][2] = true;
        }
        private void ToNull(bool[][] B, int k, int t)
        {
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < t; j++)
                {
                    B[i][j] = false;
                }
            }
        }
        public bool[][] Shadow(int mod)
        {
            bool[][] B;
            if (mod ==0)
            {
                B= new bool[m][];
                for (int i = 0; i < m; i++)
                {
                    B[i] = new bool[n];
                }
                ToNull(B, m, n);
                for (int i=0; i< m; i++)
                {
                    for(int j=0; j< n;j++)
                    {
                        for(int k=0;k<p; k++)
                        {
                            if(A[i][j][k]==true)
                            {
                                B[i][j] = true;
                            }
                        }
                    }
                }
            }
            else if(mod==1)
            {
                B = new bool[n][];
                for (int i = 0; i < n; i++)
                {
                    B[i] = new bool[p];
                }
                ToNull(B, n, p);
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < p; k++)
                        {
                            if (A[i][j][k] == true)
                            {
                                B[j][k] = true;
                            }
                        }
                    }
                }
            }
            else
            {
                B = new bool[m][];
                for (int i = 0; i < m; i++)
                {
                    B[i] = new bool[p];
                }
                ToNull(B, m, p);
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < p; k++)
                        {
                            if (A[i][j][k] == true)
                            {
                                B[i][k] = true;
                            }
                        }
                    }
                }
            }
            return B;
        }
    }

    
    class Program
    {
        static void Output(bool[][] B)
        {
            for(int i=0; i<B.Length;i++)
            {
                for(int j=0; j<B[0].Length;j++)
                {
                    if(B[i][j]==true)
                    {
                        Console.Write("1\t");
                    }
                    else
                    {
                        Console.Write("0\t");
                    }
                }
                Console.Write("\n");
            }
        }

        


        static void Main(string[] args)
        {
            
            
            

            Matrix A = new Matrix(7, 8, 9);
            bool[][] B0 =A.Shadow(0);
            Output(B0);
            Console.WriteLine("\n\n");
            bool[][] B1 = A.Shadow(1);
            Output(B1);
            Console.WriteLine("\n\n");
            bool[][] B2 = A.Shadow(2);
            Output(B2);
            Console.WriteLine("\n\n");
        }
    }
}
