namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = true;
        private void Sidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {

                Sidebar.Width -= 10;
                if (Sidebar.Width <= 61)
                {
                    sidebarExpand = false;
                    SidebarTransition.Stop();
                }
            }
            else
            {

                Sidebar.Width += 10;
                if (Sidebar.Width >= 218)
                {
                    sidebarExpand = true;
                    SidebarTransition.Stop();
                }
            }
        }

        private void btnpic_Click(object sender, EventArgs e)
        {
            SidebarTransition.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
