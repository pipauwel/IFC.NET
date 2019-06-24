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
	[Guid("e975dcb3-8d32-43fe-8db4-61a89c5a4da9")]
	public partial struct IfcThermalAdmittanceMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcThermalAdmittanceMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcThermalAdmittanceMeasure(Double value)
		{
			return new IfcThermalAdmittanceMeasure(value);
		}
	
		public static implicit operator Double(IfcThermalAdmittanceMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
