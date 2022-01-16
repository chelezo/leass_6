using System;
using System.Diagnostics;

namespace TaskList_2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                string procArgum = args[0];
                string killIdProc = args[0];
                string KillNameProc = args[0];
                
                

                if (procArgum == "-help")
                {
                    Console.WriteLine("для отображения всех процессов введите имя программы -Listproc");
                    Console.WriteLine("Для прибития процесса по имени введите имя программы -kill имя процесса");
                    Console.WriteLine("Для прибития процесса по ID введите имя программы -Kid ID процесса");
                    return;
                }
               
                if (procArgum == "-listproc")
                {
                    Process[] procList = Process.GetProcesses();
                    foreach (var ListingP in procList)
                    {
                        Console.WriteLine($"ID: {ListingP.Id}  Имя: {ListingP.ProcessName} ");
                    }
                    return;
                }
                if (procArgum == "-Kill")
                {

                    Process[] NameProc = Process.GetProcessesByName(KillNameProc);
                    foreach (var NameKill in NameProc)
                    {
                        NameKill.Kill();
                    }
                    return;
                }
                if (procArgum == "-Kid")
                {
                    int KillPID = Int32.Parse(killIdProc);
                    Process iProc = Process.GetProcessById(processId: KillPID);
                    iProc.Kill();

                    return;
                }
            }
        }
    }
}
