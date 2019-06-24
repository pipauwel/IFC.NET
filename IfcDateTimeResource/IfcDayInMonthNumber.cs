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
	[Guid("c6cfa9c8-b673-4bcf-8da4-ece7aa2cc686")]
	public partial struct IfcDayInMonthNumber
	{
		[XmlText]
		public Int64 Value { get; private set; }
	
		public IfcDayInMonthNumber(Int64 value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcDayInMonthNumber(Int64 value)
		{
			return new IfcDayInMonthNumber(value);
		}
	
		public static implicit operator Int64(IfcDayInMonthNumber value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
