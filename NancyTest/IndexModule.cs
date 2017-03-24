using System;
using Nancy;

public class IndexModule : NancyModule
{
	public IndexModule()
	{
		Get["/"] = _ => "Nancy: Hello World What What";
		Get["/os"] = _ => Environment.OSVersion.ToString();
	}
}