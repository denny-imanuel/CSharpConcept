using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp1
{
    public class Multithreading
    {
        private void MySimpleThread()
        {
            Console.WriteLine("Running Thread");
        }

        public void ExecSimpleThread()
        {
            for (int i = 0; i < 10; i++)
            {
                var ts = new ThreadStart(MySimpleThread);
                var th = new Thread(ts);
                th.Start();
            }
        }

        private int MyParamThread(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public void ExecParamThread()
        {
            for (int i = 0; i < 10; i++)
            {
                int sum = 0;
                var th = new Thread(() => { sum = MyParamThread(10, i); });
                th.Start();
                th.Join();
                Console.WriteLine(sum);
            }
        }

        private void MySimpleTask()
        {
            Console.WriteLine("Running Task");
        }

        public void ExecSimpleTask()
        {
            for (int i = 0; i < 10; i++)
            {
                var tk = new Task(MySimpleTask);
                tk.Start();
            }
        }

        private int MyParamTask(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public void ExecParamTask()
        {
            for (int i = 0; i < 10; i++)
            {
                int sum = 0;
                var tk = new Task(() => { sum = MyParamTask(10, i); });
                tk.Start();
                tk.Wait();
                Console.WriteLine(sum);
            }
        }

        public void TaskRun()
        {
            Task.Run(() =>
            {
                Console.WriteLine("Running Thread");
            });
        }
    }
}
