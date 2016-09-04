using System;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            //string file_dir = Environment.CurrentDirectory;
            //string file_dir = Path.GetDirectoryName(DB1.accdb);

            string fileName = "DB2.accdb";            
            string fullPath;
            fullPath = Path.GetFullPath(fileName);
            //MessageBox.Show( fullPath );
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = "+fullPath+"; Persist Security Info = False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {                
                connection.Open();
                checkConnection.Text = "Connection Successful";
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from EmployeeData where Username = '" + text_Username.Text+ "'and Password = '" + text_Password.Text + "'";
            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;

            connection.Close();
            connection.Dispose();
            this.Hide();
            Form f3 = new Form2(text_Username.Text);
            f3.ShowDialog();

            connection.Close();

            /*

            while (reader.Read())
            {
                count = count + 1;
            }
            if (count ==1)
            {
                // MessageBox.Show("username and password is correct");

                connection.Close();
                connection.Dispose();
                this.Hide();
                Form f2 = new Form2(text_Username.Text);
                f2.ShowDialog();
            }
            else if (count >1)
            {
                MessageBox.Show("Duplicate username and password ");
            }
            else
            {
                MessageBox.Show("username and password is not correct");
            }

            connection.Close();
            */
        }
    }
}
