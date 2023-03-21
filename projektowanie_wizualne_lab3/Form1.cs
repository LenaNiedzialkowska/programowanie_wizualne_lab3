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
            row.Cells[0].Value = "";

           dataGridView1.Rows.RemoveAt(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelAdd_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2(this);
            newform.Show();
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
                            MessageBox.Show("Nie mo¿na zapisaæ danych na dysk." + ex.Message);
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
                            MessageBox.Show("Dane zosta³y wyeksportowane prawid³owo !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("B³¹d :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Brak rekordów do wyeksportowania !!!", "Info");
            }

        }

        void readFromCSVFile()
        {
            var lines = File.ReadAllLines(@"C:\Users\lenan\OneDrive\Pulpit\VS2022\projektowanie_wizualne_lab3\projektowanie_wizualne_lab3\bin\Debug\net6.0-windows\Output.csv");
            foreach (var line in lines)
            {
                var values = line.Split(',');
                if (values.Length == 5)
                {
                    var loaded = new LoadedValues() { publisher = values[0], genre = values[1], author = values[2], date_of_publish = values[3], title = values[4] };
                    dataGridView1.Rows.Add(loaded.publisher, loaded.genre, loaded.author, loaded.date_of_publish, loaded.title);
                }
            }
        }
        private void labelLoad_Click(object sender, EventArgs e)
        {
            readFromCSVFile();
        }

        public void AddLoadedRow(string publisher, string genre, string author, string date_of_publish, string title)
        {
            dataGridView1.Rows.Add(publisher, genre, author, date_of_publish, title);
        }
    }
}