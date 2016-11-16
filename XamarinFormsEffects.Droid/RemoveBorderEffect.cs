using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormsEffects.Droid;
using Android.Runtime;

[assembly: ExportEffect(typeof(RemoveBorderEffect), nameof(RemoveBorderEffect))]

namespace XamarinFormsEffects.Droid
{
    [Preserve]
    public class RemoveBorderEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
        }

        protected override void OnDetached()
        {
        }
    }
}