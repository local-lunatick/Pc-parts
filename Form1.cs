using System.CodeDom.Compiler;

namespace Pc_parts
{
    public partial class Form1 : Form
    {
        programs programs;
        public Form1()
        {
            InitializeComponent();
            
            //style :
            this.Size = new System.Drawing.Size(500, 300);
            this.BackColor = System.Drawing.Color.Navy;
            this.BackgroundImage = new Bitmap("szg.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Abakusz PC";
            textBox1.ReadOnly = true;

            label1.Text = "Rendelések";
            label2.Text = "Névjegy";
            label3.Text = "Consult a mortichan !!!";
            label1.ForeColor = System.Drawing.Color.White;
            label2.ForeColor = System.Drawing.Color.White;
            label3.ForeColor = System.Drawing.Color.White;
            label4.ForeColor = System.Drawing.Color.Navy;
            label4.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            groupBox1.Text = "Alkatrészek";
            groupBox2.Text = "Extrák";
            groupBox1.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            groupBox2.BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            groupBox3.BackColor = System.Drawing.Color.Navy;
           
            //event listener
            label1.Click += Label1_Click;
            label2.Click += Label2_Click;
            label3.Click += Label1_Click;
            button2.Click += orderbutton;
        }

        private void Label2_Click(object? sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                MessageBox.Show("The Local lunatic");
            }
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            // yess i gave anxiety and depression to the program !!!
            MessageBox.Show("i dont feel like existing");
            Application.Exit();
            
        }
        private void orderbutton(object? sender, EventArgs e)
        {
            programs.txtdatabase();
            Console.WriteLine("Generated txt file ");
        }


    }

}