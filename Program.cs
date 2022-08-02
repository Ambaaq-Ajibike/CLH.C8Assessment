using System;
namespace C8Assessment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            StringQuestion1();
        }
        //Array
        public static void ArrayQuestion1()
        {
            int[] array = {1, 2, 3, 5};
            var sum = array.Sum();
            System.Console.WriteLine(sum);
        }
        public static void ArrayQuestion2()
        {
            bool strict= true;
            int[] array = {1, 2, 3, 4};
            int f = array[1] - array[0];
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] - array[i -1] != f)
                {
                    strict = false;
                    System.Console.WriteLine("Not strictly increasing");
                    break;
                }
            }
            if (strict)
            {
                System.Console.WriteLine("Strictly increasing");
            }
        }
        public static void ArrayQuestion3()
        {
            
        }
        public static void ArrayQuestion4()
        {
            int count = 0;
            int[] array = {1, 2, 3, 4};
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        count++;
                    }
                }
            }
            System.Console.WriteLine(count / 2);
        }
        public static void ArrayQuestion5()
        {
            int[] array = {2, 87, 1, 9, 65};
            int min = array[0];
            int max = 0;
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {                    
                    if (min > array[i - 1])
                    {
                        min = array[i - 1];
                    }
                    if (max < array[i])
                    {
                        max = array[i];
                    }                    
                    
                }
            }
            System.Console.WriteLine(min);
            System.Console.WriteLine(max);
        }
        public static void ArrayQuestion6()
        {
            int[] arr = {1, 2, 3, 4, 9};
            int sum = 0;
            for (var i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += arr[i];
                }
            }
            System.Console.WriteLine(sum);
        }
        public static void ArrayQuestion7()
        {
            int[] arr = {1, 2, 4, 3, 4, 1};
            bool check = true;
            for (int i = 0; i < arr.Length; i++)
            {
                for (var j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        check = false;
                    }
                }
                if (check == true)
                {
                    System.Console.WriteLine(arr[i]);
                }
                check = true;
            }
        }
        public static void ArrayQuestion8()
        {
            bool b = true;
            int[] arr1 = {1, 2, 4, 4};
            int[] arr2 = {1, 2, 3, 4};
                if (arr1.Length != arr2.Length)
                {
                    System.Console.WriteLine(false);
                }
                else
                {
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        if (arr1[i] != arr2[i])
                        {
                            b = false;
                            System.Console.WriteLine(false);
                            break;
                        }                        
                    }
                }
            if (b)
            {
                System.Console.WriteLine(true);
            }
        }
        public static void ArrayQuestion9()
        {
            int[] arr = {2, 1, 4, 3};
            int swap = 0;
            for (var i = 0; i < arr.Length - 1; i+=2)
            {
                swap = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = swap;
            }
            foreach (var item in arr)
            {
                System.Console.WriteLine(item);
            }
        }
        public static void ArrayQuestion10()
        {
            int count = 0;
            int max = 0;
            int num = 0;
            int[] nums = {1, 1, 2, 3, 2, 2, 2, 1, 4, 4, 4, 4};
           var arr = nums.Append(1).ToArray();
        
            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    count ++;
                }
                else
                {
                    if (max < count)
                    {
                        max = count;
                        num = arr[i - 1];
                    }
                    count = 0;
                }
            }
            System.Console.WriteLine(num);
            System.Console.WriteLine(max);
        }
        public static void StringQuestion1()
        {
            string s = "dsfghhgfssc";
            var d = s.Distinct();
            foreach (var item in d)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}