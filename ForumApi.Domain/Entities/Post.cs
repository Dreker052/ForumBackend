using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.Domain.Entities
{
    public class Post
    {
        public int PostId { get; set; }
        
        public string PostTitle { get; set; }
        
        public string PostContent { get; set; }

        public string SubjectTitle
        //public int Id { get; set; }
        //
        //public string Title { get; set; }
        //
        //public string Content { get; set; }
        //
        //
        //
        //public string SubjectId { get; set; }
        //
        //public Subject Subject { get; set; }
    }
}
