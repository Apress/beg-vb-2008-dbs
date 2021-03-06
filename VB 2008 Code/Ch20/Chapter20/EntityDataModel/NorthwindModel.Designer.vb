'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1433
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

<Assembly: Global.System.Data.Objects.DataClasses.EdmSchemaAttribute("3367ad55-f653-4f4e-b46e-23f126695da3"),  _
 Assembly: Global.System.Data.Objects.DataClasses.EdmRelationshipAttribute("NorthwindModel", "FK_Employees_Employees", "Employees", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, GetType(NorthwindModel.Employees), "Employees1", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(NorthwindModel.Employees)),  _
 Assembly: Global.System.Data.Objects.DataClasses.EdmRelationshipAttribute("NorthwindModel", "FK_EmployeeTerritories_Employees", "Employees", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.One, GetType(NorthwindModel.Employees), "EmployeeTerritories", Global.System.Data.Metadata.Edm.RelationshipMultiplicity.Many, GetType(NorthwindModel.EmployeeTerritories))> 

'Original file name:
'Generation date: 2/20/2008 2:54:22 AM
Namespace NorthwindModel
    '''<summary>
    '''There are no comments for NorthwindEntitiesConnectionString in the schema.
    '''</summary>
    Partial Public Class NorthwindEntitiesConnectionString
        Inherits Global.System.Data.Objects.ObjectContext
        '''<summary>
        '''Initializes a new NorthwindEntitiesConnectionString object using the connection string found in the 'NorthwindEntitiesConnectionString' section of the application configuration file.
        '''</summary>
        Public Sub New()
            MyBase.New("name=NorthwindEntitiesConnectionString", "NorthwindEntitiesConnectionString")
        End Sub
        '''<summary>
        '''Initialize a new NorthwindEntitiesConnectionString object.
        '''</summary>
        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString, "NorthwindEntitiesConnectionString")
        End Sub
        '''<summary>
        '''Initialize a new NorthwindEntitiesConnectionString object.
        '''</summary>
        Public Sub New(ByVal connection As Global.System.Data.EntityClient.EntityConnection)
            MyBase.New(connection, "NorthwindEntitiesConnectionString")
        End Sub
        '''<summary>
        '''There are no comments for Employees in the schema.
        '''</summary>
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public ReadOnly Property Employees() As Global.System.Data.Objects.ObjectQuery(Of Employees)
            Get
                If (Me._Employees Is Nothing) Then
                    Me._Employees = MyBase.CreateQuery(Of Employees)("[Employees]")
                End If
                Return Me._Employees
            End Get
        End Property
        Private _Employees As Global.System.Data.Objects.ObjectQuery(Of Employees)
        '''<summary>
        '''There are no comments for EmployeeTerritories in the schema.
        '''</summary>
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public ReadOnly Property EmployeeTerritories() As Global.System.Data.Objects.ObjectQuery(Of EmployeeTerritories)
            Get
                If (Me._EmployeeTerritories Is Nothing) Then
                    Me._EmployeeTerritories = MyBase.CreateQuery(Of EmployeeTerritories)("[EmployeeTerritories]")
                End If
                Return Me._EmployeeTerritories
            End Get
        End Property
        Private _EmployeeTerritories As Global.System.Data.Objects.ObjectQuery(Of EmployeeTerritories)
        '''<summary>
        '''There are no comments for Employees in the schema.
        '''</summary>
        Public Sub AddToEmployees(ByVal employees As Employees)
            MyBase.AddObject("Employees", employees)
        End Sub
        '''<summary>
        '''There are no comments for EmployeeTerritories in the schema.
        '''</summary>
        Public Sub AddToEmployeeTerritories(ByVal employeeTerritories As EmployeeTerritories)
            MyBase.AddObject("EmployeeTerritories", employeeTerritories)
        End Sub
    End Class
    '''<summary>
    '''There are no comments for NorthwindModel.Employees in the schema.
    '''</summary>
    '''<KeyProperties>
    '''EmployeeID
    '''</KeyProperties>
    <Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="NorthwindModel", Name:="Employees"),  _
     Global.System.Runtime.Serialization.DataContractAttribute(),  _
     Global.System.Serializable()>  _
    Partial Public Class Employees
        Inherits Global.System.Data.Objects.DataClasses.EntityObject
        '''<summary>
        '''Create a new Employees object.
        '''</summary>
        '''<param name="employeeID">Initial value of EmployeeID.</param>
        '''<param name="lastName">Initial value of LastName.</param>
        '''<param name="firstName">Initial value of FirstName.</param>
        Public Shared Function CreateEmployees(ByVal employeeID As Integer, ByVal lastName As String, ByVal firstName As String) As Employees
            Dim employees As Employees = New Employees
            employees.EmployeeID = employeeID
            employees.LastName = lastName
            employees.FirstName = firstName
            Return employees
        End Function
        '''<summary>
        '''There are no comments for Property EmployeeID in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property EmployeeID() As Integer
            Get
                Return Me._EmployeeID
            End Get
            Set
                Me.OnEmployeeIDChanging(value)
                Me.ReportPropertyChanging("EmployeeID")
                Me._EmployeeID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("EmployeeID")
                Me.OnEmployeeIDChanged
            End Set
        End Property
        Private _EmployeeID As Integer
        Partial Private Sub OnEmployeeIDChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnEmployeeIDChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property LastName in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property LastName() As String
            Get
                Return Me._LastName
            End Get
            Set
                Me.OnLastNameChanging(value)
                Me.ReportPropertyChanging("LastName")
                Me._LastName = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false, 20)
                Me.ReportPropertyChanged("LastName")
                Me.OnLastNameChanged
            End Set
        End Property
        Private _LastName As String
        Partial Private Sub OnLastNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnLastNameChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property FirstName in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable:=false),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property FirstName() As String
            Get
                Return Me._FirstName
            End Get
            Set
                Me.OnFirstNameChanging(value)
                Me.ReportPropertyChanging("FirstName")
                Me._FirstName = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false, 10)
                Me.ReportPropertyChanged("FirstName")
                Me.OnFirstNameChanged
            End Set
        End Property
        Private _FirstName As String
        Partial Private Sub OnFirstNameChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnFirstNameChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Title in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Title() As String
            Get
                Return Me._Title
            End Get
            Set
                Me.OnTitleChanging(value)
                Me.ReportPropertyChanging("Title")
                Me._Title = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true, 30)
                Me.ReportPropertyChanged("Title")
                Me.OnTitleChanged
            End Set
        End Property
        Private _Title As String
        Partial Private Sub OnTitleChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnTitleChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property TitleOfCourtesy in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property TitleOfCourtesy() As String
            Get
                Return Me._TitleOfCourtesy
            End Get
            Set
                Me.OnTitleOfCourtesyChanging(value)
                Me.ReportPropertyChanging("TitleOfCourtesy")
                Me._TitleOfCourtesy = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true, 25)
                Me.ReportPropertyChanged("TitleOfCourtesy")
                Me.OnTitleOfCourtesyChanged
            End Set
        End Property
        Private _TitleOfCourtesy As String
        Partial Private Sub OnTitleOfCourtesyChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnTitleOfCourtesyChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property BirthDate in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property BirthDate() As Global.System.Nullable(Of Date)
            Get
                Return Me._BirthDate
            End Get
            Set
                Me.OnBirthDateChanging(value)
                Me.ReportPropertyChanging("BirthDate")
                Me._BirthDate = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, Global.System.DateTimeKind.Unspecified, true)
                Me.ReportPropertyChanged("BirthDate")
                Me.OnBirthDateChanged
            End Set
        End Property
        Private _BirthDate As Global.System.Nullable(Of Date)
        Partial Private Sub OnBirthDateChanging(ByVal value As Global.System.Nullable(Of Date))
        End Sub
        Partial Private Sub OnBirthDateChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property HireDate in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property HireDate() As Global.System.Nullable(Of Date)
            Get
                Return Me._HireDate
            End Get
            Set
                Me.OnHireDateChanging(value)
                Me.ReportPropertyChanging("HireDate")
                Me._HireDate = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, Global.System.DateTimeKind.Unspecified, true)
                Me.ReportPropertyChanged("HireDate")
                Me.OnHireDateChanged
            End Set
        End Property
        Private _HireDate As Global.System.Nullable(Of Date)
        Partial Private Sub OnHireDateChanging(ByVal value As Global.System.Nullable(Of Date))
        End Sub
        Partial Private Sub OnHireDateChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Address in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Address() As String
            Get
                Return Me._Address
            End Get
            Set
                Me.OnAddressChanging(value)
                Me.ReportPropertyChanging("Address")
                Me._Address = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true, 60)
                Me.ReportPropertyChanged("Address")
                Me.OnAddressChanged
            End Set
        End Property
        Private _Address As String
        Partial Private Sub OnAddressChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnAddressChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property City in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property City() As String
            Get
                Return Me._City
            End Get
            Set
                Me.OnCityChanging(value)
                Me.ReportPropertyChanging("City")
                Me._City = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true, 15)
                Me.ReportPropertyChanged("City")
                Me.OnCityChanged
            End Set
        End Property
        Private _City As String
        Partial Private Sub OnCityChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnCityChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Region in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Region() As String
            Get
                Return Me._Region
            End Get
            Set
                Me.OnRegionChanging(value)
                Me.ReportPropertyChanging("Region")
                Me._Region = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true, 15)
                Me.ReportPropertyChanged("Region")
                Me.OnRegionChanged
            End Set
        End Property
        Private _Region As String
        Partial Private Sub OnRegionChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnRegionChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property PostalCode in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property PostalCode() As String
            Get
                Return Me._PostalCode
            End Get
            Set
                Me.OnPostalCodeChanging(value)
                Me.ReportPropertyChanging("PostalCode")
                Me._PostalCode = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true, 10)
                Me.ReportPropertyChanged("PostalCode")
                Me.OnPostalCodeChanged
            End Set
        End Property
        Private _PostalCode As String
        Partial Private Sub OnPostalCodeChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnPostalCodeChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Country in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Country() As String
            Get
                Return Me._Country
            End Get
            Set
                Me.OnCountryChanging(value)
                Me.ReportPropertyChanging("Country")
                Me._Country = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true, 15)
                Me.ReportPropertyChanged("Country")
                Me.OnCountryChanged
            End Set
        End Property
        Private _Country As String
        Partial Private Sub OnCountryChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnCountryChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property HomePhone in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property HomePhone() As String
            Get
                Return Me._HomePhone
            End Get
            Set
                Me.OnHomePhoneChanging(value)
                Me.ReportPropertyChanging("HomePhone")
                Me._HomePhone = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true, 24)
                Me.ReportPropertyChanged("HomePhone")
                Me.OnHomePhoneChanged
            End Set
        End Property
        Private _HomePhone As String
        Partial Private Sub OnHomePhoneChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnHomePhoneChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Extension in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Extension() As String
            Get
                Return Me._Extension
            End Get
            Set
                Me.OnExtensionChanging(value)
                Me.ReportPropertyChanging("Extension")
                Me._Extension = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true, 4)
                Me.ReportPropertyChanged("Extension")
                Me.OnExtensionChanged
            End Set
        End Property
        Private _Extension As String
        Partial Private Sub OnExtensionChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnExtensionChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Photo in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Photo() As Byte()
            Get
                Return Global.System.Data.Objects.DataClasses.StructuralObject.GetValidValue(Me._Photo)
            End Get
            Set
                Me.OnPhotoChanging(value)
                Me.ReportPropertyChanging("Photo")
                Me._Photo = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true, 2147483647)
                Me.ReportPropertyChanged("Photo")
                Me.OnPhotoChanged
            End Set
        End Property
        Private _Photo() As Byte
        Partial Private Sub OnPhotoChanging(ByVal value() As Byte)
        End Sub
        Partial Private Sub OnPhotoChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property Notes in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Notes() As String
            Get
                Return Me._Notes
            End Get
            Set
                Me.OnNotesChanging(value)
                Me.ReportPropertyChanging("Notes")
                Me._Notes = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true, 1073741823)
                Me.ReportPropertyChanged("Notes")
                Me.OnNotesChanged
            End Set
        End Property
        Private _Notes As String
        Partial Private Sub OnNotesChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnNotesChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property PhotoPath in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property PhotoPath() As String
            Get
                Return Me._PhotoPath
            End Get
            Set
                Me.OnPhotoPathChanging(value)
                Me.ReportPropertyChanging("PhotoPath")
                Me._PhotoPath = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true, 255)
                Me.ReportPropertyChanged("PhotoPath")
                Me.OnPhotoPathChanged
            End Set
        End Property
        Private _PhotoPath As String
        Partial Private Sub OnPhotoPathChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnPhotoPathChanged()
        End Sub
        '''<summary>
        '''There are no comments for Employees1 in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("NorthwindModel", "FK_Employees_Employees", "Employees1"),  _
         Global.System.Xml.Serialization.XmlIgnoreAttribute(),  _
         Global.System.Xml.Serialization.SoapIgnoreAttribute(),  _
         Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public ReadOnly Property Employees1() As Global.System.Data.Objects.DataClasses.EntityCollection(Of Employees)
            Get
                Return CType(Me,Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of Employees)("NorthwindModel.FK_Employees_Employees", "Employees1")
            End Get
        End Property
        '''<summary>
        '''There are no comments for Employees2 in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("NorthwindModel", "FK_Employees_Employees", "Employees"),  _
         Global.System.Xml.Serialization.XmlIgnoreAttribute(),  _
         Global.System.Xml.Serialization.SoapIgnoreAttribute(),  _
         Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property Employees2() As Employees
            Get
                Return CType(Me,Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Employees)("NorthwindModel.FK_Employees_Employees", "Employees").Value
            End Get
            Set
                CType(Me,Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Employees)("NorthwindModel.FK_Employees_Employees", "Employees").Value = value
            End Set
        End Property
        '''<summary>
        '''There are no comments for Employees2 in the schema.
        '''</summary>
        <Global.System.Runtime.Serialization.DataMemberAttribute(),  _
         Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property Employees2Reference() As Global.System.Data.Objects.DataClasses.EntityReference(Of Employees)
            Get
                Return CType(Me,Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Employees)("NorthwindModel.FK_Employees_Employees", "Employees")
            End Get
            Set
                If (Not (value) Is Nothing) Then
                    CType(Me,Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of Employees)("NorthwindModel.FK_Employees_Employees", "Employees", value)
                End If
            End Set
        End Property
        '''<summary>
        '''There are no comments for EmployeeTerritories in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("NorthwindModel", "FK_EmployeeTerritories_Employees", "EmployeeTerritories"),  _
         Global.System.Xml.Serialization.XmlIgnoreAttribute(),  _
         Global.System.Xml.Serialization.SoapIgnoreAttribute(),  _
         Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public ReadOnly Property EmployeeTerritories() As Global.System.Data.Objects.DataClasses.EntityCollection(Of EmployeeTerritories)
            Get
                Return CType(Me,Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedCollection(Of EmployeeTerritories)("NorthwindModel.FK_EmployeeTerritories_Employees", "EmployeeTerritories")
            End Get
        End Property
    End Class
    '''<summary>
    '''There are no comments for NorthwindModel.EmployeeTerritories in the schema.
    '''</summary>
    '''<KeyProperties>
    '''EmployeeID
    '''TerritoryID
    '''</KeyProperties>
    <Global.System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName:="NorthwindModel", Name:="EmployeeTerritories"),  _
     Global.System.Runtime.Serialization.DataContractAttribute(),  _
     Global.System.Serializable()>  _
    Partial Public Class EmployeeTerritories
        Inherits Global.System.Data.Objects.DataClasses.EntityObject
        '''<summary>
        '''Create a new EmployeeTerritories object.
        '''</summary>
        '''<param name="employeeID">Initial value of EmployeeID.</param>
        '''<param name="territoryID">Initial value of TerritoryID.</param>
        Public Shared Function CreateEmployeeTerritories(ByVal employeeID As Integer, ByVal territoryID As String) As EmployeeTerritories
            Dim employeeTerritories As EmployeeTerritories = New EmployeeTerritories
            employeeTerritories.EmployeeID = employeeID
            employeeTerritories.TerritoryID = territoryID
            Return employeeTerritories
        End Function
        '''<summary>
        '''There are no comments for Property EmployeeID in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property EmployeeID() As Integer
            Get
                Return Me._EmployeeID
            End Get
            Set
                Me.OnEmployeeIDChanging(value)
                Me.ReportPropertyChanging("EmployeeID")
                Me._EmployeeID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value)
                Me.ReportPropertyChanged("EmployeeID")
                Me.OnEmployeeIDChanged
            End Set
        End Property
        Private _EmployeeID As Integer
        Partial Private Sub OnEmployeeIDChanging(ByVal value As Integer)
        End Sub
        Partial Private Sub OnEmployeeIDChanged()
        End Sub
        '''<summary>
        '''There are no comments for Property TerritoryID in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty:=true, IsNullable:=false),  _
         Global.System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property TerritoryID() As String
            Get
                Return Me._TerritoryID
            End Get
            Set
                Me.OnTerritoryIDChanging(value)
                Me.ReportPropertyChanging("TerritoryID")
                Me._TerritoryID = Global.System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false, 20)
                Me.ReportPropertyChanged("TerritoryID")
                Me.OnTerritoryIDChanged
            End Set
        End Property
        Private _TerritoryID As String
        Partial Private Sub OnTerritoryIDChanging(ByVal value As String)
        End Sub
        Partial Private Sub OnTerritoryIDChanged()
        End Sub
        '''<summary>
        '''There are no comments for Employees in the schema.
        '''</summary>
        <Global.System.Data.Objects.DataClasses.EdmRelationshipNavigationPropertyAttribute("NorthwindModel", "FK_EmployeeTerritories_Employees", "Employees"),  _
         Global.System.Xml.Serialization.XmlIgnoreAttribute(),  _
         Global.System.Xml.Serialization.SoapIgnoreAttribute(),  _
         Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property Employees() As Employees
            Get
                Return CType(Me,Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Employees)("NorthwindModel.FK_EmployeeTerritories_Employees", "Employees").Value
            End Get
            Set
                CType(Me,Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Employees)("NorthwindModel.FK_EmployeeTerritories_Employees", "Employees").Value = value
            End Set
        End Property
        '''<summary>
        '''There are no comments for Employees in the schema.
        '''</summary>
        <Global.System.Runtime.Serialization.DataMemberAttribute(),  _
         Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property EmployeesReference() As Global.System.Data.Objects.DataClasses.EntityReference(Of Employees)
            Get
                Return CType(Me,Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.GetRelatedReference(Of Employees)("NorthwindModel.FK_EmployeeTerritories_Employees", "Employees")
            End Get
            Set
                If (Not (value) Is Nothing) Then
                    CType(Me,Global.System.Data.Objects.DataClasses.IEntityWithRelationships).RelationshipManager.InitializeRelatedReference(Of Employees)("NorthwindModel.FK_EmployeeTerritories_Employees", "Employees", value)
                End If
            End Set
        End Property
    End Class
End Namespace
