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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcProductExtension
{
	[Guid("dfb6beda-5c7c-4df8-bbc6-b101ce4006f3")]
	public partial class IfcGrid : IfcProduct
	{
		[DataMember(Order = 0)] 
		[Description("List of grid axes defining the first row of grid lines.")]
		[Required()]
		[CustomValidation(typeof(IfcGrid), "Unique")]
		[MinLength(1)]
		public IList<IfcGridAxis> UAxes { get; protected set; }
	
		[DataMember(Order = 1)] 
		[Description("List of grid axes defining the second row of grid lines.")]
		[Required()]
		[CustomValidation(typeof(IfcGrid), "Unique")]
		[MinLength(1)]
		public IList<IfcGridAxis> VAxes { get; protected set; }
	
		[DataMember(Order = 2)] 
		[Description("List of grid axes defining the third row of grid lines. It may be given in the case of a triangular grid.")]
		[CustomValidation(typeof(IfcGrid), "Unique")]
		[MinLength(1)]
		public IList<IfcGridAxis> WAxes { get; protected set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Predefined types to define the particular type of the grid.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE&nbsp; New attribute.  </blockquote>")]
		public IfcGridTypeEnum? PredefinedType { get; set; }
	
		[InverseProperty("RelatedElements")] 
		[Description("Relationship to a spatial structure element, to which the grid is primarily associated.  <blockquote class=\"change-ifc2x\">IFC2x CHANGE&nbsp; The inverse relationship has been added to <em>IfcGrid</em> with upward compatibility</blockquote>")]
		[MaxLength(1)]
		public ISet<IfcRelContainedInSpatialStructure> ContainedInStructure { get; protected set; }
	
	
		public IfcGrid(IfcGloballyUniqueId globalId, IfcGridAxis[] uAxes, IfcGridAxis[] vAxes)
			: base(globalId)
		{
			this.UAxes = new List<IfcGridAxis>(uAxes);
			this.VAxes = new List<IfcGridAxis>(vAxes);
			this.WAxes = new List<IfcGridAxis>();
			this.ContainedInStructure = new HashSet<IfcRelContainedInSpatialStructure>();
		}
	
	
	}
	
}
