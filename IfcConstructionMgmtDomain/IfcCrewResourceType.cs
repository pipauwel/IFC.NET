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
	[Guid("7036c849-da9d-45cc-b0e7-a07e7e66f2c5")]
	public partial class IfcCrewResourceType : IfcConstructionResourceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines types of crew resources.  <p></p>")]
		[Required()]
		public IfcCrewResourceTypeEnum PredefinedType { get; set; }
	
	
		public IfcCrewResourceType(IfcGloballyUniqueId globalId, IfcCrewResourceTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
