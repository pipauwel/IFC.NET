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

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("3289e523-2eef-4bfe-b002-fe259f78ee64")]
	public partial class IfcSpace : IfcSpatialStructureElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines, whether the Space is interior (Internal), or exterior (External), i.e. part of the outer space.")]
		[Required()]
		public IfcInternalOrExternalEnum InteriorOrExteriorSpace { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Level of flooring of this space; the average shall be taken, if the space ground surface is sloping or if there are level differences within this space.")]
		public IfcLengthMeasure? ElevationWithFlooring { get; set; }
	
		[InverseProperty("RelatedSpace")] 
		[Description("<EPM-HTML>  Reference to <i>IfcCovering</i> by virtue of the objectified relationship <i>IfcRelCoversSpaces</i>. It defines the concept of a space having coverings assigned. Those coverings may represent different flooring, or tiling areas.  <blockquote><small>  NOTE&nbsp; Coverings are often managed by the space, and not by the building element, which they cover.<br>  <font color=\"#ff0000\">IFC2x Edition3 CHANGE&nbsp; New inverse relationship. Upward compatibility for file based exchange is guaranteed.</font>  </small></blockquote>  </EPM-HTML>")]
		public ISet<IfcRelCoversSpaces> HasCoverings { get; protected set; }
	
		[InverseProperty("RelatingSpace")] 
		[Description("Reference to Set of Space Boundaries that defines the physical or virtual delimitation of that Space.")]
		public ISet<IfcRelSpaceBoundary> BoundedBy { get; protected set; }
	
	
		public IfcSpace(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcElementCompositionEnum compositionType, IfcInternalOrExternalEnum interiorOrExteriorSpace)
			: base(globalId, ownerHistory, compositionType)
		{
			this.InteriorOrExteriorSpace = interiorOrExteriorSpace;
			this.HasCoverings = new HashSet<IfcRelCoversSpaces>();
			this.BoundedBy = new HashSet<IfcRelSpaceBoundary>();
		}
	
	
	}
	
}
