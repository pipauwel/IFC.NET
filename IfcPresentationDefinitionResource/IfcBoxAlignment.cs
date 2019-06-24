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

namespace BuildingSmart.IFC.IfcPresentationDefinitionResource
{
	[Guid("1c75ac11-6420-4057-9787-48ceb2a433d9")]
	public partial struct IfcBoxAlignment
	{
		[XmlText]
		public IfcLabel Value { get; private set; }
	
		public IfcBoxAlignment(IfcLabel value) : this()
		{
			this.Value = value;
		}
	
		public IfcBoxAlignment(String value) : this()
		{
			this.Value = new IfcLabel(value);
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
