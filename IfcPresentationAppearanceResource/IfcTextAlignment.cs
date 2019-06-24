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
	[Guid("d2f159b6-07c8-4270-acd5-45480fa78dde")]
	public partial struct IfcTextAlignment
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcTextAlignment(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcTextAlignment(String value)
		{
			if (value == null)
				return null;
	
			return new IfcTextAlignment(value);
		}
	
		public static implicit operator String(IfcTextAlignment value)
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
