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
using BuildingSmart.IFC.IfcProductExtension;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcSharedBldgElements
{
	[Guid("b816352c-9e44-415c-8563-b3e3eafb9357")]
	public partial class IfcRelConnectsPathElements : IfcRelConnectsElements
	{
		[DataMember(Order = 0)] 
		[Description("Priorities for connection. It refers to the layers of the RelatingObject.")]
		[Required()]
		public IList<Int64> RelatingPriorities { get; protected set; }
	
		[DataMember(Order = 1)] 
		[Description("Priorities for connection. It refers to the layers of the RelatedObject.")]
		[Required()]
		public IList<Int64> RelatedPriorities { get; protected set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Indication of the connection type in relation to the path of the RelatingObject.")]
		[Required()]
		public IfcConnectionTypeEnum RelatedConnectionType { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Indication of the connection type in relation to the path of the RelatingObject.")]
		[Required()]
		public IfcConnectionTypeEnum RelatingConnectionType { get; set; }
	
	
		public IfcRelConnectsPathElements(IfcGloballyUniqueId globalId, IfcOwnerHistory ownerHistory, IfcElement relatingElement, IfcElement relatedElement, Int64[] relatingPriorities, Int64[] relatedPriorities, IfcConnectionTypeEnum relatedConnectionType, IfcConnectionTypeEnum relatingConnectionType)
			: base(globalId, ownerHistory, relatingElement, relatedElement)
		{
			this.RelatingPriorities = new List<Int64>(relatingPriorities);
			this.RelatedPriorities = new List<Int64>(relatedPriorities);
			this.RelatedConnectionType = relatedConnectionType;
			this.RelatingConnectionType = relatingConnectionType;
		}
	
	
	}
	
}
