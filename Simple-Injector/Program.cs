using System;
using System.Windows.Forms;
using Simple_Injection;
using Simple_Injector.Etc;

namespace Simple_Injector
{
    public static class Program
    {
        private static readonly Injector Injector = new Injector();

        private static readonly Status Status = new Status();

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interface());
        }

        public static Status Inject(Config config)
        {
            // Inject using specified method

            switch (config.InjectionMethod)
            {
                case "CreateRemoteThread":

                    if(Injector.CreateRemoteThread(config.DllPath, config.ProcessName))
                    {
                        Status.InjectionOutcome = true;
                    }

                    break;

                case "RtlCreateUserThread":

                    if (Injector.RtlCreateUserThread(config.DllPath, config.ProcessName))
                    {
                        Status.InjectionOutcome = true;
                    }

                    break;

                case "SetThreadContext":

                    if (Injector.SetThreadContext(config.DllPath, config.ProcessName))
                    {
                        Status.InjectionOutcome = true;
                    }

                    break;
            }

            // Erase headers if EraseHeaders is checked

            if (config.EraseHeaders)
            {
                if(Injector.EraseHeaders(config.DllPath, config.ProcessName))
                {
                    Status.EraseHeadersOutcome = true;
                }
            }

            // Close the program if CloseAfterInject is checked

            if (config.CloseAfterInject)
            {
                Application.Exit();
            }

            return Status;
        }
    }
}
