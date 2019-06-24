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

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("b442e2c7-0333-4c55-8b8b-df240b0d59af")]
	public partial class IfcTypeProduct : IfcTypeObject
	{
		[DataMember(Order = 0)] 
		[Description("List of unique representation maps. Each representation map describes a block definition of the shape of the product style. By providing more than one representation map, a multi-view block definition can be given.")]
		[CustomValidation(typeof(IfcTypeProduct), "Unique")]
		[MinLength(1)]
		public IList<IfcRepresentationMap> RepresentationMaps { get; protected set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The tag (or label) identifier at the particular type of a product, e.g. the article number (like the EAN). It is the identifier at the specific level.")]
		public IfcLabel? Tag { get; set; }
	
	
		public IfcTypeProduct(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.RepresentationMaps = new List<IfcRepresentationMap>();
		}
	
	
	}
	
}
