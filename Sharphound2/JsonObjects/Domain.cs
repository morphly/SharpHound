﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharphound2.JsonObjects
{
    internal class Domain : JsonBase
    {
        public string Name { get; set; }
        public string ObjectSid { get; set; }
        public string Description { get; set; }

        public GpLink[] Links { get; set; }
        public Trust[] Trusts { get; set; }
        public ACL[] Aces { get; set; }
        public string[] ChildOus { get; set; }
        public string[] Computers { get; set; }
        public string[] Users { get; set; }
    }
}
