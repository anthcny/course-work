namespace CourseWork.Views
{
    partial class AppView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlAirplanes = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridAirports = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridAirplanes = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNameAir = new System.Windows.Forms.Label();
            this.labelinfo = new System.Windows.Forms.Label();
            this.btnChangeAirplane = new System.Windows.Forms.Button();
            this.btnDeleteAirplane = new System.Windows.Forms.Button();
            this.textBoxNameAir = new System.Windows.Forms.TextBox();
            this.btnAddAirplane = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCarrying = new System.Windows.Forms.TextBox();
            this.textBoxMaxDistance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlAirplanes.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAirports)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAirplanes)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginName
            // 
            this.loginName.AutoSize = true;
            this.loginName.Location = new System.Drawing.Point(3, 9);
            this.loginName.Name = "loginName";
            this.loginName.Size = new System.Drawing.Size(0, 13);
            this.loginName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.loginName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 31);
            this.panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogout.Location = new System.Drawing.Point(635, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Выход";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.tabControlAirplanes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 473);
            this.panel2.TabIndex = 2;
            // 
            // tabControlAirplanes
            // 
            this.tabControlAirplanes.Controls.Add(this.tabPage1);
            this.tabControlAirplanes.Controls.Add(this.tabPage2);
            this.tabControlAirplanes.Controls.Add(this.tabPage3);
            this.tabControlAirplanes.Controls.Add(this.tabPage4);
            this.tabControlAirplanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAirplanes.Location = new System.Drawing.Point(0, 0);
            this.tabControlAirplanes.Name = "tabControlAirplanes";
            this.tabControlAirplanes.SelectedIndex = 0;
            this.tabControlAirplanes.Size = new System.Drawing.Size(713, 473);
            this.tabControlAirplanes.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(705, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Перевозки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridAirports);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(705, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Аэропорты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridAirports
            // 
            this.dataGridAirports.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAirports.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridAirports.Location = new System.Drawing.Point(3, 3);
            this.dataGridAirports.Name = "dataGridAirports";
            this.dataGridAirports.Size = new System.Drawing.Size(359, 441);
            this.dataGridAirports.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(705, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Самолеты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridAirplanes);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 447);
            this.panel4.TabIndex = 12;
            // 
            // dataGridAirplanes
            // 
            this.dataGridAirplanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridAirplanes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridAirplanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAirplanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAirplanes.Location = new System.Drawing.Point(0, 0);
            this.dataGridAirplanes.Name = "dataGridAirplanes";
            this.dataGridAirplanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAirplanes.Size = new System.Drawing.Size(505, 447);
            this.dataGridAirplanes.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelNameAir);
            this.panel3.Controls.Add(this.labelinfo);
            this.panel3.Controls.Add(this.btnChangeAirplane);
            this.panel3.Controls.Add(this.btnDeleteAirplane);
            this.panel3.Controls.Add(this.textBoxNameAir);
            this.panel3.Controls.Add(this.btnAddAirplane);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBoxCarrying);
            this.panel3.Controls.Add(this.textBoxMaxDistance);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(505, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 447);
            this.panel3.TabIndex = 11;
            // 
            // labelNameAir
            // 
            this.labelNameAir.AutoSize = true;
            this.labelNameAir.Location = new System.Drawing.Point(29, 16);
            this.labelNameAir.Name = "labelNameAir";
            this.labelNameAir.Size = new System.Drawing.Size(35, 13);
            this.labelNameAir.TabIndex = 3;
            this.labelNameAir.Text = "Name";
            // 
            // labelinfo
            // 
            this.labelinfo.AutoSize = true;
            this.labelinfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelinfo.Location = new System.Drawing.Point(29, 344);
            this.labelinfo.Name = "labelinfo";
            this.labelinfo.Size = new System.Drawing.Size(0, 13);
            this.labelinfo.TabIndex = 10;
            // 
            // btnChangeAirplane
            // 
            this.btnChangeAirplane.Location = new System.Drawing.Point(32, 227);
            this.btnChangeAirplane.Name = "btnChangeAirplane";
            this.btnChangeAirplane.Size = new System.Drawing.Size(100, 53);
            this.btnChangeAirplane.TabIndex = 1;
            this.btnChangeAirplane.Text = "Изменить";
            this.btnChangeAirplane.UseVisualStyleBackColor = true;
            this.btnChangeAirplane.Click += new System.EventHandler(this.btnChangeAirplane_Click);
            // 
            // btnDeleteAirplane
            // 
            this.btnDeleteAirplane.Location = new System.Drawing.Point(32, 286);
            this.btnDeleteAirplane.Name = "btnDeleteAirplane";
            this.btnDeleteAirplane.Size = new System.Drawing.Size(100, 55);
            this.btnDeleteAirplane.TabIndex = 9;
            this.btnDeleteAirplane.Text = "Удалить";
            this.btnDeleteAirplane.UseVisualStyleBackColor = true;
            this.btnDeleteAirplane.Click += new System.EventHandler(this.btnDeleteAirplane_Click);
            // 
            // textBoxNameAir
            // 
            this.textBoxNameAir.Location = new System.Drawing.Point(32, 32);
            this.textBoxNameAir.Name = "textBoxNameAir";
            this.textBoxNameAir.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameAir.TabIndex = 2;
            // 
            // btnAddAirplane
            // 
            this.btnAddAirplane.Location = new System.Drawing.Point(32, 168);
            this.btnAddAirplane.Name = "btnAddAirplane";
            this.btnAddAirplane.Size = new System.Drawing.Size(100, 53);
            this.btnAddAirplane.TabIndex = 8;
            this.btnAddAirplane.Text = "Добавить";
            this.btnAddAirplane.UseVisualStyleBackColor = true;
            this.btnAddAirplane.Click += new System.EventHandler(this.btnAddAirplane_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Max. Distance";
            // 
            // textBoxCarrying
            // 
            this.textBoxCarrying.Location = new System.Drawing.Point(32, 130);
            this.textBoxCarrying.Name = "textBoxCarrying";
            this.textBoxCarrying.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarrying.TabIndex = 7;
            // 
            // textBoxMaxDistance
            // 
            this.textBoxMaxDistance.Location = new System.Drawing.Point(32, 82);
            this.textBoxMaxDistance.Name = "textBoxMaxDistance";
            this.textBoxMaxDistance.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaxDistance.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Carrying";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(705, 447);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Грузы";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // AppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AppView";
            this.Size = new System.Drawing.Size(713, 504);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControlAirplanes.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAirports)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAirplanes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loginName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControlAirplanes;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridAirplanes;
        private System.Windows.Forms.Button btnChangeAirplane;
        private System.Windows.Forms.TextBox textBoxCarrying;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMaxDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNameAir;
        private System.Windows.Forms.TextBox textBoxNameAir;
        private System.Windows.Forms.Button btnAddAirplane;
        private System.Windows.Forms.Button btnDeleteAirplane;
        private System.Windows.Forms.Label labelinfo;
        private System.Windows.Forms.DataGridView dataGridAirports;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}
