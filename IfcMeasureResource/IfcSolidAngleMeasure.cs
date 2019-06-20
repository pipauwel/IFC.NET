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
	[Guid("8e327814-bf64-445b-8c48-498c363d28dc")]
	public partial struct IfcSolidAngleMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcSolidAngleMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcSolidAngleMeasure(Double value)
		{
			return new IfcSolidAngleMeasure(value);
		}
	
		public static implicit operator Double(IfcSolidAngleMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
