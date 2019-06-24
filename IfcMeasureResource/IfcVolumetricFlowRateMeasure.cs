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
	[Guid("3080a36b-a84d-4c17-b5bc-716ea318b4b7")]
	public partial struct IfcVolumetricFlowRateMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcVolumetricFlowRateMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcVolumetricFlowRateMeasure(Double value)
		{
			return new IfcVolumetricFlowRateMeasure(value);
		}
	
		public static implicit operator Double(IfcVolumetricFlowRateMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
