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
	[Guid("a4ffedba-ccfb-4631-8099-46856ae330fe")]
	public partial struct IfcElectricVoltageMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcElectricVoltageMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcElectricVoltageMeasure(Double value)
		{
			return new IfcElectricVoltageMeasure(value);
		}
	
		public static implicit operator Double(IfcElectricVoltageMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
