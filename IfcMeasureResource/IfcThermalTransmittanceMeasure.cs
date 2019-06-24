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
	[Guid("b7163a2b-e700-456c-8bff-3d369a6f4d39")]
	public partial struct IfcThermalTransmittanceMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcThermalTransmittanceMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcThermalTransmittanceMeasure(Double value)
		{
			return new IfcThermalTransmittanceMeasure(value);
		}
	
		public static implicit operator Double(IfcThermalTransmittanceMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
