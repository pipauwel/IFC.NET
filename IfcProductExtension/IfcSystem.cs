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
	[Guid("cc7be996-d1ea-43ef-8969-e97b06238a34")]
	public partial class IfcSystem : IfcGroup
	{
		[InverseProperty("RelatingSystem")] 
		[Description("<EPM-HTML>Reference to the <strike>building</strike> spatial structure via the objectified relationship <i>IfcRelServicesBuildings</i>, which is serviced by the system.  </EPM-HTML>")]
		[MaxLength(1)]
		public ISet<IfcRelServicesBuildings> ServicesBuildings { get; protected set; }
	
	
		public IfcSystem(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory)
			: base(globalId, ownerHistory)
		{
			this.ServicesBuildings = new HashSet<IfcRelServicesBuildings>();
		}
	
	
	}
	
}
