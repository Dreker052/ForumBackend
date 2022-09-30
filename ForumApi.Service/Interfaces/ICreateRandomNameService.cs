using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.Service.Interfaces
{
    public interface ICreateRandomNameService
    {
        string CreateRandomName(short length);
    }
}
