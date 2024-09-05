using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class baitap
{
    public static void bai1()
    {
        int[] arr;
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n = Convert.ToInt32(Console.ReadLine());
        arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine($"Tong cua mang la: {sum}");
    }
    public static void bai2()
    {
        Console.Write("Nhap van ban: ");
        string msg = Console.ReadLine();
        int demkitu = 0;
        foreach (char c in msg)
        {
            if (char.IsLetterOrDigit(c)) { demkitu++; }
        }
        Console.WriteLine($"So luong ki tu cua van ban la: {demkitu}");
    }
    public static void bai3()
    {
        int[] arr;
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n = Convert.ToInt32(Console.ReadLine());
        arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        Console.WriteLine($"Phan tu lon nhat trong mang la: {max}");
    }

    public static void bai4()
    {
        Console.Write("Nhap van ban: ");
        string msg = Console.ReadLine();
        char[] chararray = msg.ToCharArray();
        Array.Reverse(chararray);
        string reversedString = new string(chararray);
        Console.WriteLine("Chuoi sau khi dao nguoc: " + reversedString);
    }

    public static void bai5()
    {
        Console.Write("Nhap so luong phan tu cua mang: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Nhap phan tu thu: " + (i + 1) + ": ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        bool isPalindrome = true;

        for (int i = 0; i < n / 2; i++)
        {
            if (array[i] != array[n - i - 1])
            {
                isPalindrome = false;
                break;
            }
        }

        if (isPalindrome)
        {
            Console.WriteLine("Mang la mang doi xung");
        }
        else
        {
            Console.WriteLine("Mang khong phai la mang doi xung");
        }
    }

    public static void bai6()
    {
        Console.Write("Nhap chuoi van ban: ");
        string input = Console.ReadLine();

        Console.Write("Nhap ki tu can dem: ");
        char characterToCount = Convert.ToChar(Console.ReadLine());
        int count = 0;

        foreach (char c in input)
        {
            if (c == characterToCount)
            {
                count++;
            }
        }

        Console.WriteLine($"Ki tu '{characterToCount}' xuat hien {count} lan");
    }
}
