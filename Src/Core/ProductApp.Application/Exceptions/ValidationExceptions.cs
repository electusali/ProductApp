using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Application.Exceptions
{
	public class ValidationExceptions :Exception
	{
		public ValidationExceptions():this("validation error occourds")
		{
		}

		public ValidationExceptions(String Message) : base(Message)
		{
		}

		public ValidationExceptions(Exception ex) : this(ex.Message)
		{
		}
	}
}
