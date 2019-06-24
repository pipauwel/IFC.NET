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
	[Guid("1386f6f9-f668-4418-9168-55d106724177")]
	public partial class IfcBoundaryNodeCondition : IfcBoundaryCondition
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Linear stiffness value in x-direction of the coordinate system defined by the instance which uses this resource object.")]
		public IfcLinearStiffnessMeasure? LinearStiffnessX { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Linear stiffness value in y-direction of the coordinate system defined by the instance which uses this resource object.")]
		public IfcLinearStiffnessMeasure? LinearStiffnessY { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Linear stiffness value in z-direction of the coordinate system defined by the instance which uses this resource object.")]
		public IfcLinearStiffnessMeasure? LinearStiffnessZ { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Rotational stiffness value about the x-axis of the coordinate system defined by the instance which uses this resource object.")]
		public IfcRotationalStiffnessMeasure? RotationalStiffnessX { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Rotational stiffness value about the y-axis of the coordinate system defined by the instance which uses this resource object.")]
		public IfcRotationalStiffnessMeasure? RotationalStiffnessY { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("Rotational stiffness value about the z-axis of the coordinate system defined by the instance which uses this resource object.")]
		public IfcRotationalStiffnessMeasure? RotationalStiffnessZ { get; set; }
	
	
		public IfcBoundaryNodeCondition()
		{
		}
	
	
	}
	
}
