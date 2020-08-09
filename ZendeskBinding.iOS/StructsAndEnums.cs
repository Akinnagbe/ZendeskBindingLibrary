using ObjCRuntime;

namespace Binding
{
	[Native]
	public enum ZDKLogLevel : long
	{
		Error = 0,
		Warn = 1,
		Info = 2,
		Debug = 3,
		Verbose = 4
	}
}
