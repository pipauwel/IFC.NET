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
	[Guid("b692b10f-f7d1-4266-9dac-836915f26830")]
	public partial struct IfcIntegerCountRateMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Int64 Value { get; private set; }
	
		public IfcIntegerCountRateMeasure(Int64 value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcIntegerCountRateMeasure(Int64 value)
		{
			return new IfcIntegerCountRateMeasure(value);
		}
	
		public static implicit operator Int64(IfcIntegerCountRateMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
