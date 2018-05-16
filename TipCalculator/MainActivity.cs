using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace TipCalculator
{
    [Activity(Label = "TipCalculator", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
		EditText inputAmount;
        Button calculateTip;
        TextView tipAmount;
        TextView totalAmount;

        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
			base.OnCreate(bundle);
			SetContentView(Resource.Layout.Main);

			inputAmount = FindViewById<EditText>(Resource.Id.inputBill);
			calculateTip = FindViewById<Button>(Resource.Id.calculateButton);
			tipAmount = FindViewById<TextView>(Resource.Id.outputTip);
			totalAmount = FindViewById<TextView>(Resource.Id.outputTotal);

			calculateTip.Click += OnCalculateClick;     

        }

		void OnCalculateClick(object sender, EventArgs e)
        {
			double bill = Convert.ToDouble(inputAmount.Text);
			var tip = 0.15 * (Convert.ToDouble(tipAmount));
			var totalPayment = bill + tip;
        }
    }
}

