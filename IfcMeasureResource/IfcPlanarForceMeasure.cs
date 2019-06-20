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
	[Guid("eeb7519b-52a1-456e-96ff-ef72e17ac74f")]
	public partial struct IfcPlanarForceMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcPlanarForceMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcPlanarForceMeasure(Double value)
		{
			return new IfcPlanarForceMeasure(value);
		}
	
		public static implicit operator Double(IfcPlanarForceMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
