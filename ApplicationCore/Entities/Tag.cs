﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Tag : BaseEntity<int>
    {
        public string Name { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
