﻿using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : System.Object
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
    }
}
