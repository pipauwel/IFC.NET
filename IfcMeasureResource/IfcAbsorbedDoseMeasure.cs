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
	[Guid("305f4271-ce1e-49a5-9d16-74691a858544")]
	public partial struct IfcAbsorbedDoseMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcAbsorbedDoseMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcAbsorbedDoseMeasure(Double value)
		{
			return new IfcAbsorbedDoseMeasure(value);
		}
	
		public static implicit operator Double(IfcAbsorbedDoseMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
