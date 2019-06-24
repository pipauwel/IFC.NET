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
	[Guid("ae93fb0f-25aa-4fb3-8339-d3e089fa5951")]
	public partial struct IfcRotationalStiffnessMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcRotationalStiffnessMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcRotationalStiffnessMeasure(Double value)
		{
			return new IfcRotationalStiffnessMeasure(value);
		}
	
		public static implicit operator Double(IfcRotationalStiffnessMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
