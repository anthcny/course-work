namespace CourseWork
{
    partial class TrafficAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbxAirplanes = new System.Windows.Forms.ComboBox();
            this.lblAirplane = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cbxFrom = new System.Windows.Forms.ComboBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbxTo = new System.Windows.Forms.ComboBox();
            this.cbxCargoes = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnAddToCargoList = new System.Windows.Forms.Button();
            this.labelListCargo = new System.Windows.Forms.Label();
            this.checkedListBoxCargoes = new System.Windows.Forms.CheckedListBox();
            this.btnDeleteCargoesFromList = new System.Windows.Forms.Button();
            this.btnAddNewTraffic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxAirplanes
            // 
            this.cbxAirplanes.FormattingEnabled = true;
            this.cbxAirplanes.Location = new System.Drawing.Point(38, 30);
            this.cbxAirplanes.Name = "cbxAirplanes";
            this.cbxAirplanes.Size = new System.Drawing.Size(283, 21);
            this.cbxAirplanes.TabIndex = 0;
            // 
            // lblAirplane
            // 
            this.lblAirplane.AutoSize = true;
            this.lblAirplane.Location = new System.Drawing.Point(35, 14);
            this.lblAirplane.Name = "lblAirplane";
            this.lblAirplane.Size = new System.Drawing.Size(51, 13);
            this.lblAirplane.TabIndex = 1;
            this.lblAirplane.Text = "Самолет";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(35, 76);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(43, 13);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Откуда";
            // 
            // cbxFrom
            // 
            this.cbxFrom.FormattingEnabled = true;
            this.cbxFrom.Location = new System.Drawing.Point(38, 92);
            this.cbxFrom.Name = "cbxFrom";
            this.cbxFrom.Size = new System.Drawing.Size(121, 21);
            this.cbxFrom.TabIndex = 3;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(197, 76);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(31, 13);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "Куда";
            // 
            // cbxTo
            // 
            this.cbxTo.FormattingEnabled = true;
            this.cbxTo.Location = new System.Drawing.Point(200, 92);
            this.cbxTo.Name = "cbxTo";
            this.cbxTo.Size = new System.Drawing.Size(121, 21);
            this.cbxTo.TabIndex = 5;
            // 
            // cbxCargoes
            // 
            this.cbxCargoes.FormattingEnabled = true;
            this.cbxCargoes.Location = new System.Drawing.Point(38, 157);
            this.cbxCargoes.Name = "cbxCargoes";
            this.cbxCargoes.Size = new System.Drawing.Size(283, 21);
            this.cbxCargoes.TabIndex = 6;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(35, 141);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(30, 13);
            this.lblCargo.TabIndex = 7;
            this.lblCargo.Text = "Груз";
            // 
            // btnAddToCargoList
            // 
            this.btnAddToCargoList.Location = new System.Drawing.Point(38, 184);
            this.btnAddToCargoList.Name = "btnAddToCargoList";
            this.btnAddToCargoList.Size = new System.Drawing.Size(283, 23);
            this.btnAddToCargoList.TabIndex = 8;
            this.btnAddToCargoList.Text = "Добавить груз";
            this.btnAddToCargoList.UseVisualStyleBackColor = true;
            this.btnAddToCargoList.Click += new System.EventHandler(this.btnAddToCargoList_Click);
            // 
            // labelListCargo
            // 
            this.labelListCargo.AutoSize = true;
            this.labelListCargo.Location = new System.Drawing.Point(35, 222);
            this.labelListCargo.Name = "labelListCargo";
            this.labelListCargo.Size = new System.Drawing.Size(151, 13);
            this.labelListCargo.TabIndex = 10;
            this.labelListCargo.Text = "Список добавленных грузов";
            // 
            // checkedListBoxCargoes
            // 
            this.checkedListBoxCargoes.FormattingEnabled = true;
            this.checkedListBoxCargoes.Location = new System.Drawing.Point(38, 238);
            this.checkedListBoxCargoes.Name = "checkedListBoxCargoes";
            this.checkedListBoxCargoes.Size = new System.Drawing.Size(283, 94);
            this.checkedListBoxCargoes.TabIndex = 11;
            // 
            // btnDeleteCargoesFromList
            // 
            this.btnDeleteCargoesFromList.Location = new System.Drawing.Point(38, 338);
            this.btnDeleteCargoesFromList.Name = "btnDeleteCargoesFromList";
            this.btnDeleteCargoesFromList.Size = new System.Drawing.Size(283, 23);
            this.btnDeleteCargoesFromList.TabIndex = 12;
            this.btnDeleteCargoesFromList.Text = "Удалить выбранные грузы из списка";
            this.btnDeleteCargoesFromList.UseVisualStyleBackColor = true;
            this.btnDeleteCargoesFromList.Click += new System.EventHandler(this.btnDeleteCargoesFromList_Click);
            // 
            // btnAddNewTraffic
            // 
            this.btnAddNewTraffic.Location = new System.Drawing.Point(38, 385);
            this.btnAddNewTraffic.Name = "btnAddNewTraffic";
            this.btnAddNewTraffic.Size = new System.Drawing.Size(283, 51);
            this.btnAddNewTraffic.TabIndex = 13;
            this.btnAddNewTraffic.Text = "ОК";
            this.btnAddNewTraffic.UseVisualStyleBackColor = true;
            this.btnAddNewTraffic.Click += new System.EventHandler(this.btnAddNewTraffic_Click);
            // 
            // TrafficAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 465);
            this.Controls.Add(this.btnAddNewTraffic);
            this.Controls.Add(this.btnDeleteCargoesFromList);
            this.Controls.Add(this.checkedListBoxCargoes);
            this.Controls.Add(this.labelListCargo);
            this.Controls.Add(this.btnAddToCargoList);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.cbxCargoes);
            this.Controls.Add(this.cbxTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.cbxFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblAirplane);
            this.Controls.Add(this.cbxAirplanes);
            this.Name = "TrafficAddForm";
            this.Text = "TrafficAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAirplanes;
        private System.Windows.Forms.Label lblAirplane;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cbxFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.ComboBox cbxTo;
        private System.Windows.Forms.ComboBox cbxCargoes;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Button btnAddToCargoList;
        private System.Windows.Forms.Label labelListCargo;
        private System.Windows.Forms.CheckedListBox checkedListBoxCargoes;
        private System.Windows.Forms.Button btnDeleteCargoesFromList;
        private System.Windows.Forms.Button btnAddNewTraffic;
    }
}