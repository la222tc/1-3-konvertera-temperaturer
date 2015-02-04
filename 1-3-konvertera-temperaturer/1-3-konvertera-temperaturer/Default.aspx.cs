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
                TableRow tRow = new TableRow();
                TableHeaderCell tHeaderCell = new TableHeaderCell();
                TableHeaderCell tHeaderCell2 = new TableHeaderCell();
                TableCell tcell = new TableCell();

                int startTemp = int.Parse(StartTempTextBox.Text);
                int endTemp = int.Parse(EndTempTextBox.Text);
                int temperaturStep = int.Parse(TemperaturstegTextBox.Text);

                if (CelsiusToFahrnheit.Checked)
                {
                    TemperatureTable.Rows.Add(tRow);
                    tHeaderCell.Text = "°C";
                    tHeaderCell2.Text = "°F";
                    tRow.Cells.Add(tHeaderCell);
                    tRow.Cells.Add(tHeaderCell2);

                    for (int i = startTemp; i <= endTemp; i += temperaturStep)
                    {
                        tRow = new TableRow();
                        TemperatureTable.Rows.Add(tRow);

                        tcell = new TableCell();
                        tRow.Cells.Add(tcell);
                        tcell.Text = i.ToString();

                        tcell = new TableCell();
                        tRow.Cells.Add(tcell);
                        tcell.Text = TemperatureConverter.CelsiusToFahrenheit(i).ToString();

                    }

                    TemperatureTable.Visible = true;
                }

                else
                {
                    TemperatureTable.Rows.Add(tRow);
                    tHeaderCell.Text = "°F";
                    tHeaderCell2.Text = "°C";
                    tRow.Cells.Add(tHeaderCell);
                    tRow.Cells.Add(tHeaderCell2);

                    for (int i = startTemp; i <= endTemp; i += temperaturStep)
                    {
                        tRow = new TableRow();
                        TemperatureTable.Rows.Add(tRow);

                        tcell = new TableCell();
                        tRow.Cells.Add(tcell);
                        tcell.Text = i.ToString();

                        tcell = new TableCell();
                        tRow.Cells.Add(tcell);
                        tcell.Text = TemperatureConverter.FahrenheitToCelsius(i).ToString();

                    }

                    TemperatureTable.Visible = true;
                }
            }
        }
    }
}