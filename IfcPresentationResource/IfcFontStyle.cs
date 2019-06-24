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
	[Guid("5873bd53-48e6-4410-990d-e60c4bc0fd3f")]
	public partial struct IfcFontStyle
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcFontStyle(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcFontStyle(String value)
		{
			if (value == null)
				return null;
	
			return new IfcFontStyle(value);
		}
	
		public static implicit operator String(IfcFontStyle value)
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
