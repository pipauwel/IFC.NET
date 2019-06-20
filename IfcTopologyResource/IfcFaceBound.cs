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
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcTopologyResource
{
	[Guid("57c11bcb-98a6-432c-af6d-cb98d7020755")]
	public partial class IfcFaceBound : IfcTopologicalRepresentationItem
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("The loop which will be used as a face boundary.")]
		[Required()]
		public IfcLoop Bound { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("This indicated whether (TRUE) or not (FALSE) the loop has the same sense when used to bound the face as when first defined. If sense is FALSE the senses of all its component oriented edges are implicitly reversed when used in the face.")]
		[Required()]
		public IfcBoolean Orientation { get; set; }
	
	
		public IfcFaceBound(IfcLoop bound, IfcBoolean orientation)
		{
			this.Bound = bound;
			this.Orientation = orientation;
		}
	
	
	}
	
}
