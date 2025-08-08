using System;

namespace Scheduler_Demo
{
    partial class AppointmentForm
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
            this.SubjectTextBoxExt = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.StartDateDateTimePickerAdv = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.EndDateDateTimePickerAdv = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.StartTimeDateTimePickerAdv = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.EndTimeDateTimePickerAdv = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ok = new Syncfusion.Windows.Forms.ButtonAdv();
            this.cancel = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTextBoxExt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateTimePickerAdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDateTimePickerAdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeDateTimePickerAdv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndTimeDateTimePickerAdv)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjectTextBoxExt
            // 
            this.SubjectTextBoxExt.BackColor = System.Drawing.Color.White;
            this.SubjectTextBoxExt.BeforeTouchSize = new System.Drawing.Size(319, 20);
            this.SubjectTextBoxExt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.SubjectTextBoxExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SubjectTextBoxExt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SubjectTextBoxExt.Location = new System.Drawing.Point(69, 140);
            this.SubjectTextBoxExt.MaxLength = 255;
            this.SubjectTextBoxExt.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.SubjectTextBoxExt.Name = "SubjectTextBoxExt";
            this.SubjectTextBoxExt.Size = new System.Drawing.Size(319, 20);
            this.SubjectTextBoxExt.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Metro;
            this.SubjectTextBoxExt.TabIndex = 0;
            this.SubjectTextBoxExt.WordWrap = false;
            // 
            // StartDateDateTimePickerAdv
            // 
            this.StartDateDateTimePickerAdv.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.StartDateDateTimePickerAdv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.StartDateDateTimePickerAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartDateDateTimePickerAdv.CalendarSize = new System.Drawing.Size(189, 176);
            this.StartDateDateTimePickerAdv.Checked = false;
            this.StartDateDateTimePickerAdv.DropDownImage = null;
            this.StartDateDateTimePickerAdv.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.StartDateDateTimePickerAdv.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.StartDateDateTimePickerAdv.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.StartDateDateTimePickerAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateDateTimePickerAdv.Location = new System.Drawing.Point(68, 25);
            this.StartDateDateTimePickerAdv.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.StartDateDateTimePickerAdv.MinValue = new System.DateTime(((long)(0)));
            this.StartDateDateTimePickerAdv.Name = "StartDateDateTimePickerAdv";
            this.StartDateDateTimePickerAdv.ShowCheckBox = false;
            this.StartDateDateTimePickerAdv.Size = new System.Drawing.Size(117, 20);
            this.StartDateDateTimePickerAdv.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.StartDateDateTimePickerAdv.TabIndex = 1;
            this.StartDateDateTimePickerAdv.ThemesEnabled = true;
            this.StartDateDateTimePickerAdv.Value = DateTime.Now;
            // 
            // EndDateDateTimePickerAdv
            // 
            this.EndDateDateTimePickerAdv.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.EndDateDateTimePickerAdv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.EndDateDateTimePickerAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EndDateDateTimePickerAdv.CalendarSize = new System.Drawing.Size(189, 176);
            this.EndDateDateTimePickerAdv.Checked = false;
            this.EndDateDateTimePickerAdv.DropDownImage = null;
            this.EndDateDateTimePickerAdv.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.EndDateDateTimePickerAdv.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.EndDateDateTimePickerAdv.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.EndDateDateTimePickerAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateDateTimePickerAdv.Location = new System.Drawing.Point(68, 72);
            this.EndDateDateTimePickerAdv.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.EndDateDateTimePickerAdv.MinValue = new System.DateTime(((long)(0)));
            this.EndDateDateTimePickerAdv.Name = "EndDateDateTimePickerAdv";
            this.EndDateDateTimePickerAdv.ShowCheckBox = false;
            this.EndDateDateTimePickerAdv.Size = new System.Drawing.Size(117, 20);
            this.EndDateDateTimePickerAdv.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.EndDateDateTimePickerAdv.TabIndex = 2;
            this.EndDateDateTimePickerAdv.ThemesEnabled = true;
            this.EndDateDateTimePickerAdv.Value = DateTime.Now;
            // 
            // StartTimeDateTimePickerAdv
            // 
            this.StartTimeDateTimePickerAdv.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.StartTimeDateTimePickerAdv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.StartTimeDateTimePickerAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartTimeDateTimePickerAdv.CalendarSize = new System.Drawing.Size(189, 176);
            this.StartTimeDateTimePickerAdv.Checked = false;
            this.StartTimeDateTimePickerAdv.DropDownImage = null;
            this.StartTimeDateTimePickerAdv.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.StartTimeDateTimePickerAdv.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.StartTimeDateTimePickerAdv.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.StartTimeDateTimePickerAdv.EnableNullDate = false;
            this.StartTimeDateTimePickerAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeDateTimePickerAdv.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimeDateTimePickerAdv.Location = new System.Drawing.Point(267, 25);
            this.StartTimeDateTimePickerAdv.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.StartTimeDateTimePickerAdv.MinValue = new System.DateTime(((long)(0)));
            this.StartTimeDateTimePickerAdv.Name = "StartTimeDateTimePickerAdv";
            this.StartTimeDateTimePickerAdv.ShowCheckBox = false;
            this.StartTimeDateTimePickerAdv.ShowDropButton = false;
            this.StartTimeDateTimePickerAdv.ShowUpDown = true;
            this.StartTimeDateTimePickerAdv.Size = new System.Drawing.Size(121, 20);
            this.StartTimeDateTimePickerAdv.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.StartTimeDateTimePickerAdv.TabIndex = 3;
            this.StartTimeDateTimePickerAdv.ThemesEnabled = true;
            this.StartTimeDateTimePickerAdv.Value = new System.DateTime(2016, 9, 8, 15, 50, 34, 16);
            // 
            // EndTimeDateTimePickerAdv
            // 
            this.EndTimeDateTimePickerAdv.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.EndTimeDateTimePickerAdv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.EndTimeDateTimePickerAdv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EndTimeDateTimePickerAdv.CalendarSize = new System.Drawing.Size(189, 176);
            this.EndTimeDateTimePickerAdv.Checked = false;
            this.EndTimeDateTimePickerAdv.DropDownImage = null;
            this.EndTimeDateTimePickerAdv.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.EndTimeDateTimePickerAdv.DropDownPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.EndTimeDateTimePickerAdv.DropDownSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(191)))), ((int)(((byte)(237)))));
            this.EndTimeDateTimePickerAdv.EnableNullDate = false;
            this.EndTimeDateTimePickerAdv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeDateTimePickerAdv.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.EndTimeDateTimePickerAdv.Location = new System.Drawing.Point(267, 69);
            this.EndTimeDateTimePickerAdv.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.EndTimeDateTimePickerAdv.MinValue = new System.DateTime(((long)(0)));
            this.EndTimeDateTimePickerAdv.Name = "EndTimeDateTimePickerAdv";
            this.EndTimeDateTimePickerAdv.ShowCheckBox = false;
            this.EndTimeDateTimePickerAdv.ShowDropButton = false;
            this.EndTimeDateTimePickerAdv.ShowUpDown = true;
            this.EndTimeDateTimePickerAdv.Size = new System.Drawing.Size(121, 20);
            this.EndTimeDateTimePickerAdv.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.EndTimeDateTimePickerAdv.TabIndex = 4;
            this.EndTimeDateTimePickerAdv.ThemesEnabled = true;
            this.EndTimeDateTimePickerAdv.Value = new System.DateTime(2016, 9, 8, 15, 50, 34, 52);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Start Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "End Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Start Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Subject";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(267, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Label";
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.ok.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ok.IsBackStageButton = true;
            this.ok.Location = new System.Drawing.Point(204, 183);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 14;
            this.ok.Text = "Ok";
            this.ok.Click += new System.EventHandler(this.OnAddorEditItem_Clicked);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.cancel.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancel.IsBackStageButton = true;
            this.cancel.Location = new System.Drawing.Point(311, 183);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Cancel";
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(403, 229);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndTimeDateTimePickerAdv);
            this.Controls.Add(this.StartTimeDateTimePickerAdv);
            this.Controls.Add(this.EndDateDateTimePickerAdv);
            this.Controls.Add(this.StartDateDateTimePickerAdv);
            this.Controls.Add(this.SubjectTextBoxExt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AppointmentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Appointment Form";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTextBoxExt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateDateTimePickerAdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateDateTimePickerAdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeDateTimePickerAdv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndTimeDateTimePickerAdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private Syncfusion.Windows.Forms.Tools.TextBoxExt SubjectTextBoxExt;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv StartDateDateTimePickerAdv;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv EndDateDateTimePickerAdv;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv StartTimeDateTimePickerAdv;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv EndTimeDateTimePickerAdv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private Syncfusion.Windows.Forms.ButtonAdv ok;
        private Syncfusion.Windows.Forms.ButtonAdv cancel;
    }
}