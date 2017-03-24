using System;
using Nancy;

public class IndexModule : NancyModule
{
	public IndexModule()
	{
		Get["/"] = _ => "Nancy: Hello World My great new change!";
		Get["/os"] = _ => Environment.OSVersion.ToString();
	}
}