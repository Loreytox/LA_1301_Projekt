using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Nutzwertanalyse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            values.AllowUserToAddRows = false;
            values.RowHeadersVisible = false;
        }

        private List<Kriterien> kriterien = new List<Kriterien>();
        private List <Objekte> objekte = new List<Objekte>();
        private void addKriterium_Click(object sender, EventArgs e)
        {
            Kriterien _kriterien = new Kriterien(textBoxKriterium.Text, Convert.ToInt32(textBoxGewichtung.Text));
            kriterien.Add(_kriterien);
            textBoxGewichtung.Clear();
            textBoxKriterium.Clear();
            boxKriterien.Text += $"{_kriterien.Name} ({_kriterien.Gewichtung}), ";
        }
        private void buttonAddObject_Click(object sender, EventArgs e)
        {
            Objekte _objekte = new Objekte(textBoxObject.Text);
            objekte.Add(_objekte);
            textBoxObject.Clear();
            boxObjects.Text += $"{_objekte.Name}, ";
        }
        private void buttonStartAnalysis_Click(object sender, EventArgs e)
        {
            AddKriterienToDataGridView();
            AddObjectsToDataGridView();
            setProgramWidth();
            panelConfiguration.Hide();
        }
        private void AddKriterienToDataGridView()
        {
            foreach(Kriterien kriterium in kriterien)
            {
                values.Rows.Add(kriterium.Name);
                values.Rows[values.Rows.Count - 1].Cells[0].ReadOnly = true;
                values.Rows[values.RowCount - 1].Cells[1].Value = kriterium.Gewichtung;
                values.Rows[values.RowCount - 1].Cells[1].ReadOnly = true;
            }
        }
        private void AddObjectsToDataGridView()
        {
            foreach(Objekte objekt in objekte)
            {
                values.Columns.Add("object" + values.Columns.Count, objekt.Name);
            }
        }
        private void setProgramWidth()
        {
            values.Width = ((values.ColumnCount - 2) * 100) + 280;
            this.Width = ((values.ColumnCount - 2) * 100) + 280;
            background.Width = values.Width;
        }

        private void buttonRetreiveValues_Click(object sender, EventArgs e)
        {
            GridViewCalculation calculate = new GridViewCalculation();
            if(calculate.CalculatePoints(values))
            {
                if (calculate.ArePointsVisible) { values.Rows.Remove(values.Rows[values.RowCount - 1]); }
                values.Rows.Add("Punktzahl");
                for (int i = 0; i < calculate.Punkte.Count; i++)
                {
                    values.Rows[values.RowCount - 1].Cells[i + 2].Value = calculate.Punkte[i];
                    values.Rows[values.RowCount - 1].ReadOnly = true;
                }
            }
            else if(calculate.ArePointsVisible)
            {
                values.Rows.Remove(values.Rows[values.RowCount - 1]);
            }
        }
    }
}
