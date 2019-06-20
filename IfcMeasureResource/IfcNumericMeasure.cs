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
	[Guid("2e99a2de-5976-4fb7-9671-b95ab8c69523")]
	public partial struct IfcNumericMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public Decimal Value { get; private set; }
	
		public IfcNumericMeasure(Decimal value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcNumericMeasure(Decimal value)
		{
			return new IfcNumericMeasure(value);
		}
	
		public static implicit operator Decimal(IfcNumericMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
