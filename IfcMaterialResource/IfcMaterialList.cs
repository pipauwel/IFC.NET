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

using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IfcMaterialResource
{
	[Guid("9080f661-60ad-4ebd-ae2d-a4f114f935a4")]
	public partial class IfcMaterialList :
		IfcMaterialSelect,
		BuildingSmart.IFC.IfcPropertyResource.IfcObjectReferenceSelect
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
