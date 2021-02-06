using System;
using System.Diagnostics;


namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] procList = Process.GetProcesses();
            for (int i = 0; i < procList.Length; i++)
            {

                Console.WriteLine($"Номер по порядку: {i} ; Имя процесса: {procList[i].ProcessName} ; Id процесса:  {procList[i].Id}");
            }

            Console.Write("Укажите имя для завершения процесса: ");
            string name = Console.ReadLine();
            Process[] anti = Process.GetProcessesByName(name);



            foreach (Process killed in anti)

            {
                Console.WriteLine("Вы хотите остановить процесс "+ killed.ProcessName);
                try
                {
                    killed.Kill();
                    
                }

                catch
                {
                    Console.WriteLine("Что-то пошло не так, возможно вам не хватает прав на это действие");
                }
                
            }

            Console.Write("Укажите Id для завершения процесса: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Process ant = Process.GetProcessById(n);
            Console.WriteLine("Вы хотите остановить процесс " + ant.ProcessName);
            try
            {
                ant.Kill();
            }

            catch
            {
                Console.WriteLine("Что-то пошло не так, возможно вам не хватает прав на это действие");
            }













        }
    }
}
