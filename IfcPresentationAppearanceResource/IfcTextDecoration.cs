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
	[Guid("e7115d92-04c1-4f17-8823-3b90ddad5416")]
	public partial struct IfcTextDecoration
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcTextDecoration(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcTextDecoration(String value)
		{
			if (value == null)
				return null;
	
			return new IfcTextDecoration(value);
		}
	
		public static implicit operator String(IfcTextDecoration value)
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
