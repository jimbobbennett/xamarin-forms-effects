using System;
using System.Windows.Input;

namespace XamarinFormsTesting
{
	public class CustomSlider : Xamarin.Forms.Slider
	{
		public static readonly Xamarin.Forms.BindableProperty MinimumCommandProperty = Xamarin.Forms.BindableProperty.Create(nameof(MinimumCommand), typeof(ICommand), typeof(XamarinFormsTesting.CustomSlider), default(ICommand));
		public ICommand MinimumCommand
		{
			get
			{
				return (ICommand)GetValue(MinimumCommandProperty);
			}

			set
			{
				SetValue(MinimumCommandProperty, value);
			}
		}

		public static readonly Xamarin.Forms.BindableProperty MaximumCommandProperty = Xamarin.Forms.BindableProperty.Create(nameof(MaximumCommand), typeof(ICommand), typeof(XamarinFormsTesting.CustomSlider), default(ICommand));
		public ICommand MaximumCommand
		{
			get
			{
				return (ICommand)GetValue(MaximumCommandProperty);
			}

			set
			{
				SetValue(MaximumCommandProperty, value);
			}
		}

		public CustomSlider()
		{
			ValueChanged += (sender, e) =>
			{
				if (e.NewValue < 0.00001)
				{
					MinimumCommand?.Execute(null);
				}

				if (e.NewValue > 0.99999)
				{
					MaximumCommand?.Execute(null);
				}
			};
		}
	}
}