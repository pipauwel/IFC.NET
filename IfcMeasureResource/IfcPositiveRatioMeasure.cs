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
	[Guid("fc6f2655-8440-444a-aa02-bd5e874e526c")]
	public partial struct IfcPositiveRatioMeasure :
		IfcMeasureValue,
		BuildingSmart.IFC.IfcPresentationAppearanceResource.IfcSizeSelect
	{
		[XmlText]
		public IfcRatioMeasure Value { get; private set; }
	
		public IfcPositiveRatioMeasure(IfcRatioMeasure value) : this()
		{
			this.Value = value;
		}
	
		public IfcPositiveRatioMeasure(Double value) : this()
		{
			this.Value = new IfcRatioMeasure(value);
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
