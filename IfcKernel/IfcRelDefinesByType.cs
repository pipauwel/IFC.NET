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

using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcUtilityResource;

namespace BuildingSmart.IFC.IfcKernel
{
	[Guid("92a2c20b-4c2f-4ed2-a2f1-5d0591fa26b2")]
	public partial class IfcRelDefinesByType : IfcRelDefines
	{
		[DataMember(Order = 0)] 
		[XmlIgnore]
		[Required()]
		[MinLength(1)]
		public ISet<IfcObject> RelatedObjects { get; protected set; }
	
		[DataMember(Order = 1)] 
		[XmlElement]
		[Description("Reference to the type (or style) information for that object or set of objects.")]
		[Required()]
		public IfcTypeObject RelatingType { get; set; }
	
	
		public IfcRelDefinesByType(IfcGloballyUniqueId globalId, IfcObject[] relatedObjects, IfcTypeObject relatingType)
			: base(globalId)
		{
			this.RelatedObjects = new HashSet<IfcObject>(relatedObjects);
			this.RelatingType = relatingType;
		}
	
	
	}
	
}
