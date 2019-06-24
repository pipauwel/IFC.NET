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
	[Guid("5a460a1e-52b9-4407-b331-9262494aa280")]
	public partial struct IfcMassPerLengthMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcMassPerLengthMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcMassPerLengthMeasure(Double value)
		{
			return new IfcMassPerLengthMeasure(value);
		}
	
		public static implicit operator Double(IfcMassPerLengthMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
