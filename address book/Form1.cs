using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace address_book
{
    public partial class Form1 : Form
    {
        private List<Person> addressBook = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                Name = nameTxt.Text,
                Email = emailTxt.Text,
                Phone = phoneTxt.Text
            };
            addressBook.Add(person);
            MessageBox.Show("Entry saved successfully!");
            nameTxt.Clear();
            emailTxt.Clear();
            phoneTxt.Clear();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

}
