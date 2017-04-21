using Android.App;
using Android.Widget;
using Android.OS;
using Android.Media;

namespace KEK
{
    [Activity(Label = "Soundboard do jucao", MainLauncher = true, Icon = "@drawable/Seinfeld")]
    public class MainActivity : Activity
    {
        MediaPlayer player;
        MediaPlayer player1;
        MediaPlayer player2;
        MediaPlayer player3;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            Button button = FindViewById<Button>(Resource.Id.Play);
            button.Click += (sender, e) =>
            {
                player = MediaPlayer.Create(this, Resource.Raw.seinfeldtheme);
                player.Start();
                player.SeekTo(200);
            };
            Button button2 = FindViewById<Button>(Resource.Id.siri);
            button2.Click += (sender, e) =>
            {
                player = MediaPlayer.Create(this, Resource.Raw.PAARA);
                player.Start();
                player.SeekTo(0);
            };
            Button button3 = FindViewById<Button>(Resource.Id.curb);
            button3.Click += (sender, e) =>
            {
                player = MediaPlayer.Create(this, Resource.Raw.curbyout);
                player.Start();
                player.SeekTo(0);
            };
            Button button4 = FindViewById<Button>(Resource.Id.spanish);
            button4.Click += (sender, e) =>
            {
                player = MediaPlayer.Create(this, Resource.Raw.SPANISHflea);
                player.Start();
                player.SeekTo(5000);
            };
            Button button5 = FindViewById<Button>(Resource.Id.russia);
            button5.Click += (sender, e) =>
            {
                player = MediaPlayer.Create(this, Resource.Raw.soviet);
                player.Start();
                player.SeekTo(0);
            };
            Button button1 = FindViewById<Button>(Resource.Id.Stop);
            button1.Click += (sender, e) =>
            {
                player.Pause();
            };
        }
    }
}

