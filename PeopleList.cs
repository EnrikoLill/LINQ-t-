using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace ConsoleApp1
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Joosep",
                Age = 12,
                GenderId = Guid.Parse("03627ed4-1756-4f48-b7df-cba4ce000d02")
            },
            new People()
            {
                 Id = 2,
                Name = "Trevor",
                Age = 21,
                GenderId = Guid.Parse("03627ed4-1756-4f48-b7df-cba4ce000d02")
            },
            new People()
            {
                 Id = 3,
                Name = "Liis",
                Age = 32,
                GenderId = Guid.Parse("8dc9f0e2-e7c1-43e0-8725-38c827a9a4e4")

            },
            new People()
            {
                  Id = 4,
                Name = "Mari",
                Age = 19,
                GenderId = Guid.Parse("8dc9f0e2-e7c1-43e0-8725-38c827a9a4e4")
                  },
            new People()
            {
                Id = 5,
                Name = "Ron",
                Age = 17,
                GenderId = Guid.Parse("03627ed4-1756-4f48-b7df-cba4ce000d02")
            },

            };
        };
    }