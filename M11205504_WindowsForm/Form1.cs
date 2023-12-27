using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M11205504_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void co2_Per_Capita_Europe_2018_DescBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.co2_Per_Capita_Europe_2018_DescBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eU_Co2_2018_DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'yearly_DataSet.High_CO2_Emissions_From_Coal_Desc' 資料表。您可以視需要進行移動或移除。
            this.high_CO2_Emissions_From_Coal_DescTableAdapter.Fill(this.yearly_DataSet.High_CO2_Emissions_From_Coal_Desc);
            // TODO: 這行程式碼會將資料載入 'region_DataSet.Region_Subregion_CO2_Emissions_Desc' 資料表。您可以視需要進行移動或移除。
            this.region_Subregion_CO2_Emissions_DescTableAdapter.Fill(this.region_DataSet.Region_Subregion_CO2_Emissions_Desc);
            // TODO: 這行程式碼會將資料載入 'sub_2018_DataSet.Subregion_CO2_Emissions_2018_Desc' 資料表。您可以視需要進行移動或移除。
            this.subregion_CO2_Emissions_2018_DescTableAdapter.Fill(this.sub_2018_DataSet.Subregion_CO2_Emissions_2018_Desc);
            // TODO: 這行程式碼會將資料載入 'eU_Co2_2018_DataSet.Co2_Per_Capita_Europe_2018_Desc' 資料表。您可以視需要進行移動或移除。
            this.co2_Per_Capita_Europe_2018_DescTableAdapter.Fill(this.eU_Co2_2018_DataSet.Co2_Per_Capita_Europe_2018_Desc);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.region_Subregion_CO2_Emissions_DescTableAdapter.FillBy(this.region_DataSet.Region_Subregion_CO2_Emissions_Desc, keywordToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.high_CO2_Emissions_From_Coal_DescTableAdapter.FillBy(this.yearly_DataSet.High_CO2_Emissions_From_Coal_Desc, new System.Nullable<int>(((int)(System.Convert.ChangeType(keywordToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        
    }
}
