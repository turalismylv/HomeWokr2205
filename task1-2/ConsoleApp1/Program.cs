using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            {//        task - 1
             //Paramete olaraq Ədədlərdən ibarət array qəbul edən və onları sort edib geriyə sort 
             //            olunmuş array qaytaran method yazın.Array sort metodunu istifafə etmək olmaz.CustomSort(int[] arr)
                int[] arr = { 5, 6, 8, 10, 7, 9, 2, 1 };
                int[] cstArr = CustomSort(arr);
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }
            static int[] CustomSort(int[] Arr)
            {

                int temp = 0;

                for (int i = 0; i < Arr.Length; i++)
                {
                    for (int j = i; j < Arr.Length; j++)
                    {
                        if (Arr[i] > Arr[j])
                        {
                            temp = Arr[i];
                            Arr[i] = Arr[j];
                            Arr[j] = temp;
                        }

                    }

                }
                return Arr;
                #endregion

                #region task 2
                //            Task - 2
                // Stringlerden ibaret array - i və char qəbul edən metod yazın.
                //Arrayin hansi indexində bu qəbul edilən char varsa, o string-ləri ekranda yazdirin.
                //    string[] sozler = { "sag", "sol", "asagi", "yuxari" };
                //    char herf = 's';
                //    string[] arr = Sozler(herf, sozler);
                //    foreach (var item in arr)
                //    {
                //        Console.WriteLine(item);
                //    }
                //}

                //static string[] Sozler(char a, string[] soz)
                //{
                //    string[] arr = new string[0];
                //    int b = 0;
                //    for (int i = 0; i < soz.Length; i++)
                //    {
                //        foreach (var item in soz[i])
                //        {
                //            if (item == a)
                //            {
                //                Array.Resize(ref arr, arr.Length + 1);
                //                arr[b] = soz[i];
                //                b++;
                //            }
                //        }
                //    }
                //    return arr;
                //}
                #endregion




            }
        }
    }
}







