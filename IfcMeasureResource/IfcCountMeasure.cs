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
	[Guid("45cf17c0-0078-40d2-855f-11ff05224b61")]
	public partial struct IfcCountMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public Decimal Value { get; private set; }
	
		public IfcCountMeasure(Decimal value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcCountMeasure(Decimal value)
		{
			return new IfcCountMeasure(value);
		}
	
		public static implicit operator Decimal(IfcCountMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
