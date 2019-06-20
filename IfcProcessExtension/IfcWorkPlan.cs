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
	[Guid("1802d7e1-8d28-4916-80dd-a5f0a21f588b")]
	public partial class IfcWorkPlan : IfcWorkControl
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Identifies the predefined types of a work plan from which       the type required may be set.")]
		public IfcWorkPlanTypeEnum? PredefinedType { get; set; }
	
	
		public IfcWorkPlan(IfcGloballyUniqueId globalId, IfcDateTime creationDate, IfcDateTime startTime)
			: base(globalId, creationDate, startTime)
		{
		}
	
	
	}
	
}
