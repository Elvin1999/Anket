using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetresult_Click(object sender, EventArgs e)
        {
            this.Text = dateTimePicker.Text;
            string gender = "";
            if (maleradioButton.Checked)
            {
                gender = "male";
            }
            else if (femaleradiobutton.Checked)
            {
                gender = "female";
            }
            Anket anket = new Anket(surnametextBox.Text, nametextBox.Text, surnametextBox.Text
                , fathernametextBox.Text, countrytextBox.Text,
                citytextBox.Text, phonenumbertextBox.Text, dateTimePicker.Value, gender);
            var filename = surnametextBox.Text + ".json";
            var res = JsonConvert.SerializeObject(anket);
            File.WriteAllText(filename, res);
            foreach (var item in this.Controls)
            {
                if (item is TextBox tb)
                {
                    tb.Text = String.Empty;
                }
            }

        }
        //button1_Click belong to filenametextbox
        private void button1_Click(object sender, EventArgs e)
        {
            Anket resultanket = new Anket();
            filenametextbox.Text += ".json";
            if (File.Exists(filenametextbox.Text))
            {
                var str = File.ReadAllText(filenametextbox.Text);
                var newobject = JsonConvert.DeserializeObject<Anket>(str);
                resultanket = newobject;
            }
            nametextBox.Text = resultanket.Name;
            surnametextBox.Text = resultanket.Surname;
            fathernametextBox.Text = resultanket.FatherName;
            countrytextBox.Text = resultanket.Country;
            citytextBox.Text = resultanket.City;
            phonenumbertextBox.Text = resultanket.Phonenumber;
            dateTimePicker.Value = resultanket.BirthDate;
            if (resultanket.Gender == "male")
            {
                maleradioButton.Checked = true;
            }
            else if (resultanket.Gender == "female")
            {
                femaleradiobutton.Checked = true;
            }
            foreach (var item in Controls)
            {
                if(item is TextBox tb)
                {
                    tb.ForeColor = Color.Black;
                }
            }
        }

        private void filenametextbox_Enter(object sender, EventArgs e)
        {
            if (filenametextbox.Text=="Filename")
            {
                filenametextbox.Text = String.Empty;
            }

            filenametextbox.ForeColor = Color.Black;
        }

        private void filenametextbox_Leave(object sender, EventArgs e)
        {
            filenametextbox.ForeColor = Color.Gray;
            if (String.IsNullOrEmpty(filenametextbox.Text))
            {
                filenametextbox.Text = "Filename";
            }
        }

        private void nametextBox_Enter(object sender, EventArgs e)
        {
            if (nametextBox.Text=="Name")
            {
                nametextBox.Text = String.Empty;
            }
            nametextBox.ForeColor = Color.Black;
        }

        private void nametextBox_Leave(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(nametextBox.Text))
            {
                nametextBox.ForeColor = Color.Gray;
                nametextBox.Text = "Name";
            }

        }

        private void surnametextBox_Enter(object sender, EventArgs e)
        {
            if (surnametextBox.Text=="Surname")
            {
                surnametextBox.Text = String.Empty;
            }
            surnametextBox.ForeColor = Color.Black;
        }

        private void surnametextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(surnametextBox.Text))
            {
                surnametextBox.ForeColor = Color.Gray;
                surnametextBox.Text = "Surname";
            }
        }

        private void fathernametextBox_Enter(object sender, EventArgs e)
        {
            if (fathernametextBox.Text== "Father_name")
            {
                fathernametextBox.Text = String.Empty;
            }
            fathernametextBox.ForeColor = Color.Black;
        }

        private void fathernametextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(fathernametextBox.Text))
            {
                fathernametextBox.ForeColor = Color.Gray;
                fathernametextBox.Text = "Father_name";
            }
        }

        private void countrytextBox_Enter(object sender, EventArgs e)
        {
            if (countrytextBox.Text=="Country")
            {
                countrytextBox.Text = String.Empty;
            }
            countrytextBox.ForeColor = Color.Black;
        }

        private void countrytextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(countrytextBox.Text))
            {
                countrytextBox.ForeColor = Color.Gray;
                countrytextBox.Text = "Country";
            }
        }

        private void citytextBox_Enter(object sender, EventArgs e)
        {
            if (citytextBox.Text=="City")
            {
                citytextBox.Text = String.Empty;
            }
            citytextBox.ForeColor = Color.Black;
        }

        private void citytextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(citytextBox.Text))
            {
                citytextBox.ForeColor = Color.Gray;
                citytextBox.Text = "City";
            }
        }

        private void phonenumbertextBox_Enter(object sender, EventArgs e)
        {
            if (phonenumbertextBox.Text=="Phone number")
            {
                phonenumbertextBox.Text = String.Empty;
            }
            phonenumbertextBox.ForeColor = Color.Black;
        }

        private void phonenumbertextBox_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(phonenumbertextBox.Text))
            {
                phonenumbertextBox.ForeColor = Color.Gray;
                phonenumbertextBox.Text = "Phone number";
            }
        }
    }
}




