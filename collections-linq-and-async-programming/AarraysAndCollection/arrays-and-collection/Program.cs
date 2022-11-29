﻿// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;

dictionary();


void singleDimentionalArray()
{
    Customer customer = new Customer();
    customer.Id = 1234;
    customer.Name = "Test";
    Customer[] customers = new Customer[5];
    customers[0] = customer;

    foreach (var item in customers)
    {
        if (item != null)
        {
            Console.WriteLine(item.Id + " " + item.Name);
        }
        else
        {
            Console.WriteLine("customer is null");
        }
    }
    //Single-Dimensional Arrays
    Console.WriteLine("Single-Dimensional Arrays");

    int[] array = new int[5];
    
    

    int[] array1 = new int[] { 1, 3, 5, 7, 9, 10 };
    //foreach (var item in array1)
    //{
    //    Console.WriteLine(item);
    //}
}

void multiDimentionalArray()
{
    //Multidimensional Arrays 
    int[,] mda = new int[4, 2];
    // Two-dimensional array.
    int[,] array2D = new int[,] { 
                                    { 1, 2 },
                                    { 3, 4 },
                                    { 5, 6 },
                                    { 7, 8 } 
                                };
    // The same array with dimensions specified.
    int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
    // A similar array with string elements.
    string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };

    // Three-dimensional array.
    int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
    // The same array with dimensions specified.
    int[,,] array3Da = new int[2, 2, 3] { 
                                            { 
                                                { 1, 2, 3 }, 
                                                { 4, 5, 6 } 
                                            },
                                            { 
                                                { 7, 8, 9 }, 
                                                { 10, 11, 12 } 
                                            }
                                        };

    foreach (var item in array3Da)
    {
        Console.WriteLine(item);
    }

    // Accessing array elements.
    //Console.WriteLine(array2D[0, 0]);
    //Console.WriteLine(array2D[0, 1]);
    //Console.WriteLine(array2D[1, 0]);
    //Console.WriteLine(array2D[1, 1]);
    //Console.WriteLine(array2D[3, 0]);

    //Console.WriteLine(array2Db[1, 0]);

    //Console.WriteLine(array3Da[1, 0, 1]);
    //Console.WriteLine(array3D[1, 1, 2]);

    // Getting the total count of elements or the length of a given dimension.
    var allLength = array3D.Length;
    var total = 1;
    //for (int i = 0; i < array3D.Rank; i++)
    //{
    //    total *= array3D.GetLength(i);
    //}
    //Console.WriteLine("{0} equals {1}", allLength, total);
}

void jaggedArray() 
{
    // Declare the array of two elements.
    int[][] arr = new int[2][];

    // Initialize the elements.
    arr[0] = new int[5] { 1, 3, 5, 7, 9 };
    arr[1] = new int[4] { 2, 4, 6, 8 };

    // Display the array elements.
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write("Element({0}): ", i);

        for (int j = 0; j < arr[i].Length; j++)
        {
            System.Console.Write("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " ");
        }
        System.Console.WriteLine();
    }
}

void generics()
{

    //MyGenericArray<string> myGenericArray = new MyGenericArray<string>(5);
    //for (int i = 0; i <= 5; i++)
    //{
    //    myGenericArray.setItem(i, i.ToString());
    //}

    //for (int i = 0; i <= 5; i++)
    //{
    //    Console.Write(myGenericArray.getItem(i) + " ");
    //}

    int a, b;
    char c, d;
    a = 10;
    b = 20;
    c = 'I';
    d = 'V';

    //display values before swap:
    Console.WriteLine("Int values before calling swap:");
    Console.WriteLine("a = {0}, b = {1}", a, b);
    Console.WriteLine("Char values before calling swap:");
    Console.WriteLine("c = {0}, d = {1}", c, d);

    //call swap
    Swap<int>(ref a, ref b);
    Swap<char>(ref c, ref d);

    //display values after swap:
    Console.WriteLine("Int values after calling swap:");
    Console.WriteLine("a = {0}, b = {1}", a, b);
    Console.WriteLine("Char values after calling swap:");
    Console.WriteLine("c = {0}, d = {1}", c, d);
}

void Swap<T>(ref T lhs, ref T rhs)
{
    T temp;
    temp = lhs;
    lhs = rhs;
    rhs = temp;
}

void dictionary()
{
   Dictionary<int, Employee> dictionary = new Dictionary<int, Employee>();
   //Dictionary<int, Dictionary<int, int>> dictionary2 = new Dictionary<int, Dictionary<int, int>>();

    dictionary.Add(123, new Employee() { Id = 123, Name = "temp" });
    dictionary.Add(1234, new Employee() { Id = 1234, Name = "temp2" });
    dictionary.Clear();
    dictionary.Add(12345, new Employee() { Id = 12345, Name = "temp2" });

    // dictionary[0] = 1;
    // dictionary.Add(1, 2);
    // //dictionary.Remove(1);
    //// dictionary.Clear();
    // foreach (var item in dictionary)
    // {
    //     Console.WriteLine("Key : {0} and Value : {1}", item.Key, item.Value);
    // }
    foreach (var item in dictionary)
    {
        Console.WriteLine($"key : {item.Key} and value : {item.Value.Name}");
    }
}

void list()
{

    //List<string> names = new List<string>()
    //{
    //    "Hello", "World", "c#"
    //};
    //names = names.OrderBy(x=>x).ToList();
    //foreach (var item in names)
    //{
    //    Console.WriteLine(item);
    //}
}


public class MyGenericArray<T>
{
    private T[] array;

    public MyGenericArray(int size)
    {
        array = new T[size + 1];
    }
    public T getItem(int index)
    {
        return array[index];
    }
    public void setItem(int index, T value)
    {
        array[index] = value;
    }
}

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
}


