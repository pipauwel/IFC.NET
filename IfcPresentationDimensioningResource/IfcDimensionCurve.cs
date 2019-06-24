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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationDefinitionResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IFCPRESENTATIONDIMENSIONINGRESOURCE
{
	[Guid("25dc1886-d49e-4538-9730-df93d93f9916")]
	public partial class IfcDimensionCurve : IfcAnnotationCurveOccurrence
	{
		[InverseProperty("AnnotatedCurve")] 
		[Description("Reference to the terminator symbols that may be assigned to the dimension curve. There shall be either zero, one or two terminator symbols assigned.")]
		[MaxLength(2)]
		public ISet<IfcTerminatorSymbol> AnnotatedBySymbols { get; protected set; }
	
	
		public IfcDimensionCurve(IfcPresentationStyleAssignment[] styles)
			: base(styles)
		{
			this.AnnotatedBySymbols = new HashSet<IfcTerminatorSymbol>();
		}
	
	
	}
	
}
