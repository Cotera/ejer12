using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer12
{
    public class CafeteraSingleton
	{ 
		public static CafeteraSingleton instance;

		private CafeteraSingleton()
		{

		}

		public static CafeteraSingleton getInstance()
		{
			if (instance == null)
			{
				//getInstance = new CafeteraSingleton();
			}

			return instance;
		}
    }
}
