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
	[Guid("2127538d-266b-4b8d-a595-3ef8afe2acf0")]
	public abstract partial class IfcRelDefines : IfcRelationship
	{
		[DataMember(Order = 0)] 
		[Description("Reference to the objects (or single object) to which the property definition applies.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcObject> RelatedObjects { get; protected set; }
	
	
		protected IfcRelDefines(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcObject[] relatedObjects)
			: base(globalId, ownerHistory)
		{
			this.RelatedObjects = new HashSet<IfcObject>(relatedObjects);
		}
	
	
	}
	
}
