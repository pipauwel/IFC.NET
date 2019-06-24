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
	[Guid("be13e443-b031-4314-a1ca-5054984b82c8")]
	public partial class IfcPerformanceHistory : IfcControl
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Describes the applicable building life-cycle phase. Typical values should be DESIGNDEVELOPMENT, SCHEMATICDEVELOPMENT, CONSTRUCTIONDOCUMENT, CONSTRUCTION, ASBUILT, COMMISSIONING, OPERATION, etc.")]
		[Required()]
		public IfcLabel LifeCyclePhase { get; set; }
	
	
		public IfcPerformanceHistory(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcLabel lifeCyclePhase)
			: base(globalId, ownerHistory)
		{
			this.LifeCyclePhase = lifeCyclePhase;
		}
	
	
	}
	
}
