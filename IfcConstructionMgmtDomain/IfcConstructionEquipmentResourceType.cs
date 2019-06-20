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
	[Guid("0183b4f6-26f5-49bc-be00-a887d350340e")]
	public partial class IfcConstructionEquipmentResourceType : IfcConstructionResourceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines types of construction equipment resources.  <p></p>")]
		[Required()]
		public IfcConstructionEquipmentResourceTypeEnum PredefinedType { get; set; }
	
	
		public IfcConstructionEquipmentResourceType(IfcGloballyUniqueId globalId, IfcConstructionEquipmentResourceTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
