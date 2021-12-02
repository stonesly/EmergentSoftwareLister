using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository.IRepository
{
    public interface ISoftwareManager
    {
        IEnumerable<Software> GetAllSoftware();
        List<Software> FilterSoftwareByVersion(int major, int minor, int patch);
    }
}
