namespace projektowanie_wizualne_lab3
{
    public partial class Form1 : Form
    {
        DataGridViewRow row;
        int rowId;
        public Form1()
        {
            InitializeComponent();

            rowId = dataGridView1.Rows.Add();
            
            // Grab the new row!
            row = dataGridView1.Rows[rowId];

            // Add the data
            row.Cells[0].Value = "Value1";
            dataGridView1.Rows.Clear(); // usuwa pierwszy wiersz, ktory pozostaje pusty

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

            rowId = dataGridView1.Rows.Add();

            // Grab the new row!
            row = dataGridView1.Rows[rowId];

            // Add the data
            row.Cells[0].Value = "Value1";
        }

        private void labelRemove_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void labelSave_Click(object sender, EventArgs e)
        {

        }

        private void labelLoad_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            row.Cells[0].Value = Form2.publisher;
            row.Cells[1].Value = Form2.genre;
            row.Cells[2].Value = Form2.author;
            row.Cells[3].Value = Form2.date_of_publish;
            row.Cells[4].Value = Form2.title;
        }
    }
}