﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedPizza.Domain
{

    public class Topic
    {

		public int Id { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public ICollection<Person> Presenters { get; set; }

    }

}
