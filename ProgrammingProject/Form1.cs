using System.Drawing.Drawing2D; //Uses the library of System.Drawing for drawing 2D objects.

namespace ProgrammingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // Loads the compiled page of Form1.
        }

        float angle = 0, planetVelocity = 1; // Define constants used to determine movement of items.
        int dx = 210, dy = 150, distance = 50; // Define constants used to determine positioning of items.

        DateTime date = new DateTime();
        int days; // Creates a variable for the number of days that has passed

        void UpdateSeason()
        // Changes the label displaying seasons based on the number of days that have passed
        {
            if (days >= 1 && days <= 93)
            {
                LabelSeason.Text = "Season: Spring";
            }
            else if (days >= 94 && days <= 186)
            {
                LabelSeason.Text = "Season: Summer";
            }
            else if (days >= 187 && days <= 276)
            {
                LabelSeason.Text = "Season: Autumn";
            }
            else
            {
                LabelSeason.Text = "Season: Winter";
            }

        }
        void UpdateOrbitPeriod()
        // Updates labels based on time passed.
        {
            date = date.AddDays(planetVelocity);
            LabelDate.Text = date.ToString("dd, MM, yyyy"); // Defines the structure the date on the label as day/Month/year.
            days += 5; // Increments the number of days that have passed by five.
            if (days >= 364)
            {
                LabelOrbit.Text = "Orbit Complete - +1 Year"; // When one year passes, display that the orbit has been completed
                days = 0; // When a year passes, reset the number of days to 0.
            }
            if (days == 10)
            {
                LabelOrbit.Text = "Orbiting";
            }
            LabelPlanetDay.Text = "Days: " + days.ToString(); // Displays how many days have passed on the label.
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        // Draws the various objects used in the program and determines movement of the objects.
        {
            Graphics g = e.Graphics; // Use graphics class when using "System.Drawing"
            StringFormat str = new StringFormat(); // Initializes a new object as a string.
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Smooths the curves to remove pixellated jagged lines.
            g.FillEllipse(Brushes.Yellow, dx + 5, dy - 10, 20, 20); // Draws a yellow circle within a bounding square of width of 100 and height of 100.
            g.DrawString("Star", Font, new SolidBrush(Color.Yellow), (int)(dx - distance + 50), (int)(dy - distance + 22), str); // Writes text "Star" in yellow in position determined by variable "distance".

            int x = (int)(dx - distance * Math.Sin(angle * Math.PI / 182.5f)); // Creates new integer "x" by using the sine function and pi.
            int y = (int)(dy - distance * Math.Cos(angle * Math.PI / 182.5f)); // Creates new integer "x" by using the cosine function and pi.

            g.FillEllipse(Brushes.Aqua, (int)x, (int)y, 10, 10); // Draws a light blue circle within a bounding square of width 100 and height of 100.
            angle -= planetVelocity; // Variable "angle" is equal to itself subtract the variable "planetVelocity".

            g.DrawEllipse(Pens.White, (int)x - 10, (int)y - 10, 30, 30); // Draws an empty circle within a bounding square of width 30 and height 30, using a white pen.

            int x1 = (int)(x + 15 * Math.Sin(angle * Math.PI / 30f)); // Creates new integer "x1" by using the sine function and pi.
            int y1 = (int)(y + 15 * Math.Cos(angle * Math.PI / 30f)); // Creates new integer "y1" by using the cosine function and pi.

            g.FillEllipse(Brushes.White, (int)x1, (int)y1, 8, 8); // Draws a white circle within a bounding square of width 8 and height 8.

            g.DrawString("Satellite", Font, new SolidBrush(Color.Yellow), (int)(x - distance + 25), (int)(y - distance + 25), str); // Writes text "Satellite" in yellow in position determined by variable "distance".
            g.ResetTransform(); // Resets the transformation matrix.
        }

        private void button2_Click_1(object sender, EventArgs e) // When button2 is pressed:
        {
            timer1.Start(); // Start the timer.
        }

        private void timer1_Tick(object sender, EventArgs e) // Each instance of the timer ticking:
        {
            UpdateOrbitPeriod(); // Call function UpdateOrbitPeriod.
            UpdateSeason(); // Call function UpdateSeason
            Invalidate();  // Invalidates the entire surface of the control and causes the control to be redrawn.
        }

        private void button1_Click(object sender, EventArgs e) // When button1 is pressed:
        {
            timer1.Stop(); //Stop the timer.
        }

        private void trackBar1_Scroll(object sender, EventArgs e) // When the trackbar is scrolled along:
        {
            timer1.Interval = trackBar1.Value; // The interval of the timer ticking equals the current value of the trackbar.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
