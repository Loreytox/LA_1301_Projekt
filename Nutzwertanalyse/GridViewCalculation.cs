using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nutzwertanalyse
{
    internal class GridViewCalculation
    {
        public bool ArePointsVisible { get { return _arePointsVisible; } }
        public List<int> Punkte { get { return _punktzahl; } }

        private List<int> _punktzahl = new List<int>();
        private bool _arePointsVisible = false;
        public bool CalculatePoints(DataGridView values)
        {
            CheckIfPunktzahlVisible(values);
            try
            {
                _punktzahl.Clear();
                for (int i = 2; i < values.ColumnCount; i++)
                {
                    int berechnetePunkte = 0;
                    for (int j = 0; j < values.Rows.Count; j++)
                    {
                        int userScore = Convert.ToInt32(values.Rows[j].Cells[i].Value);
                        int gewichtung = Convert.ToInt32(values.Rows[j].Cells[1].Value);

                        berechnetePunkte += (userScore * gewichtung);
                    }
                    _punktzahl.Add(berechnetePunkte);
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Ungültige Eingaben entdeckt", "Fehler");
                return false;
            }
        }
        public void CheckIfPunktzahlVisible(DataGridView values)
        {
            if (values.Rows[values.Rows.Count-1].Cells[0].Value == "Punktzahl") { _arePointsVisible = true; }
            else { _arePointsVisible = false; }
        }
    }
}
