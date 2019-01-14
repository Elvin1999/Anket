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
        private void button1_Click(object sender, EventArgs e)
        {
            Anket resultanket = null;
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
        }

        private void filenametextbox_Enter(object sender, EventArgs e)
        {

        }
    }
}




