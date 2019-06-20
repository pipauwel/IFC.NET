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

namespace BuildingSmart.IFC.IfcPresentationOrganizationResource
{
	[Guid("32a170a7-e0ba-48c0-9f27-f2a1df1265d0")]
	public partial class IfcLightSourcePositional : IfcLightSource
	{
		[DataMember(Order = 0)] 
		[XmlElement]
		[Description("Definition from ISO/CD 10303-46:1992: The Cartesian point indicates the position of the light source.  Definition from VRML97 - ISO/IEC 14772-1:1997: A Point light node illuminates geometry within radius of its location.")]
		[Required()]
		public IfcCartesianPoint Position { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The maximum distance from the light source for a surface still to be illuminated.  Definition from VRML97 - ISO/IEC 14772-1:1997: A Point light node illuminates geometry within radius of its location.")]
		[Required()]
		public IfcPositiveLengthMeasure Radius { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Definition from ISO/CD 10303-46:1992: This real indicates the value of the attenuation in the lighting equation that is constant.")]
		[Required()]
		public IfcReal ConstantAttenuation { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Definition from ISO/CD 10303-46:1992: This real indicates the value of the attenuation in the lighting equation that proportional to the distance from the light source.")]
		[Required()]
		public IfcReal DistanceAttenuation { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("This real indicates the value of the attenuation in the lighting equation that proportional to the square value of the distance from the light source.")]
		[Required()]
		public IfcReal QuadricAttenuation { get; set; }
	
	
		public IfcLightSourcePositional(IfcColourRgb lightColour, IfcCartesianPoint position, IfcPositiveLengthMeasure radius, IfcReal constantAttenuation, IfcReal distanceAttenuation, IfcReal quadricAttenuation)
			: base(lightColour)
		{
			this.Position = position;
			this.Radius = radius;
			this.ConstantAttenuation = constantAttenuation;
			this.DistanceAttenuation = distanceAttenuation;
			this.QuadricAttenuation = quadricAttenuation;
		}
	
	
	}
	
}
