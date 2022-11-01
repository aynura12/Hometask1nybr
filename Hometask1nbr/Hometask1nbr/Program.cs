
using System;
using System.Collections.Specialized;
#region
int[] array = { 5, 20, 30 };
int sum = 0;
int count = 0;
int average = 0;

for (int i = 0; i < array.Length; i++)
{
    sum = sum + array[i];
    count++;

}
average = sum / count;
Console.WriteLine(average);
#endregion


#region


//int[] array = { -3, -7, -5, 5 };
//int pos = 0;
//int neg = 0;


//for (int index = 0; index < array.Length; index++)
//{


//    if (array[index] < 0)
//    {

//        pos++;

//    }

//    else
//    {
//        neg++;
//    }
//}
//Console.WriteLine("Menfi ededler=");
//Console.WriteLine(pos);

//Console.WriteLine("Musbet ededler=");
//Console.WriteLine(neg);
#endregion
#region

//int[] array = { 1, 9, 3, 8 };
//int max = array[0];
//for (int index = 0; index < array.Length; index++)
//{

//    if (max < array[index])
//    {

//        max = array[index];

//    }


//    }

//Console.WriteLine(max);

#endregion