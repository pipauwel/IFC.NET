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
	[Guid("4a4aadf5-9898-429b-8d62-df88761b599d")]
	public partial struct IfcShearModulusMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcShearModulusMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcShearModulusMeasure(Double value)
		{
			return new IfcShearModulusMeasure(value);
		}
	
		public static implicit operator Double(IfcShearModulusMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
