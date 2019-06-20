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
	[Guid("f1af7fcd-0edf-40fb-b760-e790d3fc9910")]
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
