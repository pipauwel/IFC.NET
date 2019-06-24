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
	[Guid("fd699225-962a-43ea-b5dc-bfb8e58d587a")]
	public partial struct IfcHeatingValueMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcHeatingValueMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcHeatingValueMeasure(Double value)
		{
			return new IfcHeatingValueMeasure(value);
		}
	
		public static implicit operator Double(IfcHeatingValueMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
