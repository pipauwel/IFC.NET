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
	[Guid("49fff44a-390a-40ad-8d04-fd1ff8538dd7")]
	public partial struct IfcPresentableText
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcPresentableText(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcPresentableText(String value)
		{
			if (value == null)
				return null;
	
			return new IfcPresentableText(value);
		}
	
		public static implicit operator String(IfcPresentableText value)
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
