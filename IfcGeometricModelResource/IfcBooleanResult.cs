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
using BuildingSmart.IFC.IfcPresentationAppearanceResource;
using BuildingSmart.IFC.IfcPresentationOrganizationResource;

namespace BuildingSmart.IFC.IfcGeometricModelResource
{
	[Guid("d78312f8-1bcd-4504-890e-d6fcdaab653c")]
	public partial class IfcBooleanResult : IfcGeometricRepresentationItem,
		IfcBooleanOperand,
		IfcCsgSelect
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The Boolean operator used in the operation to create the result.")]
		[Required()]
		public IfcBooleanOperator Operator { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The first operand to be operated upon by the Boolean operation.")]
		[Required()]
		public IfcBooleanOperand FirstOperand { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("The second operand specified for the operation.")]
		[Required()]
		public IfcBooleanOperand SecondOperand { get; set; }
	
	
		public IfcBooleanResult(IfcBooleanOperator _operator, IfcBooleanOperand firstOperand, IfcBooleanOperand secondOperand)
		{
			this.Operator = _operator;
			this.FirstOperand = firstOperand;
			this.SecondOperand = secondOperand;
		}
	
		public new IfcDimensionCount Dim { get { return new IfcDimensionCount(); } }
	
	
	}
	
}
