﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodedPizza.Data
{

	public class CodedPizzaContext : DbContext
	{

		public CodedPizzaContext()
			: base("DefaultConnection")
		{ }

		public System.Data.Entity.DbSet<CodedPizza.Domain.Topic> Topics { get; set; }

	}

}
