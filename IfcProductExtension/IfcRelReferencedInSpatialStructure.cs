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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("84e20472-51cc-4357-8e9a-6fd9f97f6e03")]
	public partial class IfcRelReferencedInSpatialStructure : IfcRelConnects
	{
		[DataMember(Order = 0)] 
		[Description("<EPM-HTML>  Set of products, which are referenced within this level of the spatial structure hierarchy.  <blockquote><small>NOTE&nbsp; Referenced elements are contained elsewhere within the spatial structure, they are referenced additionally by this spatial structure element, e.g., because they span several stories.</small>  </blockquote>  </EPM-HTML>")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcProduct> RelatedElements { get; protected set; }
	
		[DataMember(Order = 1)] 
		[Description("<EPM-HTML>  Spatial structure element, within which the element is referenced. Any element can be contained within zero, one or many elements of the project spatial structure.  </EPM-HTML>")]
		[Required()]
		public IfcSpatialStructureElement RelatingStructure { get; set; }
	
	
		public IfcRelReferencedInSpatialStructure(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcProduct[] relatedElements, IfcSpatialStructureElement relatingStructure)
			: base(globalId, ownerHistory)
		{
			this.RelatedElements = new HashSet<IfcProduct>(relatedElements);
			this.RelatingStructure = relatingStructure;
		}
	
	
	}
	
}
