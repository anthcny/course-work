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
            this.tabTraffic = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.trafficTree = new System.Windows.Forms.TreeView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnAddTraffic = new System.Windows.Forms.Button();
            this.tabAirports = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridAirports = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelAirportInfo = new System.Windows.Forms.Label();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.btnChangeAirport = new System.Windows.Forms.Button();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.textBoxCityAirport = new System.Windows.Forms.TextBox();
            this.labelCityAirport = new System.Windows.Forms.Label();
            this.tabAirplane = new System.Windows.Forms.TabPage();
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
            this.tabCargos = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridaCargos = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDeleteCargo = new System.Windows.Forms.Button();
            this.btnChangeCargo = new System.Windows.Forms.Button();
            this.btnAddCargo = new System.Windows.Forms.Button();
            this.labelCargoInfo = new System.Windows.Forms.Label();
            this.textBoxQuantityCargo = new System.Windows.Forms.TextBox();
            this.labelCuantityCargo = new System.Windows.Forms.Label();
            this.textBoxWeightCargo = new System.Windows.Forms.TextBox();
            this.labelWeightCargo = new System.Windows.Forms.Label();
            this.textBoxNameCargo = new System.Windows.Forms.TextBox();
            this.labelNameCargo = new System.Windows.Forms.Label();
            this.btnDeleteTraffic = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControlAirplanes.SuspendLayout();
            this.tabTraffic.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tabAirports.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAirports)).BeginInit();
            this.panel7.SuspendLayout();
            this.tabAirplane.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAirplanes)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabCargos.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridaCargos)).BeginInit();
            this.panel5.SuspendLayout();
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
            this.tabControlAirplanes.Controls.Add(this.tabTraffic);
            this.tabControlAirplanes.Controls.Add(this.tabAirports);
            this.tabControlAirplanes.Controls.Add(this.tabAirplane);
            this.tabControlAirplanes.Controls.Add(this.tabCargos);
            this.tabControlAirplanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAirplanes.Location = new System.Drawing.Point(0, 0);
            this.tabControlAirplanes.Name = "tabControlAirplanes";
            this.tabControlAirplanes.SelectedIndex = 0;
            this.tabControlAirplanes.Size = new System.Drawing.Size(713, 473);
            this.tabControlAirplanes.TabIndex = 0;
            // 
            // tabTraffic
            // 
            this.tabTraffic.Controls.Add(this.panel9);
            this.tabTraffic.Location = new System.Drawing.Point(4, 22);
            this.tabTraffic.Name = "tabTraffic";
            this.tabTraffic.Padding = new System.Windows.Forms.Padding(3);
            this.tabTraffic.Size = new System.Drawing.Size(705, 447);
            this.tabTraffic.TabIndex = 0;
            this.tabTraffic.Text = "Перевозки";
            this.tabTraffic.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(699, 441);
            this.panel9.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.trafficTree);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 28);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(699, 413);
            this.panel11.TabIndex = 1;
            // 
            // trafficTree
            // 
            this.trafficTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trafficTree.Location = new System.Drawing.Point(0, 0);
            this.trafficTree.Name = "trafficTree";
            this.trafficTree.Size = new System.Drawing.Size(699, 413);
            this.trafficTree.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnDeleteTraffic);
            this.panel10.Controls.Add(this.btnAddTraffic);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(699, 28);
            this.panel10.TabIndex = 0;
            // 
            // btnAddTraffic
            // 
            this.btnAddTraffic.Location = new System.Drawing.Point(3, 3);
            this.btnAddTraffic.Name = "btnAddTraffic";
            this.btnAddTraffic.Size = new System.Drawing.Size(153, 23);
            this.btnAddTraffic.TabIndex = 0;
            this.btnAddTraffic.Text = "Добавить";
            this.btnAddTraffic.UseVisualStyleBackColor = true;
            this.btnAddTraffic.Click += new System.EventHandler(this.btnAddTraffic_Click);
            // 
            // tabAirports
            // 
            this.tabAirports.Controls.Add(this.panel8);
            this.tabAirports.Controls.Add(this.panel7);
            this.tabAirports.Location = new System.Drawing.Point(4, 22);
            this.tabAirports.Name = "tabAirports";
            this.tabAirports.Padding = new System.Windows.Forms.Padding(3);
            this.tabAirports.Size = new System.Drawing.Size(705, 447);
            this.tabAirports.TabIndex = 1;
            this.tabAirports.Text = "Аэропорты";
            this.tabAirports.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dataGridAirports);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(480, 441);
            this.panel8.TabIndex = 1;
            // 
            // dataGridAirports
            // 
            this.dataGridAirports.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAirports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridAirports.Location = new System.Drawing.Point(0, 0);
            this.dataGridAirports.Name = "dataGridAirports";
            this.dataGridAirports.Size = new System.Drawing.Size(480, 441);
            this.dataGridAirports.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.labelAirportInfo);
            this.panel7.Controls.Add(this.btnDeleteAirport);
            this.panel7.Controls.Add(this.btnChangeAirport);
            this.panel7.Controls.Add(this.btnAddAirport);
            this.panel7.Controls.Add(this.textBoxCityAirport);
            this.panel7.Controls.Add(this.labelCityAirport);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(480, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(222, 441);
            this.panel7.TabIndex = 0;
            // 
            // labelAirportInfo
            // 
            this.labelAirportInfo.AutoSize = true;
            this.labelAirportInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAirportInfo.Location = new System.Drawing.Point(23, 267);
            this.labelAirportInfo.Name = "labelAirportInfo";
            this.labelAirportInfo.Size = new System.Drawing.Size(0, 13);
            this.labelAirportInfo.TabIndex = 5;
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.Location = new System.Drawing.Point(24, 205);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(118, 49);
            this.btnDeleteAirport.TabIndex = 4;
            this.btnDeleteAirport.Text = "Удалить";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // btnChangeAirport
            // 
            this.btnChangeAirport.Location = new System.Drawing.Point(24, 155);
            this.btnChangeAirport.Name = "btnChangeAirport";
            this.btnChangeAirport.Size = new System.Drawing.Size(118, 44);
            this.btnChangeAirport.TabIndex = 3;
            this.btnChangeAirport.Text = "Изменить";
            this.btnChangeAirport.UseVisualStyleBackColor = true;
            this.btnChangeAirport.Click += new System.EventHandler(this.btnChangeAirport_Click);
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.Location = new System.Drawing.Point(24, 103);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(118, 46);
            this.btnAddAirport.TabIndex = 2;
            this.btnAddAirport.Text = "Добавить";
            this.btnAddAirport.UseVisualStyleBackColor = true;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // textBoxCityAirport
            // 
            this.textBoxCityAirport.Location = new System.Drawing.Point(24, 34);
            this.textBoxCityAirport.Name = "textBoxCityAirport";
            this.textBoxCityAirport.Size = new System.Drawing.Size(100, 20);
            this.textBoxCityAirport.TabIndex = 1;
            // 
            // labelCityAirport
            // 
            this.labelCityAirport.AutoSize = true;
            this.labelCityAirport.Location = new System.Drawing.Point(21, 18);
            this.labelCityAirport.Name = "labelCityAirport";
            this.labelCityAirport.Size = new System.Drawing.Size(37, 13);
            this.labelCityAirport.TabIndex = 0;
            this.labelCityAirport.Text = "Город";
            // 
            // tabAirplane
            // 
            this.tabAirplane.Controls.Add(this.panel4);
            this.tabAirplane.Controls.Add(this.panel3);
            this.tabAirplane.Location = new System.Drawing.Point(4, 22);
            this.tabAirplane.Name = "tabAirplane";
            this.tabAirplane.Size = new System.Drawing.Size(705, 447);
            this.tabAirplane.TabIndex = 2;
            this.tabAirplane.Text = "Самолеты";
            this.tabAirplane.UseVisualStyleBackColor = true;
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
            this.dataGridAirplanes.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
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
            this.labelNameAir.Size = new System.Drawing.Size(57, 13);
            this.labelNameAir.TabIndex = 3;
            this.labelNameAir.Text = "Название";
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
            this.btnChangeAirplane.Size = new System.Drawing.Size(137, 53);
            this.btnChangeAirplane.TabIndex = 1;
            this.btnChangeAirplane.Text = "Изменить";
            this.btnChangeAirplane.UseVisualStyleBackColor = true;
            this.btnChangeAirplane.Click += new System.EventHandler(this.btnChangeAirplane_Click);
            // 
            // btnDeleteAirplane
            // 
            this.btnDeleteAirplane.Location = new System.Drawing.Point(32, 286);
            this.btnDeleteAirplane.Name = "btnDeleteAirplane";
            this.btnDeleteAirplane.Size = new System.Drawing.Size(137, 55);
            this.btnDeleteAirplane.TabIndex = 9;
            this.btnDeleteAirplane.Text = "Удалить";
            this.btnDeleteAirplane.UseVisualStyleBackColor = true;
            this.btnDeleteAirplane.Click += new System.EventHandler(this.btnDeleteAirplane_Click);
            // 
            // textBoxNameAir
            // 
            this.textBoxNameAir.Location = new System.Drawing.Point(32, 32);
            this.textBoxNameAir.Name = "textBoxNameAir";
            this.textBoxNameAir.Size = new System.Drawing.Size(137, 20);
            this.textBoxNameAir.TabIndex = 2;
            // 
            // btnAddAirplane
            // 
            this.btnAddAirplane.Location = new System.Drawing.Point(32, 168);
            this.btnAddAirplane.Name = "btnAddAirplane";
            this.btnAddAirplane.Size = new System.Drawing.Size(137, 53);
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
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Максимальная дальность, км";
            // 
            // textBoxCarrying
            // 
            this.textBoxCarrying.Location = new System.Drawing.Point(32, 130);
            this.textBoxCarrying.Name = "textBoxCarrying";
            this.textBoxCarrying.Size = new System.Drawing.Size(137, 20);
            this.textBoxCarrying.TabIndex = 7;
            this.textBoxCarrying.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCarrying_KeyPress);
            // 
            // textBoxMaxDistance
            // 
            this.textBoxMaxDistance.Location = new System.Drawing.Point(32, 82);
            this.textBoxMaxDistance.Name = "textBoxMaxDistance";
            this.textBoxMaxDistance.Size = new System.Drawing.Size(137, 20);
            this.textBoxMaxDistance.TabIndex = 5;
            this.textBoxMaxDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMaxDistance_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Грузоподъемность, кг";
            // 
            // tabCargos
            // 
            this.tabCargos.Controls.Add(this.panel6);
            this.tabCargos.Controls.Add(this.panel5);
            this.tabCargos.Location = new System.Drawing.Point(4, 22);
            this.tabCargos.Name = "tabCargos";
            this.tabCargos.Size = new System.Drawing.Size(705, 447);
            this.tabCargos.TabIndex = 3;
            this.tabCargos.Text = "Грузы";
            this.tabCargos.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridaCargos);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(504, 447);
            this.panel6.TabIndex = 1;
            // 
            // dataGridaCargos
            // 
            this.dataGridaCargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridaCargos.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridaCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridaCargos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridaCargos.Location = new System.Drawing.Point(0, 0);
            this.dataGridaCargos.Name = "dataGridaCargos";
            this.dataGridaCargos.Size = new System.Drawing.Size(504, 447);
            this.dataGridaCargos.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDeleteCargo);
            this.panel5.Controls.Add(this.btnChangeCargo);
            this.panel5.Controls.Add(this.btnAddCargo);
            this.panel5.Controls.Add(this.labelCargoInfo);
            this.panel5.Controls.Add(this.textBoxQuantityCargo);
            this.panel5.Controls.Add(this.labelCuantityCargo);
            this.panel5.Controls.Add(this.textBoxWeightCargo);
            this.panel5.Controls.Add(this.labelWeightCargo);
            this.panel5.Controls.Add(this.textBoxNameCargo);
            this.panel5.Controls.Add(this.labelNameCargo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(499, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(206, 447);
            this.panel5.TabIndex = 0;
            // 
            // btnDeleteCargo
            // 
            this.btnDeleteCargo.Location = new System.Drawing.Point(14, 293);
            this.btnDeleteCargo.Name = "btnDeleteCargo";
            this.btnDeleteCargo.Size = new System.Drawing.Size(144, 45);
            this.btnDeleteCargo.TabIndex = 9;
            this.btnDeleteCargo.Text = "Удалить";
            this.btnDeleteCargo.UseVisualStyleBackColor = true;
            this.btnDeleteCargo.Click += new System.EventHandler(this.btnDeleteCargo_Click);
            // 
            // btnChangeCargo
            // 
            this.btnChangeCargo.Location = new System.Drawing.Point(14, 241);
            this.btnChangeCargo.Name = "btnChangeCargo";
            this.btnChangeCargo.Size = new System.Drawing.Size(144, 46);
            this.btnChangeCargo.TabIndex = 8;
            this.btnChangeCargo.Text = "Изменить";
            this.btnChangeCargo.UseVisualStyleBackColor = true;
            this.btnChangeCargo.Click += new System.EventHandler(this.btnChangeCargo_Click);
            // 
            // btnAddCargo
            // 
            this.btnAddCargo.Location = new System.Drawing.Point(14, 186);
            this.btnAddCargo.Name = "btnAddCargo";
            this.btnAddCargo.Size = new System.Drawing.Size(144, 49);
            this.btnAddCargo.TabIndex = 7;
            this.btnAddCargo.Text = "Добавить";
            this.btnAddCargo.UseVisualStyleBackColor = true;
            this.btnAddCargo.Click += new System.EventHandler(this.btnAddCargo_Click);
            // 
            // labelCargoInfo
            // 
            this.labelCargoInfo.AutoSize = true;
            this.labelCargoInfo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCargoInfo.Location = new System.Drawing.Point(11, 345);
            this.labelCargoInfo.Name = "labelCargoInfo";
            this.labelCargoInfo.Size = new System.Drawing.Size(0, 13);
            this.labelCargoInfo.TabIndex = 6;
            // 
            // textBoxQuantityCargo
            // 
            this.textBoxQuantityCargo.Location = new System.Drawing.Point(14, 144);
            this.textBoxQuantityCargo.Name = "textBoxQuantityCargo";
            this.textBoxQuantityCargo.Size = new System.Drawing.Size(144, 20);
            this.textBoxQuantityCargo.TabIndex = 5;
            this.textBoxQuantityCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantityCargo_KeyPress);
            // 
            // labelCuantityCargo
            // 
            this.labelCuantityCargo.AutoSize = true;
            this.labelCuantityCargo.Location = new System.Drawing.Point(11, 128);
            this.labelCuantityCargo.Name = "labelCuantityCargo";
            this.labelCuantityCargo.Size = new System.Drawing.Size(136, 13);
            this.labelCuantityCargo.TabIndex = 4;
            this.labelCuantityCargo.Text = "Количество единиц груза";
            // 
            // textBoxWeightCargo
            // 
            this.textBoxWeightCargo.Location = new System.Drawing.Point(14, 86);
            this.textBoxWeightCargo.Name = "textBoxWeightCargo";
            this.textBoxWeightCargo.Size = new System.Drawing.Size(144, 20);
            this.textBoxWeightCargo.TabIndex = 3;
            this.textBoxWeightCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWeightCargo_KeyPress);
            // 
            // labelWeightCargo
            // 
            this.labelWeightCargo.AutoSize = true;
            this.labelWeightCargo.Location = new System.Drawing.Point(11, 70);
            this.labelWeightCargo.Name = "labelWeightCargo";
            this.labelWeightCargo.Size = new System.Drawing.Size(96, 13);
            this.labelWeightCargo.TabIndex = 2;
            this.labelWeightCargo.Text = "Вес единицы в кг";
            // 
            // textBoxNameCargo
            // 
            this.textBoxNameCargo.Location = new System.Drawing.Point(14, 28);
            this.textBoxNameCargo.Name = "textBoxNameCargo";
            this.textBoxNameCargo.Size = new System.Drawing.Size(144, 20);
            this.textBoxNameCargo.TabIndex = 1;
            // 
            // labelNameCargo
            // 
            this.labelNameCargo.AutoSize = true;
            this.labelNameCargo.Location = new System.Drawing.Point(11, 12);
            this.labelNameCargo.Name = "labelNameCargo";
            this.labelNameCargo.Size = new System.Drawing.Size(114, 13);
            this.labelNameCargo.TabIndex = 0;
            this.labelNameCargo.Text = "Наименование груза";
            // 
            // btnDeleteTraffic
            // 
            this.btnDeleteTraffic.Location = new System.Drawing.Point(162, 3);
            this.btnDeleteTraffic.Name = "btnDeleteTraffic";
            this.btnDeleteTraffic.Size = new System.Drawing.Size(141, 23);
            this.btnDeleteTraffic.TabIndex = 1;
            this.btnDeleteTraffic.Text = "Удалить";
            this.btnDeleteTraffic.UseVisualStyleBackColor = true;
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
            this.tabTraffic.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.tabAirports.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAirports)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabAirplane.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAirplanes)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabCargos.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridaCargos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label loginName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControlAirplanes;
        private System.Windows.Forms.TabPage tabAirports;
        private System.Windows.Forms.TabPage tabAirplane;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabCargos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridaCargos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelCuantityCargo;
        private System.Windows.Forms.TextBox textBoxWeightCargo;
        private System.Windows.Forms.Label labelWeightCargo;
        private System.Windows.Forms.TextBox textBoxNameCargo;
        private System.Windows.Forms.Label labelNameCargo;
        private System.Windows.Forms.TextBox textBoxQuantityCargo;
        private System.Windows.Forms.Label labelCargoInfo;
        private System.Windows.Forms.Button btnAddCargo;
        private System.Windows.Forms.Button btnChangeCargo;
        private System.Windows.Forms.Button btnDeleteCargo;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView dataGridAirports;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label labelCityAirport;
        private System.Windows.Forms.TextBox textBoxCityAirport;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.Button btnChangeAirport;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Label labelAirportInfo;
        private System.Windows.Forms.TabPage tabTraffic;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TreeView trafficTree;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnAddTraffic;
        private System.Windows.Forms.Button btnDeleteTraffic;
    }
}
