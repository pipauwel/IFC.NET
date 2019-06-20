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
	[Guid("155e77e5-f61e-487c-9e36-b6255b586646")]
	public partial struct IfcDayInWeekNumber
	{
		[XmlText]
		public Int64 Value { get; private set; }
	
		public IfcDayInWeekNumber(Int64 value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcDayInWeekNumber(Int64 value)
		{
			return new IfcDayInWeekNumber(value);
		}
	
		public static implicit operator Int64(IfcDayInWeekNumber value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
