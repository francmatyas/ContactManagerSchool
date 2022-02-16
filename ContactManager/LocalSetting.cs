using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    internal class LocalSettings
    {
        public Color PrimaryContentColor { get; set; }
        public Color SecondaryHContentColor { get; set; }
        public Color SecondaryCContentColor { get; set; }
        public string PreferredSort { get; set; }
        public string DataFile { get; set; }
    }
}
