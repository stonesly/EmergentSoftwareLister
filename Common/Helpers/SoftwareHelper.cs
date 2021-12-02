using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public static class SoftwareHelper
    {
        public static string NormalizeVersion(string version)
        {
            var versionSplit = version.Split('.', StringSplitOptions.None);
            for (int i = 0; i < 3 - versionSplit.Length; i++)
            {
                version += ".0";
            }
            return version;
        }
    }
}
