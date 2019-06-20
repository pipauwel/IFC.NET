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
	[Guid("41f309c9-a20d-4f1a-a798-a476d2bc5d8c")]
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
