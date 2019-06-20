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

using BuildingSmart.IFC.IfcMaterialResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcRepresentationResource
{
	[Guid("482a3c86-3ce0-47c4-936b-b783f9502b01")]
	public partial class IfcMaterialDefinitionRepresentation : IfcProductRepresentation
	{
		[DataMember(Order = 0)] 
		[XmlIgnore]
		[Description("Reference to the material to which the representation applies.")]
		[Required()]
		public IfcMaterial RepresentedMaterial { get; set; }
	
	
		public IfcMaterialDefinitionRepresentation(IfcRepresentation[] representations, IfcMaterial representedMaterial)
			: base(representations)
		{
			this.RepresentedMaterial = representedMaterial;
		}
	
	
	}
	
}
