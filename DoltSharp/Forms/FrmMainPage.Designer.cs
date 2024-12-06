﻿namespace DoltSharp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainPage));
            this.LblTaskView = new MetroFramework.Controls.MetroLabel();
            this.LlblProjectsView = new MetroFramework.Controls.MetroLabel();
            this.BtnNewTask = new MetroFramework.Controls.MetroButton();
            this.BtnNewProject = new MetroFramework.Controls.MetroButton();
            this.DgvTaskList = new MetroFramework.Controls.MetroGrid();
            this.DgvProjectsList = new MetroFramework.Controls.MetroGrid();
            this.LblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblWelcome = new System.Windows.Forms.Label();
            this.BtnShowReport = new MetroFramework.Controls.MetroButton();
            this.BtnNotifications = new MetroFramework.Controls.MetroButton();
            this.BtnClose = new MetroFramework.Controls.MetroButton();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            this.BtnEditInformation = new MetroFramework.Controls.MetroButton();
            this.BtnConfiguration = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProjectsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
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
            this.BtnNewTask.TabIndex = 4;
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
            this.BtnNewProject.TabIndex = 6;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTaskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTaskList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvTaskList.EnableHeadersVisualStyles = false;
            this.DgvTaskList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvTaskList.GridColor = System.Drawing.Color.Black;
            this.DgvTaskList.Location = new System.Drawing.Point(884, 294);
            this.DgvTaskList.Margin = new System.Windows.Forms.Padding(4);
            this.DgvTaskList.Name = "DgvTaskList";
            this.DgvTaskList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTaskList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvTaskList.RowHeadersWidth = 51;
            this.DgvTaskList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTaskList.Size = new System.Drawing.Size(869, 402);
            this.DgvTaskList.TabIndex = 5;
            this.DgvTaskList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTaskList_CellContentClick);
            // 
            // DgvProjectsList
            // 
            this.DgvProjectsList.AllowUserToResizeRows = false;
            this.DgvProjectsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvProjectsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvProjectsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DgvProjectsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProjectsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvProjectsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvProjectsList.DefaultCellStyle = dataGridViewCellStyle5;
            this.DgvProjectsList.EnableHeadersVisualStyles = false;
            this.DgvProjectsList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvProjectsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DgvProjectsList.Location = new System.Drawing.Point(7, 294);
            this.DgvProjectsList.Margin = new System.Windows.Forms.Padding(4);
            this.DgvProjectsList.Name = "DgvProjectsList";
            this.DgvProjectsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvProjectsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvProjectsList.RowHeadersWidth = 51;
            this.DgvProjectsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DgvProjectsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProjectsList.Size = new System.Drawing.Size(869, 402);
            this.DgvProjectsList.TabIndex = 3;
            this.DgvProjectsList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProjectsList_CellContentClick);
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
            // BtnShowReport
            // 
            this.BtnShowReport.BackgroundImage = global::DoltSharp.Properties.Resources.reporte;
            this.BtnShowReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnShowReport.Location = new System.Drawing.Point(1667, 23);
            this.BtnShowReport.Name = "BtnShowReport";
            this.BtnShowReport.Size = new System.Drawing.Size(67, 62);
            this.BtnShowReport.TabIndex = 9;
            this.BtnShowReport.UseSelectable = true;
            this.BtnShowReport.Click += new System.EventHandler(this.BtnShowReport_Click_1);
            // 
            // BtnNotifications
            // 
            this.BtnNotifications.BackgroundImage = global::DoltSharp.Properties.Resources.notificacion;
            this.BtnNotifications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnNotifications.Location = new System.Drawing.Point(1571, 23);
            this.BtnNotifications.Name = "BtnNotifications";
            this.BtnNotifications.Size = new System.Drawing.Size(63, 62);
            this.BtnNotifications.TabIndex = 8;
            this.BtnNotifications.UseSelectable = true;
            this.BtnNotifications.Click += new System.EventHandler(this.BtnNotifications_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackgroundImage = global::DoltSharp.Properties.Resources.cerrar_sesion;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnClose.Location = new System.Drawing.Point(1451, 23);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(92, 62);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.UseSelectable = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            // FrmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 943);
            this.ControlBox = false;
            this.Controls.Add(this.BtnShowReport);
            this.Controls.Add(this.BtnNotifications);
            this.Controls.Add(this.BtnClose);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private MetroFramework.Controls.MetroButton BtnClose;
        private MetroFramework.Controls.MetroButton BtnNotifications;
        private MetroFramework.Controls.MetroButton BtnShowReport;
    }
}