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
	[Guid("1cbccaa8-8e20-4d76-9a62-7ecdf4b693f0")]
	public partial struct IfcSpecularExponent :
		IfcSpecularHighlightSelect
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcSpecularExponent(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcSpecularExponent(Double value)
		{
			return new IfcSpecularExponent(value);
		}
	
		public static implicit operator Double(IfcSpecularExponent value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
