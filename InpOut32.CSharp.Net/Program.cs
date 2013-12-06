using System;
using System.Collections.Generic;
using System.Windows.Forms;
using InpOut32.CSharp.Net;
using System.Threading;

namespace InpOut32.Net
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new CSharpExample());

      //var cfg = Config.Load();
      //cfg.Save();
      //var log = new Logger() { FilePath = cfg.LogName };

      //uint val = 0;

      //while (true)
      //{
      //  var newval = CSharpExample.DlPortReadPortUlong(cfg.Port);
      //  if ( newval != val)
      //    log.Output(cfg.Port, newval);
      //  val = newval;
      //  Thread.Sleep(cfg.TimeoutInMilliseconds);
      //}
    }
  }
}