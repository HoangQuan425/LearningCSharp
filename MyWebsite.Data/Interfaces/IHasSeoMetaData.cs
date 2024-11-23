using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Data.Interfaces
{
	public interface IHasSeoMetaData
	{
		string SeoPageTittle {  get; set; }
		string SeoAlias {  get; set; }
		string SeoKeywords {  get; set; }
		string SeoDescription {  get; set; }

	}
}
