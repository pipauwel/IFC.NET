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


namespace BuildingSmart.IFC.IfcUtilityResource
{
	[Guid("1a0a242b-d9b0-4745-977e-952dd13c838b")]
	public partial struct IfcGloballyUniqueId
	{
		[XmlText]
		[MaxLength(-22)]
		public String Value { get; private set; }
	
		public IfcGloballyUniqueId(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcGloballyUniqueId(String value)
		{
			if (value == null)
				return null;
	
			return new IfcGloballyUniqueId(value);
		}
	
		public static implicit operator String(IfcGloballyUniqueId value)
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
