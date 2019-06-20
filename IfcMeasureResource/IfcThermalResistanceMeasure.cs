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


namespace BuildingSmart.IFC.IfcMeasureResource
{
	[Guid("d98e2dd4-c054-4f6e-b2eb-d1e8fec8853e")]
	public partial struct IfcThermalResistanceMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcThermalResistanceMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcThermalResistanceMeasure(Double value)
		{
			return new IfcThermalResistanceMeasure(value);
		}
	
		public static implicit operator Double(IfcThermalResistanceMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
