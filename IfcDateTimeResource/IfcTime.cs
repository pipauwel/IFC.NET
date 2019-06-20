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
	[Guid("7fc928bc-ba3f-438e-916f-3879f2396ba1")]
	public partial struct IfcTime :
		BuildingSmart.IFC.IfcMeasureResource.IfcSimpleValue
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcTime(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcTime(String value)
		{
			if (value == null)
				return null;
	
			return new IfcTime(value);
		}
	
		public static implicit operator String(IfcTime value)
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
