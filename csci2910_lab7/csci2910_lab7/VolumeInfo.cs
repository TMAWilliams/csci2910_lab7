using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csci2910_lab7
{
    public class VolumeInfo
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string[] Authors { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishedDate { get; set; }

        public override string ToString()
        {
            string msg = "";
            msg += $"{Title},{Subtitle},";
            for (int i = 0; i < Authors.Length; i++)
            {
                msg += $"{Authors[i]} ";
            }
            msg += $",{Publisher},{PublishedDate.ToString("MM/dd/yyyy")}";
            return msg;
        }
    }
}
