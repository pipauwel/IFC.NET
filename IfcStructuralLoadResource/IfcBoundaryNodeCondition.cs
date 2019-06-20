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
	[Guid("0454a0f4-fdfb-4856-bad8-c1a1202137d1")]
	public partial class IfcBoundaryNodeCondition : IfcBoundaryCondition
	{
		[DataMember(Order = 0)] 
		[Description("Translational stiffness value in x-direction of the coordinate system defined by the instance which uses this resource object.")]
		public IfcTranslationalStiffnessSelect TranslationalStiffnessX { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Translational stiffness value in y-direction of the coordinate system defined by the instance which uses this resource object.")]
		public IfcTranslationalStiffnessSelect TranslationalStiffnessY { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("Translational stiffness value in z-direction of the coordinate system defined by the instance which uses this resource object.")]
		public IfcTranslationalStiffnessSelect TranslationalStiffnessZ { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("Rotational stiffness value about the x-axis of the coordinate system defined by the instance which uses this resource object.")]
		public IfcRotationalStiffnessSelect RotationalStiffnessX { get; set; }
	
		[DataMember(Order = 4)] 
		[Description("Rotational stiffness value about the y-axis of the coordinate system defined by the instance which uses this resource object.")]
		public IfcRotationalStiffnessSelect RotationalStiffnessY { get; set; }
	
		[DataMember(Order = 5)] 
		[Description("Rotational stiffness value about the z-axis of the coordinate system defined by the instance which uses this resource object.")]
		public IfcRotationalStiffnessSelect RotationalStiffnessZ { get; set; }
	
	
		public IfcBoundaryNodeCondition()
		{
		}
	
	
	}
	
}
