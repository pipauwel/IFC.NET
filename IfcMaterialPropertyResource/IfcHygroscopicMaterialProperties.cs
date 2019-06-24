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

using BuildingSmart.IFC.IfcMaterialResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IFCMATERIALPROPERTYRESOURCE
{
	[Guid("9d6fd7bc-89ce-47f4-9ad0-b62095ab3561")]
	public partial class IfcHygroscopicMaterialProperties : IfcMaterialProperties
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The vapor permeability relationship of air/material (typically value > 1), measured in high relative humidity (typically in 95/50 % RH).")]
		public IfcPositiveRatioMeasure? UpperVaporResistanceFactor { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The vapor permeability relationship of air/material (typically value > 1), measured in low relative humidity (typically in 0/50 % RH).")]
		public IfcPositiveRatioMeasure? LowerVaporResistanceFactor { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Based on water vapor density, usually measured in [m3/ kg].")]
		public IfcIsothermalMoistureCapacityMeasure? IsothermalMoistureCapacity { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Usually measured in [kg/s m Pa].")]
		public IfcVaporPermeabilityMeasure? VaporPermeability { get; set; }
	
		[DataMember(Order = 4)] 
		[XmlAttribute]
		[Description("Usually measured in [m3/s].")]
		public IfcMoistureDiffusivityMeasure? MoistureDiffusivity { get; set; }
	
	
		public IfcHygroscopicMaterialProperties(IfcMaterial material)
			: base(material)
		{
		}
	
	
	}
	
}
