internal class Program
{
    public static void sumEven()
    {
        int start = 0; int end = 1000; int sum = 0;


        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
            {
                sum = sum + i;
            }
        }
        Console.WriteLine("the sum of even is " + sum);
    }

    public static void sumOdd()
    {
        int start = 0; int end = 1000; int sum = 0;


        for (int i = start; i <= end; i++)
        {
            if (i % 2 > 0)
            {
                sum = sum + i;
            }
        }
        Console.WriteLine("the sum of odd is " + sum);
    }
    public static void Sum()
    {
        int sum = 0;

        for (int i = 0; i <= 1000; i++)

            sum += i;


        Console.WriteLine("the sum of the numbers is " + sum);

    }


    //public static void sumOddd()
    //{
    //    int sum = 0;
    //    int[] array = new int[77];

    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        array[i] = i;
    //        Console.WriteLine(array[i]);
    //        if (array[i] %2!= 0) 
    //            sum += array[i];
    //        Console.WriteLine("sum of odd is " +sum);
    //    }


    //    //Console.WriteLine(array[4]);


    //}


    //public static void sumEvenn()
    //{
    //    int sum = 0;
    //    int[] array = new int[77];
    //    ;
    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        array[i] = i;
    //        Console.WriteLine(array[i]);
    //        if (array[i] % 2 == 0)
    //            sum += array[i];
    //        Console.WriteLine("sum of even is " + sum);
    //    }

    //}


    // public static void sumOfarray()
    //{

    //}



    //public static void even(int[] Arr)
    //{
    //    int sum = 0;

    //    for (int i = 0; i < Arr.Length; i++)
    //    {
    //        if (i % 2 == 0)
    //        { sum += Arr[i]; }

    //    }
    //    Console.WriteLine("sum even is :" + sum);
    //}

    //public static void odd(int[] Arr)
    //{
    //    int sum = 0;

    //    for (int i = 0; i < Arr.Length; i++)
    //    {

    //        if (i % 2 != 0)
    //        { sum += Arr[i]; }
    //    }
    //    Console.WriteLine("sum odd is :" + sum);

    //}

    internal class Numbers
    {

        public static void even(int[] Arr)
        {
            int sum = 0;

            for (int i = 0; i < Arr.Length; i++)
            {
                if (i % 2 == 0)
                { sum += Arr[i]; }

            }
            Console.WriteLine("sum even is :" + sum);
        }

        public static void odd(int[] Arr)
        {
            int sum = 0;

            for (int i = 0; i < Arr.Length; i++)
            {

                if (i % 2 != 0)
                { sum += Arr[i]; }
            }
            Console.WriteLine("sum odd is :" + sum);
        }
   


    private static  void Main(string[] args)
    {
        Thread thread1 = new Thread(sumEven);
        thread1.Start();

        Thread thread2 = new Thread(sumOdd);
        thread2.Start();

        Thread thread3 = new Thread(Sum);
        thread3.Start();

        int[] arr = new int[1000];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }
        Thread t1 = new Thread(() => Numbers.odd(arr));
        t1.Start();
        Thread t2 = new Thread(() => Numbers.even(arr));
        t2.Start();
        //t1.Join();t2.Join();

        Console.WriteLine();








    }
 }
    //private static void sumOddd(int v)
    //{
    //    throw new NotImplementedException();
    //}
}