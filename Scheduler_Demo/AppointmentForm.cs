using Scheduler_Demo;
using Syncfusion.Schedule;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler_Demo
{
     public partial class AppointmentForm : MetroForm
    {
        private ScheduleControl schedulegrid;
        private IScheduleAppointment currentAppointment = null;
        private bool isEdit = false;

        public AppointmentForm(ScheduleControl control)
        {
            InitializeComponent();
            schedulegrid = control;
            this.isEdit = false;
        }

        public AppointmentForm(ScheduleControl control, IScheduleAppointment appointmentToEdit)
        {
            InitializeComponent();
            schedulegrid = control;
            currentAppointment = appointmentToEdit;
            isEdit = true;
            
        }
        private void LoadAppointmentData()
        {
            if (currentAppointment != null)
            {
                this.SubjectTextBoxExt.Text = currentAppointment.Subject;
                this.StartDateDateTimePickerAdv.Value = currentAppointment.StartTime;
                this.EndDateDateTimePickerAdv.Value = currentAppointment.EndTime;
                this.comboBox1.SelectedIndex = currentAppointment.LabelValue ;
            }
        }
        private SimpleScheduleDataProvider dataProvider;
        public SimpleScheduleDataProvider DataProvider
        {
            get
            {
                return dataProvider;
            }
            set
            {
                dataProvider = value;
            }
        }

        List<String> colorOptions;

        void AppointmentForm_Load(object sender, System.EventArgs e)
        {
            colorOptions = new List<string>();
            colorOptions.Add("None");
            colorOptions.Add("Important");
            colorOptions.Add("Business");
            colorOptions.Add("Personal");
            colorOptions.Add("Vacation");
            colorOptions.Add("Must Attend");
            colorOptions.Add("Travel Required");
            colorOptions.Add("Needs Preparation");
            colorOptions.Add("Birthday");
            colorOptions.Add("Anniversary");
            colorOptions.Add("Phone Call");
            this.comboBox1.DataSource = colorOptions;
            this.comboBox1.SelectedIndex = 0;
            LoadAppointmentData();
        }

        void cancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        void OnAddorEditItem_Clicked(object sender, EventArgs e)
        {
            IScheduleAppointment item;

            if (isEdit && currentAppointment != null)
            {
                //Update existing
                item = currentAppointment; 
            }
            else
            {
                //New
                item = dataProvider.NewScheduleAppointment();
            }

            if (item != null)
            {
                item.AllDay = true;
                item.StartTime = StartDateDateTimePickerAdv.Value;
                item.EndTime = EndDateDateTimePickerAdv.Value;
                item.Subject = SubjectTextBoxExt.Text;
                item.LabelValue = comboBox1.SelectedIndex;

                if (!isEdit)
                {
                   dataProvider.AddItem(item);
                }
                    
            }

            schedulegrid.GetScheduleHost().SetDataToDayPanels();
            
            this.Close();
        }
    }
}
