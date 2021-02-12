using Syncfusion.SfSchedule.XForms;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ScheduleXamarin
{
    public class SchedulePageBehavior : Behavior<ContentPage>
    {
        SfSchedule schedule;
        Button monthbutton;
        Button weekbutton;
        Button workweekbutton;
        Button daybutton;
        Button timelinebutton;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            
            this.schedule = bindable.FindByName<SfSchedule>("Schedule");
            this.monthbutton = bindable.FindByName<Button>("monthbutton");
            this.weekbutton = bindable.FindByName<Button>("weekbutton");
            this.workweekbutton = bindable.FindByName<Button>("workweekbutton");
            this.daybutton = bindable.FindByName<Button>("daybutton");
            this.timelinebutton = bindable.FindByName<Button>("timelinebutton");
            this.WireEvents();
        }

        private void WireEvents()
        {
            monthbutton.Clicked += Monthbutton_Clicked;
            weekbutton.Clicked += Weekbutton_Clicked;
            workweekbutton.Clicked += Workweekbutton_Clicked;
            daybutton.Clicked += Daybutton_Clicked;
            timelinebutton.Clicked += Timelinebutton_Clicked;
        }
        private void Monthbutton_Clicked(object sender, EventArgs e)
        {
            schedule.ScheduleView = ScheduleView.MonthView;
        }
        private void Daybutton_Clicked(object sender, EventArgs e)
        {
            schedule.ScheduleView = ScheduleView.DayView;
        }

        private void Workweekbutton_Clicked(object sender, EventArgs e)
        {
            schedule.ScheduleView = ScheduleView.WorkWeekView;
        }

        private void Weekbutton_Clicked(object sender, EventArgs e)
        {
            schedule.ScheduleView = ScheduleView.WeekView;
        }
        private void Timelinebutton_Clicked(object sender, EventArgs e)
        {
            schedule.ScheduleView = ScheduleView.TimelineView;
        }
        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            this.UnWireEvents();
        }
        private void UnWireEvents()
        {
            monthbutton.Clicked -= Monthbutton_Clicked;
            weekbutton.Clicked -= Weekbutton_Clicked;
            workweekbutton.Clicked -= Workweekbutton_Clicked;
            daybutton.Clicked -= Daybutton_Clicked;
            timelinebutton.Clicked -= Timelinebutton_Clicked;
        }
    }
}
    