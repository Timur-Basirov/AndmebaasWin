using AndmebaasWin.AndmebaasDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndmebaasWin
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=HP-CZC2349HV2;Initial Catalog=Andmebaas;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
            //NaitaAndmed();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'andmebaasDataSet.Toode' table. You can move, or remove it, as needed.
            this.toodeTableAdapter.Fill(this.andmebaasDataSet.Toode);

        }

        public void NaitaAndmed()
        {
            this.toodeTableAdapter.Fill(this.andmebaasDataSet.Toode);
        }

        private void LisaBtn_Click(object sender, EventArgs e)
        {
            if (Nimetus_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() !=string.Empty && Hind_txt.Text.Trim() != string.Empty) 
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO Toode(Nimetus,Kogus,Hind) VALUES (@toode,@kogus,@hind)", conn);
                    cmd.Parameters.AddWithValue("@toode", Nimetus_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    cmd.ExecuteNonQuery();

                    conn.Close();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Sisesta Andmeid!");
            }
        }

        private void KustutaBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("DELETE FROM Toode WHERE Nimetus = @Nimetus AND Kogus = @kogus AND Hind = @hind", conn);
            cmd.Parameters.AddWithValue("@Nimetus", Nimetus_txt.Text);
            cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
            cmd.Parameters.AddWithValue("@hind", Hind_txt.Text);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("DBCC CHECKIDENT ('Toode', RESEED, 0)", conn);
            cmd.ExecuteNonQuery();

            conn.Close();
            this.toodeTableAdapter.Fill(this.andmebaasDataSet.Toode);

        }
    }
}
