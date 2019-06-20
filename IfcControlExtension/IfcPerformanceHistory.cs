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

using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcControlExtension
{
	[Guid("e8ca45f2-cf0b-4a93-84ca-ea3c10c7b27e")]
	public partial class IfcPerformanceHistory : IfcControl
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Describes the applicable building life-cycle phase. Typical values should be DESIGNDEVELOPMENT, SCHEMATICDEVELOPMENT, CONSTRUCTIONDOCUMENT, CONSTRUCTION, ASBUILT, COMMISSIONING, OPERATION, etc.")]
		[Required()]
		public IfcLabel LifeCyclePhase { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Predefined generic type for a performace history that is specified in an enumeration.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE  The attribute has been added at the end of the entity definition.</blockquote>")]
		public IfcPerformanceHistoryTypeEnum? PredefinedType { get; set; }
	
	
		public IfcPerformanceHistory(IfcGloballyUniqueId globalId, IfcLabel lifeCyclePhase)
			: base(globalId)
		{
			this.LifeCyclePhase = lifeCyclePhase;
		}
	
	
	}
	
}
