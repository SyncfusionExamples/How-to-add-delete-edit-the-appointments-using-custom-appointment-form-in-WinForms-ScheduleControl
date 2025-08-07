# How to add delete edit the appointments using custom appointment form in WinForms ScheduleControl


The custom appointment form in [WinForms Scheduler](https://www.syncfusion.com/winforms-ui-controls/scheduler) can be shown by using the [ShowingAppointmentForm](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Windows.Forms.Schedule.ScheduleControl.html#Syncfusion_Windows_Forms_Schedule_ScheduleControl_ShowingAppointmentForm) event. The default appointment form can be canceled using the e.Cancel property, and a custom appointment form can be shown by calling its ShowDialog method.

**Code for Showing Custom Appointment Form:**


 ```csharp
 AppointmentForm form;
//Hook the event for showing the appointment form.
this.scheduleControl1.ShowingAppointmentForm += scheduleControl1_ShowingAppointmentForm;
/// <summary>
/// Raise the event when showing the appointment form
/// </summary>
void scheduleControl1_ShowingAppointmentForm(object sender, ShowingAppointFormEventArgs e)
{
  //Cancel the default appointment form for schedule control.
   e.Cancel = true;
   //Shows the Custom appointment form.
   form.ShowDialog();
} 
 ```
 **Code for add or edit an appointment using the custom appointment form:**

```csharp
void ok_Click(object sender, EventArgs e)
{
    IScheduleAppointment item;

    if (isEdit && currentAppointment != null)
    {
        item = currentAppointment; // Update existing
    }
    else
    {
        item = dataProvider.NewScheduleAppointment(); // New
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
```
**Code for Deleting Appointment:**
```csharp
void OnDeleteItem_Click(object sender, EventArgs e)
{
    //Remove the appointment
    scheduleProvider.RemoveItem(appointment);
    scheduleControl1.GetScheduleHost().SetDataToDayPanels();
} 
```
![Add, Edit, delete the appointment](Schedule.Gif)
