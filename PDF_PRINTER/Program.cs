using System;
using System.Diagnostics;
using System.IO;





Process pdfProcess = new Process();
string close = "close";




string filename = new string("");
while (filename != close)
{
    filename = Console.ReadLine();
    if (filename == close) {return;}
    pdfProcess.StartInfo.FileName = @"C:\Program Files (x86)\Foxit Software\Foxit Reader\FoxitPDFReader.exe";
    pdfProcess.StartInfo.Arguments = string.Format((@"/t -p {0}"), ("\"../" + filename + ".pdf\""));
    pdfProcess.Start();
}


