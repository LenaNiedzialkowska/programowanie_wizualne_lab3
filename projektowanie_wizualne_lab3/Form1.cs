namespace projektowanie_wizualne_lab3
{
    public partial class Form1 : Form
    {
        DataGridViewRow row;
        int rowId;
        public Form1()
        {
            InitializeComponent();

            //do poprawienia, dodaje pusty wiersz co powoduje, ¿e w pliku zostaja puste miejsca 
            rowId = dataGridView1.Rows.Add();

            // Grab the new row!
            row = dataGridView1.Rows[rowId];

            // Add the data
            row.Cells[0].Value = "";

            dataGridView1.Rows.RemoveAt(0);// usuwa pierwszy wiersz, ktory pozostaje pusty
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
            row.Cells[0].Value = "";
  
        }

        private void labelRemove_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void labelSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
            
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