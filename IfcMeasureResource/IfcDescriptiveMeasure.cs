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
	[Guid("38a6308b-2afb-401f-ae51-e54be4bd8189")]
	public partial struct IfcDescriptiveMeasure :
		IfcMeasureValue,
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcSizeSelect
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcDescriptiveMeasure(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcDescriptiveMeasure(String value)
		{
			if (value == null)
				return null;
	
			return new IfcDescriptiveMeasure(value);
		}
	
		public static implicit operator String(IfcDescriptiveMeasure value)
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
