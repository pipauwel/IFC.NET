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
	[Guid("9e9884aa-8cd6-42e6-b0df-0c7b51b6563c")]
	public partial struct IfcAccelerationMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcAccelerationMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcAccelerationMeasure(Double value)
		{
			return new IfcAccelerationMeasure(value);
		}
	
		public static implicit operator Double(IfcAccelerationMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
