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
using BuildingSmart.IFC.IfcMaterialResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("68083c6e-1181-46f4-84da-7cd237846083")]
	public partial class IfcRelAssociatesMaterial : IfcRelAssociates
	{
		[DataMember(Order = 0)] 
		[Description("Material definition assigned to the elements or element types.")]
		[Required()]
		public IfcMaterialSelect RelatingMaterial { get; set; }
	
	
		public IfcRelAssociatesMaterial(IfcGloballyUniqueId globalId, IfcDefinitionSelect[] relatedObjects, IfcMaterialSelect relatingMaterial)
			: base(globalId, relatedObjects)
		{
			this.RelatingMaterial = relatingMaterial;
		}
	
	
	}
	
}
