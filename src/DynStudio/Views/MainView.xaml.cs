using DynStudio.ViewModels;
using System;
using System.Windows;

namespace DynStudio.Views
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
			DataContext = Workspace.This;
		}

		private void MinimizeClick(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Minimized;
		}

		private void MaximizeClick(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Maximized;
		}

		private void RestoreDownClick(object sender, RoutedEventArgs e)
		{
			WindowState = WindowState.Normal;
		}

		private void CloseClick(object sender, RoutedEventArgs e)
		{
			Close();
		}

		private void WindowStateChanged(object sender, EventArgs e)
		{
			SetCaptionHeight();
		}

		private void HeaderSizeChanged(object sender, SizeChangedEventArgs e)
		{
			SetCaptionHeight();
		}

		private void SetCaptionHeight()
		{
			switch (WindowState)
			{
				case WindowState.Normal:
					chrome.CaptionHeight = header.ActualHeight + BorderThickness.Top - chrome.ResizeBorderThickness.Top;
					break;
				case WindowState.Maximized:
					chrome.CaptionHeight = header.ActualHeight - BorderThickness.Top;
					break;
			}
		}
	}
}
