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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("4e970c36-e5df-4493-be7d-f85befcc73e3")]
	public partial class IfcRelAssociates : IfcRelationship
	{
		[DataMember(Order = 0)] 
		[Description("Objects or Types, to which the external references or information is associated.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcRoot> RelatedObjects { get; protected set; }
	
	
		public IfcRelAssociates(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcRoot[] relatedObjects)
			: base(globalId, ownerHistory)
		{
			this.RelatedObjects = new HashSet<IfcRoot>(relatedObjects);
		}
	
	
	}
	
}
