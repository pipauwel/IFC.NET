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


namespace BuildingSmart.IFC.IfcExternalReferenceResource
{
	[Guid("a42d2807-6ecc-4243-9ce7-adeb1950089a")]
	public partial struct IfcURIReference
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcURIReference(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcURIReference(String value)
		{
			if (value == null)
				return null;
	
			return new IfcURIReference(value);
		}
	
		public static implicit operator String(IfcURIReference value)
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
