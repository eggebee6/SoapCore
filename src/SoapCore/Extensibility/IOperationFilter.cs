using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace SoapCore.Extensibility
{
	public interface IOperationFilter
	{
		public Task PreInvoke(Message message, MethodInfo methodInfo);
	}
}
