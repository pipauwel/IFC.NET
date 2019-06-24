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


namespace BuildingSmart.IFC.IfcPresentationResource
{
	[Guid("18a5b5b7-aac5-46d0-8d9b-f873ed5ebf81")]
	public partial struct IfcFontVariant
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcFontVariant(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcFontVariant(String value)
		{
			if (value == null)
				return null;
	
			return new IfcFontVariant(value);
		}
	
		public static implicit operator String(IfcFontVariant value)
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
