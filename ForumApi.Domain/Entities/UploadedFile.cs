using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.Domain.Entities
{
    public class UploadedFile
    {
        public int Id { get; set; }

        public string PostId { get; set; }

        public string Path { get; set; }
    }
}
