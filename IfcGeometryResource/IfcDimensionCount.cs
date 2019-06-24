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


namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("9526e110-3cad-45d5-aab9-c5529255e5b9")]
	public partial struct IfcDimensionCount
	{
		[XmlText]
		public Int64 Value { get; private set; }
	
		public IfcDimensionCount(Int64 value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcDimensionCount(Int64 value)
		{
			return new IfcDimensionCount(value);
		}
	
		public static implicit operator Int64(IfcDimensionCount value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
