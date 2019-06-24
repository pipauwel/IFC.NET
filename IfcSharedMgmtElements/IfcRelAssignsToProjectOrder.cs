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

using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedMgmtElements
{
	[Guid("bc422187-f955-48c5-959e-fd83b6b80827")]
	public partial class IfcRelAssignsToProjectOrder : IfcRelAssignsToControl
	{
	
		public IfcRelAssignsToProjectOrder(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcObjectDefinition[] relatedObjects, IfcControl relatingControl)
			: base(globalId, ownerHistory, relatedObjects, relatingControl)
		{
		}
	
	
	}
	
}
