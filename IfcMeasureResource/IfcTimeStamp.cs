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


namespace BuildingSmart.IFC.IfcMeasureResource
{
	[Guid("3f4dfbaf-41cb-4f8a-b6ad-899320390c90")]
	public partial struct IfcTimeStamp :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Int64 Value { get; private set; }
	
		public IfcTimeStamp(Int64 value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcTimeStamp(Int64 value)
		{
			return new IfcTimeStamp(value);
		}
	
		public static implicit operator Int64(IfcTimeStamp value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
