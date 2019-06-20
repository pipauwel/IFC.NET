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
	[Guid("bda0f4ee-5054-43de-9687-1cb9f5d258f3")]
	public partial struct IfcRatioMeasure :
		IfcMeasureValue,
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcSizeSelect,
		BuildingSmart.IFC.IfcDateTimeResource.IfcTimeOrRatioSelect
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
