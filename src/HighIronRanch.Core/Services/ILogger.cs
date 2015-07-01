using System;
using System.Reflection;

namespace HighIronRanch.Core.Services
{
	public interface ILogger
	{
		void Debug(string context, string message);
		void Debug(string context, string fmt, params object[] vars);
		void Debug(string context, Exception exception, string fmt, params object[] vars);

		void Information(string context, string message);
		void Information(string context, string fmt, params object[] vars);
		void Information(string context, Exception exception, string fmt, params object[] vars);

		void Warning(string context, string message);
		void Warning(string context, string fmt, params object[] vars);
		void Warning(string context, Exception exception, string fmt, params object[] vars);

		void Error(string context, string message);
		void Error(string context, string fmt, params object[] vars);
		void Error(string context, Exception exception, string fmt, params object[] vars);

		void TraceApi(string context, string componentName, string method, TimeSpan timespan);
		void TraceApi(string context, string componentName, string method, TimeSpan timespan, string properties);
		void TraceApi(string context, string componentName, string method, TimeSpan timespan, string fmt, params object[] vars);
		void TraceApi(string context, MethodBase methodBase, TimeSpan timespan, string message);
		void TraceApi(string context, MethodBase methodBase, TimeSpan timespan, string fmt, params object[] vars);
	}
}
