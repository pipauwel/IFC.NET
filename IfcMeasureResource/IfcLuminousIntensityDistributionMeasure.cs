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
	[Guid("de87fba8-a4bf-4214-8560-734217e4d451")]
	public partial struct IfcLuminousIntensityDistributionMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcLuminousIntensityDistributionMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcLuminousIntensityDistributionMeasure(Double value)
		{
			return new IfcLuminousIntensityDistributionMeasure(value);
		}
	
		public static implicit operator Double(IfcLuminousIntensityDistributionMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
