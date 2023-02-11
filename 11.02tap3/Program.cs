namespace _11._02tap3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("uzunlugu daxil edin:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"arr[{i}]");
                arr[i] = int.Parse(Console.ReadLine());
            }

            double q1 = (double)arr[1] / arr[0];
            //double q2 = (double)arr[1] / arr[0];
            double q3 = (double)arr[1] - arr[0];
            // double q4 = (double)arr[1] - arr[0];
            double b1, b3;
            //int count = 0;

            for (int i = 1; i < arr.Length - 1; i++) // -1 yazmayandada kod isleyir
            {
                b1 = (double)arr[i + 1] / arr[i];
               // b2 = (double)arr[i + 1] / arr[i];
                b3 = (double)arr[i + 1] - arr[i];
               // b4 = (double)arr[i + 1] - arr[i];

                if (q1 == b1 && (double)arr[2] / arr[1] > 1 )
                {
                    Console.WriteLine("*");
                    break;
                }
                else if (q1 == b1 && (double)arr[2] / arr[1] < 1 )
                {
                    Console.WriteLine("/");
                    break;
                }
                else if (q3 == b3 && arr[2] - arr[1] < 0) 
                {
                    Console.WriteLine("-");
                    break;
                }

                else if (q3 == b3 && arr[2] - arr[1] > 0) 
                {
                    Console.WriteLine("+");
                    break;
                }
                else
                {
                    Console.WriteLine("silsile deyil");
                    break;
                }
            }
            //if (count == arr.Length - 2)
            //    Console.WriteLine("silsile deyil");

        }
    }
}