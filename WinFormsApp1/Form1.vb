Public Class BookTracker
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    ' Global variable to store the original data
    Private originalDataTable As DataTable

    ' Global variable to track modification status
    Private isDataModified As Boolean = False

    ' function to enable these buttons (Add, Modify, Next, Previous, MoveFirst, MoveLast, Delete)
    Private Sub EnableControlButtons()
        AddButton.Enabled = True
        Modify.Enabled = True
        NextValue.Enabled = True
        PreviousValue.Enabled = True
        MoveFirst.Enabled = True
        MoveLast.Enabled = True
        DeleteButton.Enabled = True
        AuthorSearch.Enabled = True
        TitleSearch.Enabled = True
        ISBNSearch.Enabled = True
        GenreSearch.Enabled = True
        Search.Enabled = True
    End Sub

    ' function to enable data entry controls (AuthorEntry, TitleEntry, ISBNEntry, GenreEntry, QuantityEntry, QuantityEntry, QuantityEntry, PriceEntry, DataSave)
    Private Sub EnableDataEntryControls()
        AuthorEntry.Enabled = True
        TitleEntry.Enabled = True
        ISBNEntry.Enabled = True
        GenreEntry.Enabled = True
        QuantityEntry.Enabled = True
        PriceEntry.Enabled = True
        DataSave.Enabled = True
    End Sub

    ' function to disable these buttons (Add, Modify, Next, Previous, MoveFirst, MoveLast, Delete)
    Private Sub DisableControlButtons()
        AddButton.Enabled = False
        Modify.Enabled = False
        NextValue.Enabled = False
        PreviousValue.Enabled = False
        MoveFirst.Enabled = False
        MoveLast.Enabled = False
        DeleteButton.Enabled = False
        AuthorSearch.Enabled = False
        TitleSearch.Enabled = False
        ISBNSearch.Enabled = False
        GenreSearch.Enabled = False
        Search.Enabled = False
    End Sub

    ' function to disable data entry controls (AuthorEntry, TitleEntry, ISBNEntry, GenreEntry, QuantityEntry, QuantityEntry, QuantityEntry, PriceEntry, DataSave)
    Private Sub DisableDataEntryControls()
        AuthorEntry.Enabled = False
        TitleEntry.Enabled = False
        ISBNEntry.Enabled = False
        GenreEntry.Enabled = False
        QuantityEntry.Enabled = False
        PriceEntry.Enabled = False
        DataSave.Enabled = False
    End Sub

    ' Clear data entry controls (AuthorEntry, TitleEntry, ISBNEntry, GenreEntry, QuantityEntry, QuantityEntry, QuantityEntry, PriceEntry)
    Private Sub ClearDataEntryControls()
        AuthorEntry.Text = ""
        TitleEntry.Text = ""
        ISBNEntry.Text = ""
        GenreEntry.Text = ""
        QuantityEntry.Text = ""
        PriceEntry.Text = ""
    End Sub

    ' Filestripcontrols enabled (save, save as, close)
    Private Sub FileStripControlsEnabled()
        SaveToolStripMenuItem.Enabled = True
        SaveAsToolStripMenuItem.Enabled = True
        CloseToolStripMenuItem.Enabled = True
    End Sub

    ' Filestripcontrols disabled (save, save as, close)
    Private Sub FileStripControlsDisabled()
        SaveToolStripMenuItem.Enabled = False
        SaveAsToolStripMenuItem.Enabled = False
        CloseToolStripMenuItem.Enabled = False
    End Sub


    ' Open data script
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        ' Check if there is data and if it has been modified
        If isDataModified Then
            Dim saveChangesResult As DialogResult = MessageBox.Show("Do you want to save the changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If saveChangesResult = DialogResult.Yes Then
                SaveToolStripMenuItem_Click(sender, e)
            ElseIf saveChangesResult = DialogResult.Cancel Then
                Return
            End If
        End If

        Dim ofd As New OpenFileDialog With {
        .Filter = "CSV Files (*.csv)|*.csv"
    }
        Dim openFileDialogResult As DialogResult = ofd.ShowDialog()

        If openFileDialogResult = DialogResult.OK Then
            Dim dt As New DataTable
            Dim sr As New IO.StreamReader(ofd.FileName)
            Dim line As String = sr.ReadLine
            Dim unused() As String = line.Split(","c)

            ' Remove existing columns from DataGridView1
            DataGridView1.Columns.Clear()

            ' Set the specific headers
            dt.Columns.Add("Author")
            dt.Columns.Add("Title")
            dt.Columns.Add("ISBN")
            dt.Columns.Add("Genre")
            dt.Columns.Add("Quantity")
            dt.Columns.Add("Price")

            originalDataTable = dt
            DataGridView1.DataSource = originalDataTable

            Do While sr.Peek <> -1
                Dim values As String() = sr.ReadLine.Split(","c)
                dt.Rows.Add(values)
            Loop
            sr.Close()
            DataGridView1.DataSource = dt
            Me.Text = ofd.FileName
            ToolStripStatusLabel2.Text = "Loaded"
            EnableControlButtons()
            FileStripControlsEnabled()
        End If
    End Sub



    ' Save data script (Save As)
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        ' Save as file dialog
        Dim sfd As New SaveFileDialog With {
        .Filter = "CSV Files (*.csv)|*.csv"
    }
        Dim result As DialogResult = sfd.ShowDialog()

        If result = DialogResult.OK AndAlso Not String.IsNullOrEmpty(sfd.FileName) Then
            Dim sw As New IO.StreamWriter(sfd.FileName)

            ' Write the headers to the file
            Dim headerRow As DataGridViewRow = DataGridView1.Rows(0)
            Dim headers As New List(Of String)
            For Each cell As DataGridViewCell In headerRow.Cells
                headers.Add(cell.Value.ToString())
            Next
            sw.WriteLine(String.Join(",", headers))

            ' Write the data rows to the file
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    Dim dataCells As New List(Of String)
                    For Each cell As DataGridViewCell In row.Cells
                        dataCells.Add(cell.Value.ToString())
                    Next
                    sw.WriteLine(String.Join(",", dataCells))
                End If
            Next

            sw.Close()
            Me.Text = sfd.FileName
            ToolStripStatusLabel2.Text = "Saved"
            ' Reset the modification status to false
            isDataModified = False
        End If
    End Sub


    ' Filter DataGridView1
    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        ' Filter DataGridView1 based on AuthorSearch, TitleSearch, ISBNSearch, GenreSearch
        ' Unfiltered if no search criteria
        ' code below
        Dim dt As DataTable = originalDataTable
        Dim dv As DataView = dt.DefaultView

        ' Build the filter expression
        Dim filterExpression As String = ""
        If Not String.IsNullOrWhiteSpace(AuthorSearch.Text) Then
            filterExpression &= $"Author LIKE '%{AuthorSearch.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(TitleSearch.Text) Then
            filterExpression &= $"Title LIKE '%{TitleSearch.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(ISBNSearch.Text) Then
            filterExpression &= $"ISBN LIKE '%{ISBNSearch.Text}%' AND "
        End If
        If Not String.IsNullOrWhiteSpace(GenreSearch.Text) Then
            filterExpression &= $"Genre = '{GenreSearch.Text}' AND "
        End If

        ' Remove the trailing "AND" if the filter expression is not empty
        If filterExpression <> "" Then
            filterExpression = filterExpression.TrimEnd(" "c, "A"c, "N"c, "D"c) ' Remove "AND" and whitespace
            dv.RowFilter = filterExpression
        Else
            dv.RowFilter = "" ' Reset the filter to show all rows
        End If

        DataGridView1.DataSource = dv
        ' Unfilter if no search criteria
        If filterExpression = "" Then
            DataGridView1.DataSource = originalDataTable
        End If

        ToolStripStatusLabel2.Text = "Filtered"
    End Sub

    ' Save file script
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        ' Check if there is a file name set
        If String.IsNullOrEmpty(Me.Text) Then
            ' If no file name set, prompt for a save location
            Dim sfd As New SaveFileDialog With {
            .Filter = "CSV Files (*.csv)|*.csv"
        }
            Dim saveFileDialogResult As DialogResult = sfd.ShowDialog()

            If saveFileDialogResult = DialogResult.OK Then
                ' Set the file name
                Me.Text = sfd.FileName

                ' Saves data directly to the file that was opened
                Dim sw As New IO.StreamWriter(Me.Text)

                ' Write the headers to the file
                Dim headerRow As DataGridViewRow = DataGridView1.Rows(0)
                Dim headers As New List(Of String)
                For Each cell As DataGridViewCell In headerRow.Cells
                    headers.Add(cell.Value.ToString())
                Next
                sw.WriteLine(String.Join(",", headers))

                ' Write the data rows to the file
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If Not row.IsNewRow Then
                        Dim dataCells As New List(Of String)
                        For Each cell As DataGridViewCell In row.Cells
                            dataCells.Add(cell.Value.ToString())
                        Next
                        sw.WriteLine(String.Join(",", dataCells))
                    End If
                Next

                sw.Close()
                ToolStripStatusLabel2.Text = "Saved"
                ' Reset the modification status to false after successful save
                isDataModified = False
            Else
                Return ' Cancelled save operation, do not proceed
            End If
        End If
    End Sub



    ' Close file script
    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        ' Close the file, prompt for save if the data has been modified
        If isDataModified Then
            Dim result As DialogResult = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                SaveToolStripMenuItem_Click(sender, e)
            ElseIf result = DialogResult.Cancel Then
                Exit Sub
            End If
        End If

        DataGridView1.Columns.Clear()
        Me.Text = "Book Tracker"
        ToolStripStatusLabel2.Text = "Closed"
        DisableControlButtons()
        DisableDataEntryControls()
        FileStripControlsDisabled()
    End Sub


    ' Start new data in DataGridView1
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        ' Check if the file has been changed, do a save if it has
        ' code below
        If Me.Text <> "Book Tracker" Then
            Dim result As DialogResult = MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                SaveToolStripMenuItem_Click(sender, e)
            ElseIf result = DialogResult.Cancel Then
                Exit Sub
            End If
        End If

        DataGridView1.Columns.Clear()

        ' add headers
        Dim dt As New DataTable
        dt.Columns.Add("Author")
        dt.Columns.Add("Title")
        dt.Columns.Add("ISBN")
        dt.Columns.Add("Genre")
        dt.Columns.Add("Quantity")
        dt.Columns.Add("Price")

        originalDataTable = dt
        DataGridView1.DataSource = originalDataTable

        Me.Text = "Book Tracker"
        ToolStripStatusLabel2.Text = "New"
        EnableControlButtons()
        FileStripControlsEnabled()
        ' Data has been modified
        isDataModified = True
    End Sub

    ' Add button, adds a new row to DataGridView1, selects the entire new row, enables data entry controls
    Private Sub AddButton_Click_1(sender As Object, e As EventArgs) Handles AddButton.Click
        ' Add a new row to the DataTable, select the entire row, enable data entry controls
        ' Disables selecting a different row
        ' code below
        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)
        Dim newRow As DataRow = dt.NewRow()
        dt.Rows.Add(newRow)
        DataGridView1.ClearSelection()
        DataGridView1.CurrentCell = DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0)
        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
        DataGridView1.Enabled = False
        DisableControlButtons()

        EnableDataEntryControls()
        ToolStripStatusLabel2.Text = "Added"

    End Sub

    ' Modify button, enables data entry controls, disables control buttons, disables selecting a different row, fills data entry controls with data from the selected row
    Private Sub Modify_Click(sender As Object, e As EventArgs) Handles Modify.Click
        ' Check if a row is selected, select entire row if only a cell is selected
        If DataGridView1.SelectedRows.Count = 0 AndAlso DataGridView1.SelectedCells.Count = 0 Then
            MessageBox.Show("Please add a row to modify.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If DataGridView1.SelectedCells.Count > 0 Then
            Dim selectedCell As DataGridViewCell = DataGridView1.SelectedCells(0)
            DataGridView1.ClearSelection()
            DataGridView1.Rows(selectedCell.RowIndex).Selected = True
        End If

        DataGridView1.Enabled = False
        DisableControlButtons()
        EnableDataEntryControls()

        ' Fill data entry controls with data from the selected row
        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)
        Dim selectedRow As Integer = DataGridView1.SelectedRows(0).Index
        AuthorEntry.Text = dt.Rows(selectedRow)("Author").ToString()
        TitleEntry.Text = dt.Rows(selectedRow)("Title").ToString()
        ISBNEntry.Text = dt.Rows(selectedRow)("ISBN").ToString()
        GenreEntry.Text = dt.Rows(selectedRow)("Genre").ToString()
        QuantityEntry.Text = dt.Rows(selectedRow)("Quantity").ToString()
        PriceEntry.Text = dt.Rows(selectedRow)("Price").ToString()

        ToolStripStatusLabel2.Text = "Modified"
        ' Set the modification status to true
        isDataModified = True
    End Sub




    ' Saves data from these fields to the selected row in DataGridView1 (AuthorEntry, TitleEntry, ISBNEntry, GenreEntry, QuantityEntry, QuantityEntry, QuantityEntry, PriceEntry)
    Private Sub DataSave_ClSick(sender As Object, e As EventArgs) Handles DataSave.Click
        ' Save data from the data entry controls to the selected row in the DataGridView
        ' enables control buttons, disables data entry controls
        ' code below
        ' Check if any entry field is empty
        If String.IsNullOrWhiteSpace(AuthorEntry.Text) OrElse
       String.IsNullOrWhiteSpace(TitleEntry.Text) OrElse
       String.IsNullOrWhiteSpace(ISBNEntry.Text) OrElse
       String.IsNullOrWhiteSpace(GenreEntry.Text) OrElse
       String.IsNullOrWhiteSpace(QuantityEntry.Text) OrElse
       String.IsNullOrWhiteSpace(PriceEntry.Text) Then
            MessageBox.Show("Please fill in all the entry fields.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)
        Dim selectedRow As Integer = DataGridView1.SelectedRows(0).Index
        dt.Rows(selectedRow)("Author") = AuthorEntry.Text
        dt.Rows(selectedRow)("Title") = TitleEntry.Text
        dt.Rows(selectedRow)("ISBN") = ISBNEntry.Text
        dt.Rows(selectedRow)("Genre") = GenreEntry.Text
        dt.Rows(selectedRow)("Quantity") = QuantityEntry.Text
        dt.Rows(selectedRow)("Price") = PriceEntry.Text

        DataGridView1.DataSource = dt
        DataGridView1.ClearSelection()
        DataGridView1.CurrentCell = DataGridView1.Rows(selectedRow).Cells(0)
        DataGridView1.Rows(selectedRow).Selected = True
        DataGridView1.Enabled = True

        ' Clear data entry controls
        ClearDataEntryControls()
        EnableControlButtons()
        DisableDataEntryControls()
        ToolStripStatusLabel2.Text = "Saved"
        ' Set the modification status to true
        isDataModified = True
    End Sub

    ' if there is a row above, select that row
    Private Sub NextValue_Click(sender As Object, e As EventArgs) Handles NextValue.Click
        ' Select the row above the current row or cell selected
        ' code below
        If DataGridView1.SelectedRows.Count = 0 AndAlso DataGridView1.SelectedCells.Count = 0 Then
            MessageBox.Show("Please add a row to modify.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)
        Dim selectedRow As Integer
        If DataGridView1.SelectedRows.Count > 0 Then
            selectedRow = DataGridView1.SelectedRows(0).Index
        ElseIf DataGridView1.SelectedCells.Count > 0 Then
            selectedRow = DataGridView1.SelectedCells(0).RowIndex
        Else
            Return
        End If

        If selectedRow > 0 Then
            DataGridView1.ClearSelection()
            DataGridView1.CurrentCell = DataGridView1.Rows(selectedRow - 1).Cells(0)
            DataGridView1.Rows(selectedRow - 1).Selected = True
        End If
    End Sub

    ' if there is a row below, select that row
    Private Sub PreviousValue_Click(sender As Object, e As EventArgs) Handles PreviousValue.Click
        ' Select the row below the current row or cell selected
        ' code below

        If DataGridView1.SelectedRows.Count = 0 AndAlso DataGridView1.SelectedCells.Count = 0 Then
            MessageBox.Show("Please add a row to modify.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)
        Dim selectedRow As Integer
        If DataGridView1.SelectedRows.Count > 0 Then
            selectedRow = DataGridView1.SelectedRows(0).Index
        ElseIf DataGridView1.SelectedCells.Count > 0 Then
            selectedRow = DataGridView1.SelectedCells(0).RowIndex
        Else
            Return
        End If

        If selectedRow < DataGridView1.Rows.Count - 1 Then
            DataGridView1.ClearSelection()
            DataGridView1.CurrentCell = DataGridView1.Rows(selectedRow + 1).Cells(0)
            DataGridView1.Rows(selectedRow + 1).Selected = True
        End If
    End Sub

    'Moves selected row (cell -> row) to the top of the DataGridView1
    Private Sub MoveFirst_Click(sender As Object, e As EventArgs) Handles MoveFirst.Click
        ' first check to see if a row or cell is selected
        ' if a cell is selected, select the entire row
        ' move the selected row to the top of the DataGridView
        ' code below
        If DataGridView1.SelectedRows.Count = 0 AndAlso DataGridView1.SelectedCells.Count = 0 Then
            MessageBox.Show("Please add a row to modify.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If DataGridView1.SelectedCells.Count > 0 Then
            Dim selectedCell As DataGridViewCell = DataGridView1.SelectedCells(0)
            DataGridView1.ClearSelection()
            DataGridView1.Rows(selectedCell.RowIndex).Selected = True
        End If

        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)
        Dim selectedRow As Integer = DataGridView1.SelectedRows(0).Index
        Dim row As DataRow = dt.NewRow()
        row.ItemArray = dt.Rows(selectedRow).ItemArray
        dt.Rows.RemoveAt(selectedRow)
        dt.Rows.InsertAt(row, 0)
        DataGridView1.DataSource = dt
        DataGridView1.ClearSelection()
        DataGridView1.CurrentCell = DataGridView1.Rows(0).Cells(0)
        DataGridView1.Rows(0).Selected = True
        ' data is modified
        isDataModified = True
    End Sub

    'Moves selected row (cell -> row) to the bottom of the DataGridView1
    Private Sub MoveLast_Click(sender As Object, e As EventArgs) Handles MoveLast.Click
        ' first check to see if a row or cell is selected
        ' if a cell is selected, select the entire row
        ' move the selected row to the bottom of the DataGridView
        ' code below
        If DataGridView1.SelectedRows.Count = 0 AndAlso DataGridView1.SelectedCells.Count = 0 Then
            MessageBox.Show("Please add a row to modify.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If DataGridView1.SelectedCells.Count > 0 Then
            Dim selectedCell As DataGridViewCell = DataGridView1.SelectedCells(0)
            DataGridView1.ClearSelection()
            DataGridView1.Rows(selectedCell.RowIndex).Selected = True
        End If

        Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)
        Dim selectedRow As Integer = DataGridView1.SelectedRows(0).Index
        Dim row As DataRow = dt.NewRow()
        row.ItemArray = dt.Rows(selectedRow).ItemArray
        dt.Rows.RemoveAt(selectedRow)
        dt.Rows.InsertAt(row, dt.Rows.Count)
        DataGridView1.DataSource = dt
        DataGridView1.ClearSelection()
        DataGridView1.CurrentCell = DataGridView1.Rows(dt.Rows.Count - 1).Cells(0)
        DataGridView1.Rows(dt.Rows.Count - 1).Selected = True
        ' data is modified
        isDataModified = True
    End Sub

    'Deletes selected row, (cell -> row)
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        ' first check to see if a row or cell is selected
        ' if a cell is selected, select the entire row
        ' ASK FOR CONFIRMATION
        ' delete the selected row
        ' code below
        If DataGridView1.SelectedRows.Count = 0 AndAlso DataGridView1.SelectedCells.Count = 0 Then
            MessageBox.Show("Please select a row to remove.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' If a cell is selected, select the entire row
        If DataGridView1.SelectedCells.Count > 0 Then
            Dim selectedCell As DataGridViewCell = DataGridView1.SelectedCells(0)
            DataGridView1.ClearSelection()
            DataGridView1.Rows(selectedCell.RowIndex).Selected = True
        End If

        ' Confirm row removal
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove the selected row?", "Confirm Row Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            ' Remove the selected row
            Dim dt As DataTable = CType(DataGridView1.DataSource, DataTable)
            Dim selectedRow As Integer = DataGridView1.SelectedRows(0).Index

            ' Check if it's the last row
            Dim isLastRow As Boolean = (selectedRow = dt.Rows.Count - 1)

            ' Remove the row
            dt.Rows.RemoveAt(selectedRow)
            DataGridView1.DataSource = dt

            ' Select the appropriate row
            If dt.Rows.Count > 0 Then
                If isLastRow Then
                    DataGridView1.CurrentCell = DataGridView1.Rows(selectedRow - 1).Cells(0)
                    DataGridView1.Rows(selectedRow - 1).Selected = True
                Else
                    DataGridView1.CurrentCell = DataGridView1.Rows(selectedRow).Cells(0)
                    DataGridView1.Rows(selectedRow).Selected = True
                End If
            End If

            ' Data is modified
            isDataModified = True
        End If
    End Sub

    ' FormClosing event handler
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Check if data has been modified
        If isDataModified Then
            Dim result As DialogResult = MessageBox.Show("Do you want to save the changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                SaveToolStripMenuItem_Click(sender, e)
            ElseIf result = DialogResult.Cancel Then
                e.Cancel = True ' Cancel the form closing event
            End If
        End If
    End Sub


End Class
