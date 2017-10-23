using ClassLibrary1.Entities;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Feeds : Form
    {
        private List<Category> _categories;
        private XmlHanterare xmlHanterare;

        public Feeds()
        {
            InitializeComponent();
            xmlHanterare = new XmlHanterare();
            _categories = xmlHanterare.GetAllCategories();
            fillCategorylist();
        }

        private void fillCategorylist()
        {
            foreach (var category in _categories)
               
            {
                ListCategories.Items.Add(category);

            }
        }

        private void Feeds_Load(object sender, EventArgs e)
        {

        }

        private void sparaBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void KategoriLbl_Click(object sender, EventArgs e)
        {

        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void visaFeedsLbl_Click(object sender, EventArgs e)
        {

        }

        private void ListCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
