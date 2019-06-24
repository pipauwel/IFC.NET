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
	[Guid("94b96403-6c6d-42f0-b3dd-fd18fdb25600")]
	public partial class IfcCraneRailFShapeProfileDef : IfcParameterizedProfileDef
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Total extent of the height, defined parallel to the y axis of the position coordinate system. See illustration above (= h1).")]
		[Required()]
		public IfcPositiveLengthMeasure OverallHeight { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Total extent of the width of the head, defined parallel to the x axis of the position coordinate system. See illustration above (= k)")]
		[Required()]
		public IfcPositiveLengthMeasure HeadWidth { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Edge radius according the above illustration (= r1).")]
		public IfcPositiveLengthMeasure? Radius { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Head depth of the F shape crane rail, see illustration above (= h2).")]
		[Required()]
		public IfcPositiveLengthMeasure HeadDepth2 { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Head depth of the F shape crane rail, see illustration above (= h3).")]
		[Required()]
		public IfcPositiveLengthMeasure HeadDepth3 { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("Thickness of the web of the F shape crane rail. See illustration above (= b3)")]
		[Required()]
		public IfcPositiveLengthMeasure WebThickness { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("Base depth of the F shape crane rail, see illustration above (= s1).")]
		[Required()]
		public IfcPositiveLengthMeasure BaseDepth1 { get; set; }
	
		[DataMember(Order = 7)] 
		[XmlAttribute]
		[Description("Base depth of the F shape crane rail, see illustration above (= s2).")]
		[Required()]
		public IfcPositiveLengthMeasure BaseDepth2 { get; set; }
	
		[DataMember(Order = 8)] 
		[XmlAttribute]
		[Description("<EPM-HTML> Location of centre of gravity along the y axis measured from the center of the bounding box.     <blockquote> <small><font color=\"#ff0000\">  IFC2x Edition 2 Addendum 2 CHANGE The attribute <i>CentreOfGravityInY</i> has been made optional. Upward compatibility for file based exchange is guaranteed.    </font></small></blockquote>  </EPM-HTML>")]
		public IfcPositiveLengthMeasure? CentreOfGravityInY { get; set; }
	
	
		public IfcCraneRailFShapeProfileDef(IfcProfileTypeEnum profileType, IfcAxis2Placement2D position, IfcPositiveLengthMeasure overallHeight, IfcPositiveLengthMeasure headWidth, IfcPositiveLengthMeasure headDepth2, IfcPositiveLengthMeasure headDepth3, IfcPositiveLengthMeasure webThickness, IfcPositiveLengthMeasure baseDepth1, IfcPositiveLengthMeasure baseDepth2)
			: base(profileType, position)
		{
			this.OverallHeight = overallHeight;
			this.HeadWidth = headWidth;
			this.HeadDepth2 = headDepth2;
			this.HeadDepth3 = headDepth3;
			this.WebThickness = webThickness;
			this.BaseDepth1 = baseDepth1;
			this.BaseDepth2 = baseDepth2;
		}
	
	
	}
	
}
