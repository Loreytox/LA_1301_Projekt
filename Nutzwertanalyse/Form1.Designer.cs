namespace Nutzwertanalyse
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRetreiveValues = new System.Windows.Forms.Button();
            this.labelGewichtung = new System.Windows.Forms.Label();
            this.Gewichtung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kriterium1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxGewichtung = new System.Windows.Forms.TextBox();
            this.textBoxKriterium = new System.Windows.Forms.TextBox();
            this.background = new System.Windows.Forms.PictureBox();
            this.boxObjects = new System.Windows.Forms.RichTextBox();
            this.boxKriterien = new System.Windows.Forms.RichTextBox();
            this.buttonAddObject = new System.Windows.Forms.Button();
            this.textBoxObject = new System.Windows.Forms.TextBox();
            this.labelObjects = new System.Windows.Forms.Label();
            this.buttonStartAnalysis = new System.Windows.Forms.Button();
            this.addKriterium = new System.Windows.Forms.Button();
            this.labelkriterium = new System.Windows.Forms.Label();
            this.panelConfiguration = new System.Windows.Forms.Panel();
            this.values = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.panelConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.values)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRetreiveValues
            // 
            this.buttonRetreiveValues.Location = new System.Drawing.Point(22, 278);
            this.buttonRetreiveValues.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRetreiveValues.Name = "buttonRetreiveValues";
            this.buttonRetreiveValues.Size = new System.Drawing.Size(194, 66);
            this.buttonRetreiveValues.TabIndex = 10;
            this.buttonRetreiveValues.Text = "Auswerten!";
            this.buttonRetreiveValues.UseVisualStyleBackColor = true;
            this.buttonRetreiveValues.Click += new System.EventHandler(this.buttonRetreiveValues_Click);
            // 
            // labelGewichtung
            // 
            this.labelGewichtung.AutoSize = true;
            this.labelGewichtung.Location = new System.Drawing.Point(31, 72);
            this.labelGewichtung.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGewichtung.Name = "labelGewichtung";
            this.labelGewichtung.Size = new System.Drawing.Size(64, 13);
            this.labelGewichtung.TabIndex = 12;
            this.labelGewichtung.Text = "Gewichtung";
            // 
            // Gewichtung
            // 
            this.Gewichtung.HeaderText = "Gewichtung";
            this.Gewichtung.MinimumWidth = 6;
            this.Gewichtung.Name = "Gewichtung";
            this.Gewichtung.Width = 125;
            // 
            // Kriterium1
            // 
            this.Kriterium1.HeaderText = "Kriterium";
            this.Kriterium1.MinimumWidth = 6;
            this.Kriterium1.Name = "Kriterium1";
            this.Kriterium1.Width = 150;
            // 
            // textBoxGewichtung
            // 
            this.textBoxGewichtung.Location = new System.Drawing.Point(103, 72);
            this.textBoxGewichtung.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxGewichtung.Name = "textBoxGewichtung";
            this.textBoxGewichtung.Size = new System.Drawing.Size(76, 20);
            this.textBoxGewichtung.TabIndex = 11;
            // 
            // textBoxKriterium
            // 
            this.textBoxKriterium.Location = new System.Drawing.Point(28, 49);
            this.textBoxKriterium.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxKriterium.Name = "textBoxKriterium";
            this.textBoxKriterium.Size = new System.Drawing.Size(150, 20);
            this.textBoxKriterium.TabIndex = 3;
            // 
            // background
            // 
            this.background.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.background.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(602, 63);
            this.background.TabIndex = 6;
            this.background.TabStop = false;
            // 
            // boxObjects
            // 
            this.boxObjects.Location = new System.Drawing.Point(309, 121);
            this.boxObjects.Margin = new System.Windows.Forms.Padding(2);
            this.boxObjects.Name = "boxObjects";
            this.boxObjects.Size = new System.Drawing.Size(271, 48);
            this.boxObjects.TabIndex = 10;
            this.boxObjects.Text = "";
            // 
            // boxKriterien
            // 
            this.boxKriterien.Location = new System.Drawing.Point(309, 18);
            this.boxKriterien.Margin = new System.Windows.Forms.Padding(2);
            this.boxKriterien.Name = "boxKriterien";
            this.boxKriterien.Size = new System.Drawing.Size(271, 72);
            this.boxKriterien.TabIndex = 10;
            this.boxKriterien.Text = "";
            // 
            // buttonAddObject
            // 
            this.buttonAddObject.Location = new System.Drawing.Point(202, 150);
            this.buttonAddObject.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAddObject.Name = "buttonAddObject";
            this.buttonAddObject.Size = new System.Drawing.Size(91, 19);
            this.buttonAddObject.TabIndex = 9;
            this.buttonAddObject.Text = "Hinzufügen";
            this.buttonAddObject.UseVisualStyleBackColor = true;
            this.buttonAddObject.Click += new System.EventHandler(this.buttonAddObject_Click);
            // 
            // textBoxObject
            // 
            this.textBoxObject.Location = new System.Drawing.Point(28, 150);
            this.textBoxObject.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxObject.Name = "textBoxObject";
            this.textBoxObject.Size = new System.Drawing.Size(150, 20);
            this.textBoxObject.TabIndex = 8;
            // 
            // labelObjects
            // 
            this.labelObjects.AutoSize = true;
            this.labelObjects.Location = new System.Drawing.Point(28, 121);
            this.labelObjects.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelObjects.Name = "labelObjects";
            this.labelObjects.Size = new System.Drawing.Size(99, 13);
            this.labelObjects.TabIndex = 7;
            this.labelObjects.Text = "Objekte hinzufügen";
            // 
            // buttonStartAnalysis
            // 
            this.buttonStartAnalysis.Location = new System.Drawing.Point(202, 231);
            this.buttonStartAnalysis.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartAnalysis.Name = "buttonStartAnalysis";
            this.buttonStartAnalysis.Size = new System.Drawing.Size(171, 54);
            this.buttonStartAnalysis.TabIndex = 6;
            this.buttonStartAnalysis.Text = "Nutzwertanalyse starten";
            this.buttonStartAnalysis.UseVisualStyleBackColor = true;
            this.buttonStartAnalysis.Click += new System.EventHandler(this.buttonStartAnalysis_Click);
            // 
            // addKriterium
            // 
            this.addKriterium.Location = new System.Drawing.Point(202, 48);
            this.addKriterium.Margin = new System.Windows.Forms.Padding(2);
            this.addKriterium.Name = "addKriterium";
            this.addKriterium.Size = new System.Drawing.Size(91, 41);
            this.addKriterium.TabIndex = 5;
            this.addKriterium.Text = "Hinzufügen";
            this.addKriterium.UseVisualStyleBackColor = true;
            this.addKriterium.Click += new System.EventHandler(this.addKriterium_Click);
            // 
            // labelkriterium
            // 
            this.labelkriterium.AutoSize = true;
            this.labelkriterium.Location = new System.Drawing.Point(26, 18);
            this.labelkriterium.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelkriterium.Name = "labelkriterium";
            this.labelkriterium.Size = new System.Drawing.Size(103, 13);
            this.labelkriterium.TabIndex = 4;
            this.labelkriterium.Text = "Kriterien hinzufügen:";
            // 
            // panelConfiguration
            // 
            this.panelConfiguration.Controls.Add(this.labelGewichtung);
            this.panelConfiguration.Controls.Add(this.textBoxGewichtung);
            this.panelConfiguration.Controls.Add(this.boxObjects);
            this.panelConfiguration.Controls.Add(this.boxKriterien);
            this.panelConfiguration.Controls.Add(this.buttonAddObject);
            this.panelConfiguration.Controls.Add(this.textBoxObject);
            this.panelConfiguration.Controls.Add(this.labelObjects);
            this.panelConfiguration.Controls.Add(this.buttonStartAnalysis);
            this.panelConfiguration.Controls.Add(this.addKriterium);
            this.panelConfiguration.Controls.Add(this.labelkriterium);
            this.panelConfiguration.Controls.Add(this.textBoxKriterium);
            this.panelConfiguration.Location = new System.Drawing.Point(1, 59);
            this.panelConfiguration.Margin = new System.Windows.Forms.Padding(2);
            this.panelConfiguration.Name = "panelConfiguration";
            this.panelConfiguration.Size = new System.Drawing.Size(600, 308);
            this.panelConfiguration.TabIndex = 9;
            // 
            // values
            // 
            this.values.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.values.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kriterium1,
            this.Gewichtung});
            this.values.Location = new System.Drawing.Point(0, 59);
            this.values.Margin = new System.Windows.Forms.Padding(2);
            this.values.Name = "values";
            this.values.RowHeadersWidth = 51;
            this.values.RowTemplate.Height = 24;
            this.values.Size = new System.Drawing.Size(601, 186);
            this.values.TabIndex = 8;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(262, 25);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(85, 13);
            this.labelTitle.TabIndex = 11;
            this.labelTitle.Text = "Nutzwertanalyse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 367);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelConfiguration);
            this.Controls.Add(this.buttonRetreiveValues);
            this.Controls.Add(this.background);
            this.Controls.Add(this.values);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.panelConfiguration.ResumeLayout(false);
            this.panelConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.values)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRetreiveValues;
        private System.Windows.Forms.Label labelGewichtung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gewichtung;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kriterium1;
        private System.Windows.Forms.TextBox textBoxGewichtung;
        private System.Windows.Forms.TextBox textBoxKriterium;
        private System.Windows.Forms.PictureBox background;
        private System.Windows.Forms.RichTextBox boxObjects;
        private System.Windows.Forms.RichTextBox boxKriterien;
        private System.Windows.Forms.Button buttonAddObject;
        private System.Windows.Forms.TextBox textBoxObject;
        private System.Windows.Forms.Label labelObjects;
        private System.Windows.Forms.Button buttonStartAnalysis;
        private System.Windows.Forms.Button addKriterium;
        private System.Windows.Forms.Label labelkriterium;
        private System.Windows.Forms.Panel panelConfiguration;
        private System.Windows.Forms.DataGridView values;
        private System.Windows.Forms.Label labelTitle;
    }
}

