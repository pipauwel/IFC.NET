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
	[Guid("f1f374d3-630b-4fa4-8d28-8ba29344dcdc")]
	public partial struct IfcRotationalFrequencyMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcRotationalFrequencyMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcRotationalFrequencyMeasure(Double value)
		{
			return new IfcRotationalFrequencyMeasure(value);
		}
	
		public static implicit operator Double(IfcRotationalFrequencyMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
