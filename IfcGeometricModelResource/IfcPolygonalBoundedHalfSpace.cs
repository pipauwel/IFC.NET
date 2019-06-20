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

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("65e9d30b-d646-47b9-a5b5-e3d5e4d6323c")]
	public partial class IfcPolygonalBoundedHalfSpace : IfcHalfSpaceSolid
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("<p>Definition of the position coordinate system for the bounding polyline <STRIKE>and the base surface</STRIKE>.</p>")]
		[Required()]
		public IfcAxis2Placement3D Position { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("Two-dimensional <strike>polyline</strike> bounded curve, defined in the xy plane of the position coordinate system.  <blockquote class=\"change-ifc2x3\">IFC2x3 CHANGE&nbsp; The attribute type has been changed from <em>IfcPolyline</em> to its supertype <em>IfcBoundedCurve</em> with upward compatibility for file based exchange.</blockquote>")]
		[Required()]
		public IfcBoundedCurve PolygonalBoundary { get; set; }
	
	
		public IfcPolygonalBoundedHalfSpace(IfcSurface baseSurface, IfcBoolean agreementFlag, IfcAxis2Placement3D position, IfcBoundedCurve polygonalBoundary)
			: base(baseSurface, agreementFlag)
		{
			this.Position = position;
			this.PolygonalBoundary = polygonalBoundary;
		}
	
	
	}
	
}
