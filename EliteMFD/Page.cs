﻿using System.Collections.Generic;

namespace EliteMFD
{
    public class Page
    {
        public int Index;

        public IEnumerable<string> Options => EliteMFDOptionsSource.Options;

        public string Line1Option { get; set; }
        public string Line2Option { get; set; }
        public string Line3Option { get; set; }
    }
}
