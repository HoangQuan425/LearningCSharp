﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.Interfaces
{
	public interface IMultiLanguage<T>
	{
		T LanguageId { set; get; }
	}
}
