<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.mainTabControl = New System.Windows.Forms.TabControl()
        Me.SDSLookupPage = New System.Windows.Forms.TabPage()
        Me.vendor2ComboBox = New System.Windows.Forms.ComboBox()
        Me.VendorListBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SDS_LogDataSet2 = New Safety_Data_Sheets.SDS_LogDataSet()
        Me.vendor1ComboBox = New System.Windows.Forms.ComboBox()
        Me.VendorListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SDS_LogDataSet = New Safety_Data_Sheets.SDS_LogDataSet()
        Me.selectHazardsButton = New System.Windows.Forms.Button()
        Me.resetSDSLookupButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clearSDSLookupButton = New System.Windows.Forms.Button()
        Me.vendor2EDSDSLookupDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.vender2EDSDSLookupLabel = New System.Windows.Forms.Label()
        Me.vender2SDSLookupLabel = New System.Windows.Forms.Label()
        Me.vendor1EDSDSLookupDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.vender1EDSDSLookupLabel = New System.Windows.Forms.Label()
        Me.vender1SDSLookupLabel = New System.Windows.Forms.Label()
        Me.hazardsSDSLookupTextBox = New System.Windows.Forms.TextBox()
        Me.hazardsSDSLookupLabel = New System.Windows.Forms.Label()
        Me.CASNumberSDSLookupTextBox = New System.Windows.Forms.TextBox()
        Me.CASNumberSDSLookupLabel = New System.Windows.Forms.Label()
        Me.saveSDSLookupButton = New System.Windows.Forms.Button()
        Me.materialSDSLookupLabel = New System.Windows.Forms.Label()
        Me.materialSDSLookupComboBox = New System.Windows.Forms.ComboBox()
        Me.SDSListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SDSLogPage = New System.Windows.Forms.TabPage()
        Me.SDSLogComboBox = New System.Windows.Forms.ComboBox()
        Me.getInfoSDSLogButton = New System.Windows.Forms.Button()
        Me.searchSDSLogLabel = New System.Windows.Forms.Label()
        Me.refreshSDSLogButton = New System.Windows.Forms.Button()
        Me.keywordSDSLogLabel = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.searchSDSLogButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExportSDSLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SDS_ListTableAdapter = New Safety_Data_Sheets.SDS_LogDataSetTableAdapters.SDS_ListTableAdapter()
        Me.SDS_LogDataSet1 = New Safety_Data_Sheets.SDS_LogDataSet()
        Me.SDSLogBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SDS_LogTableAdapter = New Safety_Data_Sheets.SDS_LogDataSetTableAdapters.SDS_LogTableAdapter()
        Me.VendorListTableAdapter = New Safety_Data_Sheets.SDS_LogDataSetTableAdapters.VendorListTableAdapter()
        Me.VendorListTableAdapter1 = New Safety_Data_Sheets.SDS_LogDataSetTableAdapters.VendorListTableAdapter()
        Me.VendorList1TableAdapter = New Safety_Data_Sheets.SDS_LogDataSetTableAdapters.VendorList1TableAdapter()
        Me.mainTabControl.SuspendLayout()
        Me.SDSLookupPage.SuspendLayout()
        CType(Me.VendorListBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDS_LogDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendorListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDS_LogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDSListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SDSLogPage.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SDS_LogDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SDSLogBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainTabControl
        '
        Me.mainTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainTabControl.Controls.Add(Me.SDSLookupPage)
        Me.mainTabControl.Controls.Add(Me.SDSLogPage)
        Me.mainTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mainTabControl.Location = New System.Drawing.Point(12, 27)
        Me.mainTabControl.Name = "mainTabControl"
        Me.mainTabControl.Padding = New System.Drawing.Point(50, 10)
        Me.mainTabControl.SelectedIndex = 0
        Me.mainTabControl.Size = New System.Drawing.Size(643, 430)
        Me.mainTabControl.TabIndex = 45
        Me.mainTabControl.TabStop = False
        '
        'SDSLookupPage
        '
        Me.SDSLookupPage.Controls.Add(Me.vendor2ComboBox)
        Me.SDSLookupPage.Controls.Add(Me.vendor1ComboBox)
        Me.SDSLookupPage.Controls.Add(Me.selectHazardsButton)
        Me.SDSLookupPage.Controls.Add(Me.resetSDSLookupButton)
        Me.SDSLookupPage.Controls.Add(Me.Label1)
        Me.SDSLookupPage.Controls.Add(Me.clearSDSLookupButton)
        Me.SDSLookupPage.Controls.Add(Me.vendor2EDSDSLookupDateTimePicker)
        Me.SDSLookupPage.Controls.Add(Me.vender2EDSDSLookupLabel)
        Me.SDSLookupPage.Controls.Add(Me.vender2SDSLookupLabel)
        Me.SDSLookupPage.Controls.Add(Me.vendor1EDSDSLookupDateTimePicker)
        Me.SDSLookupPage.Controls.Add(Me.vender1EDSDSLookupLabel)
        Me.SDSLookupPage.Controls.Add(Me.vender1SDSLookupLabel)
        Me.SDSLookupPage.Controls.Add(Me.hazardsSDSLookupTextBox)
        Me.SDSLookupPage.Controls.Add(Me.hazardsSDSLookupLabel)
        Me.SDSLookupPage.Controls.Add(Me.CASNumberSDSLookupTextBox)
        Me.SDSLookupPage.Controls.Add(Me.CASNumberSDSLookupLabel)
        Me.SDSLookupPage.Controls.Add(Me.saveSDSLookupButton)
        Me.SDSLookupPage.Controls.Add(Me.materialSDSLookupLabel)
        Me.SDSLookupPage.Controls.Add(Me.materialSDSLookupComboBox)
        Me.SDSLookupPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SDSLookupPage.Location = New System.Drawing.Point(4, 43)
        Me.SDSLookupPage.Name = "SDSLookupPage"
        Me.SDSLookupPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SDSLookupPage.Size = New System.Drawing.Size(635, 383)
        Me.SDSLookupPage.TabIndex = 0
        Me.SDSLookupPage.Text = "SDS Lookup and Entry"
        Me.SDSLookupPage.UseVisualStyleBackColor = True
        '
        'vendor2ComboBox
        '
        Me.vendor2ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.vendor2ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.vendor2ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VendorListBindingSource2, "VendorName", True))
        Me.vendor2ComboBox.DataSource = Me.VendorListBindingSource2
        Me.vendor2ComboBox.DisplayMember = "VendorName"
        Me.vendor2ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vendor2ComboBox.FormattingEnabled = True
        Me.vendor2ComboBox.Location = New System.Drawing.Point(437, 265)
        Me.vendor2ComboBox.Name = "vendor2ComboBox"
        Me.vendor2ComboBox.Size = New System.Drawing.Size(150, 28)
        Me.vendor2ComboBox.TabIndex = 100
        Me.vendor2ComboBox.ValueMember = "VendorName"
        '
        'VendorListBindingSource2
        '
        Me.VendorListBindingSource2.DataMember = "VendorList1"
        Me.VendorListBindingSource2.DataSource = Me.SDS_LogDataSet2
        '
        'SDS_LogDataSet2
        '
        Me.SDS_LogDataSet2.DataSetName = "SDS_LogDataSet"
        Me.SDS_LogDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vendor1ComboBox
        '
        Me.vendor1ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.vendor1ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.vendor1ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VendorListBindingSource, "VendorName", True))
        Me.vendor1ComboBox.DataSource = Me.VendorListBindingSource
        Me.vendor1ComboBox.DisplayMember = "VendorName"
        Me.vendor1ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vendor1ComboBox.FormattingEnabled = True
        Me.vendor1ComboBox.Location = New System.Drawing.Point(119, 265)
        Me.vendor1ComboBox.Name = "vendor1ComboBox"
        Me.vendor1ComboBox.Size = New System.Drawing.Size(150, 28)
        Me.vendor1ComboBox.TabIndex = 99
        Me.vendor1ComboBox.ValueMember = "VendorName"
        '
        'VendorListBindingSource
        '
        Me.VendorListBindingSource.DataMember = "VendorList"
        Me.VendorListBindingSource.DataSource = Me.SDS_LogDataSet
        '
        'SDS_LogDataSet
        '
        Me.SDS_LogDataSet.DataSetName = "SDS_LogDataSet"
        Me.SDS_LogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'selectHazardsButton
        '
        Me.selectHazardsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectHazardsButton.Location = New System.Drawing.Point(20, 149)
        Me.selectHazardsButton.Name = "selectHazardsButton"
        Me.selectHazardsButton.Size = New System.Drawing.Size(84, 53)
        Me.selectHazardsButton.TabIndex = 98
        Me.selectHazardsButton.Text = "Select Hazards"
        Me.selectHazardsButton.UseVisualStyleBackColor = True
        '
        'resetSDSLookupButton
        '
        Me.resetSDSLookupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetSDSLookupButton.Location = New System.Drawing.Point(119, 339)
        Me.resetSDSLookupButton.Name = "resetSDSLookupButton"
        Me.resetSDSLookupButton.Size = New System.Drawing.Size(115, 30)
        Me.resetSDSLookupButton.TabIndex = 9
        Me.resetSDSLookupButton.TabStop = False
        Me.resetSDSLookupButton.Text = "Reset Data"
        Me.resetSDSLookupButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(418, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 20)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "* Required Information"
        '
        'clearSDSLookupButton
        '
        Me.clearSDSLookupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearSDSLookupButton.Location = New System.Drawing.Point(6, 339)
        Me.clearSDSLookupButton.Name = "clearSDSLookupButton"
        Me.clearSDSLookupButton.Size = New System.Drawing.Size(107, 30)
        Me.clearSDSLookupButton.TabIndex = 8
        Me.clearSDSLookupButton.TabStop = False
        Me.clearSDSLookupButton.Text = "Clear Form"
        Me.clearSDSLookupButton.UseVisualStyleBackColor = True
        '
        'vendor2EDSDSLookupDateTimePicker
        '
        Me.vendor2EDSDSLookupDateTimePicker.CustomFormat = "M/d/yyyy"
        Me.vendor2EDSDSLookupDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.vendor2EDSDSLookupDateTimePicker.Location = New System.Drawing.Point(437, 298)
        Me.vendor2EDSDSLookupDateTimePicker.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.vendor2EDSDSLookupDateTimePicker.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.vendor2EDSDSLookupDateTimePicker.Name = "vendor2EDSDSLookupDateTimePicker"
        Me.vendor2EDSDSLookupDateTimePicker.Size = New System.Drawing.Size(150, 26)
        Me.vendor2EDSDSLookupDateTimePicker.TabIndex = 7
        Me.vendor2EDSDSLookupDateTimePicker.Value = New Date(2015, 7, 8, 14, 27, 4, 0)
        '
        'vender2EDSDSLookupLabel
        '
        Me.vender2EDSDSLookupLabel.AutoSize = True
        Me.vender2EDSDSLookupLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vender2EDSDSLookupLabel.Location = New System.Drawing.Point(321, 301)
        Me.vender2EDSDSLookupLabel.Name = "vender2EDSDSLookupLabel"
        Me.vender2EDSDSLookupLabel.Size = New System.Drawing.Size(110, 20)
        Me.vender2EDSDSLookupLabel.TabIndex = 68
        Me.vender2EDSDSLookupLabel.Text = "Effective Date"
        '
        'vender2SDSLookupLabel
        '
        Me.vender2SDSLookupLabel.AutoSize = True
        Me.vender2SDSLookupLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vender2SDSLookupLabel.Location = New System.Drawing.Point(370, 268)
        Me.vender2SDSLookupLabel.Name = "vender2SDSLookupLabel"
        Me.vender2SDSLookupLabel.Size = New System.Drawing.Size(61, 20)
        Me.vender2SDSLookupLabel.TabIndex = 67
        Me.vender2SDSLookupLabel.Text = "Vendor"
        '
        'vendor1EDSDSLookupDateTimePicker
        '
        Me.vendor1EDSDSLookupDateTimePicker.CustomFormat = "M/d/yyyy"
        Me.vendor1EDSDSLookupDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.vendor1EDSDSLookupDateTimePicker.Location = New System.Drawing.Point(119, 298)
        Me.vendor1EDSDSLookupDateTimePicker.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.vendor1EDSDSLookupDateTimePicker.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.vendor1EDSDSLookupDateTimePicker.Name = "vendor1EDSDSLookupDateTimePicker"
        Me.vendor1EDSDSLookupDateTimePicker.Size = New System.Drawing.Size(150, 26)
        Me.vendor1EDSDSLookupDateTimePicker.TabIndex = 5
        Me.vendor1EDSDSLookupDateTimePicker.Value = New Date(2015, 7, 8, 14, 27, 4, 0)
        '
        'vender1EDSDSLookupLabel
        '
        Me.vender1EDSDSLookupLabel.AutoSize = True
        Me.vender1EDSDSLookupLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vender1EDSDSLookupLabel.Location = New System.Drawing.Point(-4, 301)
        Me.vender1EDSDSLookupLabel.Name = "vender1EDSDSLookupLabel"
        Me.vender1EDSDSLookupLabel.Size = New System.Drawing.Size(120, 20)
        Me.vender1EDSDSLookupLabel.TabIndex = 64
        Me.vender1EDSDSLookupLabel.Text = "* Effective Date"
        '
        'vender1SDSLookupLabel
        '
        Me.vender1SDSLookupLabel.AutoSize = True
        Me.vender1SDSLookupLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vender1SDSLookupLabel.Location = New System.Drawing.Point(45, 268)
        Me.vender1SDSLookupLabel.Name = "vender1SDSLookupLabel"
        Me.vender1SDSLookupLabel.Size = New System.Drawing.Size(71, 20)
        Me.vender1SDSLookupLabel.TabIndex = 63
        Me.vender1SDSLookupLabel.Text = "* Vendor"
        '
        'hazardsSDSLookupTextBox
        '
        Me.hazardsSDSLookupTextBox.Location = New System.Drawing.Point(110, 126)
        Me.hazardsSDSLookupTextBox.Multiline = True
        Me.hazardsSDSLookupTextBox.Name = "hazardsSDSLookupTextBox"
        Me.hazardsSDSLookupTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.hazardsSDSLookupTextBox.Size = New System.Drawing.Size(477, 118)
        Me.hazardsSDSLookupTextBox.TabIndex = 3
        '
        'hazardsSDSLookupLabel
        '
        Me.hazardsSDSLookupLabel.AutoSize = True
        Me.hazardsSDSLookupLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hazardsSDSLookupLabel.Location = New System.Drawing.Point(29, 126)
        Me.hazardsSDSLookupLabel.Name = "hazardsSDSLookupLabel"
        Me.hazardsSDSLookupLabel.Size = New System.Drawing.Size(79, 20)
        Me.hazardsSDSLookupLabel.TabIndex = 60
        Me.hazardsSDSLookupLabel.Text = "* Hazards"
        '
        'CASNumberSDSLookupTextBox
        '
        Me.CASNumberSDSLookupTextBox.Location = New System.Drawing.Point(110, 85)
        Me.CASNumberSDSLookupTextBox.Name = "CASNumberSDSLookupTextBox"
        Me.CASNumberSDSLookupTextBox.Size = New System.Drawing.Size(477, 26)
        Me.CASNumberSDSLookupTextBox.TabIndex = 2
        '
        'CASNumberSDSLookupLabel
        '
        Me.CASNumberSDSLookupLabel.AutoSize = True
        Me.CASNumberSDSLookupLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CASNumberSDSLookupLabel.Location = New System.Drawing.Point(-4, 88)
        Me.CASNumberSDSLookupLabel.Name = "CASNumberSDSLookupLabel"
        Me.CASNumberSDSLookupLabel.Size = New System.Drawing.Size(112, 20)
        Me.CASNumberSDSLookupLabel.TabIndex = 55
        Me.CASNumberSDSLookupLabel.Text = "* CAS Number"
        '
        'saveSDSLookupButton
        '
        Me.saveSDSLookupButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveSDSLookupButton.Location = New System.Drawing.Point(500, 339)
        Me.saveSDSLookupButton.Name = "saveSDSLookupButton"
        Me.saveSDSLookupButton.Size = New System.Drawing.Size(125, 30)
        Me.saveSDSLookupButton.TabIndex = 10
        Me.saveSDSLookupButton.Text = "Save"
        Me.saveSDSLookupButton.UseVisualStyleBackColor = True
        '
        'materialSDSLookupLabel
        '
        Me.materialSDSLookupLabel.AutoSize = True
        Me.materialSDSLookupLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.materialSDSLookupLabel.Location = New System.Drawing.Point(33, 41)
        Me.materialSDSLookupLabel.Name = "materialSDSLookupLabel"
        Me.materialSDSLookupLabel.Size = New System.Drawing.Size(75, 20)
        Me.materialSDSLookupLabel.TabIndex = 22
        Me.materialSDSLookupLabel.Text = "* Material"
        '
        'materialSDSLookupComboBox
        '
        Me.materialSDSLookupComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.materialSDSLookupComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.materialSDSLookupComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SDSListBindingSource, "Material", True))
        Me.materialSDSLookupComboBox.DataSource = Me.SDSListBindingSource
        Me.materialSDSLookupComboBox.DisplayMember = "Material"
        Me.materialSDSLookupComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.materialSDSLookupComboBox.FormattingEnabled = True
        Me.materialSDSLookupComboBox.Location = New System.Drawing.Point(110, 38)
        Me.materialSDSLookupComboBox.Name = "materialSDSLookupComboBox"
        Me.materialSDSLookupComboBox.Size = New System.Drawing.Size(477, 28)
        Me.materialSDSLookupComboBox.TabIndex = 0
        Me.materialSDSLookupComboBox.ValueMember = "Material"
        '
        'SDSListBindingSource
        '
        Me.SDSListBindingSource.DataMember = "SDS_List"
        Me.SDSListBindingSource.DataSource = Me.SDS_LogDataSet
        '
        'SDSLogPage
        '
        Me.SDSLogPage.Controls.Add(Me.SDSLogComboBox)
        Me.SDSLogPage.Controls.Add(Me.getInfoSDSLogButton)
        Me.SDSLogPage.Controls.Add(Me.searchSDSLogLabel)
        Me.SDSLogPage.Controls.Add(Me.refreshSDSLogButton)
        Me.SDSLogPage.Controls.Add(Me.keywordSDSLogLabel)
        Me.SDSLogPage.Controls.Add(Me.DataGridView4)
        Me.SDSLogPage.Controls.Add(Me.searchSDSLogButton)
        Me.SDSLogPage.Location = New System.Drawing.Point(4, 43)
        Me.SDSLogPage.Name = "SDSLogPage"
        Me.SDSLogPage.Padding = New System.Windows.Forms.Padding(3)
        Me.SDSLogPage.Size = New System.Drawing.Size(635, 383)
        Me.SDSLogPage.TabIndex = 3
        Me.SDSLogPage.Text = "SDS Log"
        Me.SDSLogPage.UseVisualStyleBackColor = True
        '
        'SDSLogComboBox
        '
        Me.SDSLogComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.SDSLogComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.SDSLogComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SDSListBindingSource, "Material", True))
        Me.SDSLogComboBox.DataSource = Me.SDSListBindingSource
        Me.SDSLogComboBox.DisplayMember = "Material"
        Me.SDSLogComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SDSLogComboBox.FormattingEnabled = True
        Me.SDSLogComboBox.Location = New System.Drawing.Point(110, 67)
        Me.SDSLogComboBox.Name = "SDSLogComboBox"
        Me.SDSLogComboBox.Size = New System.Drawing.Size(477, 28)
        Me.SDSLogComboBox.TabIndex = 1
        Me.SDSLogComboBox.ValueMember = "Material"
        '
        'getInfoSDSLogButton
        '
        Me.getInfoSDSLogButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.getInfoSDSLogButton.Location = New System.Drawing.Point(410, 113)
        Me.getInfoSDSLogButton.Name = "getInfoSDSLogButton"
        Me.getInfoSDSLogButton.Size = New System.Drawing.Size(125, 30)
        Me.getInfoSDSLogButton.TabIndex = 4
        Me.getInfoSDSLogButton.Text = "Get Info"
        Me.getInfoSDSLogButton.UseVisualStyleBackColor = True
        '
        'searchSDSLogLabel
        '
        Me.searchSDSLogLabel.AutoSize = True
        Me.searchSDSLogLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchSDSLogLabel.Location = New System.Drawing.Point(272, 18)
        Me.searchSDSLogLabel.Name = "searchSDSLogLabel"
        Me.searchSDSLogLabel.Size = New System.Drawing.Size(89, 29)
        Me.searchSDSLogLabel.TabIndex = 61
        Me.searchSDSLogLabel.Text = "Search"
        '
        'refreshSDSLogButton
        '
        Me.refreshSDSLogButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshSDSLogButton.Location = New System.Drawing.Point(110, 113)
        Me.refreshSDSLogButton.Name = "refreshSDSLogButton"
        Me.refreshSDSLogButton.Size = New System.Drawing.Size(125, 30)
        Me.refreshSDSLogButton.TabIndex = 2
        Me.refreshSDSLogButton.Text = "Reset Log"
        Me.refreshSDSLogButton.UseVisualStyleBackColor = True
        '
        'keywordSDSLogLabel
        '
        Me.keywordSDSLogLabel.AutoSize = True
        Me.keywordSDSLogLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.keywordSDSLogLabel.Location = New System.Drawing.Point(35, 70)
        Me.keywordSDSLogLabel.Name = "keywordSDSLogLabel"
        Me.keywordSDSLogLabel.Size = New System.Drawing.Size(69, 20)
        Me.keywordSDSLogLabel.TabIndex = 62
        Me.keywordSDSLogLabel.Text = "Keyword"
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.AllowUserToResizeColumns = False
        Me.DataGridView4.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView4.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView4.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView4.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView4.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView4.Location = New System.Drawing.Point(6, 166)
        Me.DataGridView4.MultiSelect = False
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 10, 10, 10)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView4.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.RowTemplate.ReadOnly = True
        Me.DataGridView4.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView4.ShowCellErrors = False
        Me.DataGridView4.ShowCellToolTips = False
        Me.DataGridView4.ShowEditingIcon = False
        Me.DataGridView4.ShowRowErrors = False
        Me.DataGridView4.Size = New System.Drawing.Size(623, 211)
        Me.DataGridView4.TabIndex = 63
        Me.DataGridView4.TabStop = False
        '
        'searchSDSLogButton
        '
        Me.searchSDSLogButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchSDSLogButton.Location = New System.Drawing.Point(260, 113)
        Me.searchSDSLogButton.Name = "searchSDSLogButton"
        Me.searchSDSLogButton.Size = New System.Drawing.Size(125, 30)
        Me.searchSDSLogButton.TabIndex = 3
        Me.searchSDSLogButton.Text = "Search"
        Me.searchSDSLogButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportSDSLogToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(661, 24)
        Me.MenuStrip1.TabIndex = 44
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExportSDSLogToolStripMenuItem
        '
        Me.ExportSDSLogToolStripMenuItem.Name = "ExportSDSLogToolStripMenuItem"
        Me.ExportSDSLogToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.ExportSDSLogToolStripMenuItem.Text = "Export SDS Log"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem1})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.SettingsToolStripMenuItem.Text = "Edit"
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem1.Text = "Settings"
        '
        'SDS_ListTableAdapter
        '
        Me.SDS_ListTableAdapter.ClearBeforeFill = True
        '
        'SDS_LogDataSet1
        '
        Me.SDS_LogDataSet1.DataSetName = "SDS_LogDataSet"
        Me.SDS_LogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SDSLogBindingSource
        '
        Me.SDSLogBindingSource.DataMember = "SDS_Log"
        Me.SDSLogBindingSource.DataSource = Me.SDS_LogDataSet1
        '
        'SDS_LogTableAdapter
        '
        Me.SDS_LogTableAdapter.ClearBeforeFill = True
        '
        'VendorListTableAdapter
        '
        Me.VendorListTableAdapter.ClearBeforeFill = True
        '
        'VendorListTableAdapter1
        '
        Me.VendorListTableAdapter1.ClearBeforeFill = True
        '
        'VendorList1TableAdapter
        '
        Me.VendorList1TableAdapter.ClearBeforeFill = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 26.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 453)
        Me.Controls.Add(Me.mainTabControl)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Safety Data Sheets"
        Me.mainTabControl.ResumeLayout(False)
        Me.SDSLookupPage.ResumeLayout(False)
        Me.SDSLookupPage.PerformLayout()
        CType(Me.VendorListBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDS_LogDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendorListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDS_LogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDSListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SDSLogPage.ResumeLayout(False)
        Me.SDSLogPage.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.SDS_LogDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SDSLogBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainTabControl As TabControl
    Friend WithEvents SDSLookupPage As TabPage
    Friend WithEvents resetSDSLookupButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents clearSDSLookupButton As Button
    Friend WithEvents vendor2EDSDSLookupDateTimePicker As DateTimePicker
    Friend WithEvents vender2EDSDSLookupLabel As Label
    Friend WithEvents vender2SDSLookupLabel As Label
    Friend WithEvents vendor1EDSDSLookupDateTimePicker As DateTimePicker
    Friend WithEvents vender1EDSDSLookupLabel As Label
    Friend WithEvents vender1SDSLookupLabel As Label
    Friend WithEvents hazardsSDSLookupTextBox As TextBox
    Friend WithEvents hazardsSDSLookupLabel As Label
    Friend WithEvents CASNumberSDSLookupTextBox As TextBox
    Friend WithEvents CASNumberSDSLookupLabel As Label
    Friend WithEvents saveSDSLookupButton As Button
    Friend WithEvents materialSDSLookupLabel As Label
    Friend WithEvents materialSDSLookupComboBox As ComboBox
    Friend WithEvents SDSLogPage As TabPage
    Friend WithEvents getInfoSDSLogButton As Button
    Friend WithEvents searchSDSLogLabel As Label
    Friend WithEvents refreshSDSLogButton As Button
    Friend WithEvents keywordSDSLogLabel As Label
    Friend WithEvents DataGridView4 As DataGridView
    Friend WithEvents searchSDSLogButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExportSDSLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SDS_LogDataSet As SDS_LogDataSet
    Friend WithEvents SDSListBindingSource As BindingSource
    Friend WithEvents SDS_ListTableAdapter As SDS_LogDataSetTableAdapters.SDS_ListTableAdapter
    Friend WithEvents SDSLogComboBox As ComboBox
    Friend WithEvents SDS_LogDataSet1 As SDS_LogDataSet
    Friend WithEvents SDSLogBindingSource As BindingSource
    Friend WithEvents SDS_LogTableAdapter As SDS_LogDataSetTableAdapters.SDS_LogTableAdapter
    Friend WithEvents VendorListBindingSource As BindingSource
    Friend WithEvents VendorListTableAdapter As SDS_LogDataSetTableAdapters.VendorListTableAdapter
    Friend WithEvents selectHazardsButton As Button
    Friend WithEvents vendor2ComboBox As ComboBox
    Friend WithEvents vendor1ComboBox As ComboBox
    Friend WithEvents VendorListTableAdapter1 As SDS_LogDataSetTableAdapters.VendorListTableAdapter
    Friend WithEvents VendorListBindingSource2 As BindingSource
    Friend WithEvents SDS_LogDataSet2 As SDS_LogDataSet
    Friend WithEvents VendorList1TableAdapter As SDS_LogDataSetTableAdapters.VendorList1TableAdapter
End Class
