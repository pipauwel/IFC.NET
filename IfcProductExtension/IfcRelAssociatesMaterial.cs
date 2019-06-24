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
	[Guid("157a4d8c-92d8-4c73-a181-a3fc355cb7a1")]
	public partial class IfcRelAssociatesMaterial : IfcRelAssociates
	{
		[DataMember(Order = 0)] 
		[Description("Material definition (either a single material, a list of materials, or a set of material layers) assigned to the elements.")]
		[Required()]
		public IfcMaterialSelect RelatingMaterial { get; set; }
	
	
		public IfcRelAssociatesMaterial(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcRoot[] relatedObjects, IfcMaterialSelect relatingMaterial)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.RelatingMaterial = relatingMaterial;
		}
	
	
	}
	
}
