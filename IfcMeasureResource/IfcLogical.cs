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
	[Guid("1f5e1412-afec-42ef-ad7d-6ede2efbbd03")]
	public partial struct IfcLogical :
		IfcSimpleValue
	{
		[XmlText]
		public Boolean? Value { get; private set; }
	
		public IfcLogical(Boolean? value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcLogical(Boolean? value)
		{
			return new IfcLogical(value);
		}
	
		public static implicit operator Boolean?(IfcLogical value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
