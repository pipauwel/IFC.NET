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
	[Guid("a5a5e840-ed08-4a81-8d77-486cb6715f70")]
	public partial struct IfcElectricCapacitanceMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcElectricCapacitanceMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcElectricCapacitanceMeasure(Double value)
		{
			return new IfcElectricCapacitanceMeasure(value);
		}
	
		public static implicit operator Double(IfcElectricCapacitanceMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
