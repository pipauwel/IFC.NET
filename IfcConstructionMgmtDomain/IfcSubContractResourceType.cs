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
	[Guid("352fd6e0-58e5-4a63-905c-991b1079ef81")]
	public partial class IfcSubContractResourceType : IfcConstructionResourceType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines types of subcontract resources.  <p></p>")]
		[Required()]
		public IfcSubContractResourceTypeEnum PredefinedType { get; set; }
	
	
		public IfcSubContractResourceType(IfcGloballyUniqueId globalId, IfcSubContractResourceTypeEnum predefinedType)
			: base(globalId)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
