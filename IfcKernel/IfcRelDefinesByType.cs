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
	[Guid("f48dfb4d-c177-4f88-b654-b0d80b6d1908")]
	public partial class IfcRelDefinesByType : IfcRelDefines
	{
		[DataMember(Order = 0)] 
		[Description("Reference to the type (or style) information for that object or set of objects.")]
		[Required()]
		public IfcTypeObject RelatingType { get; set; }
	
	
		public IfcRelDefinesByType(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcObject[] relatedObjects, IfcTypeObject relatingType)
			: base(globalId, ownerHistory, relatedObjects)
		{
			this.RelatingType = relatingType;
		}
	
	
	}
	
}
