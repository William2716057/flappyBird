using Android.App;
using Android.OS;
using Android.Views;

namespace FlappyBird
{
    [Activity(Label = "FlappyBird", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var gameView = new GameView(this);
            SetContentView(gameView);

            gameView.Touch += (s, e) =>
            {
                if (e.Event.Action == MotionEventActions.Down)
                {
                    gameView.Flap();
                }
            };
        }
    }
}