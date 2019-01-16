using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Services
{
    public class UCService
    {

        public string Load(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
