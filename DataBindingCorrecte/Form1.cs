using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DataBindingCorrecte
{
    public partial class Form1 : Form
    {
        private BindingSource dgv;
        public Form1()
        {

            InitializeComponent();

            // Exercici 1

            // Creo els alumnes
            Alumne alumne1 = new Alumne("Ferran", "Fuentes", "ferranfu1@gmail.com", new DateTime(2002, 11, 20), true,true, true, false, true);
            Alumne alumne2 = new Alumne("Ruben", "Paleto", "ruben2006lover@gmail.com", new DateTime(2004, 1, 6), true, true, false, false, true);
            Alumne alumne3 = new Alumne("Miguel", "Latino", "fvckvenezuela@gmail.com", new DateTime(2009, 7, 13), true, false, false, true, false);

            // Creo la llista i els afegeixo a la llista
            List<Alumne> Alumnes = new List<Alumne>();
            Alumnes.Add(alumne1);
            Alumnes.Add(alumne2);
            Alumnes.Add(alumne3);

            dgv = new BindingSource();
            dgv.DataSource = Alumnes;
            dataGridView1.DataSource = dgv;

            textBox1.DataBindings.Add("Text", dgv, "Nom");
            textBox2.DataBindings.Add("Text", dgv, "Cognom");
            textBox3.DataBindings.Add("Text", dgv, "Email");
            radioButton1.DataBindings.Add("Checked", dgv, "Horari_mati");
            radioButton2.DataBindings.Add("Checked", dgv, "Horari_tarda");
            checkBox1.DataBindings.Add("Checked", dgv, "Curset1");
            checkBox2.DataBindings.Add("Checked", dgv, "Curset2");
            checkBox3.DataBindings.Add("Checked", dgv, "Curset3");
            dateTimePicker1.DataBindings.Add("Value", dgv, "dataNaixement");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumne alumnenou = new Alumne("", "", "", DateTime.MinValue, false, false, false, false, false);
            dgv.Add(alumnenou);
            int rowIndex = dgv.IndexOf(alumnenou);
            dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                DialogResult result = MessageBox.Show("Estàs segur de que vols borrar aquesta fila? ", "Confirma acció destructiva ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            
                if (result == DialogResult.Yes)
                {
                   dataGridView1.Rows.Remove(selectedRow);
                }
                else
                {
                    MessageBox.Show("No s'ha esborrat la fila correctament ");
                }
            }
        }
    }
}
