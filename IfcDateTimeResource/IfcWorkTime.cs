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
	[Guid("cb173376-bb9c-47f5-99f1-2fd84e691ccc")]
	public partial class IfcWorkTime : IfcSchedulingTime
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("Recurrence pattern that defines a time period, which, if given, is      valid within the time period defined by      <em>IfcWorkTime.Start</em> and <em>IfcWorkTime.Finish</em>.")]
		public IfcRecurrencePattern RecurrencePattern { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Start date of the work time (0:00), that might be further      restricted by a recurrence pattern.")]
		public IfcDate? Start { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("End date of the work time (24:00), that might be further      restricted by a recurrence pattern.")]
		public IfcDate? Finish { get; set; }
	
	
		public IfcWorkTime()
		{
		}
	
	
	}
	
}
