namespace MultiThreadBugGame
{
    public partial class Form1 : Form
    {
        private bool winnerFound = false;
        private volatile bool stopThreads = false;
        private Thread? thread1, thread2, thread3; 

        public Form1()
        {
            InitializeComponent();
            thread1 = null; 
            thread2 = null;
            thread3 = null;
        }

        public void ChangePlaceBtn()
        => MoveButton(frstBug, 705, 182);

        public void ChangePlaceBtn1() 
        => MoveButton(scndBug, 705, 292);

        public void ChangePlaceBtn2()
        => MoveButton(thrdBug, 705, 409);

        private void Button4_Click(object sender, EventArgs e)
        {
            frstBug.Location = new Point(12, 182);
            scndBug.Location = new Point(12, 292);
            thrdBug.Location = new Point(12, 409);

            thread1 = new Thread(() => MoveButton(frstBug, 705, 182));
            thread2 = new Thread(() => MoveButton(scndBug, 705, 292));
            thread3 = new Thread(() => MoveButton(thrdBug, 705, 409));

            if (thread1 != null && thread2 != null && thread3 != null)
            {
                thread1.Start();
                thread2.Start();
                thread3.Start();
            }
        }

        public void MoveButton(Button button, int targetX, int targetY)
        {
            Random rnd = new Random();

            int stepX = (targetX - button.Location.X) / 10;
            int stepY = (targetY - button.Location.Y) / 10;

            for (int i = 0; i < 10 && !stopThreads; i++) 
            {
                button.Location = new Point(
                    button.Location.X + stepX,
                    button.Location.Y + stepY
                );

                Thread.Sleep(rnd.Next(1000));
            }

            if (!stopThreads) 
            {
                button.Location = new Point(targetX, targetY);
                CheckWinner();
            }
        }


        public void CheckWinner()
        {
            if (frstBug.Location.X >= 705)
            {
                label1.Text = "The winner is " + frstBug.Text;
                winnerFound = true;
                stopThreads = true; 
            }
            else if (scndBug.Location.X >= 705)
            {
                label1.Text = "The winner is " + scndBug.Text;
                winnerFound = true;
                stopThreads = true; 
            }
            else if (thrdBug.Location.X >= 705)
            {
                label1.Text = "The winner is " + thrdBug.Text;
                winnerFound = true;
                stopThreads = true; 
            }
        }
    }
}