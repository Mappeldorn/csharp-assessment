using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace csharp_1
{
    public partial class Form1 : Form
    {

        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        List<Boat> dbBoats;
        List<Rent> dbRents;

        AboutBox1 aboutBox = new AboutBox1();
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(startSplashscreen));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

            
            dbBoats = new List<Boat>();
            dbRents = new List<Rent>();
            con = new MySqlConnection("Server=localhost;Database=boat_rental;user=stenden;Pwd=stenden;SslMode=none");
            cmd = new MySqlCommand();
            cmd.Connection = con;

            this.getAllBoats();
            this.getAllRents();
            this.showBoats();
            boatRental boatRental = new boatRental("happy boat rental");
            
        }

         public void startSplashscreen()
        {
            Application.Run(new splashscreen());
        }

        private void saveRent_Click(object sender, EventArgs e)
        {

            string startStr = startInput.Text.ToString();
            string endStr = endInput.Text.ToString();
            string usedFuelStr = usedFuelInput.Text.ToString();
            int damageStr = damageInput.SelectedIndex;

            if (!string.IsNullOrEmpty(startStr) && !string.IsNullOrEmpty(endStr) && !string.IsNullOrEmpty(usedFuelStr) && boatInput.SelectedIndex != -1 && damageInput.SelectedIndex != -1) 
            {
               
                try
                {
                    int number = int.Parse(boatInput.SelectedItem.ToString());
                    DateTime start = DateTime.ParseExact(startStr, "HH:mm", null);
                    DateTime end = DateTime.ParseExact(endStr, "HH:mm", null);
                    int usedFuel = int.Parse(usedFuelStr);
                    Boolean damage = false;

                    switch (damageStr)
                    {
                        case 1:
                            damage = true;
                            break;
                        case 0:
                            damage = false;
                            break;
                    }

                    if (checkRentAvailable(number, DateTime.Now.Date))
                    {
                        addRent(number, start, end, usedFuel, damage);
                        MessageBox.Show("New rent added");
                    }
                    else
                    {
                        MessageBox.Show("Boat already rented out today");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

               
            }
            else
            {
                MessageBox.Show("Please fill all the forms in");
            }

        }

        public Boolean checkRentAvailable(int boat, DateTime date)
        {
            Boolean available = true;
            con.Open();
            cmd.CommandText = "SELECT * FROM rent WHERE boat_id = @boat_id";
            cmd.Parameters.AddWithValue("@boat_id", boat);
            cmd.Prepare();
            dr = cmd.ExecuteReader();
            while (dr.Read()) { 
                DateTime dbDate = DateTime.Parse(dr.GetString("rentDate"));
                bool res = DateTime.Equals(date, dbDate.Date);
                if (res)
                {
                    available = false;
                }
             }

            cmd.Parameters.Clear();
            con.Close();
            return available;

        }

        public void addRent(int boat, DateTime start, DateTime end, int usedFuel, Boolean damage)
        {
            con.Open();
            cmd.CommandText = "INSERT INTO `rent`(`boat_id`, `start`, `end`, `usedFuel`, `rentDate`, `damage`) VALUES (@boat_id, @start, @end, @usedFuel, @rentDate, @damage)";
            cmd.Parameters.AddWithValue("@boat_id", boat);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("@end", end);
            cmd.Parameters.AddWithValue("@usedFuel", usedFuel);
            cmd.Parameters.AddWithValue("@rentDate", DateTime.Now.Date);
            cmd.Parameters.AddWithValue("@damage", damage);
            cmd.Prepare();

            cmd.ExecuteNonQuery();
            dbRents.Add(new Rent(cmd.LastInsertedId, boat, start, end, usedFuel, DateTime.Now.Date, damage));
            cmd.Parameters.Clear();
            con.Close();
        }

        public void getAllBoats()
        {
            con.Open();
            cmd.CommandText = "SELECT * FROM boat";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.dbBoats.Add(new Boat(int.Parse(dr.GetString("id")), double.Parse(dr.GetString("weight")), int.Parse(dr.GetString("power")), double.Parse(dr.GetString("length")), double.Parse(dr.GetString("rent"))));
            }
            con.Close();
        }

        public void getAllRents()
        {
            con.Open();
            cmd.CommandText = "SELECT * FROM rent";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.dbRents.Add(new Rent(  long.Parse(dr.GetString("id")),  
                                            int.Parse(dr.GetString("boat_id")), 
                                            DateTime.Parse(dr.GetString("start")), 
                                            DateTime.Parse(dr.GetString("end")), 
                                            int.Parse(dr.GetString("usedFuel")), 
                                            DateTime.Parse(dr.GetString("rentDate")),
                                            System.Convert.ToBoolean(dr.GetString("damage"))
                                            ));
            }
            con.Close();

        }

        public void showBoats()
        {

            if(this.dbBoats.Count >=0)
            {
                foreach (Boat boat in dbBoats)
                {
                    boatsLabel.Text += $"Number: {boat.number}, Weight: {boat.weight}, Power: {boat.power}, Length: {boat.length}, Rent: {boat.rent}\n";
                    boatInput.Items.Add(boat.number);
                }


            }
            else
            {
                boatsLabel.Text = "No boats";
            }
            
        }

        private void totalRevenue_Click(object sender, EventArgs e)
        {
            double revenue = 0.0;
            foreach (Rent rent in dbRents)
            {

                con.Open();
                cmd.CommandText = "SELECT rent FROM boat WHERE id = @boat_id";
                cmd.Parameters.AddWithValue("@boat_id", rent.boat);
                cmd.Prepare();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    revenue += rent.getRevenue(double.Parse(dr.GetString("rent")));
                }
                cmd.Parameters.Clear();
                con.Close();
            }

            result.Text = "Total revenue: " + revenue;
        }

        private void mostConsumed_Click(object sender, EventArgs e)
        {
            long boat = 0;
            double mostConsumed = 0.0;

            foreach (Rent rent in this.dbRents)
            {
                if (rent.usedFuel > mostConsumed)
                {
                    boat = rent.boat;
                    mostConsumed = rent.usedFuel;
                }
            }

            result.Text = "Most consumed boat: " + boat;
         }

        private void percentageDamage_Click(object sender, EventArgs e)
        {
            int totalRents = this.dbRents.Count;
            int totalDamage = 0;

            foreach (Rent rent in dbRents)
            {
                if (rent.damage)
                {
                    totalDamage++;
                }
            }

            result.Text = (100 / totalRents * totalDamage) + " % are damage";
        }

        private void leastUsedBoat_Click(object sender, EventArgs e)
        {
            long boat = 0;
            int shortestTime = 1000;
            foreach (Rent rent in dbRents)
            {
                int compare = shortestTime.CompareTo(rent.calculateRentTime());
                if (rent.calculateRentTime() < shortestTime)
                {
                    boat = rent.boat;
                    shortestTime = rent.calculateRentTime();
                }
            }

            result.Text = "Least used boat: " + boat.ToString();
        }

        private void totalRentTime_Click(object sender, EventArgs e)
        {
            double totalTime = 0;
            foreach (Rent rent in dbRents)
            {
                totalTime += rent.calculateRentTime();
            }

            result.Text = "Total rent time: " + totalTime.ToString() + " minute";
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.aboutBox.Show();
        }

        private void overviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(overview_tab);
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void rentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(rent_tab);
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void boatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(boat_tab);
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
