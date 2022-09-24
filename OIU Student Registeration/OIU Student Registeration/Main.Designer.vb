<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdLogout = New System.Windows.Forms.Button()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.cmdAbout = New System.Windows.Forms.Button()
        Me.cmdHome = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdUpdateS = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdQuery = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cmdLogout)
        Me.Panel1.Controls.Add(Me.lblWelcome)
        Me.Panel1.Controls.Add(Me.cmdAbout)
        Me.Panel1.Controls.Add(Me.cmdHome)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 637)
        Me.Panel1.TabIndex = 7
        '
        'cmdLogout
        '
        Me.cmdLogout.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdLogout.Enabled = False
        Me.cmdLogout.FlatAppearance.BorderSize = 0
        Me.cmdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLogout.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.cmdLogout.Image = Global.OIU_Student_Registeration.My.Resources.Resources.icons8_logout_rounded_left_64
        Me.cmdLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdLogout.Location = New System.Drawing.Point(0, 473)
        Me.cmdLogout.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.Size = New System.Drawing.Size(158, 102)
        Me.cmdLogout.TabIndex = 11
        Me.cmdLogout.UseVisualStyleBackColor = True
        '
        'lblWelcome
        '
        Me.lblWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI Semibold", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(2, 168)
        Me.lblWelcome.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(152, 82)
        Me.lblWelcome.TabIndex = 8
        '
        'cmdAbout
        '
        Me.cmdAbout.Enabled = False
        Me.cmdAbout.FlatAppearance.BorderSize = 0
        Me.cmdAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAbout.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold)
        Me.cmdAbout.Image = Global.OIU_Student_Registeration.My.Resources.Resources.icons8_male_user_64
        Me.cmdAbout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdAbout.Location = New System.Drawing.Point(0, 271)
        Me.cmdAbout.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(154, 175)
        Me.cmdAbout.TabIndex = 10
        Me.cmdAbout.Text = "Programmer"
        Me.cmdAbout.UseVisualStyleBackColor = True
        '
        'cmdHome
        '
        Me.cmdHome.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmdHome.FlatAppearance.BorderSize = 0
        Me.cmdHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHome.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cmdHome.ForeColor = System.Drawing.Color.White
        Me.cmdHome.Image = Global.OIU_Student_Registeration.My.Resources.Resources.icons8_student_641
        Me.cmdHome.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdHome.Location = New System.Drawing.Point(0, 0)
        Me.cmdHome.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdHome.Name = "cmdHome"
        Me.cmdHome.Size = New System.Drawing.Size(156, 207)
        Me.cmdHome.TabIndex = 9
        Me.cmdHome.Text = "OIU Student Registeration"
        Me.cmdHome.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2500
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmdSearch.Enabled = False
        Me.cmdSearch.FlatAppearance.BorderSize = 0
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Font = New System.Drawing.Font("Segoe UI Semibold", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ForeColor = System.Drawing.Color.White
        Me.cmdSearch.Image = Global.OIU_Student_Registeration.My.Resources.Resources.icons8_search_64
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearch.Location = New System.Drawing.Point(354, 491)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(369, 85)
        Me.cmdSearch.TabIndex = 12
        Me.cmdSearch.Text = "Search Students"
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.FlatAppearance.BorderSize = 0
        Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDelete.Font = New System.Drawing.Font("Segoe UI Semibold", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelete.ForeColor = System.Drawing.Color.White
        Me.cmdDelete.Image = Global.OIU_Student_Registeration.My.Resources.Resources.icons8_remove_64
        Me.cmdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDelete.Location = New System.Drawing.Point(354, 361)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(369, 85)
        Me.cmdDelete.TabIndex = 11
        Me.cmdDelete.Text = "Delete Student Record"
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdUpdateS
        '
        Me.cmdUpdateS.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmdUpdateS.Enabled = False
        Me.cmdUpdateS.FlatAppearance.BorderSize = 0
        Me.cmdUpdateS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUpdateS.Font = New System.Drawing.Font("Segoe UI Semibold", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdateS.ForeColor = System.Drawing.Color.White
        Me.cmdUpdateS.Image = Global.OIU_Student_Registeration.My.Resources.Resources.icons8_update_64
        Me.cmdUpdateS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUpdateS.Location = New System.Drawing.Point(354, 235)
        Me.cmdUpdateS.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdUpdateS.Name = "cmdUpdateS"
        Me.cmdUpdateS.Size = New System.Drawing.Size(369, 85)
        Me.cmdUpdateS.TabIndex = 10
        Me.cmdUpdateS.Text = "Update Student Record"
        Me.cmdUpdateS.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.FlatAppearance.BorderSize = 0
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.Font = New System.Drawing.Font("Segoe UI Semibold", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.ForeColor = System.Drawing.Color.White
        Me.cmdAdd.Image = Global.OIU_Student_Registeration.My.Resources.Resources.icons8_add_64
        Me.cmdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAdd.Location = New System.Drawing.Point(354, 122)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(369, 85)
        Me.cmdAdd.TabIndex = 9
        Me.cmdAdd.Text = "Add Student Record"
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdQuery
        '
        Me.cmdQuery.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.cmdQuery.Enabled = False
        Me.cmdQuery.FlatAppearance.BorderSize = 0
        Me.cmdQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdQuery.Font = New System.Drawing.Font("Segoe UI Semibold", 13.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQuery.ForeColor = System.Drawing.Color.White
        Me.cmdQuery.Image = Global.OIU_Student_Registeration.My.Resources.Resources.icons8_student_642
        Me.cmdQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdQuery.Location = New System.Drawing.Point(354, 11)
        Me.cmdQuery.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.Size = New System.Drawing.Size(369, 85)
        Me.cmdQuery.TabIndex = 8
        Me.cmdQuery.Text = "Show Students"
        Me.cmdQuery.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CancelButton = Me.cmdLogout
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdUpdateS)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdQuery)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Main"
        Me.Text = "Main Menu"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents cmdAbout As System.Windows.Forms.Button
    Friend WithEvents cmdHome As System.Windows.Forms.Button
    Friend WithEvents cmdQuery As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdUpdateS As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdLogout As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
