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
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcQuantityResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcConstructionMgmtDomain
{
	[Guid("9fada597-3474-49fa-8994-f2b3e432d696")]
	public partial class IfcConstructionEquipmentResource : IfcConstructionResource
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines types of construction equipment resources.  <blockquote class=\"change-ifc2x4\">IFC4 New attribute.</blockquote>")]
		public IfcConstructionEquipmentResourceTypeEnum? PredefinedType { get; set; }
	
	
		public IfcConstructionEquipmentResource(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
