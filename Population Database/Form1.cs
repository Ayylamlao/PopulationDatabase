using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Population_Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.populationDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'populationDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.populationDataSet.City);

        }




        //AVERAGE POPULATION
    //    private void averagePopulation_Click(object sender, EventArgs e)
      //  {
        //    double averagePopulation;
          //  averagePopulation = PopulationDataSet.Average(Population);
           // MessageBox.Show("The average population is: " + averagePopulation.ToString());
        //}



        //private void totalPopulation_Click(object sender, EventArgs e)
        //{
           
             //double totalPopulation;
             //averagePopulation = PopulationDataSet.Total(Population);
            //
  //           MessageBox.Show("The total population is: " + totalPopulation.ToString());
//        }




    }
}
   