using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace WinFormUserInformation
{
    public class StudentDocument
{
    public int StudentRollNo { get; set; }

    public string DocumentType { get; set; } = "";

    public string FileName { get; set; } = "";

    public string FilePath { get; set; } = "";
}
}