namespace DoltSharp
{
    partial class FrmMainPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainPage));
            this.LblTaskView = new MetroFramework.Controls.MetroLabel();
            this.LlblProjectsView = new MetroFramework.Controls.MetroLabel();
            this.BtnNewTask = new MetroFramework.Controls.MetroButton();
            this.BtnNewProject = new MetroFramework.Controls.MetroButton();
            this.DgvTaskList = new MetroFramework.Controls.MetroGrid();
            this.DgvProjectsList = new MetroFramework.Controls.MetroGrid();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnEditInformation = new MetroFramework.Controls.MetroButton();
            this.BtnConfiguration = new MetroFramework.Controls.MetroButton();
            this.LblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblWelcome = new System.Windows.Forms.Label();
            this.BtnShowNotifications = new System.Windows.Forms.PictureBox();
            this.BtnShowReport = new System.Windows.Forms.PictureBox();
            this.BtnLeave = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShowNotifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShowReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLeave)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTaskView
            // 
            this.LblTaskView.AutoSize = true;
            this.LblTaskView.Location = new System.Drawing.Point(331, 267);
            this.LblTaskView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTaskView.Name = "LblTaskView";
            this.LblTaskView.Size = new System.Drawing.Size(99, 20);
            this.LblTaskView.TabIndex = 3;
            this.LblTaskView.Text = "Lista de Tareas";
            // 
            // LlblProjectsView
            // 
            this.LlblProjectsView.AutoSize = true;
            this.LlblProjectsView.Location = new System.Drawing.Point(1275, 267);
            this.LlblProjectsView.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LlblProjectsView.Name = "LlblProjectsView";
            this.LlblProjectsView.Size = new System.Drawing.Size(121, 20);
            this.LlblProjectsView.TabIndex = 5;
            this.LlblProjectsView.Text = "Lista de Proyectos";
            // 
            // BtnNewTask
            // 
            this.BtnNewTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewTask.Location = new System.Drawing.Point(263, 704);
            this.BtnNewTask.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewTask.Name = "BtnNewTask";
            this.BtnNewTask.Size = new System.Drawing.Size(167, 37);
            this.BtnNewTask.TabIndex = 5;
            this.BtnNewTask.Text = "Agregar nueva Tareas";
            this.BtnNewTask.UseSelectable = true;
            this.BtnNewTask.Click += new System.EventHandler(this.BtnNewTask_Click);
            // 
            // BtnNewProject
            // 
            this.BtnNewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNewProject.Location = new System.Drawing.Point(1275, 704);
            this.BtnNewProject.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewProject.Name = "BtnNewProject";
            this.BtnNewProject.Size = new System.Drawing.Size(189, 37);
            this.BtnNewProject.TabIndex = 8;
            this.BtnNewProject.Text = "Agregar nueva Proyectos";
            this.BtnNewProject.UseSelectable = true;
            this.BtnNewProject.Click += new System.EventHandler(this.BtnNewProject_Click);
            // 
            // DgvTaskList
            // 
            this.DgvTaskList.AllowUserToResizeRows = false;
            this.DgvTaskList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvTaskList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvTaskList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvTaskList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTaskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTaskList.DefaultCellStyle = dataGridViewCellStyle14;
            this.DgvTaskList.EnableHeadersVisualStyles = false;
            this.DgvTaskList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvTaskList.GridColor = System.Drawing.Color.Black;
            this.DgvTaskList.Location = new System.Drawing.Point(884, 294);
            this.DgvTaskList.Margin = new System.Windows.Forms.Padding(4);
            this.DgvTaskList.Name = "DgvTaskList";
            this.DgvTaskList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTaskList.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DgvTaskList.RowHeadersWidth = 51;
            this.DgvTaskList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTaskList.Size = new System.Drawing.Size(869, 402);
            this.DgvTaskList.TabIndex = 4;
            this.DgvTaskList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTaskList_CellContentClick);
            // 
            // DgvProjectsList
            // 
            this.DgvProjectsList.AllowUserToResizeRows = false;
            this.DgvProjectsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvProjectsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvProjectsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvProjectsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProjectsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.DgvProjectsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProjectsList.DefaultCellStyle = dataGridViewCellStyle17;
            this.DgvProjectsList.EnableHeadersVisualStyles = false;
            this.DgvProjectsList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvProjectsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvProjectsList.Location = new System.Drawing.Point(7, 294);
            this.DgvProjectsList.Margin = new System.Windows.Forms.Padding(4);
            this.DgvProjectsList.Name = "DgvProjectsList";
            this.DgvProjectsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProjectsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.DgvProjectsList.RowHeadersWidth = 51;
            this.DgvProjectsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvProjectsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProjectsList.Size = new System.Drawing.Size(869, 402);
            this.DgvProjectsList.TabIndex = 7;
            this.DgvProjectsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProjectsList_CellContentClick);
            // 
            // PbLogo
            // 
            this.PbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.Location = new System.Drawing.Point(788, 129);
            this.PbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(193, 157);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo.TabIndex = 12;
            this.PbLogo.TabStop = false;
            this.PbLogo.WaitOnLoad = true;
            // 
            // BtnEditInformation
            // 
            this.BtnEditInformation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEditInformation.BackgroundImage")));
            this.BtnEditInformation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEditInformation.Location = new System.Drawing.Point(16, 23);
            this.BtnEditInformation.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEditInformation.Name = "BtnEditInformation";
            this.BtnEditInformation.Size = new System.Drawing.Size(60, 62);
            this.BtnEditInformation.TabIndex = 1;
            this.BtnEditInformation.UseSelectable = true;
            this.BtnEditInformation.Click += new System.EventHandler(this.BtnEditarInformarcion_Click);
            // 
            // BtnConfiguration
            // 
            this.BtnConfiguration.BackColor = System.Drawing.Color.White;
            this.BtnConfiguration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnConfiguration.BackgroundImage")));
            this.BtnConfiguration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnConfiguration.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BtnConfiguration.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnConfiguration.ForeColor = System.Drawing.Color.White;
            this.BtnConfiguration.Location = new System.Drawing.Point(112, 23);
            this.BtnConfiguration.Margin = new System.Windows.Forms.Padding(4);
            this.BtnConfiguration.Name = "BtnConfiguration";
            this.BtnConfiguration.Size = new System.Drawing.Size(67, 62);
            this.BtnConfiguration.TabIndex = 2;
            this.BtnConfiguration.UseSelectable = true;
            this.BtnConfiguration.Click += new System.EventHandler(this.BtnConfiguration_Click);
            // 
            // LblClock
            // 
            this.LblClock.AutoSize = true;
            this.LblClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClock.Location = new System.Drawing.Point(256, 33);
            this.LblClock.Name = "LblClock";
            this.LblClock.Size = new System.Drawing.Size(91, 42);
            this.LblClock.TabIndex = 16;
            this.LblClock.Text = "4:45";
            // 
            // LblWelcome
            // 
            this.LblWelcome.AutoSize = true;
            this.LblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWelcome.Location = new System.Drawing.Point(697, 74);
            this.LblWelcome.Name = "LblWelcome";
            this.LblWelcome.Size = new System.Drawing.Size(378, 29);
            this.LblWelcome.TabIndex = 17;
            this.LblWelcome.Text = "Bienvenido a la Pagina Principal";
            this.LblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnShowNotifications
            // 
            this.BtnShowNotifications.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowNotifications.Image")));
            this.BtnShowNotifications.Location = new System.Drawing.Point(1568, 23);
            this.BtnShowNotifications.Name = "BtnShowNotifications";
            this.BtnShowNotifications.Size = new System.Drawing.Size(63, 62);
            this.BtnShowNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnShowNotifications.TabIndex = 19;
            this.BtnShowNotifications.TabStop = false;
            this.BtnShowNotifications.Click += new System.EventHandler(this.BtnShowNotification_Click);
            // 
            // BtnShowReport
            // 
            this.BtnShowReport.Image = ((System.Drawing.Image)(resources.GetObject("BtnShowReport.Image")));
            this.BtnShowReport.Location = new System.Drawing.Point(1667, 23);
            this.BtnShowReport.Name = "BtnShowReport";
            this.BtnShowReport.Size = new System.Drawing.Size(67, 62);
            this.BtnShowReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnShowReport.TabIndex = 20;
            this.BtnShowReport.TabStop = false;
            this.BtnShowReport.Click += new System.EventHandler(this.BtnShowReport_Click);
            // 
            // BtnLeave
            // 
            this.BtnLeave.Image = ((System.Drawing.Image)(resources.GetObject("BtnLeave.Image")));
            this.BtnLeave.Location = new System.Drawing.Point(1451, 23);
            this.BtnLeave.Name = "BtnLeave";
            this.BtnLeave.Size = new System.Drawing.Size(92, 62);
            this.BtnLeave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnLeave.TabIndex = 21;
            this.BtnLeave.TabStop = false;
            this.BtnLeave.Click += new System.EventHandler(this.BtnLeave_Click);
            // 
            // FrmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 943);
            this.Controls.Add(this.BtnLeave);
            this.Controls.Add(this.BtnShowReport);
            this.Controls.Add(this.BtnShowNotifications);
            this.Controls.Add(this.LblWelcome);
            this.Controls.Add(this.LblClock);
            this.Controls.Add(this.DgvProjectsList);
            this.Controls.Add(this.DgvTaskList);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.BtnEditInformation);
            this.Controls.Add(this.BtnConfiguration);
            this.Controls.Add(this.BtnNewProject);
            this.Controls.Add(this.BtnNewTask);
            this.Controls.Add(this.LlblProjectsView);
            this.Controls.Add(this.LblTaskView);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "FrmMainPage";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShowIcon = false;
            this.Text = "Principal";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmMainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTaskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShowNotifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnShowReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLeave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel LblTaskView;
        private MetroFramework.Controls.MetroLabel LlblProjectsView;
        private MetroFramework.Controls.MetroButton BtnNewTask;
        private MetroFramework.Controls.MetroButton BtnNewProject;
        private MetroFramework.Controls.MetroButton BtnConfiguration;
        private MetroFramework.Controls.MetroButton BtnEditInformation;
        private System.Windows.Forms.PictureBox PbLogo;
        private MetroFramework.Controls.MetroGrid DgvTaskList;
        private MetroFramework.Controls.MetroGrid DgvProjectsList;
        private System.Windows.Forms.Label LblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblWelcome;
        private System.Windows.Forms.PictureBox BtnShowNotifications;
        private System.Windows.Forms.PictureBox BtnShowReport;
        private System.Windows.Forms.PictureBox BtnLeave;
    }
}