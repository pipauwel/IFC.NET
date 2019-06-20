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
	[Guid("3bb00789-25bf-4fc4-a8fa-d4282e28b0bc")]
	public partial struct IfcNormalisedRatioMeasure :
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcColourOrFactor,
		IfcMeasureValue,
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcSizeSelect
	{
		[XmlText]
		public IfcRatioMeasure Value { get; private set; }
	
		public IfcNormalisedRatioMeasure(IfcRatioMeasure value) : this()
		{
			this.Value = value;
		}
	
		public IfcNormalisedRatioMeasure(Double value) : this()
		{
			this.Value = new IfcRatioMeasure(value);
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
