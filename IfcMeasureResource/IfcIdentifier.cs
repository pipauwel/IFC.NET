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
	[Guid("c8b5fa3f-462a-4041-b3fb-2bc28c491abd")]
	public partial struct IfcIdentifier :
		IfcSimpleValue
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcIdentifier(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcIdentifier(String value)
		{
			if (value == null)
				return null;
	
			return new IfcIdentifier(value);
		}
	
		public static implicit operator String(IfcIdentifier value)
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
