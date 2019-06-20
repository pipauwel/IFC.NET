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
	[Guid("3e42e773-d2e7-4b27-8517-e04c42c4b1de")]
	public partial class IfcDoorStyle : IfcTypeProduct
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("Type defining the general layout and operation of the door style.  <br>")]
		[Required()]
		public IfcDoorStyleOperationEnum OperationType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Type defining the basic construction and material type of the door.  <br>")]
		[Required()]
		public IfcDoorStyleConstructionEnum ConstructionType { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("The Boolean value reflects, whether the parameter given in the attached lining and panel properties exactly define the geometry (TRUE), or whether the attached style shape take precedence (FALSE). In the last case the parameter have only informative value.  <br>")]
		[Required()]
		public IfcBoolean ParameterTakesPrecedence { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("The Boolean indicates, whether the attached <em>IfcMappedRepresentation</em> (if given) can be sized (using scale factor of transformation), or not (FALSE). If not, the <em>IfcMappedRepresentation</em> should be <em>IfcShapeRepresentation</em> of the <em>IfcDoor</em> (using <em>IfcMappedItem</em> as the <em>Item</em>) with the scale factor = 1.  <br>")]
		[Required()]
		public IfcBoolean Sizeable { get; set; }
	
	
		public IfcDoorStyle(IfcGloballyUniqueId globalId, IfcDoorStyleOperationEnum operationType, IfcDoorStyleConstructionEnum constructionType, IfcBoolean parameterTakesPrecedence, IfcBoolean sizeable)
			: base(globalId)
		{
			this.OperationType = operationType;
			this.ConstructionType = constructionType;
			this.ParameterTakesPrecedence = parameterTakesPrecedence;
			this.Sizeable = sizeable;
		}
	
	
	}
	
}
