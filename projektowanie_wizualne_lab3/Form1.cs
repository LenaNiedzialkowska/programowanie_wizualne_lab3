namespace projektowanie_wizualne_lab3
{
    public partial class Form1 : Form
    {
        DataGridViewRow row;
        public Form1()
        {
            InitializeComponent();
            
            row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = "XYZ";
            //row.Cells[1].Value = 50.2;
            dataGridView1.Rows.Add(row);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelAdd_Click(object sender, EventArgs e)
        {
            
            Form2 newform = new Form2();
            newform.Show();
        }

        private void labelRemove_Click(object sender, EventArgs e)
        {

        }

        private void labelSave_Click(object sender, EventArgs e)
        {

        }

        private void labelLoad_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            row.Cells[0].Value = Form2.value;
            //textBox1.Text = Form2.value;
        }
    }
}