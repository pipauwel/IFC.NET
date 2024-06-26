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

namespace BuildingSmart.IFC.IfcActorResource
{
	[Guid("9adbf974-1f10-42f4-bd17-f909754b6a5e")]
	public partial class IfcActorRole
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("The name of the role played by an actor. If the Role has value USERDEFINED, then  the user defined role shall be provided as a value of the attribute UserDefinedRole.")]
		[Required()]
		public IfcRoleEnum Role { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("Allows for specification of user defined roles beyond the   enumeration values provided by Role attribute of type IfcRoleEnum.   When a value is provided for attribute UserDefinedRole in parallel   the attribute Role shall have enumeration value USERDEFINED.")]
		public IfcLabel? UserDefinedRole { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("A textual description relating the nature of the role played by an actor.")]
		public IfcText? Description { get; set; }
	
	
		public IfcActorRole(IfcRoleEnum role)
		{
			this.Role = role;
		}
	
	
	}
	
}
