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

using BuildingSmart.IFC.IfcActorResource;
using BuildingSmart.IFC.IfcDateTimeResource;
using BuildingSmart.IFC.IfcExternalReferenceResource;
using BuildingSmart.IFC.IfcMeasureResource;

namespace BuildingSmart.IFC.IfcConstraintResource
{
	[Guid("d03dd5c6-bc93-4f7a-903f-d59e7c256d59")]
	public abstract partial class IfcConstraint :
		BuildingSmart.IFC.IfcExternalReferenceResource.IfcResourceObjectSelect
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		[Description("A human-readable name to be used for the constraint.")]
		[Required()]
		public IfcLabel Name { get; set; }
	
		[DataMember(Order = 1)] 
		[XmlAttribute]
		[Description("A human-readable description that may apply additional information about a constraint.")]
		public IfcText? Description { get; set; }
	
		[DataMember(Order = 2)] 
		[XmlAttribute]
		[Description("Enumeration that qualifies the type of constraint.")]
		[Required()]
		public IfcConstraintEnum ConstraintGrade { get; set; }
	
		[DataMember(Order = 3)] 
		[XmlAttribute]
		[Description("Any source material, such as a code or standard, from which the constraint originated.")]
		public IfcLabel? ConstraintSource { get; set; }
	
		[DataMember(Order = 4)] 
		[Description("Person and/or organization that has created the constraint.")]
		public IfcActorSelect CreatingActor { get; set; }
	
		[DataMember(Order = 5)] 
		[XmlAttribute]
		[Description("Time when information specifying the constraint instance was created.")]
		public IfcDateTime? CreationTime { get; set; }
	
		[DataMember(Order = 6)] 
		[XmlAttribute]
		[Description("Allows for specification of user defined grade of the constraint  beyond the enumeration values (hard, soft, advisory) provided by ConstraintGrade attribute of type <em>IfcConstraintEnum</em>.   When a value is provided for attribute UserDefinedGrade in parallel the attribute ConstraintGrade shall have enumeration value USERDEFINED.")]
		public IfcLabel? UserDefinedGrade { get; set; }
	
		[InverseProperty("RelatedResourceObjects")] 
		[Description("Reference to an external references, e.g. library, classification, or document information, that are associated to the constraint.  <blockquote class=\"change-ifc2x4\">IFC4 CHANGE New inverse attribute.</blockquote>")]
		public ISet<IfcExternalReferenceRelationship> HasExternalReferences { get; protected set; }
	
		[InverseProperty("RelatingConstraint")] 
		[Description("Reference to the properties to which the constraint is applied.")]
		public ISet<IfcResourceConstraintRelationship> PropertiesForConstraint { get; protected set; }
	
	
		protected IfcConstraint(IfcLabel name, IfcConstraintEnum constraintGrade)
		{
			this.Name = name;
			this.ConstraintGrade = constraintGrade;
			this.HasExternalReferences = new HashSet<IfcExternalReferenceRelationship>();
			this.PropertiesForConstraint = new HashSet<IfcResourceConstraintRelationship>();
		}
	
	
	}
	
}
