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
	[Guid("ebde4676-fd2c-4f52-8985-79f623317d88")]
	public partial class IfcLagTime : IfcSchedulingTime
	{
		[DataMember(Order = 0)] 
		[Description("Value of the time lag selected as being either a ratio or a      time measure.")]
		[Required()]
		public IfcTimeOrRatioSelect LagValue { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The allowed types of task duration that specify the lag time      measurement (work time or elapsed time).")]
		[Required()]
		public IfcTaskDurationEnum DurationType { get; set; }
	
	
		public IfcLagTime(IfcTimeOrRatioSelect lagValue, IfcTaskDurationEnum durationType)
		{
			this.LagValue = lagValue;
			this.DurationType = durationType;
		}
	
	
	}
	
}
