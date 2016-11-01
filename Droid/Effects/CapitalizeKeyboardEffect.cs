using Android.Text;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsTesting.Droid.Effects;

[assembly: ResolutionGroupName("MyCompany")]
[assembly: ExportEffect(typeof(CapitalizeKeyboardEffect), nameof(CapitalizeKeyboardEffect))]

namespace XamarinFormsTesting.Droid.Effects
{
	public class CapitalizeKeyboardEffect : PlatformEffect
	{
		InputTypes _old;

		protected override void OnAttached()
		{
			var editText = Control as EditText;
			if (editText != null)
			{
				_old = editText.InputType;
				//editText.InputType = InputTypes.TextFlagCapCharacters;
				editText.SetFilters(new IInputFilter[] { new InputFilterAllCaps() });
			}
		}

		protected override void OnDetached()
		{
			var editText = Control as EditText;
			if (editText != null)
			{
				//editText.InputType = _old;
			}
		}
	}
}
