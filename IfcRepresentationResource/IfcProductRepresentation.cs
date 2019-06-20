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

namespace BuildingSmart.IFC.IfcRepresentationResource
{
	[Guid("ebb1e658-5b55-4231-9e88-68b1c85889f8")]
	public abstract partial class IfcProductRepresentation
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The word or group of words by which the product representation is known.")]
		public IfcLabel? Name { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The word or group of words that characterize the product representation. It can be used to add additional meaning to the name of the product representation.")]
		public IfcText? Description { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("Contained list of representations (including shape representations). Each member defines a valid representation of a particular type within a particular representation context.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcRepresentation> Representations { get; protected set; }
	
	
		protected IfcProductRepresentation(IfcRepresentation[] representations)
		{
			this.Representations = new List<IfcRepresentation>(representations);
		}
	
	
	}
	
}
