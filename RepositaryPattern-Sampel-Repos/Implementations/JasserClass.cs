using RepositaryPattern_Sampel_Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositaryPattern_Sampel_Repos.Implementations
{
    public class JasserClass : IJasserInterface
    {
        public async Task<List<int>> GetMarks()
        {
            List<int> ints = new List<int>() { 85, 95, 6, 2, 3, 85, 2586, 269456 };
            return ints;
        }
    }
}
