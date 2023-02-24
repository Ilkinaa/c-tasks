//task 1
//using System.Security.Cryptography.X509Certificates;

//int mark = int.Parse(Console.ReadLine());
//if (mark <= 100 && mark > 90)
//{
//    Console.WriteLine("A");
//}
//else if (mark <= 90 && mark > 80)
//{
//    Console.WriteLine("B");
//}
//else if (mark <= 80 && mark > 70)
//{
//    Console.WriteLine("C");
//}
//else if (mark <= 70 && mark > 60)
//{
//    Console.WriteLine("D");
//}
//else if (mark <= 60 && mark > 50)
//{
//    Console.WriteLine("E");
//}

//else if (mark <= 50)
//{
//    Console.WriteLine("Kesildin Ruslan");
//}

//else
//{
//    Console.WriteLine("100 den yuxari qiymet olmur");
//}


//task 2
//int[] numbers = {1,2,3,4,5,-6,-4};
//int countP  = 0;
//int countN = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] > 0)
//    {
//        countP++;
//    }
//    else 
//    { 
//        countN++; 
//    }
//}
//Console.WriteLine(countP);  
//Console.WriteLine(countN);

//task 3
int[] numbers = { 1, 3, 55, 77, 34, 90 };
int max = 0;
for (int i = 0;i < numbers.Length; i++)
{
    if (numbers[i] > max)
        max = numbers[i];

}
Console.WriteLine(max);