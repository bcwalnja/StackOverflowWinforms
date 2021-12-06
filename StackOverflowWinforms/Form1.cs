using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackOverflowWinforms
{
    class Coordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public partial class Form1 : Form
    {
        private bool GameOver;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(700, 700);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Generate100Buttons();
        }

        private void Generate100Buttons()
        {
            var toppad = 25;
            var leftpad = 45;

            var pad = 7;
            var w = 50;
            for (int i = 0; i < 10; i++)
            {
                var x = (w + pad) * i + leftpad;

                for (int j = 0; j < 10; j++)
                {
                    var y = (w + pad) * j + toppad;

                    var button = new Button();
                    button.Location = new Point(x, y);
                    button.Size = new Size(w, w);
                    button.Text = "XX";

                    button.Tag = new FormPosition()
                    {
                        Column = i,
                        Row = j
                    };

                    button.Click += Button_Click;

                    Controls.Add(button);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (GameOver)
            {
                return;
            }
            LogButtonAddress(sender);
            AssignARandomButtonText();
            CheckIfButtonIsZero(sender);

            GameOver = true;
        }

        public bool ScreenIsOn()
        {
            return true;
        }

        void CheckIfButtonIsZero(object sender)
        {
            if (sender is Button button)
            {
                var buttonsToCheck = new List<Coordinate>();
                var buttonsChecked = new List<Coordinate>();

                if (button.Text == "0")
                {
                    AddIfNotAlreadyIn(buttonsToCheck, button.Tag as Coordinate);
                }
                AddIfNotAlreadyIn(buttonsChecked, button.Tag as Coordinate);
            }
        }

        private void AddIfNotAlreadyIn(List<Coordinate> list, Coordinate coord)
        {
            bool contains = false;

            foreach (var item in list)
            {
                if (item.X == coord.X && item.Y == coord.Y)
                {
                    contains = true;
                    break;
                }
            }

            if (!contains)
            {
                list.Add(coord);
            }
        }

        private void AssignARandomButtonText()
        {
            var rand = new Random();
            var x = (rand.Next(10));
            var y = (rand.Next(10));

            foreach (var item in Controls)
            {
                if (item is Button b && b.Tag is FormPosition p)
                {
                    if (p.Column == x && p.Row == y)
                    {
                        b.Text = "Me!";
                    }
                    else
                    {
                        b.Text = "";
                    }
                }
            }
        }

        private static void LogButtonAddress(object sender)
        {
            if (sender is Button button && button.Tag is FormPosition position)
            {
                var message = $"Button was clicked Column({position.Column}) Row({position.Row})";
                System.Diagnostics.Debug.WriteLine(message);
            }
        }
    }
}
