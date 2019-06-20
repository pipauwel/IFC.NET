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

namespace BuildingSmart.IFC.IfcProcessExtension
{
	[Guid("0cce4f12-90b1-4e02-a09b-0dab4f9a731c")]
	public partial class IfcProcedure : IfcProcess
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Identifies the predefined types of a procedure from which       the type required may be set.")]
		public IfcProcedureTypeEnum? PredefinedType { get; set; }
	
	
		public IfcProcedure(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
		}
	
	
	}
	
}
