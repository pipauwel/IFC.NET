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
	[Guid("b2ac2bfe-0bb6-4b03-9fab-c94b736ac935")]
	public partial struct IfcAngularVelocityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcAngularVelocityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcAngularVelocityMeasure(Double value)
		{
			return new IfcAngularVelocityMeasure(value);
		}
	
		public static implicit operator Double(IfcAngularVelocityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
