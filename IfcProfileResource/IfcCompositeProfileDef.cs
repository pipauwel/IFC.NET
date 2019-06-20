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

using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcProfileResource
{
	[Guid("f27d7589-d76f-4bdd-9102-d6fee84cd2a1")]
	public partial class IfcCompositeProfileDef : IfcProfileDef
	{
		[DataMember(Order = 0)] 
		[Description("The profiles which are used to define the composite profile.")]
		[Required()]
		[MinLength(2)]
		public ISet<IfcProfileDef> Profiles { get; protected set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("The name by which the composition may be referred to. The actual meaning of the name has to be defined in the context of applications.")]
		public IfcLabel? Label { get; set; }
	
	
		public IfcCompositeProfileDef(IfcProfileTypeEnum profileType, IfcProfileDef[] profiles)
			: base(profileType)
		{
			this.Profiles = new HashSet<IfcProfileDef>(profiles);
		}
	
	
	}
	
}
