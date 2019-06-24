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

using BuildingSmart.IFC.IfcGeometricConstraintResource;
using BuildingSmart.IFC.IfcKernel;
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcRepresentationResource;
using BuildingSmart.IFC.IfcStructuralAnalysisDomain;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("42319f70-e8d2-4b5b-8920-101a38252ebe")]
	public partial class IfcElementAssembly : IfcElement
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("A designation of where the assembly is intended to take place defined by an Enum.")]
		public IfcAssemblyPlaceEnum? AssemblyPlace { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Predefined generic types for a element assembly that are specified in an enumeration.")]
		[Required()]
		public IfcElementAssemblyTypeEnum PredefinedType { get; set; }
	
	
		public IfcElementAssembly(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcElementAssemblyTypeEnum predefinedType)
			: base(globalId, ownerHistory)
		{
			this.PredefinedType = predefinedType;
		}
	
	
	}
	
}
