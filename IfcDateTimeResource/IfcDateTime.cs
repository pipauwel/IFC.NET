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


namespace BuildingSmart.IFC.IfcDateTimeResource
{
	[Guid("5d20f1df-868d-4116-9bde-ed1cf033eccc")]
	public partial struct IfcDateTime :
		BuildingSmart.IFC.IfcMeasureResource.IfcSimpleValue
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcDateTime(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcDateTime(String value)
		{
			if (value == null)
				return null;
	
			return new IfcDateTime(value);
		}
	
		public static implicit operator String(IfcDateTime value)
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
