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
	[Guid("c4a10f03-9492-44dd-983b-fe5bd85a0184")]
	public partial struct IfcTemperatureRateOfChangeMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcTemperatureRateOfChangeMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcTemperatureRateOfChangeMeasure(Double value)
		{
			return new IfcTemperatureRateOfChangeMeasure(value);
		}
	
		public static implicit operator Double(IfcTemperatureRateOfChangeMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
