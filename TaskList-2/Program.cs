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
                //string procArgum2 = args[1];
                //string[] ArrayArgum = new string[] { procArgum, procArgum2 };

                switch (procArgum)
                {
                    case "-help":
                    {
                            Console.WriteLine("для отображения всех процессов введите имя программы -listproc");
                            Console.WriteLine("Для прибития процесса по имени введите имя программы -kill имя процесса");
                            Console.WriteLine("Для прибития процесса по ID введите имя программы -kid ID процесса");
                            return;
                        }

                    case "-listproc":
                        {

                            Process[] procList = Process.GetProcesses();
                            foreach (var ListingP in procList)
                            {
                                Console.WriteLine($"ID: {ListingP.Id}  Имя: {ListingP.ProcessName} ");
                            }
                            break;
                        }

                    case "-Kill":
                        {
                           
                            Process[] NameProc = Process.GetProcessesByName(args[1]);
                            foreach (var NameKill in NameProc)
                            {
                                NameKill.Kill();
                            }
                            break;
                        }

                    case "-kid":
                        {
                            
                            int KillPID = Int32.Parse(args[1]);
                            Process iProc = Process.GetProcessById(processId: KillPID);
                            iProc.Kill();

                            break;
                        }
                }
            }
        }
    }
}
