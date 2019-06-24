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
	[Guid("55319343-8365-4a00-a7de-4cf13f760e2b")]
	public partial class IfcRelAssignsToProduct : IfcRelAssigns
	{
		[DataMember(Order = 0)] 
		[Description("Reference to the Product to which the objects are assigned to.")]
		[Required()]
		public IfcProduct RelatingProduct { get; set; }
	
	
		public IfcRelAssignsToProduct(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcObjectDefinition[] relatedObjects, IfcProduct relatingProduct)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.RelatingProduct = relatingProduct;
		}
	
	
	}
	
}
