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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProcessExtension
{
	[Guid("d247df5b-2f6d-4ef6-bca1-19a0283512e0")]
	public abstract partial class IfcWorkControl : IfcControl
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The date that the plan is created.")]
		[Required()]
		public IfcDateTime CreationDate { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The authors of the work plan.")]
		[MinLength(1)]
		public ISet<IfcPerson> Creators { get; protected set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("A description of the purpose of the work schedule.")]
		public IfcLabel? Purpose { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The total duration of the entire work schedule.")]
		public IfcDuration? Duration { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("The total time float of the entire work schedule.")]
		public IfcDuration? TotalFloat { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("The start time of the schedule.")]
		[Required()]
		public IfcDateTime StartTime { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("The finish time of the schedule.")]
		public IfcDateTime? FinishTime { get; set; }
	
	
		protected IfcWorkControl(IfcGloballyUniqueId globalId, IfcDateTime creationDate, IfcDateTime startTime)
			: base(globalId)
		{
			this.CreationDate = creationDate;
			this.Creators = new HashSet<IfcPerson>();
			this.StartTime = startTime;
		}
	
	
	}
	
}
