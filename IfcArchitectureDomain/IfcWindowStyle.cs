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
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcArchitectureDomain
{
	[Guid("db2eb89c-05a5-4166-8f16-149189ed3bfa")]
	public partial class IfcWindowStyle : IfcTypeProduct
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Type defining the basic construction and material type of the window.")]
		[Required()]
		public IfcWindowStyleConstructionEnum ConstructionType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Type defining the general layout and operation of the window style.")]
		[Required()]
		public IfcWindowStyleOperationEnum OperationType { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The Boolean value reflects, whether the parameter given in the attached lining and panel properties exactly define the geometry (TRUE), or whether the attached style shape take precedence (FALSE). In the last case the parameter have only informative value.")]
		[Required()]
		public IfcBoolean ParameterTakesPrecedence { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The Boolean indicates, whether the attached ShapeStyle can be sized (using scale factor of transformation), or not (FALSE). If not, the ShapeStyle should be inserted by the IfcWindow (using IfcMappedItem) with the scale factor = 1.")]
		[Required()]
		public IfcBoolean Sizeable { get; set; }
	
	
		public IfcWindowStyle(IfcGloballyUniqueId globalId, IfcWindowStyleConstructionEnum constructionType, IfcWindowStyleOperationEnum operationType, IfcBoolean parameterTakesPrecedence, IfcBoolean sizeable)
			: base(globalId)
		{
			this.ConstructionType = constructionType;
			this.OperationType = operationType;
			this.ParameterTakesPrecedence = parameterTakesPrecedence;
			this.Sizeable = sizeable;
		}
	
	
	}
	
}
