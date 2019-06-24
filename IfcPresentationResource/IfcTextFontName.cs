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
	[Guid("9ed3db43-5ec9-4368-ae09-0635e3bec9fe")]
	public partial struct IfcTextFontName
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcTextFontName(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcTextFontName(String value)
		{
			if (value == null)
				return null;
	
			return new IfcTextFontName(value);
		}
	
		public static implicit operator String(IfcTextFontName value)
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
