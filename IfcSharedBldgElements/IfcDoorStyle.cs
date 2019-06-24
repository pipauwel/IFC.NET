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

namespace BuildingSmart.IFC.IfcSharedBldgElements
{
	[Guid("56391c72-81c3-43aa-a74e-4217b2dc660e")]
	public partial class IfcDoorStyle : IfcTypeProduct
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  Type defining the general layout and operation of the door style.  <br>  </EPM-HTML>")]
		[Required()]
		public IfcDoorStyleOperationEnum OperationType { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("<EPM-HTML>  Type defining the basic construction and material type of the door.  <br>  </EPM-HTML>")]
		[Required()]
		public IfcDoorStyleConstructionEnum ConstructionType { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("<EPM-HTML>  The Boolean value reflects, whether the parameter given in the attached lining and panel properties exactly define the geometry (TRUE), or whether the attached style shape take precedence (FALSE). In the last case the parameter have only informative value.  <br>  </EPM-HTML>")]
		[Required()]
		public Boolean ParameterTakesPrecedence { get; set; }
	
		[DataMember(Order = 3)] 
		[Description("<EPM-HTML>  The Boolean indicates, whether the attached <i>IfcMappedRepresentation</i> (if given) can be sized (using scale factor of transformation), or not (FALSE). If not, the <i>IfcMappedRepresentation</i> should be <i>IfcShapeRepresentation</i> of the <i>IfcDoor</i> (using <i>IfcMappedItem</i> as the <i>Item</i>) with the scale factor = 1.  <br>  </EPM-HTML>")]
		[Required()]
		public Boolean Sizeable { get; set; }
	
	
		public IfcDoorStyle(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcDoorStyleOperationEnum operationType, IfcDoorStyleConstructionEnum constructionType, Boolean parameterTakesPrecedence, Boolean sizeable)
			: base(globalId, ownerHistory)
		{
			this.OperationType = operationType;
			this.ConstructionType = constructionType;
			this.ParameterTakesPrecedence = parameterTakesPrecedence;
			this.Sizeable = sizeable;
		}
	
	
	}
	
}
