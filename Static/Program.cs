﻿using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Human human1 = new Human(100);
        Human human2 = new Human(200);
        Human human3 = new Human(300);

        Console.WriteLine(Human.GetCount());
        Console.WriteLine(human2.GetBalance());
    }
}

class Human
{
    private static int _count;
    private int _balance;
    public Human(int balance)
    {
        _count++;
        _balance = balance;
        
    }
    public static int GetCount()
    {
        return _count;
    }
    public int GetBalance()
    {
        return _balance;
    }
}