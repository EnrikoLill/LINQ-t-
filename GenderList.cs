using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class GenderList
    {
        public static readonly List<Gender> genderList = new List<Gender>
        {
            new Gender()
            {
                Id = Guid.Parse("03627ed4-1756-4f48-b7df-cba4ce000d02"),
                Sex = "male"
            },
            new Gender()
            {
                Id = Guid.Parse("8dc9f0e2-e7c1-43e0-8725-38c827a9a4e4"),
                Sex = "female"
            },
        };
    }
}