using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_In_CSharp
{
    class Program
    {
        public int data;
        public Program link;

        Program Top;

        static void Main(string[] args)
        {
            Program Stack = new Program();
            Program Init = new Program();

            int value;

            Init.Push(10, Stack);
            Init.Push(20, Stack);
            Init.Push(30, Stack);

            value = Init.Pop(Stack);
            if (value != -1) Console.WriteLine("{0}", value);

            value = Init.Pop(Stack);
            if (value != -1) Console.WriteLine("{0}", value);

            value = Init.Pop(Stack);
            if (value != -1) Console.WriteLine("{0}", value);

            value = Init.Pop(Stack);
            if (value != -1) Console.WriteLine("{0}", value);
        }

        public void Push(int data, Program P)
        {
            Program tmp;

            try
            {
                tmp = P.Top;

                P.Top = new Program();
                P.Top.link = tmp;
                P.Top.data = data;
            }
            catch(Exception e)
            {
                Console.WriteLine("Push 함수 오류 : " + e.Message);
            }
        }

        public int Pop(Program P)
        {
            Program tmp;

            if (P.Top != null)
            {
                try
                {
                    tmp = P.Top;
                    P.Top = P.Top.link;

                    return tmp.data;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Pop 함수 오류 : " + e.Message);
                    return -1;
                }
            }
            else
            {
                Console.WriteLine("스택이 비어 있습니다.");
                return -1;
            }
        }
    }
}
