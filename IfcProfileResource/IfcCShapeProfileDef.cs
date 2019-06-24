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

namespace BuildingSmart.IFC.IfcProfileResource
{
	[Guid("a4f2c60a-b8a0-4f54-a66a-b99e53d00ea4")]
	public partial class IfcCShapeProfileDef : IfcParameterizedProfileDef
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Profile depth, see illustration above (= h).")]
		[Required()]
		public IfcPositiveLengthMeasure Depth { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Profile width, see illustration above (= b).")]
		[Required()]
		public IfcPositiveLengthMeasure Width { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Constant wall thickness of profile (= ts).")]
		[Required()]
		public IfcPositiveLengthMeasure WallThickness { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Lengths of girth, see illustration above (= c).")]
		[Required()]
		public IfcPositiveLengthMeasure Girth { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Internal fillet radius according the above illustration (= r1). If it is not given, zero is assumed.")]
		public IfcPositiveLengthMeasure? InternalFilletRadius { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("<EPM-HTML> Location of centre of gravity along the x axis measured from the center of the bounding box.     <blockquote> <small><color=\"#ff0000\">  IFC2x Edition 2 Addendum 2 CHANGE The attribute <i>CentreOfGravityInX</i> has been made optional. Upward compatibility for file based exchange is guaranteed.    </font></small></blockquote>  </EPM-HTML>")]
		public IfcPositiveLengthMeasure? CentreOfGravityInX { get; set; }
	
	
		public IfcCShapeProfileDef(IfcProfileTypeEnum profileType, IfcAxis2Placement2D position, IfcPositiveLengthMeasure depth, IfcPositiveLengthMeasure width, IfcPositiveLengthMeasure wallThickness, IfcPositiveLengthMeasure girth)
			: base(profileType, position)
		{
			this.Depth = depth;
			this.Width = width;
			this.WallThickness = wallThickness;
			this.Girth = girth;
		}
	
	
	}
	
}
