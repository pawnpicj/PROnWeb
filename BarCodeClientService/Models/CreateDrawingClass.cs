using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarCodeClientService.Models
{
    public class CreateDrawingClass
    {

        public string DocNum { get; set; } = "";

        public string DateCurrent { get; set; } = "";

        public string CreateBy { get; set; } = "";

        public string Remark { get; set; } = "";

        public string FileName { get; set; } = "";

    }
}
