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
	[Guid("1f50642d-91d9-482e-88d6-43da661b053f")]
	public partial struct IfcHourInDay
	{
		[XmlText]
		public Int64 Value { get; private set; }
	
		public IfcHourInDay(Int64 value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcHourInDay(Int64 value)
		{
			return new IfcHourInDay(value);
		}
	
		public static implicit operator Int64(IfcHourInDay value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
