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


namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("d5a72992-5672-4281-bb31-ce25d74519d4")]
	public partial struct IfcPropertySetDefinitionSet :
		IfcPropertySetDefinitionSelect
	{
		[XmlText]
		public IfcPropertySetDefinition Value { get; private set; }
	
		public IfcPropertySetDefinitionSet(IfcPropertySetDefinition value) : this()
		{
			this.Value = value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
