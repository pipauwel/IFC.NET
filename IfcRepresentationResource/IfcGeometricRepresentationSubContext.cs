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

namespace BuildingSmart.IFC.IfcRepresentationResource
{
	[Guid("44f28476-02ef-4526-9ddf-ac07ffc148d8")]
	public partial class IfcGeometricRepresentationSubContext : IfcGeometricRepresentationContext
	{
		[DataMember(Order = 0)] 
		[Description("Parent context from which the sub context derives its world coordinate system, precision, space coordinate dimension and true north.")]
		[Required()]
		public IfcGeometricRepresentationContext ParentContext { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  The target <font color=\"#ff0000\">plot</font> scale of the representation   to which this representation context applies.  <blockquote> <font size=\"-1\"> Scale indicates the target plot scale for  the representation sub context, all annotation styles are given in plot  dimensions according to this target plot scale.<br>  If multiple instances of <i>IfcGeometricRepresentationSubContext</i>  are given having the same <i>TargetView</i> value, the target plot scale   applies up to the next smaller scale, or up to unlimited small scale.    <br>    <br>  Note: Scale 1:100 (given as 0.01 within <i>TargetScale</i>)  is bigger then 1:200 (given as 0.005 within <i>TargetScale</i>).    </font></blockquote>  </EPM-HTML>")]
		public IfcPositiveRatioMeasure? TargetScale { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Target view of the representation to which this representation context applies.")]
		[Required()]
		public IfcGeometricProjectionEnum TargetView { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("User defined target view, this attribute value shall be given, if the TargetView attribute is set to USERDEFINED.")]
		public IfcLabel? UserDefinedTargetView { get; set; }
	
	
		public IfcGeometricRepresentationSubContext(IfcDimensionCount coordinateSpaceDimension, IfcAxis2Placement worldCoordinateSystem, IfcGeometricRepresentationContext parentContext, IfcGeometricProjectionEnum targetView)
			: base(coordinateSpaceDimension, worldCoordinateSystem)
		{
			this.ParentContext = parentContext;
			this.TargetView = targetView;
		}
	
		public new IfcAxis2Placement WorldCoordinateSystem { get { return null; } }
	
		public new IfcDimensionCount CoordinateSpaceDimension { get { return new IfcDimensionCount(); } }
	
		public new IfcDirection TrueNorth { get { return null; } }
	
		public new Double Precision { get { return null; } }
	
	
	}
	
}
