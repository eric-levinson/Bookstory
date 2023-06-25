<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookTracker
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        SaveAsToolStripMenuItem = New ToolStripMenuItem()
        CloseToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolStripStatusLabel2 = New ToolStripStatusLabel()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        ControlGroup = New GroupBox()
        AddButton = New Button()
        DeleteButton = New Button()
        Modify = New Button()
        MoveFirst = New Button()
        MoveLast = New Button()
        NextValue = New Button()
        PreviousValue = New Button()
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        SearchGroup = New GroupBox()
        AuthorSearch = New TextBox()
        ISBNSearch = New TextBox()
        TitleSearch = New TextBox()
        GenreSearch = New ComboBox()
        AuthorLabel = New Label()
        TitleLabel = New Label()
        ISBNLabel = New Label()
        GenreLabel = New Label()
        Search = New Button()
        DataEntryGroup = New GroupBox()
        GenreEntry = New ComboBox()
        DataSave = New Button()
        AuthorEntry = New TextBox()
        ISBNEntry = New TextBox()
        TitleEntry = New TextBox()
        Label4 = New Label()
        PriceEntry = New TextBox()
        Label3 = New Label()
        PriceLabel = New Label()
        Label2 = New Label()
        QuantityEntry = New TextBox()
        Label1 = New Label()
        QuantityLabel = New Label()
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        ControlGroup.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SearchGroup.SuspendLayout()
        DataEntryGroup.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1562, 33)
        MenuStrip1.TabIndex = 31
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, SaveAsToolStripMenuItem, CloseToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(54, 29)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewToolStripMenuItem
        ' 
        NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        NewToolStripMenuItem.Size = New Size(270, 34)
        NewToolStripMenuItem.Text = "New"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(270, 34)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Enabled = False
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(270, 34)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' SaveAsToolStripMenuItem
        ' 
        SaveAsToolStripMenuItem.Enabled = False
        SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        SaveAsToolStripMenuItem.Size = New Size(270, 34)
        SaveAsToolStripMenuItem.Text = "Save as..."
        ' 
        ' CloseToolStripMenuItem
        ' 
        CloseToolStripMenuItem.Enabled = False
        CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        CloseToolStripMenuItem.Size = New Size(270, 34)
        CloseToolStripMenuItem.Text = "Close"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1, ToolStripStatusLabel2})
        StatusStrip1.Location = New Point(0, 566)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(1562, 32)
        StatusStrip1.SizingGrip = False
        StatusStrip1.TabIndex = 36
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(69, 25)
        ToolStripStatusLabel1.Text = "Status: "
        ' 
        ' ToolStripStatusLabel2
        ' 
        ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        ToolStripStatusLabel2.Size = New Size(89, 25)
        ToolStripStatusLabel2.Text = "Unloaded"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ControlGroup
        ' 
        ControlGroup.Controls.Add(AddButton)
        ControlGroup.Controls.Add(DeleteButton)
        ControlGroup.Controls.Add(Modify)
        ControlGroup.Controls.Add(MoveFirst)
        ControlGroup.Controls.Add(MoveLast)
        ControlGroup.Controls.Add(NextValue)
        ControlGroup.Controls.Add(PreviousValue)
        ControlGroup.Location = New Point(12, 36)
        ControlGroup.Name = "ControlGroup"
        ControlGroup.Size = New Size(123, 311)
        ControlGroup.TabIndex = 34
        ControlGroup.TabStop = False
        ControlGroup.Text = "Controls"
        ' 
        ' AddButton
        ' 
        AddButton.Enabled = False
        AddButton.Location = New Point(6, 29)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(112, 34)
        AddButton.TabIndex = 1
        AddButton.Text = "Add"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' DeleteButton
        ' 
        DeleteButton.Enabled = False
        DeleteButton.Location = New Point(6, 269)
        DeleteButton.Name = "DeleteButton"
        DeleteButton.Size = New Size(112, 34)
        DeleteButton.TabIndex = 2
        DeleteButton.Text = "Delete"
        DeleteButton.UseVisualStyleBackColor = True
        ' 
        ' Modify
        ' 
        Modify.Enabled = False
        Modify.Location = New Point(6, 69)
        Modify.Name = "Modify"
        Modify.Size = New Size(112, 34)
        Modify.TabIndex = 3
        Modify.Text = "Modify"
        Modify.UseVisualStyleBackColor = True
        ' 
        ' MoveFirst
        ' 
        MoveFirst.Enabled = False
        MoveFirst.Location = New Point(6, 189)
        MoveFirst.Name = "MoveFirst"
        MoveFirst.Size = New Size(112, 34)
        MoveFirst.TabIndex = 3
        MoveFirst.Text = "Move First"
        MoveFirst.UseVisualStyleBackColor = True
        ' 
        ' MoveLast
        ' 
        MoveLast.Enabled = False
        MoveLast.Location = New Point(6, 229)
        MoveLast.Name = "MoveLast"
        MoveLast.Size = New Size(112, 34)
        MoveLast.TabIndex = 4
        MoveLast.Text = "Move Last"
        MoveLast.UseVisualStyleBackColor = True
        ' 
        ' NextValue
        ' 
        NextValue.Enabled = False
        NextValue.Location = New Point(6, 109)
        NextValue.Name = "NextValue"
        NextValue.Size = New Size(112, 34)
        NextValue.TabIndex = 5
        NextValue.Text = "Next"
        NextValue.UseVisualStyleBackColor = True
        ' 
        ' PreviousValue
        ' 
        PreviousValue.Enabled = False
        PreviousValue.Location = New Point(6, 149)
        PreviousValue.Name = "PreviousValue"
        PreviousValue.Size = New Size(112, 34)
        PreviousValue.TabIndex = 6
        PreviousValue.Text = "Previous"
        PreviousValue.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(141, 39)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 33
        DataGridView1.Size = New Size(1038, 521)
        DataGridView1.TabIndex = 37
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Panel1.Controls.Add(SearchGroup)
        Panel1.Controls.Add(DataEntryGroup)
        Panel1.Location = New Point(1185, 36)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(377, 534)
        Panel1.TabIndex = 38
        ' 
        ' SearchGroup
        ' 
        SearchGroup.Controls.Add(AuthorSearch)
        SearchGroup.Controls.Add(ISBNSearch)
        SearchGroup.Controls.Add(TitleSearch)
        SearchGroup.Controls.Add(GenreSearch)
        SearchGroup.Controls.Add(AuthorLabel)
        SearchGroup.Controls.Add(TitleLabel)
        SearchGroup.Controls.Add(ISBNLabel)
        SearchGroup.Controls.Add(GenreLabel)
        SearchGroup.Controls.Add(Search)
        SearchGroup.Location = New Point(3, 3)
        SearchGroup.Name = "SearchGroup"
        SearchGroup.Size = New Size(368, 226)
        SearchGroup.TabIndex = 32
        SearchGroup.TabStop = False
        SearchGroup.Text = "Search"
        ' 
        ' AuthorSearch
        ' 
        AuthorSearch.Enabled = False
        AuthorSearch.Location = New Point(92, 33)
        AuthorSearch.Name = "AuthorSearch"
        AuthorSearch.Size = New Size(249, 31)
        AuthorSearch.TabIndex = 7
        ' 
        ' ISBNSearch
        ' 
        ISBNSearch.Enabled = False
        ISBNSearch.Location = New Point(92, 107)
        ISBNSearch.Name = "ISBNSearch"
        ISBNSearch.Size = New Size(249, 31)
        ISBNSearch.TabIndex = 8
        ' 
        ' TitleSearch
        ' 
        TitleSearch.Enabled = False
        TitleSearch.Location = New Point(92, 70)
        TitleSearch.Name = "TitleSearch"
        TitleSearch.Size = New Size(249, 31)
        TitleSearch.TabIndex = 9
        ' 
        ' GenreSearch
        ' 
        GenreSearch.Enabled = False
        GenreSearch.FormattingEnabled = True
        GenreSearch.Items.AddRange(New Object() {"fiction", "mystery", "non-fiction", "romance"})
        GenreSearch.Location = New Point(92, 144)
        GenreSearch.Name = "GenreSearch"
        GenreSearch.Size = New Size(249, 33)
        GenreSearch.TabIndex = 10
        ' 
        ' AuthorLabel
        ' 
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New Point(23, 36)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New Size(67, 25)
        AuthorLabel.TabIndex = 11
        AuthorLabel.Text = "Author"
        ' 
        ' TitleLabel
        ' 
        TitleLabel.AutoSize = True
        TitleLabel.Location = New Point(42, 73)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New Size(44, 25)
        TitleLabel.TabIndex = 12
        TitleLabel.Text = "Title"
        ' 
        ' ISBNLabel
        ' 
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New Point(36, 110)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New Size(50, 25)
        ISBNLabel.TabIndex = 13
        ISBNLabel.Text = "ISBN"
        ' 
        ' GenreLabel
        ' 
        GenreLabel.AutoSize = True
        GenreLabel.Location = New Point(28, 147)
        GenreLabel.Name = "GenreLabel"
        GenreLabel.Size = New Size(58, 25)
        GenreLabel.TabIndex = 14
        GenreLabel.Text = "Genre"
        ' 
        ' Search
        ' 
        Search.Enabled = False
        Search.Location = New Point(220, 183)
        Search.Name = "Search"
        Search.Size = New Size(121, 34)
        Search.TabIndex = 15
        Search.Text = "Search"
        Search.UseVisualStyleBackColor = True
        ' 
        ' DataEntryGroup
        ' 
        DataEntryGroup.Controls.Add(GenreEntry)
        DataEntryGroup.Controls.Add(DataSave)
        DataEntryGroup.Controls.Add(AuthorEntry)
        DataEntryGroup.Controls.Add(ISBNEntry)
        DataEntryGroup.Controls.Add(TitleEntry)
        DataEntryGroup.Controls.Add(Label4)
        DataEntryGroup.Controls.Add(PriceEntry)
        DataEntryGroup.Controls.Add(Label3)
        DataEntryGroup.Controls.Add(PriceLabel)
        DataEntryGroup.Controls.Add(Label2)
        DataEntryGroup.Controls.Add(QuantityEntry)
        DataEntryGroup.Controls.Add(Label1)
        DataEntryGroup.Controls.Add(QuantityLabel)
        DataEntryGroup.Location = New Point(3, 235)
        DataEntryGroup.Name = "DataEntryGroup"
        DataEntryGroup.Size = New Size(368, 289)
        DataEntryGroup.TabIndex = 33
        DataEntryGroup.TabStop = False
        DataEntryGroup.Text = "Data Entry"
        ' 
        ' GenreEntry
        ' 
        GenreEntry.Enabled = False
        GenreEntry.FormattingEnabled = True
        GenreEntry.Items.AddRange(New Object() {"fiction", "mystery", "non-fiction", "romance"})
        GenreEntry.Location = New Point(92, 139)
        GenreEntry.Name = "GenreEntry"
        GenreEntry.Size = New Size(249, 33)
        GenreEntry.TabIndex = 16
        ' 
        ' DataSave
        ' 
        DataSave.Enabled = False
        DataSave.Location = New Point(225, 246)
        DataSave.Name = "DataSave"
        DataSave.Size = New Size(116, 34)
        DataSave.TabIndex = 29
        DataSave.Text = "Save"
        DataSave.UseVisualStyleBackColor = True
        ' 
        ' AuthorEntry
        ' 
        AuthorEntry.Enabled = False
        AuthorEntry.Location = New Point(92, 28)
        AuthorEntry.Name = "AuthorEntry"
        AuthorEntry.Size = New Size(249, 31)
        AuthorEntry.TabIndex = 16
        ' 
        ' ISBNEntry
        ' 
        ISBNEntry.Enabled = False
        ISBNEntry.Location = New Point(92, 102)
        ISBNEntry.Name = "ISBNEntry"
        ISBNEntry.Size = New Size(249, 31)
        ISBNEntry.TabIndex = 17
        ' 
        ' TitleEntry
        ' 
        TitleEntry.Enabled = False
        TitleEntry.Location = New Point(92, 65)
        TitleEntry.Name = "TitleEntry"
        TitleEntry.Size = New Size(249, 31)
        TitleEntry.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 34)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 25)
        Label4.TabIndex = 20
        Label4.Text = "Author"
        ' 
        ' PriceEntry
        ' 
        PriceEntry.Enabled = False
        PriceEntry.Location = New Point(92, 209)
        PriceEntry.Name = "PriceEntry"
        PriceEntry.Size = New Size(249, 31)
        PriceEntry.TabIndex = 28
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(43, 71)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 25)
        Label3.TabIndex = 21
        Label3.Text = "Title"
        ' 
        ' PriceLabel
        ' 
        PriceLabel.AutoSize = True
        PriceLabel.Location = New Point(37, 215)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New Size(49, 25)
        PriceLabel.TabIndex = 27
        PriceLabel.Text = "Price"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(50, 25)
        Label2.TabIndex = 22
        Label2.Text = "ISBN"
        ' 
        ' QuantityEntry
        ' 
        QuantityEntry.Enabled = False
        QuantityEntry.Location = New Point(92, 175)
        QuantityEntry.Name = "QuantityEntry"
        QuantityEntry.Size = New Size(249, 31)
        QuantityEntry.TabIndex = 26
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(29, 145)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 25)
        Label1.TabIndex = 23
        Label1.Text = "Genre"
        ' 
        ' QuantityLabel
        ' 
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New Point(7, 181)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New Size(80, 25)
        QuantityLabel.TabIndex = 25
        QuantityLabel.Text = "Quantity"
        ' 
        ' BookTracker
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1562, 598)
        Controls.Add(ControlGroup)
        Controls.Add(DataGridView1)
        Controls.Add(StatusStrip1)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "BookTracker"
        ShowIcon = False
        SizeGripStyle = SizeGripStyle.Hide
        Text = "Book Tracker"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ControlGroup.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        SearchGroup.ResumeLayout(False)
        SearchGroup.PerformLayout()
        DataEntryGroup.ResumeLayout(False)
        DataEntryGroup.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Delete As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ControlGroup As GroupBox
    Friend WithEvents AddButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents Modify As Button
    Friend WithEvents MoveFirst As Button
    Friend WithEvents MoveLast As Button
    Friend WithEvents NextValue As Button
    Friend WithEvents PreviousValue As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchGroup As GroupBox
    Friend WithEvents AuthorSearch As TextBox
    Friend WithEvents ISBNSearch As TextBox
    Friend WithEvents TitleSearch As TextBox
    Friend WithEvents GenreSearch As ComboBox
    Friend WithEvents AuthorLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents ISBNLabel As Label
    Friend WithEvents GenreLabel As Label
    Friend WithEvents Search As Button
    Friend WithEvents DataEntryGroup As GroupBox
    Friend WithEvents GenreEntry As ComboBox
    Friend WithEvents DataSave As Button
    Friend WithEvents AuthorEntry As TextBox
    Friend WithEvents ISBNEntry As TextBox
    Friend WithEvents TitleEntry As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PriceEntry As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents QuantityEntry As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents QuantityLabel As Label
End Class
