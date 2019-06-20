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
	[Guid("c561b140-ae11-4c30-a795-c1dddbbb9710")]
	public partial struct IfcNonNegativeLengthMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public IfcLengthMeasure Value { get; private set; }
	
		public IfcNonNegativeLengthMeasure(IfcLengthMeasure value) : this()
		{
			this.Value = value;
		}
	
		public IfcNonNegativeLengthMeasure(Double value) : this()
		{
			this.Value = new IfcLengthMeasure(value);
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
