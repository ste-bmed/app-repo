﻿using System;

using Xamarin.Forms;

namespace Mediolanum
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new LoginPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public bool test(int numero)
        {
          
            return false;
        }
	}
}

