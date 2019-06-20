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
	[Guid("62b43f5d-3d2b-4f6d-955c-addd375550a8")]
	public partial struct IfcInductanceMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcInductanceMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcInductanceMeasure(Double value)
		{
			return new IfcInductanceMeasure(value);
		}
	
		public static implicit operator Double(IfcInductanceMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
