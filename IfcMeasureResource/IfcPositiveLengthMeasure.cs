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
	[Guid("476306ae-1d08-4e27-a80e-af066c396aaa")]
	public partial struct IfcPositiveLengthMeasure :
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcHatchLineDistanceSelect,
		IfcMeasureValue,
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcSizeSelect
	{
		[XmlText]
		public IfcLengthMeasure Value { get; private set; }
	
		public IfcPositiveLengthMeasure(IfcLengthMeasure value) : this()
		{
			this.Value = value;
		}
	
		public IfcPositiveLengthMeasure(Double value) : this()
		{
			this.Value = new IfcLengthMeasure(value);
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
