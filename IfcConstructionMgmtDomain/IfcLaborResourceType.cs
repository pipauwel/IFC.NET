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
	[Guid("3c666024-11d1-4495-9763-09f6ca7f89e7")]
	public partial class IfcLaborResourceType : IfcConstructionResourceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines types of labour resources.  <p></p>")]
		[Required()]
		public IfcLaborResourceTypeEnum PredefinedType { get; set; }
	
	
		public IfcLaborResourceType(IfcGloballyUniqueId globalId, IfcLaborResourceTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
