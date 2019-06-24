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
	[Guid("a9ff8add-feac-4853-8092-c9d330767399")]
	public partial struct IfcBoolean :
		IfcSimpleValue
	{
		[XmlText]
		public Boolean Value { get; private set; }
	
		public IfcBoolean(Boolean value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcBoolean(Boolean value)
		{
			return new IfcBoolean(value);
		}
	
		public static implicit operator Boolean(IfcBoolean value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
