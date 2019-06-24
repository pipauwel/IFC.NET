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
	[Guid("69d44c42-bcae-4b9a-858e-97f4d46a97ec")]
	public partial struct IfcPositivePlaneAngleMeasure :
		IfcMeasureValue
	{
		[XmlText]
		public IfcPlaneAngleMeasure Value { get; private set; }
	
		public IfcPositivePlaneAngleMeasure(IfcPlaneAngleMeasure value) : this()
		{
			this.Value = value;
		}
	
		public IfcPositivePlaneAngleMeasure(Double value) : this()
		{
			this.Value = new IfcPlaneAngleMeasure(value);
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
