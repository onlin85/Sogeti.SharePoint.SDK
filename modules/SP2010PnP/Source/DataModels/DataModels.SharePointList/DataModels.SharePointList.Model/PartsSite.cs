//===============================================================================
// Microsoft patterns & practices
// Developing Applications for SharePoint 2010
//===============================================================================
// Copyright Microsoft Corporation.  All rights reserved.
// This code released under the terms of the 
// Microsoft patterns & practices license (http://msdn.microsoft.com/en-us/library/ee663037.aspx)
//===============================================================================


//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModels.SharePointList.Model {
	using System;
	
	
	public partial class PartsSiteDataContext : Microsoft.SharePoint.Linq.DataContext {
		
		#region Extensibility Method Definitions
		partial void OnCreated();
		#endregion
		
		public PartsSiteDataContext(string requestUrl) : 
				base(requestUrl) {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Categories")]
		public Microsoft.SharePoint.Linq.EntityList<Category> Categories {
			get {
				return this.GetList<Category>("Categories");
			}
		}
		
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Departments")]
		public Microsoft.SharePoint.Linq.EntityList<Department> Departments {
			get {
				return this.GetList<Department>("Departments");
			}
		}
		
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Inventory Locations")]
		public Microsoft.SharePoint.Linq.EntityList<InventoryLocation> InventoryLocations {
			get {
				return this.GetList<InventoryLocation>("Inventory Locations");
			}
		}
		
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Machine Departments")]
		public Microsoft.SharePoint.Linq.EntityList<MachineDepartment> MachineDepartments {
			get {
				return this.GetList<MachineDepartment>("Machine Departments");
			}
		}
		
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Machine Parts")]
		public Microsoft.SharePoint.Linq.EntityList<MachinePart> MachineParts {
			get {
				return this.GetList<MachinePart>("Machine Parts");
			}
		}
		
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Machines")]
		public Microsoft.SharePoint.Linq.EntityList<Machine> Machines {
			get {
				return this.GetList<Machine>("Machines");
			}
		}
		
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Manufacturers")]
		public Microsoft.SharePoint.Linq.EntityList<Manufacturer> Manufacturers {
			get {
				return this.GetList<Manufacturer>("Manufacturers");
			}
		}
		
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Part Suppliers")]
		public Microsoft.SharePoint.Linq.EntityList<PartSupplier> PartSuppliers {
			get {
				return this.GetList<PartSupplier>("Part Suppliers");
			}
		}
		
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Parts")]
		public Microsoft.SharePoint.Linq.EntityList<Part> Parts {
			get {
				return this.GetList<Part>("Parts");
			}
		}
		
		/// <summary>
		/// Use the style library to store style sheets, such as CSS or XSL files. The style sheets in this gallery can be used by this site or any of its subsites.
		/// </summary>
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Style Library")]
		public Microsoft.SharePoint.Linq.EntityList<Document> StyleLibrary {
			get {
				return this.GetList<Document>("Style Library");
			}
		}
		
		[Microsoft.SharePoint.Linq.ListAttribute(Name="Suppliers")]
		public Microsoft.SharePoint.Linq.EntityList<Supplier> Suppliers {
			get {
				return this.GetList<Supplier>("Suppliers");
			}
		}
	}
	
	/// <summary>
	/// Create a new list item.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Item", Id="0x01")]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Category))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Department))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(InventoryLocation))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(MachineDepartment))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(MachinePart))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Machine))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Manufacturer))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(PartSupplier))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Part))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Document))]
	[Microsoft.SharePoint.Linq.DerivedEntityClassAttribute(Type=typeof(Supplier))]
	public partial class Item : Microsoft.SharePoint.Linq.ITrackEntityState, Microsoft.SharePoint.Linq.ITrackOriginalValues, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging {
		
		private System.Nullable<int> _id;
		
		private System.Nullable<int> _version;
		
		private string _path;
		
		private Microsoft.SharePoint.Linq.EntityState _entityState;
		
		private System.Collections.Generic.IDictionary<string, object> _originalValues;
		
		private string _title;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion

		Microsoft.SharePoint.Linq.EntityState Microsoft.SharePoint.Linq.ITrackEntityState.EntityState {
			get {
				return this._entityState;
			}
			set {
				if ((value != this._entityState)) {
					this._entityState = value;
				}
			}
		}

		System.Collections.Generic.IDictionary<string, object> Microsoft.SharePoint.Linq.ITrackOriginalValues.OriginalValues {
			get {
				if ((null == this._originalValues)) {
					this._originalValues = new System.Collections.Generic.Dictionary<string, object>();
				}
				return this._originalValues;
			}
		}
		
		public Item() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="ID", Storage="_id", ReadOnly=true, FieldType="Counter")]
		public System.Nullable<int> Id {
			get {
				return this._id;
			}
			set {
				if ((value != this._id)) {
					this.OnPropertyChanging("Id", this._id);
					this._id = value;
					this.OnPropertyChanged("Id");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="owshiddenversion", Storage="_version", ReadOnly=true, FieldType="Integer")]
		public System.Nullable<int> Version {
			get {
				return this._version;
			}
			set {
				if ((value != this._version)) {
					this.OnPropertyChanging("Version", this._version);
					this._version = value;
					this.OnPropertyChanged("Version");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="FileDirRef", Storage="_path", ReadOnly=true, FieldType="Lookup", IsLookupValue=true)]
		public string Path {
			get {
				return this._path;
			}
			set {
				if ((value != this._path)) {
					this.OnPropertyChanging("Path", this._path);
					this._path = value;
					this.OnPropertyChanged("Path");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Title", Storage="_title", Required=true, FieldType="Text")]
		public virtual string Title {
			get {
				return this._title;
			}
			set {
				if ((value != this._title)) {
					this.OnPropertyChanging("Title", this._title);
					this._title = value;
					this.OnPropertyChanged("Title");
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		protected virtual void OnPropertyChanged(string propertyName) {
			if ((null != this.PropertyChanged)) {
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		protected virtual void OnPropertyChanging(string propertyName, object value) {
			if ((null == this._originalValues)) {
				this._originalValues = new System.Collections.Generic.Dictionary<string, object>();
			}
			if ((false == this._originalValues.ContainsKey(propertyName))) {
				this._originalValues.Add(propertyName, value);
			}
			if ((null != this.PropertyChanging)) {
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
	}
	
	/// <summary>
	/// Create a new document.
	/// </summary>
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Document", Id="0x0101")]
	public partial class Document : Item {
		
		private string _name;
		
		private string _documentModifiedBy;
		
		private string _documentCreatedBy;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Document() {
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="FileLeafRef", Storage="_name", Required=true, FieldType="File")]
		public string Name {
			get {
				return this._name;
			}
			set {
				if ((value != this._name)) {
					this.OnPropertyChanging("Name", this._name);
					this._name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Modified_x0020_By", Storage="_documentModifiedBy", ReadOnly=true, FieldType="Text")]
		public string DocumentModifiedBy {
			get {
				return this._documentModifiedBy;
			}
			set {
				if ((value != this._documentModifiedBy)) {
					this.OnPropertyChanging("DocumentModifiedBy", this._documentModifiedBy);
					this._documentModifiedBy = value;
					this.OnPropertyChanged("DocumentModifiedBy");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Created_x0020_By", Storage="_documentCreatedBy", ReadOnly=true, FieldType="Text")]
		public string DocumentCreatedBy {
			get {
				return this._documentCreatedBy;
			}
			set {
				if ((value != this._documentCreatedBy)) {
					this.OnPropertyChanging("DocumentCreatedBy", this._documentCreatedBy);
					this._documentCreatedBy = value;
					this.OnPropertyChanged("DocumentCreatedBy");
				}
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Category", Id="0x01001BE67949DD484746B132BFA579DE4D1A")]
	public partial class Category : Item {
		
		private string _categoryName;
		
		private Microsoft.SharePoint.Linq.EntitySet<Machine> _machine;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Category() {
			this._machine = new Microsoft.SharePoint.Linq.EntitySet<Machine>();
			this._machine.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Machine>>(this.OnMachineSync);
			this._machine.OnChanged += new System.EventHandler(this.OnMachineChanged);
			this._machine.OnChanging += new System.EventHandler(this.OnMachineChanging);
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="CategoryName", Storage="_categoryName", FieldType="Text")]
		public string CategoryName {
			get {
				return this._categoryName;
			}
			set {
				if ((value != this._categoryName)) {
					this.OnPropertyChanging("CategoryName", this._categoryName);
					this._categoryName = value;
					this.OnPropertyChanged("CategoryName");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="CategoryLookup", Storage="_machine", ReadOnly=true, MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Backward, List="Machines")]
		public Microsoft.SharePoint.Linq.EntitySet<Machine> Machine {
			get {
				return this._machine;
			}
			set {
				this._machine.Assign(value);
			}
		}
		
		private void OnMachineChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Machine", this._machine.Clone());
		}
		
		private void OnMachineChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Machine");
		}
		
		private void OnMachineSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Machine> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.Category = this;
			}
			else {
				e.Item.Category = null;
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Department", Id="0x01004F9943253ED2684E90E2BC4FCD34A54B")]
	public partial class Department : Item {
		
		private System.Nullable<double> _departmentNumber;
		
		private string _description;
		
		private Microsoft.SharePoint.Linq.EntitySet<MachineDepartment> _machineDepartment;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Department() {
			this._machineDepartment = new Microsoft.SharePoint.Linq.EntitySet<MachineDepartment>();
			this._machineDepartment.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<MachineDepartment>>(this.OnMachineDepartmentSync);
			this._machineDepartment.OnChanged += new System.EventHandler(this.OnMachineDepartmentChanged);
			this._machineDepartment.OnChanging += new System.EventHandler(this.OnMachineDepartmentChanging);
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="DepartmentNumber", Storage="_departmentNumber", Required=true, FieldType="Number")]
		public System.Nullable<double> DepartmentNumber {
			get {
				return this._departmentNumber;
			}
			set {
				if ((value != this._departmentNumber)) {
					this.OnPropertyChanging("DepartmentNumber", this._departmentNumber);
					this._departmentNumber = value;
					this.OnPropertyChanged("DepartmentNumber");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="PartsDescription", Storage="_description", FieldType="Text")]
		public string Description {
			get {
				return this._description;
			}
			set {
				if ((value != this._description)) {
					this.OnPropertyChanging("Description", this._description);
					this._description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="DepartmentLookup", Storage="_machineDepartment", ReadOnly=true, MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Backward, List="Machine Departments")]
		public Microsoft.SharePoint.Linq.EntitySet<MachineDepartment> MachineDepartment {
			get {
				return this._machineDepartment;
			}
			set {
				this._machineDepartment.Assign(value);
			}
		}
		
		private void OnMachineDepartmentChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("MachineDepartment", this._machineDepartment.Clone());
		}
		
		private void OnMachineDepartmentChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("MachineDepartment");
		}
		
		private void OnMachineDepartmentSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<MachineDepartment> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.Department = this;
			}
			else {
				e.Item.Department = null;
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Inventory Location", Id="0x01003ADD73260584374BA9AF545AB6ECF52B")]
	public partial class InventoryLocation : Item {
		
		private string _binNumber;
		
		private System.Nullable<double> _quantity;
		
		private Microsoft.SharePoint.Linq.EntityRef<Part> _part;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public InventoryLocation() {
			this._part = new Microsoft.SharePoint.Linq.EntityRef<Part>();
			this._part.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Part>>(this.OnPartSync);
			this._part.OnChanged += new System.EventHandler(this.OnPartChanged);
			this._part.OnChanging += new System.EventHandler(this.OnPartChanging);
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="BinNumber", Storage="_binNumber", Required=true, FieldType="Text")]
		public string BinNumber {
			get {
				return this._binNumber;
			}
			set {
				if ((value != this._binNumber)) {
					this.OnPropertyChanging("BinNumber", this._binNumber);
					this._binNumber = value;
					this.OnPropertyChanged("BinNumber");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Quantity", Storage="_quantity", Required=true, FieldType="Number")]
		public System.Nullable<double> Quantity {
			get {
				return this._quantity;
			}
			set {
				if ((value != this._quantity)) {
					this.OnPropertyChanging("Quantity", this._quantity);
					this._quantity = value;
					this.OnPropertyChanged("Quantity");
				}
			}
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		[Microsoft.SharePoint.Linq.RemovedColumnAttribute()]
		public override string Title {
			get {
				throw new System.InvalidOperationException("Field Title was removed from content type Inventory Location.");
			}
			set {
				throw new System.InvalidOperationException("Field Title was removed from content type Inventory Location.");
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="PartLookup", Storage="_part", MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Single, List="Parts")]
		public Part Part {
			get {
				return this._part.GetEntity();
			}
			set {
				this._part.SetEntity(value);
			}
		}
		
		private void OnPartChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Part", this._part.Clone());
		}
		
		private void OnPartChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Part");
		}
		
		private void OnPartSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Part> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.InventoryLocation.Add(this);
			}
			else {
				e.Item.InventoryLocation.Remove(this);
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Machine Department", Id="0x0100F8A89D8611A0E8439DC1395EE949C21A")]
	public partial class MachineDepartment : Item {
		
		private string _description;
		
		private Microsoft.SharePoint.Linq.EntityRef<Machine> _machine;
		
		private Microsoft.SharePoint.Linq.EntityRef<Department> _department;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public MachineDepartment() {
			this._machine = new Microsoft.SharePoint.Linq.EntityRef<Machine>();
			this._machine.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Machine>>(this.OnMachineSync);
			this._machine.OnChanged += new System.EventHandler(this.OnMachineChanged);
			this._machine.OnChanging += new System.EventHandler(this.OnMachineChanging);
			this._department = new Microsoft.SharePoint.Linq.EntityRef<Department>();
			this._department.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Department>>(this.OnDepartmentSync);
			this._department.OnChanged += new System.EventHandler(this.OnDepartmentChanged);
			this._department.OnChanging += new System.EventHandler(this.OnDepartmentChanging);
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="PartsDescription", Storage="_description", Required=true, FieldType="Text")]
		public string Description {
			get {
				return this._description;
			}
			set {
				if ((value != this._description)) {
					this.OnPropertyChanging("Description", this._description);
					this._description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		[Microsoft.SharePoint.Linq.RemovedColumnAttribute()]
		public override string Title {
			get {
				throw new System.InvalidOperationException("Field Title was removed from content type Machine Department.");
			}
			set {
				throw new System.InvalidOperationException("Field Title was removed from content type Machine Department.");
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="MachineLookup", Storage="_machine", MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Single, List="Machines")]
		public Machine Machine {
			get {
				return this._machine.GetEntity();
			}
			set {
				this._machine.SetEntity(value);
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="DepartmentLookup", Storage="_department", MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Single, List="Departments")]
		public Department Department {
			get {
				return this._department.GetEntity();
			}
			set {
				this._department.SetEntity(value);
			}
		}
		
		private void OnMachineChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Machine", this._machine.Clone());
		}
		
		private void OnMachineChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Machine");
		}
		
		private void OnMachineSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Machine> e) {
		}
		
		private void OnDepartmentChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Department", this._department.Clone());
		}
		
		private void OnDepartmentChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Department");
		}
		
		private void OnDepartmentSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Department> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.MachineDepartment.Add(this);
			}
			else {
				e.Item.MachineDepartment.Remove(this);
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Machine Part", Id="0x0100220B06426A421E41A0CA50F1FA1F421F")]
	public partial class MachinePart : Item {
		
		private Microsoft.SharePoint.Linq.EntityRef<Machine> _machine;
		
		private Microsoft.SharePoint.Linq.EntityRef<Part> _part;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public MachinePart() {
			this._machine = new Microsoft.SharePoint.Linq.EntityRef<Machine>();
			this._machine.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Machine>>(this.OnMachineSync);
			this._machine.OnChanged += new System.EventHandler(this.OnMachineChanged);
			this._machine.OnChanging += new System.EventHandler(this.OnMachineChanging);
			this._part = new Microsoft.SharePoint.Linq.EntityRef<Part>();
			this._part.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Part>>(this.OnPartSync);
			this._part.OnChanged += new System.EventHandler(this.OnPartChanged);
			this._part.OnChanging += new System.EventHandler(this.OnPartChanging);
			this.OnCreated();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		[Microsoft.SharePoint.Linq.RemovedColumnAttribute()]
		public override string Title {
			get {
				throw new System.InvalidOperationException("Field Title was removed from content type Machine Part.");
			}
			set {
				throw new System.InvalidOperationException("Field Title was removed from content type Machine Part.");
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="MachineLookup", Storage="_machine", MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Single, List="Machines")]
		public Machine Machine {
			get {
				return this._machine.GetEntity();
			}
			set {
				this._machine.SetEntity(value);
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="PartLookup", Storage="_part", MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Single, List="Parts")]
		public Part Part {
			get {
				return this._part.GetEntity();
			}
			set {
				this._part.SetEntity(value);
			}
		}
		
		private void OnMachineChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Machine", this._machine.Clone());
		}
		
		private void OnMachineChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Machine");
		}
		
		private void OnMachineSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Machine> e) {
		}
		
		private void OnPartChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Part", this._part.Clone());
		}
		
		private void OnPartChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Part");
		}
		
		private void OnPartSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Part> e) {
		}
	}
	
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Machine", Id="0x01002131F2F6C84FE042A765CDC2C96765F4")]
	public partial class Machine : Item {
		
		private string _modelNumber;
		
		private Microsoft.SharePoint.Linq.EntityRef<Manufacturer> _manufacturer;
		
		private Microsoft.SharePoint.Linq.EntityRef<Category> _category;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Machine() {
			this._manufacturer = new Microsoft.SharePoint.Linq.EntityRef<Manufacturer>();
			this._manufacturer.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Manufacturer>>(this.OnManufacturerSync);
			this._manufacturer.OnChanged += new System.EventHandler(this.OnManufacturerChanged);
			this._manufacturer.OnChanging += new System.EventHandler(this.OnManufacturerChanging);
			this._category = new Microsoft.SharePoint.Linq.EntityRef<Category>();
			this._category.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Category>>(this.OnCategorySync);
			this._category.OnChanged += new System.EventHandler(this.OnCategoryChanged);
			this._category.OnChanging += new System.EventHandler(this.OnCategoryChanging);
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="ModelNumber", Storage="_modelNumber", Required=true, FieldType="Text")]
		public string ModelNumber {
			get {
				return this._modelNumber;
			}
			set {
				if ((value != this._modelNumber)) {
					this.OnPropertyChanging("ModelNumber", this._modelNumber);
					this._modelNumber = value;
					this.OnPropertyChanged("ModelNumber");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="ManufacturerLookup", Storage="_manufacturer", MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Single, List="Manufacturers")]
		public Manufacturer Manufacturer {
			get {
				return this._manufacturer.GetEntity();
			}
			set {
				this._manufacturer.SetEntity(value);
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="CategoryLookup", Storage="_category", MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Single, List="Categories")]
		public Category Category {
			get {
				return this._category.GetEntity();
			}
			set {
				this._category.SetEntity(value);
			}
		}
		
		private void OnManufacturerChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Manufacturer", this._manufacturer.Clone());
		}
		
		private void OnManufacturerChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Manufacturer");
		}
		
		private void OnManufacturerSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Manufacturer> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.Machine.Add(this);
			}
			else {
				e.Item.Machine.Remove(this);
			}
		}
		
		private void OnCategoryChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Category", this._category.Clone());
		}
		
		private void OnCategoryChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Category");
		}
		
		private void OnCategorySync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Category> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.Machine.Add(this);
			}
			else {
				e.Item.Machine.Remove(this);
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Manufacturer", Id="0x0100AE7CD2D2A3D4BC469EB4E95692B750F3")]
	public partial class Manufacturer : Item {
		
		private string _manufacturerAddress;
		
		private Microsoft.SharePoint.Linq.EntitySet<Machine> _machine;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Manufacturer() {
			this._machine = new Microsoft.SharePoint.Linq.EntitySet<Machine>();
			this._machine.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Machine>>(this.OnMachineSync);
			this._machine.OnChanged += new System.EventHandler(this.OnMachineChanged);
			this._machine.OnChanging += new System.EventHandler(this.OnMachineChanging);
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="ManufacturerAddress", Storage="_manufacturerAddress", FieldType="Text")]
		public string ManufacturerAddress {
			get {
				return this._manufacturerAddress;
			}
			set {
				if ((value != this._manufacturerAddress)) {
					this.OnPropertyChanging("ManufacturerAddress", this._manufacturerAddress);
					this._manufacturerAddress = value;
					this.OnPropertyChanged("ManufacturerAddress");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="ManufacturerLookup", Storage="_machine", ReadOnly=true, MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Backward, List="Machines")]
		public Microsoft.SharePoint.Linq.EntitySet<Machine> Machine {
			get {
				return this._machine;
			}
			set {
				this._machine.Assign(value);
			}
		}
		
		private void OnMachineChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Machine", this._machine.Clone());
		}
		
		private void OnMachineChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Machine");
		}
		
		private void OnMachineSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Machine> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.Manufacturer = this;
			}
			else {
				e.Item.Manufacturer = null;
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Part Supplier", Id="0x0100679072FB68AF53409FD9F7E845B4D053")]
	public partial class PartSupplier : Item {
		
		private Microsoft.SharePoint.Linq.EntityRef<Part> _part;
		
		private Microsoft.SharePoint.Linq.EntityRef<Supplier> _supplier;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public PartSupplier() {
			this._part = new Microsoft.SharePoint.Linq.EntityRef<Part>();
			this._part.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Part>>(this.OnPartSync);
			this._part.OnChanged += new System.EventHandler(this.OnPartChanged);
			this._part.OnChanging += new System.EventHandler(this.OnPartChanging);
			this._supplier = new Microsoft.SharePoint.Linq.EntityRef<Supplier>();
			this._supplier.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Supplier>>(this.OnSupplierSync);
			this._supplier.OnChanged += new System.EventHandler(this.OnSupplierChanged);
			this._supplier.OnChanging += new System.EventHandler(this.OnSupplierChanging);
			this.OnCreated();
		}
		
		[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
		[Microsoft.SharePoint.Linq.RemovedColumnAttribute()]
		public override string Title {
			get {
				throw new System.InvalidOperationException("Field Title was removed from content type Part Supplier.");
			}
			set {
				throw new System.InvalidOperationException("Field Title was removed from content type Part Supplier.");
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="PartLookup", Storage="_part", MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Single, List="Parts")]
		public Part Part {
			get {
				return this._part.GetEntity();
			}
			set {
				this._part.SetEntity(value);
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="SupplierLookup", Storage="_supplier", MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Single, List="Suppliers")]
		public Supplier Supplier {
			get {
				return this._supplier.GetEntity();
			}
			set {
				this._supplier.SetEntity(value);
			}
		}
		
		private void OnPartChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Part", this._part.Clone());
		}
		
		private void OnPartChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Part");
		}
		
		private void OnPartSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Part> e) {
		}
		
		private void OnSupplierChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("Supplier", this._supplier.Clone());
		}
		
		private void OnSupplierChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("Supplier");
		}
		
		private void OnSupplierSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<Supplier> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.PartSupplier.Add(this);
			}
			else {
				e.Item.PartSupplier.Remove(this);
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Part", Id="0x01001966A9D6EDFEB845A8DD2DDA365BF5DC")]
	public partial class Part : Item {
		
		private string _sKU;
		
		private string _description;
		
		private Microsoft.SharePoint.Linq.EntitySet<InventoryLocation> _inventoryLocation;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Part() {
			this._inventoryLocation = new Microsoft.SharePoint.Linq.EntitySet<InventoryLocation>();
			this._inventoryLocation.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<InventoryLocation>>(this.OnInventoryLocationSync);
			this._inventoryLocation.OnChanged += new System.EventHandler(this.OnInventoryLocationChanged);
			this._inventoryLocation.OnChanging += new System.EventHandler(this.OnInventoryLocationChanging);
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="SKU", Storage="_sKU", Required=true, FieldType="Text")]
		public string SKU {
			get {
				return this._sKU;
			}
			set {
				if ((value != this._sKU)) {
					this.OnPropertyChanging("SKU", this._sKU);
					this._sKU = value;
					this.OnPropertyChanged("SKU");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="PartsDescription", Storage="_description", Required=true, FieldType="Text")]
		public string Description {
			get {
				return this._description;
			}
			set {
				if ((value != this._description)) {
					this.OnPropertyChanging("Description", this._description);
					this._description = value;
					this.OnPropertyChanged("Description");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="PartLookup", Storage="_inventoryLocation", ReadOnly=true, MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Backward, List="Inventory Locations")]
		public Microsoft.SharePoint.Linq.EntitySet<InventoryLocation> InventoryLocation {
			get {
				return this._inventoryLocation;
			}
			set {
				this._inventoryLocation.Assign(value);
			}
		}
		
		private void OnInventoryLocationChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("InventoryLocation", this._inventoryLocation.Clone());
		}
		
		private void OnInventoryLocationChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("InventoryLocation");
		}
		
		private void OnInventoryLocationSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<InventoryLocation> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.Part = this;
			}
			else {
				e.Item.Part = null;
			}
		}
	}
	
	[Microsoft.SharePoint.Linq.ContentTypeAttribute(Name="Supplier", Id="0x0100C8F084CAA9580A4CB3E1B290909459F6")]
	public partial class Supplier : Item {
		
		private string _dUNS;
		
		private System.Nullable<double> _rating;
		
		private Microsoft.SharePoint.Linq.EntitySet<PartSupplier> _partSupplier;
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate();
		partial void OnCreated();
		#endregion
		
		public Supplier() {
			this._partSupplier = new Microsoft.SharePoint.Linq.EntitySet<PartSupplier>();
			this._partSupplier.OnSync += new System.EventHandler<Microsoft.SharePoint.Linq.AssociationChangedEventArgs<PartSupplier>>(this.OnPartSupplierSync);
			this._partSupplier.OnChanged += new System.EventHandler(this.OnPartSupplierChanged);
			this._partSupplier.OnChanging += new System.EventHandler(this.OnPartSupplierChanging);
			this.OnCreated();
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="DUNS", Storage="_dUNS", Required=true, FieldType="Text")]
		public string DUNS {
			get {
				return this._dUNS;
			}
			set {
				if ((value != this._dUNS)) {
					this.OnPropertyChanging("DUNS", this._dUNS);
					this._dUNS = value;
					this.OnPropertyChanged("DUNS");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.ColumnAttribute(Name="Rating", Storage="_rating", Required=true, FieldType="Number")]
		public System.Nullable<double> Rating {
			get {
				return this._rating;
			}
			set {
				if ((value != this._rating)) {
					this.OnPropertyChanging("Rating", this._rating);
					this._rating = value;
					this.OnPropertyChanged("Rating");
				}
			}
		}
		
		[Microsoft.SharePoint.Linq.AssociationAttribute(Name="SupplierLookup", Storage="_partSupplier", ReadOnly=true, MultivalueType=Microsoft.SharePoint.Linq.AssociationType.Backward, List="Part Suppliers")]
		public Microsoft.SharePoint.Linq.EntitySet<PartSupplier> PartSupplier {
			get {
				return this._partSupplier;
			}
			set {
				this._partSupplier.Assign(value);
			}
		}
		
		private void OnPartSupplierChanging(object sender, System.EventArgs e) {
			this.OnPropertyChanging("PartSupplier", this._partSupplier.Clone());
		}
		
		private void OnPartSupplierChanged(object sender, System.EventArgs e) {
			this.OnPropertyChanged("PartSupplier");
		}
		
		private void OnPartSupplierSync(object sender, Microsoft.SharePoint.Linq.AssociationChangedEventArgs<PartSupplier> e) {
			if ((Microsoft.SharePoint.Linq.AssociationChangedState.Added == e.State)) {
				e.Item.Supplier = this;
			}
			else {
				e.Item.Supplier = null;
			}
		}
	}
}
