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
	[Guid("d81e9c4a-ace7-4741-8aca-d40d3fca27b2")]
	public partial struct IfcPlaneAngleMeasure :
		BuildingSmart.IFC.IfcStructuralElementsDomain.IfcBendingParameterSelect,
		IfcMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcPlaneAngleMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcPlaneAngleMeasure(Double value)
		{
			return new IfcPlaneAngleMeasure(value);
		}
	
		public static implicit operator Double(IfcPlaneAngleMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
