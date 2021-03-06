﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication_Assignment3.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LMS")]
	public partial class BookClassDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertbook(book instance);
    partial void Updatebook(book instance);
    partial void Deletebook(book instance);
    #endregion
		
		public BookClassDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["LMSConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BookClassDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BookClassDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BookClassDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BookClassDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<book> books
		{
			get
			{
				return this.GetTable<book>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.books")]
	public partial class book : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _bookName;
		
		private string _bookAuthor;
		
		private string _bookEdition;
		
		private string _bookCategory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnbookNameChanging(string value);
    partial void OnbookNameChanged();
    partial void OnbookAuthorChanging(string value);
    partial void OnbookAuthorChanged();
    partial void OnbookEditionChanging(string value);
    partial void OnbookEditionChanged();
    partial void OnbookCategoryChanging(string value);
    partial void OnbookCategoryChanged();
    #endregion
		
		public book()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookName", DbType="NChar(50)")]
		public string bookName
		{
			get
			{
				return this._bookName;
			}
			set
			{
				if ((this._bookName != value))
				{
					this.OnbookNameChanging(value);
					this.SendPropertyChanging();
					this._bookName = value;
					this.SendPropertyChanged("bookName");
					this.OnbookNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookAuthor", DbType="NChar(50)")]
		public string bookAuthor
		{
			get
			{
				return this._bookAuthor;
			}
			set
			{
				if ((this._bookAuthor != value))
				{
					this.OnbookAuthorChanging(value);
					this.SendPropertyChanging();
					this._bookAuthor = value;
					this.SendPropertyChanged("bookAuthor");
					this.OnbookAuthorChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookEdition", DbType="NChar(10)")]
		public string bookEdition
		{
			get
			{
				return this._bookEdition;
			}
			set
			{
				if ((this._bookEdition != value))
				{
					this.OnbookEditionChanging(value);
					this.SendPropertyChanging();
					this._bookEdition = value;
					this.SendPropertyChanged("bookEdition");
					this.OnbookEditionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bookCategory", DbType="NChar(20)")]
		public string bookCategory
		{
			get
			{
				return this._bookCategory;
			}
			set
			{
				if ((this._bookCategory != value))
				{
					this.OnbookCategoryChanging(value);
					this.SendPropertyChanging();
					this._bookCategory = value;
					this.SendPropertyChanged("bookCategory");
					this.OnbookCategoryChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
