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

using BuildingSmart.IFC.IfcGeometryResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedFacilitiesElements
{
	[Guid("a8b69ebd-a055-4b49-b99d-0de94f4c7d81")]
	public partial class IfcFurnitureType : IfcFurnishingElementType
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<p>A designation of where the assembly is intended to take place. A selection of alternatives s provided in an enumerated list.</p>")]
		[Required()]
		public IfcAssemblyPlaceEnum AssemblyPlace { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		public IfcFurnitureTypeEnum? PredefinedType { get; set; }
	
	
		public IfcFurnitureType(IfcGloballyUniqueId globalId, IfcAssemblyPlaceEnum assemblyPlace)
			: base(globalId)
		{
			this.AssemblyPlace = assemblyPlace;
		}
	
	
	}
	
}
