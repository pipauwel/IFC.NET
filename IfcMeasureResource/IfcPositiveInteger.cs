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
	[Guid("b8fda749-c537-47d2-8f9c-2a65f3604a3d")]
	public partial struct IfcPositiveInteger :
		IfcSimpleValue
	{
		[XmlText]
		public IfcInteger Value { get; private set; }
	
		public IfcPositiveInteger(IfcInteger value) : this()
		{
			this.Value = value;
		}
	
		public IfcPositiveInteger(Int64 value) : this()
		{
			this.Value = new IfcInteger(value);
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
