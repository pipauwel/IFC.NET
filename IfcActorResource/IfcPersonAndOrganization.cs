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

using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IfcActorResource
{
	[Guid("22436df9-b9a1-47b7-872f-e3d35caded50")]
	public partial class IfcPersonAndOrganization :
		IfcActorSelect,
		BuildingSmart.IFC.IfcPropertyResource.IfcObjectReferenceSelect
	{
		[DataMember(Order = 0)] 
		[Description("The person who is related to the organization.")]
		[Required()]
		public IfcPerson ThePerson { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("The organization to which the person is related.")]
		[Required()]
		public IfcOrganization TheOrganization { get; set; }
	
		[DataMember(Order = 2)] 
		[Description("Roles played by the person within the context of an organization.")]
		[MinLength(1)]
		public IList<IfcActorRole> Roles { get; protected set; }
	
	
		public IfcPersonAndOrganization(IfcPerson thePerson, IfcOrganization theOrganization)
		{
			this.ThePerson = thePerson;
			this.TheOrganization = theOrganization;
			this.Roles = new List<IfcActorRole>();
		}
	
	
	}
	
}
