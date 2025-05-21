using Android.Content;
using Android.Graphics;
using Android.Views;

namespace FlappyBird
{
    public class GameView : View
    {
        private Paint paint = new Paint();
        private float birdY = 500;
        private float gravity = 1;
        private float velocity = 0;

        public GameView(Context context) : base(context)
        {
        }

        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
            canvas.DrawColor(Color.Cyan); //background colour
            velocity += gravity;
            birdY += velocity;

            paint.Color = Color.Yellow;
            canvas.DrawCircle(200, birdY, 50, paint);

            Invalidate(); // Redraw continuously
        }

        public void Flap()
        {
            velocity = -30;
        }
    }
}