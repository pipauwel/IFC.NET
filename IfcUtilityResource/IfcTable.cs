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

using BuildingSmart.IFC.IfcConstraintResource;

namespace BuildingSmart.IFC.IfcUtilityResource
{
	[Guid("6568e6cb-93db-4698-822f-33bbc35a1144")]
	public partial class IfcTable :
		BuildingSmart.IFC.IfcConstraintResource.IfcMetricValueSelect
	{
		[DataMember(Order = 0)] 
		[Description("A unique name which is intended to describe the usage of the Table.")]
		[Required()]
		public String Name { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Reference to information content of rows.")]
		[Required()]
		[MinLength(1)]
		public IList<IfcTableRow> Rows { get; protected set; }
	
	
		public IfcTable(String name, IfcTableRow[] rows)
		{
			this.Name = name;
			this.Rows = new List<IfcTableRow>(rows);
		}
	
		public new Int64 NumberOfCellsInRow { get { return null; } }
	
		public new Int64 NumberOfHeadings { get { return null; } }
	
		public new Int64 NumberOfDataRows { get { return null; } }
	
	
	}
	
}
