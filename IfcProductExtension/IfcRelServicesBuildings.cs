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
	[Guid("10f0323d-4a18-4ef3-a7ed-de9488cd0b5c")]
	public partial class IfcRelServicesBuildings : IfcRelConnects
	{
		[DataMember(Order = 0)] 
		[Description("System that services the Buildings.")]
		[Required()]
		public IfcSystem RelatingSystem { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("<EPM-HTML>  Spatial structure elements (including site, building, storeys) that are serviced by the system.  <blockquote><small><font color=\"#FF0000\">  IFC2x PLATFORM CHANGE&nbsp; The data type has been changed from <i>IfcBuilding</i> to <i>IfcSpatialStructureElement</i> with upward compatibility for file based exchange.  </font></small></blockquote>  </EPM-HTML>")]
		[Required()]
		[MinLength(1)]
		public ISet<IfcSpatialStructureElement> RelatedBuildings { get; protected set; }
	
	
		public IfcRelServicesBuildings(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcSystem relatingSystem, IfcSpatialStructureElement[] relatedBuildings)
			: base(globalId, ownerHistory)
		{
			this.RelatingSystem = relatingSystem;
			this.RelatedBuildings = new HashSet<IfcSpatialStructureElement>(relatedBuildings);
		}
	
	
	}
	
}
