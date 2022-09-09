﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.Domain.Entities
{
    public class Post
    {
        public string Id { get; set; }
        
        public string Title { get; set; }
        
        public string Content { get; set; }
        
        
        
        public string SubjectTitle { get; set; }
        
        //public Subject Subject { get; set; }
    }
}
