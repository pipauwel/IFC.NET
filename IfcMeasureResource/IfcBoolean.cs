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
	[Guid("6f28babb-8b8b-4b31-a6e3-068bfc20ff6c")]
	public partial struct IfcBoolean :
		BuildingSmart.IFC.IfcStructuralLoadResource.IfcModulusOfRotationalSubgradeReactionSelect,
		BuildingSmart.IFC.IfcStructuralLoadResource.IfcModulusOfSubgradeReactionSelect,
		BuildingSmart.IFC.IfcStructuralLoadResource.IfcModulusOfTranslationalSubgradeReactionSelect,
		BuildingSmart.IFC.IfcStructuralLoadResource.IfcRotationalStiffnessSelect,
		IfcSimpleValue,
		BuildingSmart.IFC.IfcStructuralLoadResource.IfcTranslationalStiffnessSelect,
		BuildingSmart.IFC.IfcStructuralLoadResource.IfcWarpingStiffnessSelect
	{
		[XmlText]
		public Boolean Value { get; private set; }
	
		public IfcBoolean(Boolean value) : this()
		{
			this.Value = value;
		}
	
		public static implicit operator IfcBoolean(Boolean value)
		{
			return new IfcBoolean(value);
		}
	
		public static implicit operator Boolean(IfcBoolean value)
		{
			return value.Value;
		}
	
		public override string ToString()
		{
			return Value.ToString();
		}
	}
	
}
