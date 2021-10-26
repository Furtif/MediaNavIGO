using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaNavIGO.Models
{
    public class Config
    {
        public string USBPath { get; set; }
        public string LOCALPath { get; set; }
        public bool OnlyPresentInUsb { get; set; } = true;
    }
}
