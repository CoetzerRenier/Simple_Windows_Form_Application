using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_Part_1_ST10055559
{
    internal class Report
    {
        public string location, description, categories, filePath;

        public Report(string loc, string cat, string des, string path)
        {
            this.location = loc;
            this.categories = cat;
            this.description = des;
            this.filePath = path;
        }
    }
}
