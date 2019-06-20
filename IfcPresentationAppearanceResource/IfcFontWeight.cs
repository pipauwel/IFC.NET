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


namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("bce759cd-c6d9-46b7-a8a9-b61c08dd5f34")]
	public partial struct IfcFontWeight
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcFontWeight(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcFontWeight(String value)
		{
			if (value == null)
				return null;
	
			return new IfcFontWeight(value);
		}
	
		public static implicit operator String(IfcFontWeight value)
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
