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
	[Guid("dfa04fa0-8256-470a-a86f-3b979a7ed69e")]
	public partial struct IfcTemperatureGradientMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcTemperatureGradientMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcTemperatureGradientMeasure(Double value)
		{
			return new IfcTemperatureGradientMeasure(value);
		}
	
		public static implicit operator Double(IfcTemperatureGradientMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
