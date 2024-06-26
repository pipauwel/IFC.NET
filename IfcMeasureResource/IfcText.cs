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
	[Guid("f35610cd-065e-4917-84ec-747793b4f51e")]
	public partial struct IfcText :
		BuildingSmart.IFC.IfcConstraintResource.IfcMetricValueSelect,
		IfcSimpleValue
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcText(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcText(String value)
		{
			if (value == null)
				return null;
	
			return new IfcText(value);
		}
	
		public static implicit operator String(IfcText value)
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
