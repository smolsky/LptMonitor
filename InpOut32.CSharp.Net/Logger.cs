﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace InpOut32.CSharp.Net
{
  class Logger
  {
    public String FilePath { get; set; }
    public void Output(int port, uint val)
    {
      var date = DateTime.Now;
      var strVal = Convert.ToString(val, 2);
      while (strVal.Length < 32)
        strVal = "0" + strVal;
      var line = String.Format("{0}> Port: '{1}' Value: {2} {3}", date.ToString("dd MMM HH:mm:ss"), port, strVal, Environment.NewLine );
      File.AppendAllText(FilePath, line);      
      
    }
  }
}
