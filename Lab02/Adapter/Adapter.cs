using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class Adapter: Target
	{
		private Adaptee _adaptee = new Adaptee();
		public override void Request()
		{
			// Possibly do some other work
			// and then call SpecificRequest
			_adaptee.SpecificRequest();
		}
	}
	/// <summary>
	/// The 'Adaptee' class
	/// </summary>
	class Adaptee
	{
		public void SpecificRequest()
		{
			Console.WriteLine("Called SpecificRequest()");
		}
	}
}
