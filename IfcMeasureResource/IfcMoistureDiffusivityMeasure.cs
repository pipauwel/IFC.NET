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
	[Guid("33e04445-94e2-4690-adee-492e33160128")]
	public partial struct IfcMoistureDiffusivityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcMoistureDiffusivityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcMoistureDiffusivityMeasure(Double value)
		{
			return new IfcMoistureDiffusivityMeasure(value);
		}
	
		public static implicit operator Double(IfcMoistureDiffusivityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
