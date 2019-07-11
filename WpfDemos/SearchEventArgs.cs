using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfDemos
{
    public class SearchEventArgs :EventArgs
    {
        public string SearchItem { get; set; }
    }
}
