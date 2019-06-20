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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("0ae997a0-8ed2-4ce0-aaf7-1b4d33ce64bb")]
	public partial class IfcRelAssignsToGroupByFactor : IfcRelAssignsToGroup
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Factor provided as a ratio measure that identifies the fraction or weighted factor that applies to the group assignment.")]
		[Required()]
		public IfcRatioMeasure Factor { get; set; }
	
	
		public IfcRelAssignsToGroupByFactor(IfcGloballyUniqueId globalId, IfcObjectDefinition[] relatedObjects, IfcGroup relatingGroup, IfcRatioMeasure factor)
			: base(globalId, relatedObjects, relatingGroup)
		{
			this.Factor = factor;
		}
	
	
	}
	
}
