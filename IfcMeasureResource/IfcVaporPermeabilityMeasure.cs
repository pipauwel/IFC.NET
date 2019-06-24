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
	[Guid("e6669694-c503-4222-97a6-04b93e328dcd")]
	public partial struct IfcVaporPermeabilityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcVaporPermeabilityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcVaporPermeabilityMeasure(Double value)
		{
			return new IfcVaporPermeabilityMeasure(value);
		}
	
		public static implicit operator Double(IfcVaporPermeabilityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
