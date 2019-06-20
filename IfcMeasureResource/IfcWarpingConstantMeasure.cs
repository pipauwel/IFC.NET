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
	[Guid("136dab93-c904-47cf-a447-d2c90c456f8d")]
	public partial struct IfcWarpingConstantMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcWarpingConstantMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcWarpingConstantMeasure(Double value)
		{
			return new IfcWarpingConstantMeasure(value);
		}
	
		public static implicit operator Double(IfcWarpingConstantMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
