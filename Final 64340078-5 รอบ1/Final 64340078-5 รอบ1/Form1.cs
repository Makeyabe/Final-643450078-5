namespace Final_64340078_5_รอบ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string file = openFileDialog1.FileName;
            loadProductFromFile(file);
        }
        public void loadProductFromFile(string filepath)
        {
            string[] lines = System.IO.File.ReadAllLines(filepath);
            if (lines.Length > 0)
            {
                string firstLine = lines[0];
                string[] headerLadels = firstLine.Split(',');
                DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
                Name.HeaderText = headerLadels[0];
                DataGridViewTextBoxColumn Price = new DataGridViewTextBoxColumn();
                Price.HeaderText = headerLadels[1];
                DataGridViewTextBoxColumn Select = new DataGridViewTextBoxColumn();
                Select.HeaderText = headerLadels[2];
                DataGridViewTextBoxColumn Amount = new DataGridViewTextBoxColumn();
                Amount.HeaderText = headerLadels[3];
            }
        }
    }
}