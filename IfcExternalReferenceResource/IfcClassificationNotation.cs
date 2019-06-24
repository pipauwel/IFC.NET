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


namespace BuildingSmart.IFC.IfcExternalReferenceResource
{
	[Guid("54f9c8f1-3d9f-4e33-b7a4-8f397eb5f490")]
	public partial class IfcClassificationNotation :
		IfcClassificationNotationSelect
	{
		[DataMember(Order = 0)] 
		[Description("Alphanumeric characters in defined groups from which the classification notation is derived.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcClassificationNotationFacet> NotationFacets { get; protected set; }
	
	
		public IfcClassificationNotation(IfcClassificationNotationFacet[] notationFacets)
		{
			this.NotationFacets = new HashSet<IfcClassificationNotationFacet>(notationFacets);
		}
	
	
	}
	
}
