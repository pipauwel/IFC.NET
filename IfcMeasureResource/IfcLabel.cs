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
	[Guid("6b63cdf3-e884-464a-b95f-0d11f0ec118d")]
	public partial struct IfcLabel :
		IfcSimpleValue
	{
		[XmlText]
		[MaxLength(255)]
		public String Value { get; private set; }
	
		public IfcLabel(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcLabel(String value)
		{
			if (value == null)
				return null;
	
			return new IfcLabel(value);
		}
	
		public static implicit operator String(IfcLabel value)
		{
			if (value == null)
				return null;
	
			return value.Value;
		}
	
		public override string ToString()
		{
			return (Value == null ? "" : Value.ToString());
		}
	}
	
}
