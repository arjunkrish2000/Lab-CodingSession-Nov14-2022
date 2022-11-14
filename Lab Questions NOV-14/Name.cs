﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Questions_NOV_14
{
    internal class Name
    {
        string[] name = new string[10];
        String str;
        bool flag = false;
        int len;
        int count;

        public void ASort()
        {
            int a = 0;
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[i][a] < name[j][a])
                    {
                        str = name[i];
                        name[i] = name[j];
                        name[j] = str;
                    }
                }
            }


            foreach (var item in name)
            {
                Console.Write(" " + item + "  ");
            }
        }

        public void RSort()
        {
            int a = 0;
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < name.Length; j++)
                {

                    if (name[i][a] > name[j][a])
                    {
                        str = name[i];
                        name[i] = name[j];
                        name[j] = str;
                    }
                }
            }

            foreach (var item in name)
            {
                Console.Write(" " + item + "  ");
            }
        }
        public void EnterData()
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write($"{i + 1}. Enter the Name : ");
                name[i] = Console.ReadLine();
            }
        }

        public void ShowData()
        {
            foreach (var item in name)
            {
                Console.Write(" " + item + "  ");
            }
        }

        public void search()
        {
            Console.WriteLine("Enter the name to be searched : ");
            str = Console.ReadLine();

            foreach (var item in name)
            {
                if (str.Equals(item)) ;
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
                Console.WriteLine("The name is there in the Name Array");
            else
                Console.WriteLine("The name is not there in the Name Array");

        }

        public void FindLength()
        {
            count = 1;
            foreach (var item in name)
            {
                len = item.Length;
                Console.WriteLine($"{count} Element has length : {len}");
                count++;
            }
        }

        public void Split()
        {
            foreach (var item in name)
            {
                string[] words = item.Split(" ");
                for (int i = 0; i < words.Length; i++)
                {
                    Console.Write(words[i]+"-");
                }
                Console.WriteLine();
            
            }
        }

        public void duplicates()
        {
    
            var duplicates = new string[name.Length];
            int k = 0;
            foreach (var n in name)
            {
                int count = 0;
                foreach (var item in name)
                {
                    if (n == item)
                        count++;
                }
                if (count >= 2)
                {
                    bool hasFoundMatch = false;
                    foreach (var num in duplicates)
                    {
                        if (num == n)
                        {
                            hasFoundMatch = true;
                            break;
                        }
                    }
                    if (!hasFoundMatch)
                        duplicates[k++] = n;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Duplicate Names");
            Console.WriteLine();
            foreach (var item in duplicates)
            {
                Console.Write($"{item}    ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
