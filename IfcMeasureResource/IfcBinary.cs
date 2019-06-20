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
	[Guid("49732fd6-d5d7-4faf-a19b-eb2525e3c427")]
	public partial struct IfcBinary :
		IfcSimpleValue
	{
		[XmlText]
		public Byte[] Value { get; private set; }
	
		public IfcBinary(Byte[] value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcBinary(Byte[] value)
		{
			return new IfcBinary(value);
		}
	
		public static implicit operator Byte[](IfcBinary value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
