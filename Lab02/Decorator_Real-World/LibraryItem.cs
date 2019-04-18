using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Real_World
{
	abstract class LibraryItem
	{
		private int _numCopies;
		// Property
		public int NumCopies
		{
			get { return _numCopies; }
			set { _numCopies = value; }
		}
		public abstract void Display();
	}
}
