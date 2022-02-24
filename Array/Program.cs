using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Task 211

            Console.WriteLine("please entre count of array...");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n]; double sum = 0; int i; double div;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] >= 0)
                {

                    sum += array[i];
                }
            }
            div = sum / n;
            Console.WriteLine(div);

            //Task 212
            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            double sqr = 0;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] >= 0)
                {
                    sqr = sqr + Math.Pow(array[i], 2);

                }
            }
            double s = sqr / n;

            Console.WriteLine(Math.Sqrt(s));

            //Task213
            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            sqr = 0;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < 0)
                {
                    sqr = sqr + Math.Pow(array[i], 2);

                }
            }
            s = sqr / n;

            Console.WriteLine(Math.Sqrt(s));

            // Task 214
            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n]; sum = 0;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < 0)
                {

                    sum += array[i];
                }
            }
            div = sum / n;
            Console.WriteLine(div);

            // Task 215

            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n]; sum = 0;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {

                    sum += array[i];
                }
            }

            Console.WriteLine(sum);

            // Task 216
            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n]; int mult = 1;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {

                    mult *= array[i];
                }
            }

            Console.WriteLine(mult);

            // Task 217

            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n]; double mmult = 1;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    double x = Math.Pow(array[i], 2);
                    mmult *= x;
                }
            }

            Console.WriteLine(mmult);

            //  TAsk 218

            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n]; sum = 0;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    sum += array[i];
                }

            }
            Console.WriteLine(sum);


            // Task 219

            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n]; int k; int t = 0;
            Console.WriteLine("please entre k number...");
            k = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());

                if (i % k == 0)
                {
                    t++;
                }

            }
            Console.WriteLine(t);

            //     TASk 220

            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n]; int z = 0;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());

                if (array[i] >= 0)
                {
                    t++;
                }
                else
                {
                    z++;
                }

            }
            Console.WriteLine("drakan=" + t + "Bacasakan=" + z);

            //  task 224

            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n];
            Console.WriteLine("please entre k number...");
            k = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());

                double pow = Math.Pow(array[i], 3);
                sum = sum + pow;

            }
            if (sum < k)
            {
                Console.WriteLine(sum);
            }

            //  Task 225
            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n];
            Console.WriteLine("please entre k number...");
            k = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                mult *= array[i];

            }
            if (mult < k)
            {
                Console.WriteLine(mult);
            }

            //  Task 226

            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n];
            Console.WriteLine("please entre k number...");
            k = int.Parse(Console.ReadLine()); int xy = 0;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < k)
                {

                    xy++;
                }

            }
            Console.WriteLine(xy);

            //   TASk 227
            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n];
            Console.WriteLine("please entre k number...");
            k = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                if (i % k == 0)
                {
                    sum += array[i];
                }

            }
            Console.WriteLine(sum / n);

            //  Task 228
            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n];
            Console.WriteLine("please entre k number...");
            k = int.Parse(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                if (i % k == 0)
                {
                    sum += array[i];
                }

            }
            Console.WriteLine(sum);

            //  TAsk 229
            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] - i >= 0)
                {
                    mult *= array[i];
                }

            }
            Console.WriteLine(mult);

            //Task 251
            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n]; int max = array[0];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > max)
                {
                    max = array[i];
                }

            }
            Console.WriteLine(max);

            // Task 252
            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n]; int min = 0;

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                min = array[0];
                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            Console.WriteLine(min);

            // Task 253
            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n]; max = array[0];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                min = array[0];
                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            for (int kk = 0; kk < n; kk++)
            {
                if (array[kk] > max)
                {
                    max = array[kk];
                }

            }
            sum = min + max;
            Console.WriteLine("max" + max + "min" + min + " " + sum);

            // TASk 254
            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n]; max = array[0];

            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[i] = int.Parse(Console.ReadLine());
                min = array[0];
                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            for (int kk = 0; kk < n; kk++)
            {
                if (array[kk] > max)
                {
                    max = array[kk];
                }

            }
            mult = min * max;
            Console.WriteLine("max" + max + "min" + min + " " + mult);

            //TAsk 255

            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n]; max = array[0]; int j;
            int maxId = 0;
            for (j = 0; j < n; j++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[j] = int.Parse(Console.ReadLine());
                if (array[j] > max)
                {
                    max = array[j];
                    maxId = j;
                }

            }
            sum = max + maxId;
            Console.WriteLine(sum);

            //Task 256
            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n];
            int minId = 0;
            for (j = 0; j < n; j++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[j] = int.Parse(Console.ReadLine());
                min = array[0];
                if (array[j] < min)
                {
                    min = array[j];
                    minId = j;
                }

            }
            sum = min + minId;
            Console.WriteLine(sum);

            //TAsk 257

            Console.WriteLine("please entre count of array...");
            n = int.Parse(Console.ReadLine());
            array = new int[n];
            maxId = 0;
            for (j = 0; j < n; j++)
            {
                Console.WriteLine("Entre numbers of array ...");
                array[j] = int.Parse(Console.ReadLine());
                max = array[0];
                if (array[j] < array[j + 1])
                {
                    max = array[j + 1];
                    maxId = j + 1;
                    break;
                }
                else
                {
                    max = array[j];
                    maxId = j;
                    break;
                }

            }

            Console.WriteLine(maxId);

        }
    }
}
