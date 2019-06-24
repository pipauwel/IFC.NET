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
using BuildingSmart.IFC.IfcProfileResource;

namespace BuildingSmart.IFC.IFCPROFILEPROPERTYRESOURCE
{
	[Guid("08eadbb5-12bc-46bb-a1dc-e79ab27d206c")]
	public partial class IfcStructuralSteelProfileProperties : IfcStructuralProfileProperties
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Area of the profile for calculating the shear stress for a shear force parallel to the profiles Z-axis. Usually measured in [mm2].")]
		public IfcAreaMeasure? ShearAreaZ { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Area of the profile for calculating the shear stress for a shear force parallel to the profiles Y-axis. Usually measured in [mm2].")]
		public IfcAreaMeasure? ShearAreaY { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Ratio of plastic versus elastic bending moment capacity (about y-axis) of the profile.")]
		public IfcPositiveRatioMeasure? PlasticShapeFactorY { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Ratio of plastic versus elastic bending moment capacity (about z-axis) of the profile.")]
		public IfcPositiveRatioMeasure? PlasticShapeFactorZ { get; set; }
	
	
		public IfcStructuralSteelProfileProperties()
		{
		}
	
	
	}
	
}
