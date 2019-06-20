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
using BuildingSmart.IFC.IfcMeasureResource;
using BuildingSmart.IFC.IfcPropertyResource;

namespace BuildingSmart.IFC.IfcUtilityResource
{
	[Guid("a998a201-457f-4f17-9337-b5f2acb084d8")]
	public partial class IfcTable :
		BuildingSmart.IFC.IfcConstraintResource.IfcMetricValueSelect,
		BuildingSmart.IFC.IfcPropertyResource.IfcObjectReferenceSelect
	{
		[DataMember(Order = 0)] 
		[XmlAttribute]
		public IfcLabel? Name { get; set; }
	
		[DataMember(Order = 1)] 
		[Description("Reference to information content of rows.")]
		[MinLength(1)]
		public IList<IfcTableRow> Rows { get; protected set; }
	
		[DataMember(Order = 2)] 
		[Description("The column information associated with this table.")]
		[MinLength(1)]
		public IList<IfcTableColumn> Columns { get; protected set; }
	
	
		public IfcTable()
		{
			this.Rows = new List<IfcTableRow>();
			this.Columns = new List<IfcTableColumn>();
		}
	
		public new IfcInteger NumberOfCellsInRow { get { return new IfcInteger(); } }
	
		public new IfcInteger NumberOfHeadings { get { return new IfcInteger(); } }
	
		public new IfcInteger NumberOfDataRows { get { return new IfcInteger(); } }
	
	
	}
	
}
