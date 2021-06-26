using System;

namespace DesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			var log = Singleton.Log.Instance;
			log.Save("a");
			log.Save("b");
		}
	}
}
