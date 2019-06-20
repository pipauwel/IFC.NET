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

using BuildingSmart.IFC.IfcCostResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcQuantityResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcConstructionMgmtDomain
{
	[Guid("f91f11b0-b549-4807-8ebb-0801f1abe42a")]
	public partial class IfcConstructionProductResourceType : IfcConstructionResourceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines types of construction product resources.  <p></p>")]
		[Required()]
		public IfcConstructionProductResourceTypeEnum PredefinedType { get; set; }
	
	
		public IfcConstructionProductResourceType(IfcGloballyUniqueId globalId, IfcConstructionProductResourceTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
