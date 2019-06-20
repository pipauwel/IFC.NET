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

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("dffb2f7f-2ba0-4b5f-88e4-bde0fa72fa1d")]
	public partial class IfcSystem : IfcGroup
	{
		[InverseProperty("RelatingSystem")] 
		[Description("Reference to the <strike>building</strike> spatial structure via the objectified relationship <em>IfcRelServicesBuildings</em>, which is serviced by the system.")]
		[MaxLength(1)]
		public ISet<IfcRelServicesBuildings> ServicesBuildings { get; protected set; }
	
	
		public IfcSystem(IfcGloballyUniqueId globalId)
			: base(globalId)
		{
			this.ServicesBuildings = new HashSet<IfcRelServicesBuildings>();
		}
	
	
	}
	
}
