using _1_3_konvertera_temperaturer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_3_konvertera_temperaturer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConvertButton_Click(object sender, EventArgs e)
        {
            if (IsValid)
            {
                int startTemp = int.Parse(StartTempTextBox.Text);
                int endTemp = int.Parse(EndTempTextBox.Text);
                int temperaturStep = int.Parse(TemperaturstegTextBox.Text);

                if (!CelsiusToFahrnheit.Checked)
                {
                    FirstTableHeaderCell.Text = "°F";
                    SecondTableHeaderCell.Text = "°C";
                }

                for (int i = startTemp; i <= endTemp; i += temperaturStep)
                {
                    var tRow = new TableRow();
                    TemperatureTable.Rows.Add(tRow);

                    var tcell = new TableCell();
                    tRow.Cells.Add(tcell);
                    tcell.Text = i.ToString();

                    tcell = new TableCell();
                    tRow.Cells.Add(tcell);
                    tcell.Text = CelsiusToFahrnheit.Checked ? TemperatureConverter.CelsiusToFahrenheit(i).ToString() :
                        TemperatureConverter.FahrenheitToCelsius(i).ToString();
                }

                TemperatureTable.Visible = true;
            }
        }
    }
}