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
	[Guid("4e2569b1-6ae8-47ca-8bc2-23920a37fbd8")]
	public partial struct IfcDuration :
		BuildingSmart.IFC.IfcMeasureResource.IfcSimpleValue,
		IfcTimeOrRatioSelect
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcDuration(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcDuration(String value)
		{
			if (value == null)
				return null;
	
			return new IfcDuration(value);
		}
	
		public static implicit operator String(IfcDuration value)
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
