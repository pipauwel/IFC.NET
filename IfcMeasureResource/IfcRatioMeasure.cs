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
	[Guid("40b33d00-3d4e-461b-ac16-d6b46e44d920")]
	public partial struct IfcRatioMeasure :
		BuildingSmart.IFC.IfcCostResource.IfcAppliedValueSelect,
		IfcMeasureValue,
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcSizeSelect
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcRatioMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcRatioMeasure(Double value)
		{
			return new IfcRatioMeasure(value);
		}
	
		public static implicit operator Double(IfcRatioMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
