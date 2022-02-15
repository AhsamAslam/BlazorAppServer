using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace communitybuilderapi.Models
{
    public class File
    {
        public string FileID { get; set; }
        public string FileOriginalName { get; set; }
        public string FileExtension { get; set; }
        public string FileType { get; set; }
        public string FilePath { get; set; }
        public float FileSize { get; set; }
    }
}
