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
	[Guid("dcd8e1d1-0c2f-4576-8716-1192e38d5738")]
	public partial struct IfcTextTransformation
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcTextTransformation(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcTextTransformation(String value)
		{
			if (value == null)
				return null;
	
			return new IfcTextTransformation(value);
		}
	
		public static implicit operator String(IfcTextTransformation value)
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
