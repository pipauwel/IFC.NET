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
	[Guid("2329352f-c331-4f44-b7f5-81e08b340810")]
	public partial struct IfcEnergyMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcEnergyMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcEnergyMeasure(Double value)
		{
			return new IfcEnergyMeasure(value);
		}
	
		public static implicit operator Double(IfcEnergyMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
