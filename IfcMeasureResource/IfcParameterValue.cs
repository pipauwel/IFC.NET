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
	[Guid("f8d91fbf-99fa-41a0-aee1-6c80bbeaf7d0")]
	public partial struct IfcParameterValue :
		IfcMeasureValue,
		BuildingSmart.IFC.IfcGeometryResource.IfcTrimmingSelect
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcParameterValue(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcParameterValue(Double value)
		{
			return new IfcParameterValue(value);
		}
	
		public static implicit operator Double(IfcParameterValue value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
