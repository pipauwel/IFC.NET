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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProcessExtension
{
	[Guid("0a7f7d22-a0d6-4988-b9ca-edacae24cc2a")]
	public partial class IfcWorkSchedule : IfcWorkControl
	{
	
		public IfcWorkSchedule(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcIdentifier identifier, IfcDateTimeSelect creationDate, IfcDateTimeSelect startTime)
			: base(globalId, ownerHistory, identifier, creationDate, startTime)
		{
		}
	
	
	}
	
}
