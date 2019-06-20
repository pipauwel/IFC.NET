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
	[Guid("e3299706-7a2b-4061-b892-2367a0b2f9cd")]
	public partial struct IfcKinematicViscosityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcKinematicViscosityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcKinematicViscosityMeasure(Double value)
		{
			return new IfcKinematicViscosityMeasure(value);
		}
	
		public static implicit operator Double(IfcKinematicViscosityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
