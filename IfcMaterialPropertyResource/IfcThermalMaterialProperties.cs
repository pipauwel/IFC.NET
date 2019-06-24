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
	[Guid("82ee30bf-1000-431a-ab5c-326d65e8e250")]
	public partial class IfcThermalMaterialProperties : IfcMaterialProperties
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Defines the specific heat of the material: heat energy absorbed per  temperature unit. Usually measured in [J/kg K].")]
		public IfcSpecificHeatCapacityMeasure? SpecificHeatCapacity { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The boiling point of the material (fluid). Usually measured in Kelvin.")]
		public IfcThermodynamicTemperatureMeasure? BoilingPoint { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The freezing point of the material (fluid). Usually measured in Kelvin.")]
		public IfcThermodynamicTemperatureMeasure? FreezingPoint { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The rate at which thermal energy is transmitted through the material.Usually in [W/m K].")]
		public IfcThermalConductivityMeasure? ThermalConductivity { get; set; }
	
	
		public IfcThermalMaterialProperties(IfcMaterial material)
			: base(material)
		{
		}
	
	
	}
	
}
