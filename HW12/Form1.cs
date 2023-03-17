namespace HW12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder_of_mathematical_graphs_of_functions functions = new builder_of_mathematical_graphs_of_functions();
            functions.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a_charting_application a_Charting_Application = new a_charting_application();
            a_Charting_Application.ShowDialog();
        }
    }
}