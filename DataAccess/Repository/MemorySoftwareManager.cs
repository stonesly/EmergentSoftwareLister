using Business.Repository.IRepository;
using Common.Helpers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class MemorySoftwareManager : ISoftwareManager
    {
        public List<Software> FilterSoftwareByVersion(int major, int minor, int patch)
        {
            var software = GetAllSoftware();
            var filters = new List<int> { major, minor, patch };
            return software.Where(s =>
            {
                var versionSplit = s.Version.Split('.').ToList();

                var softwareMajor = int.Parse(versionSplit[0]);
                var softwareMinor = int.Parse(versionSplit[1]);
                var softwarePatch = int.Parse(versionSplit[2]);

                if (softwareMajor > major)
                {
                    return true;
                }
                else if (softwareMajor < major)
                {
                    return false;
                }

                if (softwareMinor > minor)
                {
                    return true;
                }
                else if (softwareMinor < minor)
                {
                    return false;
                }

                if(softwarePatch > patch)
                {
                    return true;
                }
                return false;
            }).OrderBy(s => s.Name).ToList();

        }

        public IEnumerable<Software> GetAllSoftware()
        {

            var software = new List<Software>
            {
                new Software
                {
                    Name = "MS Word",
                    Version = "13.2.1"
                },
                new Software
                {
                    Name = "AngularJS",
                    Version = "1.7.1"
                },
                new Software
                {
                    Name = "Angular",
                    Version = "8.1.13"
                },
                new Software
                {
                    Name = "React",
                    Version = "0.0.5"
                },
                new Software
                {
                    Name = "Vue.js",
                    Version = "2.6"
                },
                new Software
                {
                    Name = "Visual Studio",
                    Version = "2017.0.1"
                },
                new Software
                {
                    Name = "Visual Studio",
                    Version = "2019.1"
                },
                new Software
                {
                    Name = "Visual Studio Code",
                    Version = "1.35"
                },
                new Software
                {
                    Name = "Blazor",
                    Version = "0.7"
                }
            };

            software.ForEach(s => s.Version = SoftwareHelper.NormalizeVersion(s.Version));
            return software.OrderBy(s => s.Name);
        }
    }
}
