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

using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcProfileResource
{
	[Guid("a97ad274-6a1b-4db7-b4a9-46725be04471")]
	public partial class IfcAsymmetricIShapeProfileDef : IfcParameterizedProfileDef
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Extent of the bottom flange, defined parallel to the x axis of the position coordinate system.")]
		[Required()]
		public IfcPositiveLengthMeasure BottomFlangeWidth { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Total extent of the depth, defined parallel to the y axis of the position coordinate system.")]
		[Required()]
		public IfcPositiveLengthMeasure OverallDepth { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Thickness of the web of the I-shape. The web is centred on the x-axis and the y-axis of the position coordinate system.")]
		[Required()]
		public IfcPositiveLengthMeasure WebThickness { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Flange thickness of the bottom flange.")]
		[Required()]
		public IfcPositiveLengthMeasure BottomFlangeThickness { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("The fillet between the web and the bottom flange.  0 if sharp-edged, omitted if unknown.")]
		public IfcNonNegativeLengthMeasure? BottomFlangeFilletRadius { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("Extent of the top flange, defined parallel to the x axis of the position coordinate system.")]
		[Required()]
		public IfcPositiveLengthMeasure TopFlangeWidth { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("Flange thickness of the top flange. This attribute is formally optional for historic reasons only. Whenever the flange thickness is known, it shall be provided by value.")]
		public IfcPositiveLengthMeasure? TopFlangeThickness { get; set; }
	
		[DataMember(Order = 7)] 
		[XmlAttribute]
		[Description("The fillet between the web and the top flange.  0 if sharp-edged, omitted if unknown.")]
		public IfcNonNegativeLengthMeasure? TopFlangeFilletRadius { get; set; }
	
		[DataMember(Order = 8)] 
		[XmlAttribute]
		[Description("Radius of the upper edges of the bottom flange.  0 if sharp-edged, omitted if unknown.")]
		public IfcNonNegativeLengthMeasure? BottomFlangeEdgeRadius { get; set; }
	
		[DataMember(Order = 9)] 
		[XmlAttribute]
		[Description("Slope of the upper faces of the bottom flange.  Non-zero in case of of tapered bottom flange, 0 in case of parallel bottom flange, omitted if unknown.")]
		public IfcPlaneAngleMeasure? BottomFlangeSlope { get; set; }
	
		[DataMember(Order = 10)] 
		[XmlAttribute]
		[Description("Radius of the lower edges of the top flange.  0 if sharp-edged, omitted if unknown.")]
		public IfcNonNegativeLengthMeasure? TopFlangeEdgeRadius { get; set; }
	
		[DataMember(Order = 11)] 
		[XmlAttribute]
		[Description("Slope of the lower faces of the top flange.  Non-zero in case of of tapered top flange, 0 in case of parallel top flange, omitted if unknown.")]
		public IfcPlaneAngleMeasure? TopFlangeSlope { get; set; }
	
	
		public IfcAsymmetricIShapeProfileDef(IfcProfileTypeEnum profileType, IfcPositiveLengthMeasure bottomFlangeWidth, IfcPositiveLengthMeasure overallDepth, IfcPositiveLengthMeasure webThickness, IfcPositiveLengthMeasure bottomFlangeThickness, IfcPositiveLengthMeasure topFlangeWidth)
			: base(profileType)
		{
			this.BottomFlangeWidth = bottomFlangeWidth;
			this.OverallDepth = overallDepth;
			this.WebThickness = webThickness;
			this.BottomFlangeThickness = bottomFlangeThickness;
			this.TopFlangeWidth = topFlangeWidth;
		}
	
	
	}
	
}
