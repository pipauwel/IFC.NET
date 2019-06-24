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
	[Guid("716c87db-2649-40b7-87ab-cd548df4a969")]
	public partial struct IfcMolecularWeightMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcMolecularWeightMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcMolecularWeightMeasure(Double value)
		{
			return new IfcMolecularWeightMeasure(value);
		}
	
		public static implicit operator Double(IfcMolecularWeightMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
