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
	[Guid("794cd420-c8fb-4cb5-b42f-c5131a0795d4")]
	public partial struct IfcDynamicViscosityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcDynamicViscosityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcDynamicViscosityMeasure(Double value)
		{
			return new IfcDynamicViscosityMeasure(value);
		}
	
		public static implicit operator Double(IfcDynamicViscosityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
