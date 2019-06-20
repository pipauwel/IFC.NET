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
	[Guid("51ba0123-164c-4caf-8ba8-61e9906b07c0")]
	public partial class IfcRelDefinesByObject : IfcRelDefines
	{
		[DataMember(Order = 0)] 
		[Description("Objects being part of an object occurrence decomposition, acting as the \"reflecting parts\" in the relationship.")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcObject> RelatedObjects { get; protected set; }
	
		[DataMember(Order = 1)] 
		[XmlIgnore]
		[Description("Object being part of an object type decomposition, acting as the \"declaring part\" in the relationship.")]
		[Required()]
		public IfcObject RelatingObject { get; set; }
	
	
		public IfcRelDefinesByObject(IfcGloballyUniqueId globalId, IfcObject[] relatedObjects, IfcObject relatingObject)
			: base(globalId)
		{
			this.RelatedObjects = new HashSet<IfcObject>(relatedObjects);
			this.RelatingObject = relatingObject;
		}
	
	
	}
	
}
