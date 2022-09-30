using ForumApi.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApi.Service.Implementations
{
    public class CreateRandomNameService : ICreateRandomNameService
    {
        Random random = new Random();
        public string CreateRandomName(short length)
        {
            string symbols = "abcdefghijklmnopqrstuvwxyx0123456789";
            string name = "";

            for(int i = 0; i < length; i++)
            {
                name += symbols[random.Next(symbols.Length)];
            }

            return name;
        }
    }
}
