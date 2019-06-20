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
	[Guid("815d41cd-035f-4317-9f9e-5af33389091f")]
	public partial struct IfcWarpingMomentMeasure :
		IfcDerivedMeasureValue,
		BuildingSmart.IFC.IfcStructuralLoadResource.IfcWarpingStiffnessSelect
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcWarpingMomentMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcWarpingMomentMeasure(Double value)
		{
			return new IfcWarpingMomentMeasure(value);
		}
	
		public static implicit operator Double(IfcWarpingMomentMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
