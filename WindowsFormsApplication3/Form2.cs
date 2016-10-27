using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using ExcelLibrary.SpreadSheet;
using System.Drawing.Printing;
using System.Drawing;
using System.Collections;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private PrintDocument printDocument1;

        public Form2(string userName)
        {
            InitializeComponent();
            AutoCompleteText();
            string fileName = "DB2.accdb";
            string fullPath;
            fullPath = Path.GetFullPath(fileName);
            //MessageBox.Show( fullPath );
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + fullPath + "; "
                +" Persist Security Info = False;";            
            label8.Text = "Hi  " + userName + " welcome!! ";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int nm_Point = 10;     // initial 10 points 
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;                
                command.CommandText = "insert into EmployeeData (FirstName, LastName, Point) "
                    +"values ('" + txt_fName.Text + "' , '" + txt_lName.Text + "' , " +nm_Point + ") ";    // auto add 10 points
                command.ExecuteNonQuery();
                MessageBox.Show("Employeed added");
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;                                
                string query = "update EmployeeData set FirstName = '" + txt_fName.Text + "' , LastName  = '" +txt_lName.Text+ "' "
                    + ", Point = '" +nm_Point.Text + "', Dept= '" + txt_dept.Text + "'  where EID = " + txt_eid.Text + " ";                            
                command.CommandText = query ;
                command.ExecuteNonQuery();                         
                MessageBox.Show("Data saved !!");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = " delete from EmployeeData where EID =  " + txt_eid.Text + " ";
                //MessageBox.Show(query);
                command.CommandText = query;
                command.ExecuteNonQuery();
                MessageBox.Show("Data deleted");                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                // ------------- list first name to the select-employee textbox -------------
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;                
                string query = " select FirstName from EmployeeData ";      
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                if (reader.HasRows == true)
                {
                    while (reader.Read())
                    {
                        fname_select.Items.Add(reader["FirstName"].ToString());
                    }
                }
                connection.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // ----------------- select employee to display corresponding record in each textBox --------------------
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = " select * from EmployeeData where FirstName = '"+ fname_select.Text+"'  ";                                
                command.CommandText = query;                
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())       
                {
                    txt_eid.Text = reader["EID"].ToString();
                    txt_fName.Text= reader["FirstName"].ToString();
                    txt_lName.Text= reader["LastName"].ToString();
                    txt_dept.Text = reader["Dept"].ToString();
                    nm_Point.Text= reader["Point"].ToString();                    
                }                
                update_datagridview();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        

        private void AutoCompleteText() // firstname search
        {
            fname_select.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            fname_select.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            // --------------- read in the tabel -------------------

            string fileName = "DB2.accdb";
            string fullPath;
            fullPath = Path.GetFullPath(fileName);
            connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + fullPath + "; "
                + " Persist Security Info = False;";

            connection.Open();
            OleDbCommand command2 = new OleDbCommand();
            command2.Connection = connection;
            string query2 = " select * from EmployeeData  ";
            command2.CommandText = query2;
            OleDbDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                string sName = reader2.GetString(1);   //firstname column
                collection.Add(sName);
            }
            //--------------------------------------------------------------
            fname_select.AutoCompleteCustomSource = collection;
            connection.Close();
        }        

        private void btn_addRecord_Click(object sender, EventArgs e)
        {
            try
            {                
                // ------------ add deduction record ---------------------
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into DeductData ( EID, DeductDate, TimeIn_hh, TimeIn_mm, TimeIn_ampm, DeductPoint, Reason, Processing_date)"
                    + "values ( '" + txt_eid.Text + "' , '" + Deduct_date.Text + "',  '" + TimeIn_hh.Text + "', '" + TimeIn_mm.Text + "', '" + Am_Pm.Text + "', "
                    + " " + Ded_point.Text + " , '" + Reason.Text + "', '" + Proc_date.Text + "' ) ";                
                command.ExecuteNonQuery();
                
                // ------------ update the point balance ---------------------
                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                double Pt = double.Parse(nm_Point.Text);
                double De_pt = double.Parse(Ded_point.Text);
                Pt = Pt - De_pt;                                
                string query2 = "update EmployeeData set Point = " + Pt + " where EID = " + txt_eid.Text + " ";
                command2.CommandText = query2;
                command2.ExecuteNonQuery();              
                connection.Close();
                update_remaining_point();
                update_datagridview();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }
        
        private void update_datagridview()
        {
            try
            {
                // ----------------- update corresponding record in the dataGridView --------------------                
                OleDbCommand command3 = new OleDbCommand();
                command3.Connection = connection;
                string query3 = "select RID, DeductDate, TimeIn_hh, TimeIn_mm, TimeIn_ampm, DeductPoint, Reason, Processing_date from DeductData where EID = " + txt_eid.Text + " ";
                command3.CommandText = query3;
                OleDbDataAdapter da = new OleDbDataAdapter(command3);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoResizeColumns();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        // Quit program gracefully 
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        // display deduction data on the GridView Box
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txt_rid.Text = row.Cells[0].Value.ToString();
                Deduct_date.Text = row.Cells[1].Value.ToString();
                TimeIn_hh.Text = row.Cells[2].Value.ToString();
                TimeIn_mm.Text = row.Cells[3].Value.ToString();
                Am_Pm.Text = row.Cells[4].Value.ToString();
                Ded_point.Text = row.Cells[5].Value.ToString();
                Reason.Text = row.Cells[6].Value.ToString();
            }
        }

        /*
         * Name: Delete Record button
         * Description: add point back then delete record
         */        
        private void btn_del_rec_Click(object sender, EventArgs e)
        {
            try
            {                
                
                // ------------ add the deduction point back ---------------------                 
                connection.Open();
                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                string query2 = "select DeductPoint from DeductData where RID = " + txt_rid.Text + " ";                
                //MessageBox.Show(query2);
                command2.CommandText = query2;
                OleDbDataReader reader = command2.ExecuteReader();
                //if (reader.HasRows == true)
                //{
                    while (reader.Read())
                    {                                                
                        double Pt = double.Parse(nm_Point.Text);
                        double De_pt = double.Parse(reader["DeductPoint"].ToString());
                        //MessageBox.Show(De_pt.ToString());                        
                        Pt = Pt + De_pt;
                        OleDbCommand command3 = new OleDbCommand();
                        command3.Connection = connection;
                        string query3 = "update EmployeeData set Point = " + Pt + " where EID = " + txt_eid.Text + " ";
                        command3.CommandText = query3;
                        command3.ExecuteNonQuery();
                    }
                //}                
                
                connection.Close();
                update_remaining_point();
                update_datagridview();

                // ------------ Delete deduction record ---------------------
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = " delete from DeductData where RID =  " + txt_rid.Text + " ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                //MessageBox.Show("Record deleted");
                update_datagridview();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }
        
        private void update_remaining_point()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = " select Point from EmployeeData where FirstName = '" + fname_select.Text + "'  ";
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    nm_Point.Text = reader["Point"].ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }
        
        /*
         * Name: Edit Record button
         * 
         */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // ------------ retrive deduct point from access ---------------------                 
                connection.Open();
                OleDbCommand command2 = new OleDbCommand();
                command2.Connection = connection;
                string query2 = "select DeductPoint from DeductData where RID = " + txt_rid.Text + " ";
                //MessageBox.Show(query2);
                command2.CommandText = query2;
                OleDbDataReader reader = command2.ExecuteReader();
                //if (reader.HasRows == true)
                //{
                while (reader.Read())
                {
                    double Pt = double.Parse(nm_Point.Text);
                    double De_pt = double.Parse(reader["DeductPoint"].ToString());
                    double new_de_pt = double.Parse(Ded_point.Text);
                    //MessageBox.Show(De_pt.ToString());                        
                    Pt = Pt + De_pt - new_de_pt;
                    OleDbCommand command3 = new OleDbCommand();
                    command3.Connection = connection;
                    string query3 = "update EmployeeData set Point = " + Pt + " where EID = " + txt_eid.Text + " ";
                    command3.CommandText = query3;
                    command3.ExecuteNonQuery();
                }
                //}                

                connection.Close();
                update_remaining_point();
                update_datagridview();
                
                // update DB
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = " update DeductData set DeductDate = '" + Deduct_date.Text + "' ,TimeIn_hh = '" + TimeIn_hh.Text + "',  "
                    + " TimeIn_mm = '" + TimeIn_mm.Text + "', TimeIn_ampm = '" + Am_Pm.Text + "', DeductPoint = '" + Ded_point.Text + "', "
                    + " Reason = '" + Reason.Text + "'  where RID = " + txt_rid.Text + " ";
                command.CommandText = query;
                command.ExecuteNonQuery();
                //MessageBox.Show("Data saved !!");
                update_datagridview();
                connection.Close();
                
                update_remaining_point();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Software Version
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Employee Management System 2016 \n Version: 1.0.1 "
                +"\n Developer: Sean Chen \n Special Thanks: Shawn Chao \n All Rights Reserved ");
        }


        private void btn_Print_Click(object sender, EventArgs e)
        {
            try {
                printPreviewDialog1.Document = printDocument2;
                printDocument2.PrintPage += new PrintPageEventHandler(PrintPage);
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }



        ArrayList records = new ArrayList();

        // print slip
        public void PrintPage(object sender, PrintPageEventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            string header =
                " \n\t\t\tTARDY SLIP "
                + "\n _____________________________________________________________"
                + "\n Name:\t\t" + txt_fName.Text + "  " + txt_lName.Text + " "
                + "\n Department:\t" + txt_dept.Text + " "
                + "\n Processing date:\t" + Proc_date.Text + " "
                + "\n Remaining Points: " + nm_Point.Text + " "
                + "\n _____________________________________________________________ ";

            sb.Append(header);


            for (int i = 0; i <= records.Count - 1; i++)
            {
                sb.Append(records[i].ToString());
            }
            
            e.Graphics.DrawString( sb.ToString() , new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point (10, 10));

            //records.Clear();
        }

        //add to print Q        
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            records.Add("\n Deducted Date:\t\t" + Deduct_date.Text + "\tTime In: " + TimeIn_hh.Text + ":" + TimeIn_mm.Text + " " + Am_Pm.Text + " "
                + "\n Reason:\t" + Reason.Text + " "
                + "\n Deducted Points: " + Ded_point.Text + " \n"
                //+ "\n _____________________________________________________________ "
                );
        }


        // hotkey
        // Ctrl + p = prints
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            { 
                if (e.Control && e.KeyCode.ToString() == "A")
                {
                    btn_addRecord.PerformClick();
                }
                if (e.Control && e.KeyCode.ToString() == "D")
                {
                    btn_del_rec.PerformClick();
                }
                if (e.Control && e.KeyCode.ToString() == "E")
                {
                    edit_rec.PerformClick();
                }
                if (e.Control && e.KeyCode.ToString() == "P")
                {
                    btn_Print.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        
    }
}
