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
	[Guid("d0f92def-fcfc-4e52-866b-b11c2bd3e0c9")]
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
