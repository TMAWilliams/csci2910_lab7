using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csci2910_lab7
{
    public class Bookshelf
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public int VolumeCount { get; set; }
        public Book[]Items { get; set; }

        public override string ToString()
        {
            string msg = $"{Id},{Title},{Description},{Created},{VolumeCount}";
            return msg;
        }
    }
}
