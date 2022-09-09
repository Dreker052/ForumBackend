using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.Domain.Entities
{
    public class Reply
    {
        public string Id { get; set; }

        public string Content { get; set; }

        public string PostId { get; set; }
    }
}
