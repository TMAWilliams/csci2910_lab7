using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace csci2910_lab7
{
    public class Book : VolumeInfo
    {
        public VolumeInfo VolumeInfo { get; set; }
    }
}
