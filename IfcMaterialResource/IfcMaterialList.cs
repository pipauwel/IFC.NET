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


namespace BuildingSmart.IFC.IfcMaterialResource
{
	[Guid("e2c88e35-f4a8-464a-8816-1b1ae58202f5")]
	public partial class IfcMaterialList :
		IfcMaterialSelect
	{
		[DataMember(Order = 0)] 
		[Description("Materials used in a composition of substances.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcMaterial> Materials { get; protected set; }
	
	
		public IfcMaterialList(IfcMaterial[] materials)
		{
			this.Materials = new List<IfcMaterial>(materials);
		}
	
	
	}
	
}
