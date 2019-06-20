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


namespace BuildingSmart.IFC.IfcMaterialResource
{
	[Guid("4d56e169-ce56-415e-908a-f24a0197eb76")]
	public partial struct IfcCardinalPointReference
	{
		[XmlText]
		public Int64 Value { get; private set; }
	
		public IfcCardinalPointReference(Int64 value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcCardinalPointReference(Int64 value)
		{
			return new IfcCardinalPointReference(value);
		}
	
		public static implicit operator Int64(IfcCardinalPointReference value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
