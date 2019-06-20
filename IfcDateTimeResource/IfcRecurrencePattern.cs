// This file may be edited manually or auto-generated using IfcKit at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcDateTimeResource
{
	[Guid("258a0af9-321d-4e24-a6cc-be10c825e9f7")]
	public partial class IfcRecurrencePattern
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines the recurrence type that gives meaning to the used      attributes and decides about possible attribute      combinations, i.e. what attributes are needed to fully      describe the pattern type.")]
		[Required()]
		public IfcRecurrenceTypeEnum RecurrenceType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The position of the specified day in a month.")]
		[MinLength(1)]
		public ISet<IfcDayInMonthNumber> DayComponent { get; protected set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The weekday name of the specified day in a week.")]
		[MinLength(1)]
		public ISet<IfcDayInWeekNumber> WeekdayComponent { get; protected set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The position of the specified month in a year.")]
		[MinLength(1)]
		public ISet<IfcMonthInYearNumber> MonthComponent { get; protected set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("The position of the specified component, e.g. the 3rd      (position=3) Tuesday (weekday component) in a month. A      negative position value is used to define the last position       of the component (-1), the next to last position (-2) etc.")]
		public IfcInteger? Position { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("An interval can be given according to the pattern type. An      interval value of 2 can for instance every two days, weeks,      months, years. An empty interval value is regarded as 1. The      used interval values should be in a reasonable range, e.g.      not 0 or &lt;0.")]
		public IfcInteger? Interval { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("Defines the number of occurrences of this pattern, e.g. a weekly       event might be defined to occur 5 times before it stops.")]
		public IfcInteger? Occurrences { get; set; }
	
		[DataMember(Order = 7)] 
		[Description("List of time periods that are defined by a start and end time      of the recurring element (day). The order of the list should      reflect the sequence of the time periods.")]
		[MinLength(1)]
		public IList<IfcTimePeriod> TimePeriods { get; protected set; }
	
	
		public IfcRecurrencePattern(IfcRecurrenceTypeEnum recurrenceType)
		{
			this.RecurrenceType = recurrenceType;
			this.DayComponent = new HashSet<IfcDayInMonthNumber>();
			this.WeekdayComponent = new HashSet<IfcDayInWeekNumber>();
			this.MonthComponent = new HashSet<IfcMonthInYearNumber>();
			this.TimePeriods = new List<IfcTimePeriod>();
		}
	
	
	}
	
}
