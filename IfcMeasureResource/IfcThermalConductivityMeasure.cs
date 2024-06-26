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
	[Guid("edc2a1c6-19da-49ff-bb23-dd1fa042fed4")]
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
