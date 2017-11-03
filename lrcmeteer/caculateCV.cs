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
        private bool caculateCV(DataTable datatable, DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No data to caculate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if(txtCVArea.Text==""|| txtCVPermittivity.Text == "")
            {
                MessageBox.Show("Program cannot perform caculation, since Area or Permittivity was not entered. To perform caculation again, please check Area and Permittivity, and click the Caculate button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!(datatable.Columns.Contains("w(μm)") || datatable.Columns.Contains("NA(cm-3)")))
            {
                datatable.Columns.Add("w(μm)", typeof(System.Double));
                datatable.Columns.Add("NA(cm-3)", typeof(System.Double));
            }
            int lenRow = datatable.Rows.Count;
            double epsilonS = Convert.ToDouble(txtCVPermittivity.Text);
            double epsilon0 = 8.854E-12;
            double area_m2 = Convert.ToDouble(txtCVArea.Text)/10000;
            double q = 1.6E-19;
            for (i=0;i<lenRow;i++)
            {
                dgvData.Rows[i].Cells[2].Value = epsilon0 * epsilonS * area_m2 / Convert.ToDouble(dataGridView.Rows[0].Cells[1].Value) * 1E06;
            }
            for (i=1;i<lenRow;i++)
            {
                double c1 = Convert.ToDouble(dataGridView.Rows[i-1].Cells[1].Value);
                double c2 = Convert.ToDouble(dataGridView.Rows[i].Cells[1].Value);
                double v1 = Convert.ToDouble(dataGridView.Rows[i - 1].Cells[0].Value);
                double v2 = Convert.ToDouble(dataGridView.Rows[i].Cells[0].Value); 
                dgvData.Rows[i].Cells[3].Value = ((v2 - v1) / (1 / (c2 * c2) - 1 / (c1 * c1))) * -2 / epsilon0 / epsilonS / area_m2 / area_m2 / q*10E-6;

            }
            return true;
        }
    }
}