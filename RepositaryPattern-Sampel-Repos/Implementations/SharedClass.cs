using RepositaryPattern_Sampel_Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositaryPattern_Sampel_Repos.Implementations
{
    public class SharedClass : ISharedInterface
    {
        public async Task<string> GetSampleRequest()
        {
            return "Test Repositiory Pattern Click -1";
        }
    }
}
