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
        private bool isGameOver = false;

        public GameView(Context context) : base(context)
        {
        }

        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
            canvas.DrawColor(Color.Cyan); //background colour

            if (!isGameOver)
            {

                velocity += gravity;
                birdY += velocity;

                if (birdY + 50 >= Height)
                {
                    birdY = Height - 50;
                    isGameOver = true;
                }

            }
            paint.Color = Color.Yellow;
            canvas.DrawCircle(200, birdY, 50, paint);

            if (isGameOver)
            {
                paint.Color = Color.Red;
                paint.TextSize = 100;
                paint.TextAlign = Paint.Align.Center;
                canvas.DrawColor(Color.Black); //animate to make more clear game over
            }
            else
            {
                Invalidate(); // Redraw continuously
            }
        }

        public void Flap()
        {
            velocity = -30;
        }
    }
}