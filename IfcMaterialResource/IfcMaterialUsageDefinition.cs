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

using BuildingSmart.IFC.IfcProductExtension;

namespace BuildingSmart.IFC.IfcMaterialResource
{
	[Guid("c49fa2f9-55a1-4a45-9f3c-ca8a7106f785")]
	public abstract partial class IfcMaterialUsageDefinition :
		IfcMaterialSelect
	{
		[InverseProperty("RelatingMaterial")] 
		[Description("Use of the <em>IfcMaterialUsageDefinition</em> subtypes within the material association of an element occurrence. The association is established by the <em>IfcRelAssociatesMaterial</em> relationship.")]
		[MinLength(1)]
		public ISet<IfcRelAssociatesMaterial> AssociatedTo { get; protected set; }
	
	
		protected IfcMaterialUsageDefinition()
		{
			this.AssociatedTo = new HashSet<IfcRelAssociatesMaterial>();
		}
	
	
	}
	
}
