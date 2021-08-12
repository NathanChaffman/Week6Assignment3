using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StatuesRepository;

namespace Week6Assignment3
{
    public partial class Form1 : Form
    {
        StatueDepot statue;
        public Form1()
        {
            InitializeComponent();
            statue = new StatueDepot();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = statue.Read();
            btnUpdate.Enabled = false;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtnumber.Text == "")
            {
                CleardataNew();
            }
            if (!string.IsNullOrWhiteSpace(txtnumber.Text) && !string.IsNullOrWhiteSpace(txtchar.Text) && !string.IsNullOrWhiteSpace(txtcompany.Text) && !string.IsNullOrWhiteSpace(txtedition.Text) && !string.IsNullOrWhiteSpace(txtlicense.Text))
            {
                StatueTable obj = new StatueTable();
                obj.Statue_number = Convert.ToDecimal(txtnumber.Text);
                obj.Character = txtchar.Text;
                obj.Company = txtcompany.Text;
                obj.Scale = Convert.ToString(comboBox1.SelectedItem);
                obj.License = txtlicense.Text;
                obj.Edition_Size = Convert.ToDecimal(txtedition.Text);
                statue.Create(obj);
                statue.Save();
                Clear();
            }
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = statue.Read();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.CurrentRow.Cells[0].Value;
            var statuetodel = statue.Read().First(p => p.Statue_number == (decimal)id);
            statue.Delete(statuetodel);
            statue.Save();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtnumber.Text) && !string.IsNullOrWhiteSpace(txtchar.Text) && !string.IsNullOrWhiteSpace(txtcompany.Text) && !string.IsNullOrWhiteSpace(txtedition.Text) && !string.IsNullOrWhiteSpace(txtlicense.Text))
            {
                var id = Convert.ToDecimal(txtnumber.Text);
                var statuetoupdate = statue.Read().First(p => p.Statue_number == id);
                statuetoupdate.Character = txtchar.Text;
                statuetoupdate.Company = txtcompany.Text;
                statuetoupdate.Edition_Size = decimal.Parse(txtedition.Text);
                statuetoupdate.Statue_number = decimal.Parse(txtnumber.Text);
                statuetoupdate.License = txtlicense.Text;
                statuetoupdate.Scale = comboBox1.SelectedItem.ToString();
                statue.Save();
                Clear();
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            var id = dataGridView1.CurrentRow.Cells[0].Value;
            var statuetoupdate = statue.Read().First(p => p.Statue_number == (decimal)id);
            txtnumber.Text = statuetoupdate.Statue_number.ToString();
            txtnumber.ReadOnly = true;
            txtchar.Text = statuetoupdate.Character;
            txtcompany.Text = statuetoupdate.Company;
            txtlicense.Text = statuetoupdate.License;
            comboBox1.Items.Add("OneTenth");
            comboBox1.Items.Add("OneEighth");
            comboBox1.Items.Add("OneSixth");
            comboBox1.Items.Add("OneFourth");
            comboBox1.Items.Add("OneThird");
            comboBox1.Items.Add("Half");
            comboBox1.Items.Add("Lifesize");
            comboBox1.Items.Add("Other");
            comboBox1.SelectedItem = statuetoupdate.Scale;
            txtedition.Text = statuetoupdate.Edition_Size.ToString();
            btnUpdate.Enabled = true;
        }
        private void CleardataNew()
        {
            txtchar.Clear();
            txtnumber.ReadOnly = true;
            txtnumber.Text = (statue.Read().Max(p => p.Statue_number) + 1).ToString();
            txtcompany.Clear();
            txtedition.Clear();
            txtlicense.Clear();
            comboBox1.Items.Add("OneTenth");
            comboBox1.Items.Add("OneEighth");
            comboBox1.Items.Add("OneSixth");
            comboBox1.Items.Add("OneFourth");
            comboBox1.Items.Add("OneThird");
            comboBox1.Items.Add("Half");
            comboBox1.Items.Add("Lifesize");
            comboBox1.Items.Add("Other");
        }
        private void Clear()
        {
            txtchar.Clear();
            txtcompany.Clear();
            txtedition.Clear();
            txtlicense.Clear();
            txtnumber.Clear();
            comboBox1.Items.Clear();
        }
    }
}
