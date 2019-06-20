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
	[Guid("5a483f82-8322-48da-b92d-fbd95bd3d269")]
	public partial struct IfcAreaDensityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcAreaDensityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcAreaDensityMeasure(Double value)
		{
			return new IfcAreaDensityMeasure(value);
		}
	
		public static implicit operator Double(IfcAreaDensityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
