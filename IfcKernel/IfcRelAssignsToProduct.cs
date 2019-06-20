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
	[Guid("72eec376-bbab-40d5-9342-93108c172713")]
	public partial class IfcRelAssignsToProduct : IfcRelAssigns
	{
		[DataMember(Order = 0)] 
		[Description("Reference to the product or product type to which the objects are assigned to.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE Datatype expanded to include <em>IfcProduct</em> and <em>IfcTypeProduct</em>.</blockquote>")]
		[Required()]
		public IfcProductSelect RelatingProduct { get; set; }
	
	
		public IfcRelAssignsToProduct(IfcGloballyUniqueId globalId, IfcObjectDefinition[] relatedObjects, IfcProductSelect relatingProduct)
			: base(globalId, relatedObjects)
		{
			this.RelatingProduct = relatingProduct;
		}
	
	
	}
	
}
