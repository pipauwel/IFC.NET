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
	[Guid("ea72903a-e218-4de1-961b-c00824a4625c")]
	public partial class IfcRectangularPyramid : IfcCsgPrimitive3D
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  The length of the base measured along the placement X axis. It is provided by the inherited axis placement through <i>SELF\\IfcCsgPrimitive3D.Position.P[1]</i>.  </EPM-HTML>")]
		[Required()]
		public IfcPositiveLengthMeasure XLength { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  The length of the base measured along the placement Y axis. It is provided by the inherited axis placement through <i>SELF\\IfcCsgPrimitive3D.Position.P[2]</i>.  </EPM-HTML>")]
		[Required()]
		public IfcPositiveLengthMeasure YLength { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  The height of the apex above the plane of the base, measured in the direction of the placement Z axis, the <i>SELF\\IfcCsgPrimitive3D.Position.P[2]</i>.  </EPM-HTML>")]
		[Required()]
		public IfcPositiveLengthMeasure Height { get; set; }
	
	
		public IfcRectangularPyramid(IfcAxis2Placement3D position, IfcPositiveLengthMeasure xLength, IfcPositiveLengthMeasure yLength, IfcPositiveLengthMeasure height)
			: base(position)
		{
			this.XLength = xLength;
			this.YLength = yLength;
			this.Height = height;
		}
	
	
	}
	
}
