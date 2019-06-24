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
	[Guid("d6a01043-67e3-44ca-af7e-8083992016d5")]
	public partial class IfcConnectionPointEccentricity : IfcConnectionPointGeometry
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  Distance in x direction between the two points (or vertex points) engaged in the point connection.  </EPM-HTML>")]
		public IfcLengthMeasure? EccentricityInX { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  Distance in y direction between the two points (or vertex points) engaged in the point connection.  </EPM-HTML>")]
		public IfcLengthMeasure? EccentricityInY { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  Distance in z direction between the two points (or vertex points) engaged in the point connection.  </EPM-HTML>")]
		public IfcLengthMeasure? EccentricityInZ { get; set; }
	
	
		public IfcConnectionPointEccentricity(IfcPointOrVertexPoint pointOnRelatingElement)
			: base(pointOnRelatingElement)
		{
		}
	
	
	}
	
}
