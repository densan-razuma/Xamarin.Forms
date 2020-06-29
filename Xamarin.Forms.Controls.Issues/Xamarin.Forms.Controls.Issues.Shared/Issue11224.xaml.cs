﻿using System;
using Xamarin.Forms.CustomAttributes;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

#if UITEST
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using NUnit.Framework;
using Xamarin.Forms.Core.UITests;
#endif

namespace Xamarin.Forms.Controls.Issues
{
#if UITEST
	[Category(UITestCategories.CarouselView)]
#endif
#if APP
	[XamlCompilation(XamlCompilationOptions.Compile)]
#endif
	[Preserve(AllMembers = true)]
	[Issue(IssueTracker.Github, 11224, "[Bug] CarouselView Position property fails to update visual while control isn't visible", PlatformAffected.Android)]
	public partial class Issue11224 : TestContentPage
	{
		public Issue11224()
		{
#if APP
			Title = "Issue 11224";
			InitializeComponent();
#endif
		}

		protected override void Init()
		{

		}


#if APP
		void Button_Clicked(object sender, EventArgs e)
		{
			carousel.IsVisible = true;
		}
#endif

	}
}