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
	[Guid("d04cfc70-6990-4fa0-97ee-21ef68d32ca6")]
	public partial struct IfcLabel :
		BuildingSmart.IFC.IFCFACILITIESMGMTDOMAIN.IfcConditionCriterionSelect,
		IfcSimpleValue
	{
		[XmlText]
		public String Value { get; private set; }
	
		public IfcLabel(String value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcLabel(String value)
		{
			if (value == null)
				return null;
	
			return new IfcLabel(value);
		}
	
		public static implicit operator String(IfcLabel value)
		{
			if (value == null)
				return null;
	
			return value.Value;
		}
	
		public override string ToString()
		{
			return (Value == null ? "" : Value.ToString());
		}
	}
	
}
