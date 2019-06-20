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
	[Guid("0d780540-b4aa-49d6-a0d5-4c6e14da3427")]
	public partial class IfcEventTime : IfcSchedulingTime
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The date on which an event actually occurs. It is a measured value.")]
		public IfcDateTime? ActualDate { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The earliest date on which an event can occur. It is a calculated value.")]
		public IfcDateTime? EarlyDate { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The latest date on which an event can occur. It is a calculated value.")]
		public IfcDateTime? LateDate { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The date on which an event is scheduled to occur.       The value might be measured or somehow calculated, which is defined by      <em>ScheduleDataOrigin</em>.")]
		public IfcDateTime? ScheduleDate { get; set; }
	
	
		public IfcEventTime()
		{
		}
	
	
	}
	
}
