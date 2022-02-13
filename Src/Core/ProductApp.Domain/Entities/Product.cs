using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductApp.Domain.Common;

namespace ProductApp.Domain.Entities
{
	public class Product:BaseEntitiy
	{
		public String Name { get; set; }
		public decimal Value { get; set; }
		public int Type { get; set; }
	}
}
