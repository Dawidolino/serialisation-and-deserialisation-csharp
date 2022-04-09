using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace serializacja_i_deserializacja_Dawid_Ruth_58411
{
    public partial class Form1 : Form
    {
        const string path = @"C:\json\JsonText.txt"; //domyslna sciezka w ktorej istnieje plik 

        public Customer Customer { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var serialisedString = File.ReadAllText(path);

            Customer = JsonConvert.DeserializeObject<Customer>(serialisedString, new JsonSerializerSettings());
           
            
            if (Customer == null) //wypelnianie danymi w przypadku pustego pliku txt
            {
                Customer = new Customer
                {
                    Name = "Kacper Molesinski",
                    Age = 25,
                    Adress = "Śląska st., 21-15 Gdynia, Poland",
                    PESEL = 21156942069,
                    Email = "kot984@wp.pl",
                    Website = "kacpercorp.de"
                };
            }
            propertyGrid1.SelectedObject = Customer;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Customer.Adress = ((Customer)propertyGrid1.SelectedObject).Adress;
            Customer.Age = ((Customer)propertyGrid1.SelectedObject).Age;
            Customer.Name = ((Customer)propertyGrid1.SelectedObject).Name;
            Customer.PESEL = ((Customer)propertyGrid1.SelectedObject).PESEL;
            Customer.Website = ((Customer)propertyGrid1.SelectedObject).Website;
            Customer.Email = ((Customer)propertyGrid1.SelectedObject).Email;

            var serialisedString = JsonConvert.SerializeObject(Customer, Formatting.Indented);


            File.WriteAllText(path, serialisedString);
          
        }
    }
}
