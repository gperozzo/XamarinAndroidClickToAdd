using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;

namespace AddElementToLayout
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private RelativeLayout _layoutToAddElement;
        private TextView _txtViewCount;
        private int _count = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_main);

            SetupFields();
        }

        private void SetupFields()
        {
            _layoutToAddElement = FindViewById<RelativeLayout>(Resource.Id.layoutToAddElement);
            _txtViewCount = FindViewById<TextView>(Resource.Id.txtViewCount);
            Button btnResetView = FindViewById<Button>(Resource.Id.btnResetView);

            _layoutToAddElement.Clickable = true;
            _layoutToAddElement.Touch += LayoutToAddElement_Touch;

            _txtViewCount.Text = $"Views added: {_count}";

            btnResetView.Click += ResetView_Click;
        }

        private void ResetView_Click(object sender, System.EventArgs e)
        {
            _layoutToAddElement.RemoveAllViews();
            _count = 0;
            _txtViewCount.Text = $"Views added: {_count}";
        }

        private void LayoutToAddElement_Touch(object sender, View.TouchEventArgs e)
        {
            if(e.Event.Action == MotionEventActions.Down)
            {
                Toast.MakeText(this, $"{e.Event.GetX()},{e.Event.GetY()}", ToastLength.Short).Show();

                RelativeLayout.LayoutParams parameters = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.WrapContent, RelativeLayout.LayoutParams.WrapContent);
                parameters.LeftMargin = (int)e.Event.GetX();
                parameters.TopMargin = (int)e.Event.GetY();

                ImageView image = new ImageView(this);
                image.SetBackgroundResource(Resource.Mipmap.ic_launcher_round);

                _layoutToAddElement.AddView(image, parameters);

                _txtViewCount.Text = $"Views added: {++_count}";
            }
        }
    }
}

