﻿using System;
using System.Collections.Generic;

namespace R.Scheduler.Contracts.Calendars.Holiday.Model
{
    public class AddExclusionDatesRequest
    {
        public List<DateTime> ExclusionDates { get; set; }
    }
}
