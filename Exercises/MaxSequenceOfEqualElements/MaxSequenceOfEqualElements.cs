using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            List<int> temp = new List<int>();
            List<int> result = new List<int>();

            temp.Add(input[0]);   //Добавяме първия елемент от масива input в листа temp.
            for (int i = 1; i < input.Length; i++) //Започваме да обхождаме масива input
            {
                if (input[i] == input[i - 1])  //Сравнява текущия и миналия елемент 
                {
                    temp.Add(input[i]);         //Ако намери съвпадение добавя текущия елемент във                                  времения списък
                    if (i == input.Length - 1)  //Когато стигнем последния елемент от масива input                                правим същата проверка като в елзе - тоест проверяваме бройката елементи от времения списък temp дали е по-голяма от броят елементи в листа result, тоест ако в temp има повече резултати от листа result, последният се изчиства и след това му се добавят резултатите от листа temp.
                    {
                        if (temp.Count > result.Count)
                        {
                            result.Clear();
                            result.InsertRange(0, temp);
                        }
                    }
                }
                else                                     //Ако текущия и миналия елемент са различни
                {
                    if (temp.Count > result.Count)      //Проверяваме дали намерените резултати във                                     времения лист са повече от този на result. Ако                                    темп има повече намерени елементи, тоест поредица                                 от числа тогава изчистваме листа result и му                                      даваме намерената поредица числа от temp 
                    {
                        result.Clear();
                        result.InsertRange(0, temp);
                    }
                    temp.Clear();                   //След като сме предали поредицата от числа от temp                               на result , изчистваме temp и след това му предаваме                              текущия елемент. 
                    temp.Add(input[i]);
                }
            }


            Console.WriteLine("{0}", string.Join(" ", result));

        }
    }
}
