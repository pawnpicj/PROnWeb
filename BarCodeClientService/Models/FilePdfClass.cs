using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarCodeClientService.Models
{
    public class FilePdfClass
    {

        public int FileId { get; set; } = 0;

        public string Name { get; set; } = "";

        public string Path { get; set; } = "";

        public List<FilePdfClass> Files { get; set; } = new List<FilePdfClass>();

    }
}
