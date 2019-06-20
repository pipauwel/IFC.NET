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
	[Guid("76ac30d4-4f7a-4b0f-baa3-842d8322a117")]
	public partial struct IfcThermalConductivityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcThermalConductivityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcThermalConductivityMeasure(Double value)
		{
			return new IfcThermalConductivityMeasure(value);
		}
	
		public static implicit operator Double(IfcThermalConductivityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
