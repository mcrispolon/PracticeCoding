using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program : Color, IFive
    {
        private string b = string.Empty;
        public string body
        {
            get;
            set;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            long sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(sum);
                Console.ReadLine();
        }
        #region "Fibonacci"
        static void run(int x, int y)
        {

            //int first = 0;
            //int second = 1;
            int m = 0;

            m = x + y;

            Console.Write(y + ",");


            if (m < 1000)
            {
                run(y, m);
            }
        }
        #endregion

        #region "IClass"
        public void ONE()
        {
            Console.WriteLine("test");
        }

        public void THREE()
        {
            Console.WriteLine("test");
        }

        public void FIVE()
        {
            Console.WriteLine("test");
        }

        public void FOUR()
        {
            Console.WriteLine("4 test");
        }
        #endregion

        #region "Pangram"
        /// <summary>
        /// Version 1.0
        /// </summary>
        /// <param name="s"></param>

        static void CheckPangram(string s)
        {
            string STDIN = "the quick broWn fox jumps oVer the LaZY dog";
            Console.WriteLine(STDIN);
            var alphaList = new List<Dictionary<char, int>>();


            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();


            Alphabet alphabet = new Alphabet();
            alphabet.LetterList = new List<Letter>();


            foreach (char a in alpha)
            {
                var letter = new Letter();
                letter.letter = a;
                letter.count = 0;
                alphabet.LetterList.Add(letter);
            }

            List<Letter> letterList = alphabet.LetterList;


            string input = new string(STDIN.Where(c => !Char.IsWhiteSpace(c)).ToArray()).ToUpper();
            foreach (char c in input)
            {
                foreach (var le in letterList)
                {
                    if (le.letter == c)
                    {
                        le.count = 1;
                    }
                }
            }

            int pangram = letterList.Where(l => l.count == 0).Count();


            if (pangram > 1)
            {
                Console.WriteLine("Not a Panagram");

            }
            else Console.WriteLine("Panagram");

        }

        /// <summary>
        /// Version 2.0
        /// </summary>
        static void Pangram()
        {

            string STDIN = Console.In.ReadLine();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            char[] letter = STDIN.ToUpper().Where(c => !Char.IsWhiteSpace(c)).ToArray();

            bool isPangram = true;

            foreach (char a in alpha)
            {
                var x = Array.Find(letter, l => l == a);

                if (x != '\0') continue;
                else isPangram = false; break;
            }

            if (isPangram) Console.WriteLine("pangram");
            else Console.WriteLine("Not a pangram");
        }

        #endregion

        #region "Staircase - character printing"

        static void PrintStairCase()
        {
            //array sum
            //int r = arr.Sum();

            int n = 6;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(string.Format("{0}{1}", new string(' ', n - i), new string('#', i)));
            }
        }


        #endregion

        #region "Diagonal Difference"
        /// <summary>
        /// Sample Input
        //3
        //11 2 4
        //4 5 6
        //10 8 -12
        //Sample Output
        //15
        /// </summary>
        static void FindDifference()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            int p = 0;
            int s = 0;
            int diff = 0;

            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);

                var y = a[a_i].ToArray();
                p += y[a_i];
                s += y[n - (a_i + 1)];
            }

            diff = Math.Abs(p - s);
            Console.WriteLine(diff);
        }

        #endregion

        #region "Plus Minus"
        /// <summary>
        /// Sample Inputk
        // 6
        //-4 3 -9 0 4 1         
        //Sample Output

        //0.500000
        //0.333333
        //0.166667
        /// </summary>
        static void GetFraction()
        {
            int n = 6;//Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = { "-4", "3", "-9", "0", "4", "1" }; // Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            double pn = 0;
            double nn = 0;
            double zn = 0;

            foreach (int a in arr)
            {
                if (a > 0) pn++;
                else if (a < 0) nn++;
                else zn++;
            }

            Console.WriteLine((pn / n).ToString("0.000000"));
            Console.WriteLine((nn / n).ToString("0.000000"));
            Console.WriteLine((zn / n).ToString("0.000000"));
            Console.ReadLine();
        }
        #endregion

        #region "2D Array - Max Value HourGlass"
        /// <summary>
        /// Sample Input
        /// int[][] arr = new int[6][]  
        //          new int[]{1, 1 ,1, 0 ,0 ,0},
        //         new int[]{0, 1, 0,0, 0, 0},
        //         new int[]{1,1 ,1 ,0 ,0 ,0},
        //         new int[]{0, 0, 2, 4, 4, 0},
        //         new int[]{0 ,0 ,0 ,2 ,0 ,0},
        //         new int[]{0 ,0, 1, 2, 4, 0}};
        //Sample Output : 19
        ///// </summary>

        static void GetMaxValue()
        {
            List<int> sumList = new List<int>();
            int[][] arr = new int[6][];
            int a = 0, b = 0, c = 0, sum = 0;

            for (int arr_i = 0; arr_i < 6; arr_i++)
            {
                string[] arr_temp = Console.ReadLine().Split(' ');
                arr[arr_i] = Array.ConvertAll(arr_temp, Int32.Parse);

                if (arr_i < 5) continue;
                else
                {
                    //row            
                    for (int r_i = 0; r_i < 4; r_i++)
                    {
                        //column
                        for (int c_i = 0; c_i < 4; c_i++)
                        {
                            a = new ArraySegment<int>(arr[r_i], c_i, 3).ToArray().Sum();
                            b = new ArraySegment<int>(arr[r_i + 1], c_i, 3).ToArray().Skip(1).Take(1).Sum(); ;
                            c = new ArraySegment<int>(arr[r_i + 2], c_i, 3).ToArray().Sum();

                            sum = a + b + c;
                            sumList.Add(sum);
                        }
                    }
                }
            }
            Console.WriteLine(sumList.Max());
        }

        #endregion

        #region "Compare the triplets"
        /// <summary>
        /// Sample Input
        /// 5 6 7
        /// 3 6 10
        /// Sample Output
        /// 1 1 
        /// </summary>
        static void CompareScore()
        {
            int alice = 0, bob = 0;

            string[] tokens_a0 = { "5", "6", "7" }; //Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);

            string[] tokens_b0 = { "3", "6", "10" };//Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            int y = (a0 > b0) ? alice++ : (a0 < b0) ? bob++ : 0;
            int x = (a1 > b1) ? alice++ : (a1 < b1) ? bob++ : 0;
            int z = (a2 > b2) ? alice++ : (a2 < b2) ? bob++ : 0;



            Console.WriteLine(string.Format("{0} {1}", alice, bob));
        }
        #endregion

        #region "Very Long Sum"

         void ComputeLongSum()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            int q = Convert.ToInt32(tokens_n[2]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            for (int a0 = 0; a0 < q; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
            }
        }
        #endregion
    }
}
