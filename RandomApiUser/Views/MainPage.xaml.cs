﻿using RandomApiUser.ViewModels;

namespace RandomApiUser.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainPageViewModel();
	}
}


