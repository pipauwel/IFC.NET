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
	[Guid("b071348d-3e08-4ae1-a193-ba601f2ab26a")]
	public partial struct IfcRotationalStiffnessMeasure :
		IfcDerivedMeasureValue,
		BuildingSmart.IFC.IfcStructuralLoadResource.IfcRotationalStiffnessSelect
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcRotationalStiffnessMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcRotationalStiffnessMeasure(Double value)
		{
			return new IfcRotationalStiffnessMeasure(value);
		}
	
		public static implicit operator Double(IfcRotationalStiffnessMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
