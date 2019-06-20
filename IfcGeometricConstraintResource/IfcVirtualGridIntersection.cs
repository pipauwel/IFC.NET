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

namespace BuildingSmart.IFC.IfcGeometricConstraintResource
{
	[Guid("f63d89d0-3786-4462-861e-92b27070fde7")]
	public partial class IfcVirtualGridIntersection :
		IfcGridPlacementDirectionSelect
	{
		[DataMember(Order = 0)] 
		[Description("Two grid axes which intersects at exactly one intersection (see also informal proposition at IfcGrid). If attribute OffsetDistances is omitted, the intersection defines the placement or ref direction of a grid placement directly. If OffsetDistances are given, the intersection is defined by the offset curves to the grid axes.")]
		[Required()]
		[CustomValidation(typeof(IfcVirtualGridIntersection), "Unique")]
		[MinLength(2)]
		[MaxLength(2)]
		public IList<IfcGridAxis> IntersectingAxes { get; protected set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Offset distances to the grid axes. If given, it defines virtual offset curves to the grid axes. The intersection of the offset curves specify the virtual grid intersection.")]
		[Required()]
		[MinLength(2)]
		[MaxLength(3)]
		public IList<IfcLengthMeasure> OffsetDistances { get; protected set; }
	
	
		public IfcVirtualGridIntersection(IfcGridAxis[] intersectingAxes, IfcLengthMeasure[] offsetDistances)
		{
			this.IntersectingAxes = new List<IfcGridAxis>(intersectingAxes);
			this.OffsetDistances = new List<IfcLengthMeasure>(offsetDistances);
		}
	
	
	}
	
}
