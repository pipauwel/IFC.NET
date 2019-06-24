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
	[Guid("02a680bf-4622-48e0-92eb-9c42ff0f72a1")]
	public partial class IfcRelAggregates : IfcRelDecomposes
	{
	
		public IfcRelAggregates(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcObjectDefinition relatingObject, IfcObjectDefinition[] relatedObjects)
			: base(globalId, ownerHistory, relatingObject, relatedObjects)
		{
		}
	
	
	}
	
}
