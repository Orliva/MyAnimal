using System;
using System.Windows.Forms;
using MyAnimalDll;

namespace MyAnimal
{
    public partial class Form1 : Form
    {
        readonly MyCat cat;
        public Form1()
        {
            cat = new MyCat(this, IAnimal.ModeAnimal.UncompetitiveAnimal);
            this.Click += Form1_Click;
            this.DoubleClick += Form1_DoubleClick;
            this.Icon = MyAnimalDll.ResIcon.icon_cat_;
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e) => cat.Move();

        private void Form1_DoubleClick(object sender, EventArgs e) => this.Close();
    }
}
