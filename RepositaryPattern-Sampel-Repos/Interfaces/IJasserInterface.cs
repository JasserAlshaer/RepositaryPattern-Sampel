using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositaryPattern_Sampel_Repos.Interfaces
{
    public interface IJasserInterface
    {
        Task<List<int>> GetMarks();
        
    }
}
