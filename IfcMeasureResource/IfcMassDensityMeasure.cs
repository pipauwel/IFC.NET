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
	[Guid("3de62867-cb19-4444-b113-83f70de5daad")]
	public partial struct IfcMassDensityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcMassDensityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcMassDensityMeasure(Double value)
		{
			return new IfcMassDensityMeasure(value);
		}
	
		public static implicit operator Double(IfcMassDensityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
