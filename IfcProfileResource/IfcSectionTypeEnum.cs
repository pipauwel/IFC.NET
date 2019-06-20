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


namespace BuildingSmart.IFC.IfcProfileResource
{
	[Guid("5e0f50ac-3073-4ca6-879b-0a92c83a3275")]
	public enum IfcSectionTypeEnum
	{
		[Description("The section is uniform in longitudinal direction.")]
		UNIFORM = 1,
	
		[Description("The section is tapered in longitudinal direction.")]
		TAPERED = 2,
	
	}
}
