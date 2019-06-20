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
	[Guid("863af35b-d9f7-458e-816e-351ab24b707b")]
	public partial class IfcWorkSchedule : IfcWorkControl
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Identifies the predefined types of a work schedule from which       the type required may be set.")]
		public IfcWorkScheduleTypeEnum? PredefinedType { get; set; }
	
	
		public IfcWorkSchedule(IfcGloballyUniqueId globalId, IfcDateTime creationDate, IfcDateTime startTime)
			: base(globalId, creationDate, startTime)
		{
		}
	
	
	}
	
}
