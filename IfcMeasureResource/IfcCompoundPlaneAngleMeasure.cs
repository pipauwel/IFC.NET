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
	[Guid("6b5c667d-bed9-4b77-ba0b-039cef56680c")]
	public partial struct IfcCompoundPlaneAngleMeasure :
		IfcDerivedMeasureValue
	{
		[XmlText]
		public Int64 Value { get; private set; }
	
		public IfcCompoundPlaneAngleMeasure(Int64 value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcCompoundPlaneAngleMeasure(Int64 value)
		{
			return new IfcCompoundPlaneAngleMeasure(value);
		}
	
		public static implicit operator Int64(IfcCompoundPlaneAngleMeasure value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
