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


namespace BuildingSmart.IFC.IfcDateTimeResource
{
	[Guid("64ce4875-50fa-4b22-8f72-2fb65d537d04")]
	public partial struct IfcSecondInMinute
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcSecondInMinute(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcSecondInMinute(Double value)
		{
			return new IfcSecondInMinute(value);
		}
	
		public static implicit operator Double(IfcSecondInMinute value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
