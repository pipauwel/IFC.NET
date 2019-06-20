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
	[Guid("e3b528c2-0baa-4a60-a0fb-c38630b874c6")]
	public partial struct IfcMassFlowRateMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcMassFlowRateMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcMassFlowRateMeasure(Double value)
		{
			return new IfcMassFlowRateMeasure(value);
		}
	
		public static implicit operator Double(IfcMassFlowRateMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
