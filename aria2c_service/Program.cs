﻿using System.ServiceProcess;

namespace Aria2_Remote_Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Aria2_remote_service()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
