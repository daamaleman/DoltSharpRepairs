﻿namespace DoltSharp
{
    partial class FrmTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTask));
            this.BtnAdd = new MetroFramework.Controls.MetroButton();
            this.LblName = new MetroFramework.Controls.MetroLabel();
            this.LblTaskDescription = new MetroFramework.Controls.MetroLabel();
            this.LblTaskDeadLine = new MetroFramework.Controls.MetroLabel();
            this.LblTaskStatus = new MetroFramework.Controls.MetroLabel();
            this.LblTaskPriority = new MetroFramework.Controls.MetroLabel();
            this.DtpTaskDeadLine = new MetroFramework.Controls.MetroDateTime();
            this.TxtTaskName = new MetroFramework.Controls.MetroTextBox();
            this.CmbTaskPriority = new MetroFramework.Controls.MetroComboBox();
            this.CmbTaskStatus = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnReturn = new MetroFramework.Controls.MetroButton();
            this.LblClock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RtbTaskDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Location = new System.Drawing.Point(179, 496);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(96, 37);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Crear";
            this.BtnAdd.UseSelectable = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(24, 261);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(133, 20);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Nombre de la tarea:";
            // 
            // LblTaskDescription
            // 
            this.LblTaskDescription.AutoSize = true;
            this.LblTaskDescription.Location = new System.Drawing.Point(87, 303);
            this.LblTaskDescription.Name = "LblTaskDescription";
            this.LblTaskDescription.Size = new System.Drawing.Size(82, 20);
            this.LblTaskDescription.TabIndex = 2;
            this.LblTaskDescription.Text = "Descripcion";
            // 
            // LblTaskDeadLine
            // 
            this.LblTaskDeadLine.AutoSize = true;
            this.LblTaskDeadLine.Location = new System.Drawing.Point(79, 341);
            this.LblTaskDeadLine.Name = "LblTaskDeadLine";
            this.LblTaskDeadLine.Size = new System.Drawing.Size(90, 20);
            this.LblTaskDeadLine.TabIndex = 3;
            this.LblTaskDeadLine.Text = "Fecha Limite:";
            // 
            // LblTaskStatus
            // 
            this.LblTaskStatus.AutoSize = true;
            this.LblTaskStatus.Location = new System.Drawing.Point(116, 430);
            this.LblTaskStatus.Name = "LblTaskStatus";
            this.LblTaskStatus.Size = new System.Drawing.Size(53, 20);
            this.LblTaskStatus.TabIndex = 4;
            this.LblTaskStatus.Text = "Estado:";
            // 
            // LblTaskPriority
            // 
            this.LblTaskPriority.AutoSize = true;
            this.LblTaskPriority.Location = new System.Drawing.Point(101, 380);
            this.LblTaskPriority.Name = "LblTaskPriority";
            this.LblTaskPriority.Size = new System.Drawing.Size(67, 20);
            this.LblTaskPriority.TabIndex = 5;
            this.LblTaskPriority.Text = "Prioridad:";
            // 
            // DtpTaskDeadLine
            // 
            this.DtpTaskDeadLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DtpTaskDeadLine.Location = new System.Drawing.Point(201, 341);
            this.DtpTaskDeadLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DtpTaskDeadLine.MinimumSize = new System.Drawing.Size(0, 30);
            this.DtpTaskDeadLine.Name = "DtpTaskDeadLine";
            this.DtpTaskDeadLine.Size = new System.Drawing.Size(281, 30);
            this.DtpTaskDeadLine.TabIndex = 3;
            // 
            // TxtTaskName
            // 
            // 
            // 
            // 
            this.TxtTaskName.CustomButton.Image = null;
            this.TxtTaskName.CustomButton.Location = new System.Drawing.Point(259, 1);
            this.TxtTaskName.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTaskName.CustomButton.Name = "";
            this.TxtTaskName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtTaskName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtTaskName.CustomButton.TabIndex = 1;
            this.TxtTaskName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtTaskName.CustomButton.UseSelectable = true;
            this.TxtTaskName.CustomButton.Visible = false;
            this.TxtTaskName.Lines = new string[0];
            this.TxtTaskName.Location = new System.Drawing.Point(201, 261);
            this.TxtTaskName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTaskName.MaxLength = 32767;
            this.TxtTaskName.Name = "TxtTaskName";
            this.TxtTaskName.PasswordChar = '\0';
            this.TxtTaskName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtTaskName.SelectedText = "";
            this.TxtTaskName.SelectionLength = 0;
            this.TxtTaskName.SelectionStart = 0;
            this.TxtTaskName.ShortcutsEnabled = true;
            this.TxtTaskName.Size = new System.Drawing.Size(281, 23);
            this.TxtTaskName.TabIndex = 1;
            this.TxtTaskName.UseSelectable = true;
            this.TxtTaskName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtTaskName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CmbTaskPriority
            // 
            this.CmbTaskPriority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbTaskPriority.FormattingEnabled = true;
            this.CmbTaskPriority.ItemHeight = 24;
            this.CmbTaskPriority.Items.AddRange(new object[] {
            "Urgente",
            "Importante",
            "Alta",
            "Baja",
            "No prioritaria"});
            this.CmbTaskPriority.Location = new System.Drawing.Point(201, 380);
            this.CmbTaskPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbTaskPriority.Name = "CmbTaskPriority";
            this.CmbTaskPriority.Size = new System.Drawing.Size(281, 30);
            this.CmbTaskPriority.TabIndex = 4;
            this.CmbTaskPriority.UseSelectable = true;
            // 
            // CmbTaskStatus
            // 
            this.CmbTaskStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CmbTaskStatus.FormattingEnabled = true;
            this.CmbTaskStatus.ItemHeight = 24;
            this.CmbTaskStatus.Items.AddRange(new object[] {
            "No iniciado ",
            "Iniciado",
            "En proceso",
            "Culminado"});
            this.CmbTaskStatus.Location = new System.Drawing.Point(201, 430);
            this.CmbTaskStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbTaskStatus.Name = "CmbTaskStatus";
            this.CmbTaskStatus.Size = new System.Drawing.Size(281, 30);
            this.CmbTaskStatus.TabIndex = 5;
            this.CmbTaskStatus.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(224, 76);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BtnReturn
            // 
            this.BtnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReturn.Location = new System.Drawing.Point(309, 496);
            this.BtnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(103, 37);
            this.BtnReturn.TabIndex = 7;
            this.BtnReturn.Text = "Regresar";
            this.BtnReturn.UseSelectable = true;
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // LblClock
            // 
            this.LblClock.AutoSize = true;
            this.LblClock.Location = new System.Drawing.Point(24, 32);
            this.LblClock.Name = "LblClock";
            this.LblClock.Size = new System.Drawing.Size(31, 16);
            this.LblClock.TabIndex = 15;
            this.LblClock.Text = "4:41";
            // 
            // RtbTaskDescription
            // 
            this.RtbTaskDescription.Location = new System.Drawing.Point(201, 303);
            this.RtbTaskDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RtbTaskDescription.Name = "RtbTaskDescription";
            this.RtbTaskDescription.Size = new System.Drawing.Size(281, 22);
            this.RtbTaskDescription.TabIndex = 2;
            this.RtbTaskDescription.Text = "";
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 575);
            this.ControlBox = false;
            this.Controls.Add(this.RtbTaskDescription);
            this.Controls.Add(this.LblClock);
            this.Controls.Add(this.BtnReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CmbTaskStatus);
            this.Controls.Add(this.CmbTaskPriority);
            this.Controls.Add(this.TxtTaskName);
            this.Controls.Add(this.DtpTaskDeadLine);
            this.Controls.Add(this.LblTaskPriority);
            this.Controls.Add(this.LblTaskStatus);
            this.Controls.Add(this.LblTaskDeadLine);
            this.Controls.Add(this.LblTaskDescription);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.BtnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTask";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.Text = "Agregar Tarea";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnAdd;
        private MetroFramework.Controls.MetroLabel LblName;
        private MetroFramework.Controls.MetroLabel LblTaskDescription;
        private MetroFramework.Controls.MetroLabel LblTaskDeadLine;
        private MetroFramework.Controls.MetroLabel LblTaskStatus;
        private MetroFramework.Controls.MetroLabel LblTaskPriority;
        private MetroFramework.Controls.MetroDateTime DtpTaskDeadLine;
        private MetroFramework.Controls.MetroTextBox TxtTaskName;
        private MetroFramework.Controls.MetroComboBox CmbTaskPriority;
        private MetroFramework.Controls.MetroComboBox CmbTaskStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton BtnReturn;
        private System.Windows.Forms.Label LblClock;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox RtbTaskDescription;
    }
}