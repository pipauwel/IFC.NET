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
	[Guid("1445582b-1b87-4b61-9171-bff80196b02a")]
	public partial struct IfcMonthInYearNumber
	{
		[XmlText]
		public Int64 Value { get; private set; }
	
		public IfcMonthInYearNumber(Int64 value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcMonthInYearNumber(Int64 value)
		{
			return new IfcMonthInYearNumber(value);
		}
	
		public static implicit operator Int64(IfcMonthInYearNumber value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
