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

using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("fd79e3b5-9d55-4a57-ba6b-1fca7392b523")]
	public partial class IfcCompositeCurveSegment : IfcGeometricRepresentationItem
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The state of transition (i.e., geometric continuity from the last point of this segment to the first point of the next segment) in a composite curve.")]
		[Required()]
		public IfcTransitionCode Transition { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("An indicator of whether or not the sense of the segment agrees with, or opposes, that of the parent curve. If SameSense is false, the point with highest parameter value is taken as the first point of the segment.")]
		[Required()]
		public Boolean SameSense { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("The bounded curve which defines the geometry of the segment.")]
		[Required()]
		public IfcCurve ParentCurve { get; set; }
	
		[InverseProperty("Segments")] 
		[Description("The set of composite curves which use this composite curve segment as a segment. This set shall not be empty.")]
		[MinLength(1)]
		public ISet<IfcCompositeCurve> UsingCurves { get; protected set; }
	
	
		public IfcCompositeCurveSegment(IfcTransitionCode transition, Boolean sameSense, IfcCurve parentCurve)
		{
			this.Transition = transition;
			this.SameSense = sameSense;
			this.ParentCurve = parentCurve;
			this.UsingCurves = new HashSet<IfcCompositeCurve>();
		}
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}
