﻿using System;
using Mono.Data.Sqlite;
using Bangazon.Menu;

namespace Bangazon
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MenuSystem menu = new MenuSystem ();
			menu.ShowMainMenu ();
		}
	}
}
