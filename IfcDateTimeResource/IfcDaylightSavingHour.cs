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
	[Guid("20ae0f87-3185-4acb-85a7-2a854f3f6820")]
	public partial struct IfcDaylightSavingHour
	{
		[XmlText]
		public Int64 Value { get; private set; }
	
		public IfcDaylightSavingHour(Int64 value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcDaylightSavingHour(Int64 value)
		{
			return new IfcDaylightSavingHour(value);
		}
	
		public static implicit operator Int64(IfcDaylightSavingHour value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
