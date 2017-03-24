﻿using System;
using Nancy;

public class IndexModule : NancyModule
{
	public IndexModule()
	{
		Get["/"] = _ => "Nancy: Hello World I am new";
		Get["/os"] = _ => Environment.OSVersion.ToString();
	}
}