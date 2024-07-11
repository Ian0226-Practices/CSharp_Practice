/* 
(A * B) + (C * D) - E => 中綴表達式
A B * C D * + E - => 後綴表達式(Postfix Expression)
- + * AB * CS E  => 前綴表達式(Prefix Expression)

Tip : 
宣告stack，存取所有運算符operator。
優先級處理方式
    加減的優先級相同，但越左邊的優先級越高;乘跟除同理。
    當遇上當前stack中最上面那一項優先級還低的運算符時，pop當前stack中所有元素並放入exp list。
    舉例來說，peek目前stack中的元素為「*」，當現在又找到一個運算符為「-」，pop掉stack中所有元素並放入list，接著把「-」放入stack。
判斷exp的結尾
    1. 得到了一個更低優先級的運算符。
    2. 到達表達式結尾。
遇到括號的解法
    遇到左括號，將左括號放入stack。
    遇到右括號，pop stack中所有元素直到碰到左括號，左括號也pop掉。
*/

/*
    符號與字母優先級判斷 : 
    使用ASCII判斷。
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PrefixAndPostfixExpressions;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
class Postfix
{
    StackInArrayImplement.StackInArray<string> stack = new StackInArrayImplement.StackInArray<string>();

    List<string> postfixExp = new List<string>();

    public void EvaluatePostfix(string[] exp)
    {
        if (exp.Length == 0) { return; }

        for (int i = 0; i < exp.Length; i++)
        {
            if (exp[i].Equals("x") || exp[i].Equals("/") || exp[i].Equals("+") || exp[i].Equals("-"))
            {
                // while (!stack.IsEmpty() && stack.Top() > exp[i])
                // {
                //     postfixExp.Add(stack.Pop());
                // }
                stack.Push(exp[i]);
            }
            else
            {
                postfixExp.Add(exp[i]);
            }
        }
    }

    /// <summary>
    /// Return int of letter priority.1 is Characters priority A~Z,2 is Operators priority +-,3 is Higher Operators priority */ ,
    /// 4 is Parentheses priority ()[].
    /// </summary>
    /// <param name="letter"></param>
    /// <returns></returns>
    public int CatchLetters(char letter)
    {
        int letterNum = (int)letter;
        int priority = 0;
        if (letterNum <= 90 && letterNum >= 65)
        {
            Console.WriteLine("This is Character A~Z,priority is 1 ");
            priority = 1;
        }
        switch (letterNum)
        {
            case 43:
            case 45:
                Console.WriteLine("This is Operator +- ,priority is 2 ");
                priority = 2;
                break;
            case 42:
            case 47:
                Console.WriteLine("This is Higher Operator */ ,priority is 3 ");
                priority = 3;
                break;
            case 40:
            case 41:
            case 91:
            case 93:
                Console.WriteLine("This is Parentheses ()[] ,priority is 4 ");
                priority = 4;
                break;
        }
        return priority;
    }

    void PrintPostfixExp()
    {
        foreach (string exp in postfixExp)
        {
            Console.Write(exp);
        }
    }
}

class Prefix<T>()
{

}