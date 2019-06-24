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
	[Guid("94feb80e-1e13-405a-8975-53cc85817646")]
	public partial struct IfcVolumeMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcVolumeMeasure(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcVolumeMeasure(Double value)
		{
			return new IfcVolumeMeasure(value);
		}
	
		public static implicit operator Double(IfcVolumeMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
