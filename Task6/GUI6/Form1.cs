using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Implementation6;


namespace GUI6
{
    public partial class Form1 : Form
    {
        private int b = 0;
        List list = new List();
        private int Date;
        private double Lenght;
        private String NameA;
        private String Model;
        public Form1()
        {
            InitializeComponent();
        }

        /* 
         private void uploadButt_Click(object sender, EventArgs e)
         {
             Date = Convert.ToInt32(dateBox.Text);
             Lenght = Convert.ToDouble(lenghtBox.Text);
             NameA = nameBox.Text;
             Model = modelBox.Text;
             AircraftCarrier newAircraft = new AircraftCarrier(NameA, Model, Date, Lenght);
             listBox1.Items.Add(newAircraft);
             list.Add(newAircraft);
             listBox1.DataSource = list;
             textBox1.Text = "fdf";
             textBox1.Refresh();
         }
        */
        private void uploadButt_Click_1(object sender, EventArgs e)
        {
            b = 0;
            Date = Convert.ToInt32(dateBox.Text);
            Lenght = Convert.ToDouble(lenghtBox.Text);
            NameA = nameBox.Text;
            Model = modelBox.Text;

            list.Add(new AircraftCarrier(NameA, Model, Date, Lenght));
            updateListBox1();
            b = 1;
        }

        private void updateListBox1()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = list.ShipList;
        }

        private void toSailButt_Click(object sender, EventArgs e)
        {
            list.ToSail(listBox1.SelectedIndex);
            outBoxUpdate();
        }

        private void fromSailButt_Click(object sender, EventArgs e)
        {
            list.FromSail(listBox1.SelectedIndex);
            outBoxUpdate();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (b == 1)
            {
                outBoxUpdate();
            }
        }


        private void outBoxUpdate()
        {
            outBox.Text = Convert.ToString(list.ShipList[listBox1.SelectedIndex].GetInfo());
            outBox.Refresh();
        }
    }
}
