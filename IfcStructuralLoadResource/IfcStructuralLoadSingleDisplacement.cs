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

namespace BuildingSmart.IFC.IfcStructuralLoadResource
{
	[Guid("752102ba-0ec1-4d20-a018-53413630fa9a")]
	public partial class IfcStructuralLoadSingleDisplacement : IfcStructuralLoadStatic
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Displacement in x-direction.")]
		public IfcLengthMeasure? DisplacementX { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Displacement in y-direction.")]
		public IfcLengthMeasure? DisplacementY { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Displacement in z-direction.")]
		public IfcLengthMeasure? DisplacementZ { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Rotation about the x-axis.")]
		public IfcPlaneAngleMeasure? RotationalDisplacementRX { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Rotation about the y-axis.")]
		public IfcPlaneAngleMeasure? RotationalDisplacementRY { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("Rotation about the z-axis.")]
		public IfcPlaneAngleMeasure? RotationalDisplacementRZ { get; set; }
	
	
		public IfcStructuralLoadSingleDisplacement()
		{
		}
	
	
	}
	
}
