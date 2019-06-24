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
	[Guid("c61fb4db-0cf8-48c7-8d8f-aa7dc803cb0c")]
	public partial class IfcRelContainedInSpatialStructure : IfcRelConnects
	{
		[DataMember(Order = 0)] 
		[Description("<EPM-HTML>  Set of <strike>elements</strike> products, which are contained within this level of the spatial structure hierarchy.  <blockquote><font color=\"#ff0000\"><small>  IFC2x PLATFORM CHANGE&nbsp; The data type has been changed from <i>IfcElement</i> to <i>IfcProduct</i> with upward compatibility  <small></font></blockquote>  </EPM-HTML>")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcProduct> RelatedElements { get; protected set; }
	
		[DataMember(Order = 1)] 
		[Description("<EPM-HTML>  Spatial structure element, within which the element is contained. Any element can only be contained within one element of the project spatial structure.  </EPM-HTML>")]
		[Required()]
		public IfcSpatialStructureElement RelatingStructure { get; set; }
	
	
		public IfcRelContainedInSpatialStructure(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcProduct[] relatedElements, IfcSpatialStructureElement relatingStructure)
			: base(globalId, ownerHistory)
		{
			this.RelatedElements = new HashSet<IfcProduct>(relatedElements);
			this.RelatingStructure = relatingStructure;
		}
	
	
	}
	
}
