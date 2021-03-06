using System;
using Android.App;
using Android.OS;
using Android.Widget;
using Android.Support.Design.Widget;
using NavTest.ViewModels.ItemNew;

namespace NavTest.Droid
{
    [Activity(Label = "AddItemActivity")]
    public class AddItemActivity : BaseActivity<AddItemViewModel>
    {
        FloatingActionButton saveButton;
        EditText title, description;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.activity_add_item);
            saveButton = FindViewById<FloatingActionButton>(Resource.Id.save_button);
            title = FindViewById<EditText>(Resource.Id.txtTitle);
            description = FindViewById<EditText>(Resource.Id.txtDesc);

            saveButton.Click += SaveButton_Click;
        }

        void SaveButton_Click(object sender, EventArgs e)
        {
            var item = new Item(title.Text, description.Text);
            ViewModel.SaveItem(item);
        }
    }
}
