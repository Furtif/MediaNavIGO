using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNavIGO.Models
{
    public class Config
    {
        public string USBPath { get; set; } = @"D:\NaviSync";
        public string LOCALPath { get; set; } = @"C:\Users\msntc\Downloads\360\iGO R3 HERE [Navteq] 2020.(Q4) EUROPE";
        public bool OnlyPresentInUsb { get; set; } = true;
    }
}
