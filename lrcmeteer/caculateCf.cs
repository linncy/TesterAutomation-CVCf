using System;
using System.Windows.Forms;
using System.Data;
using Ivi.Visa;
using Ivi.Visa.FormattedIO;
using LogRecord;
using System.IO;

namespace lrcmeteer
{
    public partial class Form1 : Form
    {
        private bool caculateCf(DataTable datatable, DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No data to caculate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtCfArea.Text == "")
            {
                MessageBox.Show("Program cannot perform caculation, since Area was not entered. To perform caculation again, please check Area and click the Caculate button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!(datatable.Columns.Contains("C/S(nF/cm²)") || datatable.Columns.Contains("dC/dln ω")))
            {
                datatable.Columns.Add("C/S(nF/cm²)", typeof(System.Double));
                datatable.Columns.Add("dC/dln ω", typeof(System.Double));
            }
            int lenRow = datatable.Rows.Count;
           // double epsilonS = Convert.ToDouble(txtCVPermittivity.Text);
           // double epsilon0 = 8.854E-12;
            double area_cm2 = Convert.ToDouble(txtCfArea.Text);
          //  double q = 1.6E-19;
            for (i = 0; i < lenRow; i++)
            {
                dgvData.Rows[i].Cells[4].Value = Convert.ToDouble(dataGridView.Rows[i].Cells[3].Value) / area_cm2;
            }
            for (i = 0; i < lenRow-1; i++)
            {
                double c1 = Convert.ToDouble(dataGridView.Rows[i].Cells[3].Value);
                double c2 = Convert.ToDouble(dataGridView.Rows[i+1].Cells[3].Value);
                double lnw1 = Convert.ToDouble(dataGridView.Rows[i].Cells[2].Value);
                double lnw2 = Convert.ToDouble(dataGridView.Rows[i+1].Cells[2].Value);
                dgvData.Rows[i].Cells[5].Value = (c2 - c1) / (lnw2 - lnw1);
            }
            return true;
        }
    }
}