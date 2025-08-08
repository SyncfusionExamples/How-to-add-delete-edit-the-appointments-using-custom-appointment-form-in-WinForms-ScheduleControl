using Scheduler_Demo;
using Syncfusion.Schedule;
using Syncfusion.Windows.Forms.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler_Demo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        #region API Definition
        private Syncfusion.Windows.Forms.Schedule.ScheduleControl scheduleControl1;
        private Panel panel1;
        private IContainer components;
        /// <summary>
        /// col index of the marker column
        /// </summary>
        private int markCol = 2;
        private int dayColCount = 212; // product of 2 + 1 * 2 * 3 * 5 * 7  - can handle up to maxconflicts conflicts
        /// <summary>
        /// col index of the time col
        /// </summary>
        private int timeCol = 1;
        IScheduleAppointment appointment;
        SimpleScheduleDataProvider scheduleProvider = new SimpleScheduleDataProvider();
        #endregion

        #region Constructor
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            scheduleProvider.MasterList = new SimpleScheduleAppointmentList();

            this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
            scheduleControl1.DataSource = scheduleProvider;
            scheduleControl1.GetScheduleHost().MouseDown += Form1_MouseDown;
            //Hook the event for showing the appointment form.
            this.scheduleControl1.ShowingAppointmentForm += scheduleControl1_ShowingAppointmentForm;
            grid = this.scheduleControl1.GetScheduleHost();
            ContextMenu menu = new System.Windows.Forms.ContextMenu();
            MenuItem item = new MenuItem("Add appointments");
            MenuItem item2 = new MenuItem("Edit");
            MenuItem item3 = new MenuItem("Delete");
            item.Click += new EventHandler(item_Click);
            item2.Click += new EventHandler(Edititem_Click);
            item3.Click += new EventHandler(OnDeleteItem_Clicked);
            menu.MenuItems.Add(item);
            menu.MenuItems.Add(item2);
            menu.MenuItems.Add(item3);
            grid.ContextMenu = menu;

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            appointment = scheduleControl1.GetItemAtPoint(e.Location, out var item);
        }

        void OnDeleteItem_Clicked(object sender, EventArgs e)
        {
            //Remove the appointment
            scheduleProvider.RemoveItem(appointment);
            scheduleControl1.GetScheduleHost().SetDataToDayPanels();
        }

        void Edititem_Click(object sender, EventArgs e)
        {
            // Create the edit form and pass the selected item
            form = new AppointmentForm(scheduleControl1, appointment);
            form.ShowDialog();
        }

        void item_Click(object sender, EventArgs e)
        {
            form = new AppointmentForm(this.scheduleControl1);
            form.DataProvider = scheduleProvider;
            form.ShowDialog();
        }

        ScheduleGrid grid = new ScheduleGrid();
        AppointmentForm form;

        /// <summary>
        /// Raise the event when showing the appointment form
        /// </summary>
        void scheduleControl1_ShowingAppointmentForm(object sender, ShowingAppointFormEventArgs e)
        {
            //Cancel the default appointform for schedule control.
            e.Cancel = true;
            //Shows the Custom appointment form.
            form.ShowDialog();
        }
        #endregion

        #region Designer Stuffs
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scheduleControl1 = new Syncfusion.Windows.Forms.Schedule.ScheduleControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scheduleControl1
            // 
            this.scheduleControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scheduleControl1.BackColor = System.Drawing.Color.Gray;
            this.scheduleControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scheduleControl1.Culture = new System.Globalization.CultureInfo("");
            this.scheduleControl1.DataSource = null;
            this.scheduleControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduleControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scheduleControl1.ISO8601CalenderFormat = false;
            this.scheduleControl1.Location = new System.Drawing.Point(6, 3);
            this.scheduleControl1.Name = "scheduleControl1";
            this.scheduleControl1.NavigationPanelPosition = Syncfusion.Schedule.CalendarNavigationPanelPosition.Left;
            this.scheduleControl1.ShowRoundedCorners = true;
            this.scheduleControl1.Size = new System.Drawing.Size(986, 583);
            this.scheduleControl1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.scheduleControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 586);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(996, 586);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(900, 590);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scheduler";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        //utility that looks for the file in the project folder up from the exe folder
        private bool FindFile(ref string fileName)
        {
            int i = 0;
            while (i < 4 && !File.Exists(fileName))
            {
                fileName = "..\\" + fileName;
                i++;
            }
            return File.Exists(fileName);
        }

        #endregion

    }
}
