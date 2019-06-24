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
	[Guid("ad604730-5fbf-45b9-8538-be203cc7439d")]
	public partial struct IfcLinearVelocityMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcLinearVelocityMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcLinearVelocityMeasure(Double value)
		{
			return new IfcLinearVelocityMeasure(value);
		}
	
		public static implicit operator Double(IfcLinearVelocityMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
