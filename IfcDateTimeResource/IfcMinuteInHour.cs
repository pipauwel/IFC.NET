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
	[Guid("946a6db8-f79d-4749-802d-7079624d173e")]
	public partial struct IfcMinuteInHour
	{
		[XmlText]
		public Int64 Value { get; private set; }
	
		public IfcMinuteInHour(Int64 value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcMinuteInHour(Int64 value)
		{
			return new IfcMinuteInHour(value);
		}
	
		public static implicit operator Int64(IfcMinuteInHour value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
