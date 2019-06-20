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

using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcGeometryResource
{
	[Guid("71ff2a67-6250-4d5e-9756-9ffa2c51aec5")]
	public partial struct IfcArcIndex :
		IfcSegmentIndexSelect
	{
		[XmlText]
		public IfcPositiveInteger Value { get; private set; }
	
		public IfcArcIndex(IfcPositiveInteger value) : this()
		{
			this.Value = value;
		}
	
		public IfcArcIndex(IfcInteger value) : this()
		{
			this.Value = new IfcPositiveInteger(value);
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
