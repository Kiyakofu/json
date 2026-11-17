using System;
using System.Collections.Generic;
using System.Text;

namespace json
{
    internal class Album
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Year { get; set; }
        public string Studio { get; set; }
        
        public Song[] Songs { get; set; }   
    }
}
