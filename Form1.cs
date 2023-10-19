using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Otel
{
    public partial class Form1 : Form
    {
        Connection connection = new Connection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void show_Data(string command)
        {
            Connection connection = new Connection();

            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connection.conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            dataGridViewMain.DataSource = dt;
            dataGridViewMain.Columns[0].Visible = false;
        }

        private void show_Data_tab2(string command)
        {
            Connection connection = new Connection();

            DataTable dt2 = new DataTable();
            using (SqlConnection conn = new SqlConnection(connection.conn_string))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(command, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    dt2.Load(reader);
                }
            }
            dataGridViewSecond.DataSource = dt2;
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {
            show_Data("getUsersdata");
            connection.table = "Users";
        }

        private void btnShowBookings_Click(object sender, EventArgs e)
        {
            show_Data("getBookingsData");
            connection.table = "Bookings";
            dataGridViewMain.Columns[5].Visible = false;
            dataGridViewMain.Columns[6].Visible = false;
            dataGridViewMain.Columns[7].Visible = false;
        }

        private void btnShowRooms_Click(object sender, EventArgs e)
        {
            show_Data("getHotelRoomsData");
            connection.table = "HotelRooms";
        }

        private void btnShowServices_Click(object sender, EventArgs e)
        {
            show_Data("getServicesData");
            connection.table = "Services";
            dataGridViewMain.Columns[4].Visible = false;
        }

        private void dataGridViewMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewMain.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewMain.SelectedRows[0];
                DataGridViewColumnCollection columns = dataGridViewMain.Columns;

                label0.Text = "";
                labelName1.Text = "";
                labelName2.Text = "";
                labelName3.Text = "";
                labelName4.Text = "";
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = false;
                label0.Text += dataGridViewMain.Columns[0].HeaderText;
                textBoxID.Text = selectedRow.Cells[0].Value.ToString();
                labelName1.Text += dataGridViewMain.Columns[1].HeaderText;
                textBox1.Text = selectedRow.Cells[1].Value.ToString();
                labelName2.Text += dataGridViewMain.Columns[2].HeaderText;
                textBox2.Text = selectedRow.Cells[2].Value.ToString();
                labelName3.Text += dataGridViewMain.Columns[3].HeaderText;
                textBox3.Text = selectedRow.Cells[3].Value.ToString();
                if (selectedRow.Cells.Count >= 5)
                {
                    if (dataGridViewMain.Columns[4].HeaderText != "RoomID")
                    {
                        textBox4.Visible = true;
                        labelName4.Text += dataGridViewMain.Columns[4].HeaderText;
                    }
                    textBox4.Text = selectedRow.Cells[4].Value.ToString();
                    if (selectedRow.Cells.Count == 8)
                    {
                        textBoxUserID.Text = selectedRow.Cells[5].Value.ToString();
                        textBoxRoomID.Text = selectedRow.Cells[6].Value.ToString();
                        textBoxServiceID.Text = selectedRow.Cells[7].Value.ToString();
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection.conn_string))
                    {
                        string command_change = "";
                        if (connection.table == "Users" || connection.table == "HotelRooms")
                        {
                            command_change = "Update " + connection.table + " Set " +
                            labelName1.Text + " = '" + textBox1.Text + "',\n" +
                            labelName2.Text + " = '" + textBox2.Text + "',\n" +
                            labelName3.Text + " = '" + textBox3.Text + "'\n" +
                            "Where " + connection.table + "." + label0.Text + " = " + textBoxID.Text + ";";
                        }
                        else if (connection.table == "Services")
                        {
                            command_change = "Update Services Set " +
                            labelName1.Text + " = '" + textBox1.Text + "', " +
                            labelName2.Text + " = " + textBox2.Text +
                            " Where " + label0.Text + " = " + textBoxID.Text + "\n" +
                            "Update HotelRooms Set " +
                            labelName3.Text + " = " + textBox3.Text +
                            " Where " + "RoomID = " + textBox4.Text;
                        }
                        else if (connection.table == "Bookings")
                        {
                            command_change = "Update Users Set " +
                            "UserName = '" + textBox1.Text +
                            "' Where UserID = " + textBoxUserID.Text + "\n" +
                            "Update HotelRooms Set " +
                            "Number = " + textBox2.Text +
                            " Where RoomID = " + textBoxRoomID.Text + "\n" +
                            "Update Services Set " +
                            "ServiceName = '" + textBox3.Text +
                            "' Where ServiceID = " + textBoxServiceID.Text + "\n" +
                            "Update Bookings Set " +
                            "Date = '" + textBox4.Text +
                            "' Where BookingID = " + textBoxID.Text;
                        }
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(command_change, conn))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text != "")
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connection.conn_string))
                    {
                        string command_delete = "";
                        if (connection.table == "Users")
                        {
                            command_delete = "Delete From Bookings Where Client = "+ textBoxID.Text +
                                "\n Delete From Users Where UserID = " + textBoxID.Text; 
                        }
                        else if (connection.table == "HotelRooms")
                        {
                            command_delete = "Delete From Bookings Where Room = " + textBoxID.Text +
                                "\n Delete From Services Where Room = " + textBoxID.Text +
                                "\n Delete From HotelRooms Where RoomID = " + textBoxID.Text;
                        }
                        else if (connection.table == "Services")
                        {
                            command_delete = "Delete From Bookings Where Service = " + textBoxID.Text +
                                "\n Delete From Services Where ServiceID = " + textBoxID.Text;
                        }
                        else if (connection.table == "Bookings")
                        {
                            command_delete = "Delete From Bookings Where BookingID = " + textBoxID.Text;
                        }
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(command_delete, conn))
                        {
                            SqlDataReader reader = cmd.ExecuteReader();
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            string command = textBoxSql.Text;
            show_Data_tab2(command);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connection.conn_string))
                {
                    string command_add = "";
                    if (connection.table == "Users")
                    {
                        command_add = "Insert Into Users (UserName, Login, Password) Values('" + textBox1.Text.Replace(" ","") + "', '" + textBox2.Text.Replace(" ", "") + "', '" + textBox3.Text.Replace(" ", "") + "')";
                    }
                    else if (connection.table == "HotelRooms")
                    {
                        command_add = "Insert Into HotelRooms (Number, Class, Price) Values ('" + textBox1.Text.Replace(" ", "") + "', '" + textBox2.Text.Replace(" ", "") + "', '" + textBox3.Text.Replace(" ", "") + "')";
                    }
                    else if (connection.table == "Services")
                    {
                        command_add = "Insert Into Services (ServiceName, Price, Room) Values ('" + textBox1.Text.Replace(" ", "") + "', '" + textBox2.Text.Replace(" ", "") + "', '" + textBox3.Text.Replace(" ", "") + "')";
                    }
                    else if (connection.table == "Bookings")
                    {
                        command_add = "Insert Into Bookings (Client, Room, Service, Date) Values ('" + textBox1.Text.Replace(" ", "") + "', '" + textBox2.Text.Replace(" ", "") + "', '" + textBox3.Text.Replace(" ", "") + "', '" + textBox4.Text.Replace(" ", "") + "')";
                    }
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(command_add, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_Data("PRCase");

            dataGridViewMain.Columns[0].Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show_Data("PRPod");

            dataGridViewMain.Columns[0].Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            show_Data("PRCor");

            dataGridViewMain.Columns[0].Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            show_Data("PRHav");
            dataGridViewMain.Columns[0].Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            show_Data("PRAny");

            dataGridViewMain.Columns[0].Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            show_Data("PRAll");

            dataGridViewMain.Columns[0].Visible = true;
        }
    }
}
