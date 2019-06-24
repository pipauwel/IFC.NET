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


namespace BuildingSmart.IFC.IfcPresentationAppearanceResource
{
	[Guid("6ad4a56e-ae7d-414b-ae89-68f1d24a89ec")]
	public partial struct IfcSpecularRoughness :
		IfcSpecularHighlightSelect
	{
		[XmlText]
		public Double Value { get; private set; }
	
		public IfcSpecularRoughness(Double value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcSpecularRoughness(Double value)
		{
			return new IfcSpecularRoughness(value);
		}
	
		public static implicit operator Double(IfcSpecularRoughness value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
