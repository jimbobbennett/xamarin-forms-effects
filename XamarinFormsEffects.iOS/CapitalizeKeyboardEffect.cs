using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormsEffects.iOS;
using UIKit;
using Foundation;

[assembly: ResolutionGroupName("XamarinFormsEffects")]
[assembly: ExportEffect(typeof(CapitalizeKeyboardEffect), nameof(CapitalizeKeyboardEffect))]

namespace XamarinFormsEffects.iOS
{
    [Preserve]
	public class CapitalizeKeyboardEffect : PlatformEffect
	{
        private UITextAutocapitalizationType _old;

		protected override void OnAttached()
		{
            var editText = Control as UITextField;
			if (editText != null)
			{
                _old = editText.AutocapitalizationType;
                editText.AutocapitalizationType = UITextAutocapitalizationType.AllCharacters;
			}
		}

		protected override void OnDetached()
		{
			var editText = Control as UITextField;
			if (editText != null)
				editText.AutocapitalizationType = _old;
		}
	}
}
