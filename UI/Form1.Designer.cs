namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnpic = new PictureBox();
            button3 = new Button();
            panel4 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            Menu = new Button();
            Sidebar = new FlowLayoutPanel();
            panel9 = new Panel();
            panel10 = new Panel();
            button7 = new Button();
            button8 = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            button5 = new Button();
            button6 = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            button2 = new Button();
            button4 = new Button();
            SidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnpic).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            Sidebar.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnpic);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 40);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(23, 24, 26);
            label2.Location = new Point(93, 10);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 3;
            label2.Text = "Pizzas";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(221, 184, 146);
            label1.Location = new Point(44, 10);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Super";
            // 
            // btnpic
            // 
            btnpic.Image = (Image)resources.GetObject("btnpic.Image");
            btnpic.Location = new Point(2, 4);
            btnpic.Name = "btnpic";
            btnpic.Size = new Size(47, 33);
            btnpic.SizeMode = PictureBoxSizeMode.CenterImage;
            btnpic.TabIndex = 1;
            btnpic.TabStop = false;
            btnpic.Click += btnpic_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(23, 24, 29);
            button3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-6, -11);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(279, 65);
            button3.TabIndex = 5;
            button3.Text = "                INICIO";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(209, 46);
            panel4.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel2);
            panel6.Controls.Add(Menu);
            panel6.Location = new Point(3, 211);
            panel6.Name = "panel6";
            panel6.Size = new Size(209, 46);
            panel6.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(8, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 46);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 24, 29);
            button1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-13, -18);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(279, 65);
            button1.TabIndex = 3;
            button1.Text = "                SALIR";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            Menu.BackColor = Color.FromArgb(23, 24, 29);
            Menu.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Menu.ForeColor = Color.White;
            Menu.Image = (Image)resources.GetObject("Menu.Image");
            Menu.ImageAlign = ContentAlignment.MiddleLeft;
            Menu.Location = new Point(-6, -7);
            Menu.Margin = new Padding(0);
            Menu.Name = "Menu";
            Menu.Padding = new Padding(20, 0, 0, 0);
            Menu.Size = new Size(279, 65);
            Menu.TabIndex = 3;
            Menu.Text = "                MENU";
            Menu.TextAlign = ContentAlignment.MiddleLeft;
            Menu.UseVisualStyleBackColor = false;
            // 
            // Sidebar
            // 
            Sidebar.BackColor = Color.FromArgb(23, 24, 29);
            Sidebar.Controls.Add(panel4);
            Sidebar.Controls.Add(panel9);
            Sidebar.Controls.Add(panel7);
            Sidebar.Controls.Add(panel3);
            Sidebar.Controls.Add(panel6);
            Sidebar.Dock = DockStyle.Left;
            Sidebar.Location = new Point(0, 40);
            Sidebar.Name = "Sidebar";
            Sidebar.Size = new Size(218, 425);
            Sidebar.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel10);
            panel9.Controls.Add(button8);
            panel9.Location = new Point(3, 55);
            panel9.Name = "panel9";
            panel9.Size = new Size(209, 46);
            panel9.TabIndex = 8;
            // 
            // panel10
            // 
            panel10.Controls.Add(button7);
            panel10.Location = new Point(8, 8);
            panel10.Name = "panel10";
            panel10.Size = new Size(209, 46);
            panel10.TabIndex = 5;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(23, 24, 29);
            button7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(-13, -15);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Padding = new Padding(20, 0, 0, 0);
            button7.Size = new Size(279, 65);
            button7.TabIndex = 3;
            button7.Text = "                PRODUCTOS";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(23, 24, 29);
            button8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.ForeColor = Color.White;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(-6, -7);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Padding = new Padding(20, 0, 0, 0);
            button8.Size = new Size(279, 65);
            button8.TabIndex = 3;
            button8.Text = "                MENU";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(button6);
            panel7.Location = new Point(3, 107);
            panel7.Name = "panel7";
            panel7.Size = new Size(209, 46);
            panel7.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.Controls.Add(button5);
            panel8.Location = new Point(8, 8);
            panel8.Name = "panel8";
            panel8.Size = new Size(209, 46);
            panel8.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(23, 24, 29);
            button5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-13, -18);
            button5.Margin = new Padding(0);
            button5.Name = "button5";
            button5.Padding = new Padding(20, 0, 0, 0);
            button5.Size = new Size(279, 65);
            button5.TabIndex = 3;
            button5.Text = "                MENU";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(23, 24, 29);
            button6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(-6, -7);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Padding = new Padding(20, 0, 0, 0);
            button6.Size = new Size(279, 65);
            button6.TabIndex = 3;
            button6.Text = "                MENU";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(button4);
            panel3.Location = new Point(3, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(209, 46);
            panel3.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(button2);
            panel5.Location = new Point(8, 8);
            panel5.Name = "panel5";
            panel5.Size = new Size(209, 46);
            panel5.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(23, 24, 29);
            button2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-13, -18);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(279, 65);
            button2.TabIndex = 3;
            button2.Text = "                CARRITO";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(23, 24, 29);
            button4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-6, -7);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Size = new Size(279, 65);
            button4.TabIndex = 3;
            button4.Text = "                MENU";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            // 
            // SidebarTransition
            // 
            SidebarTransition.Interval = 10;
            SidebarTransition.Tick += Sidebar_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 465);
            Controls.Add(Sidebar);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnpic).EndInit();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            Sidebar.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnpic;
        private Label label2;
        private Label label1;
        private Button button3;
        private Panel panel4;
        private Panel panel6;
        private Button Menu;
        private FlowLayoutPanel Sidebar;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private Panel panel5;
        private Button button2;
        private Button button4;
        private Panel panel7;
        private Panel panel8;
        private Button button5;
        private Button button6;
        private Panel panel9;
        private Panel panel10;
        private Button button7;
        private Button button8;
        private System.Windows.Forms.Timer SidebarTransition;
    }
}
