using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.Domain.Entities
{
    public class Reply
    {
        public string Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string PostId { get; set; }
    }
}
