﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace App.Models
{
    public partial class CalendarDay: ObservableObject
    {
        public int DayIndex { get; set; }
        public string DayOfWeek { get; set; }
        public int DayOfMonth { get; set; }
        [ObservableProperty]
        public string color;
        public bool Selected { get; set; }

        [ObservableProperty]
        public IEnumerable<IGrouping<int, EventSchedule>> groupedEvents;
        [ObservableProperty]
        public List<ScheduleGroup> scheduleGroups = new();
        [ObservableProperty]
        public List<EventSchedule> events = new();
        public string Details
        {
            get
            {
                return $"{DayOfWeek} {DayOfMonth}, {Events.Count}";
            }
        }
    }

    public class ScheduleGroup : List<EventSchedule>
    {
        public string Hour { get; private set; }

        public ScheduleGroup(string hour, List<EventSchedule> events) : base(events)
        {
            Hour = hour;
        }
    }
}
