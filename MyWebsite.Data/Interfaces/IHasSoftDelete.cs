﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.Interfaces
{
	public interface IHasSoftDelete
	{
		bool IsDeleted { set;  get; }
	}
}