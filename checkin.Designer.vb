﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class checkin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(checkin))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Pricebox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.firstname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lastname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.nights = New System.Windows.Forms.TextBox()
        Me.connumber = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Goldenrod
        Me.Button2.Location = New System.Drawing.Point(255, 629)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 41)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(36, 27)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(138, 27)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Single  $75"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(36, 53)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(136, 27)
        Me.RadioButton2.TabIndex = 4
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Twin    $95"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.White
        Me.RadioButton3.Location = New System.Drawing.Point(36, 79)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(145, 27)
        Me.RadioButton3.TabIndex = 5
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Studio $125"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton6)
        Me.GroupBox1.Controls.Add(Me.Pricebox)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Goldenrod
        Me.GroupBox1.Location = New System.Drawing.Point(48, 433)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 177)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select room type:"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.White
        Me.RadioButton4.Location = New System.Drawing.Point(196, 27)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(191, 27)
        Me.RadioButton4.TabIndex = 13
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Deluxe       $237"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.ForeColor = System.Drawing.Color.White
        Me.RadioButton5.Location = New System.Drawing.Point(196, 53)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(195, 27)
        Me.RadioButton5.TabIndex = 12
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Penthouse   $345"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.ForeColor = System.Drawing.Color.White
        Me.RadioButton6.Location = New System.Drawing.Point(196, 79)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(194, 27)
        Me.RadioButton6.TabIndex = 11
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Presidential $520"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Pricebox
        '
        Me.Pricebox.BackColor = System.Drawing.Color.White
        Me.Pricebox.Cursor = System.Windows.Forms.Cursors.No
        Me.Pricebox.Enabled = False
        Me.Pricebox.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pricebox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Pricebox.Location = New System.Drawing.Point(71, 126)
        Me.Pricebox.Name = "Pricebox"
        Me.Pricebox.ReadOnly = True
        Me.Pricebox.Size = New System.Drawing.Size(264, 31)
        Me.Pricebox.TabIndex = 10
        Me.Pricebox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Goldenrod
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(80, 629)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 41)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(78, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "First name:"
        '
        'firstname
        '
        Me.firstname.BackColor = System.Drawing.Color.White
        Me.firstname.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.firstname.Location = New System.Drawing.Point(80, 58)
        Me.firstname.MaxLength = 50
        Me.firstname.Name = "firstname"
        Me.firstname.Size = New System.Drawing.Size(332, 31)
        Me.firstname.TabIndex = 1
        Me.firstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(78, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 23)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Last name:"
        '
        'lastname
        '
        Me.lastname.BackColor = System.Drawing.Color.White
        Me.lastname.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.lastname.Location = New System.Drawing.Point(80, 127)
        Me.lastname.MaxLength = 50
        Me.lastname.Name = "lastname"
        Me.lastname.Size = New System.Drawing.Size(332, 31)
        Me.lastname.TabIndex = 3
        Me.lastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(76, 389)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(206, 23)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Number of nights:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(78, 174)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(191, 23)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Contact number:"
        '
        'nights
        '
        Me.nights.BackColor = System.Drawing.Color.White
        Me.nights.Enabled = False
        Me.nights.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nights.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.nights.Location = New System.Drawing.Point(288, 386)
        Me.nights.MaxLength = 50
        Me.nights.Name = "nights"
        Me.nights.ReadOnly = True
        Me.nights.Size = New System.Drawing.Size(124, 31)
        Me.nights.TabIndex = 5
        Me.nights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'connumber
        '
        Me.connumber.BackColor = System.Drawing.Color.White
        Me.connumber.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.connumber.Location = New System.Drawing.Point(80, 200)
        Me.connumber.MaxLength = 13
        Me.connumber.Name = "connumber"
        Me.connumber.Size = New System.Drawing.Size(332, 31)
        Me.connumber.TabIndex = 4
        Me.connumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(80, 272)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(332, 27)
        Me.DateTimePicker1.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(76, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 23)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Check-out Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(78, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 23)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Check-in Date:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(80, 340)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(332, 27)
        Me.DateTimePicker2.TabIndex = 33
        '
        'checkin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(488, 701)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.connumber)
        Me.Controls.Add(Me.nights)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lastname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.firstname)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "checkin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Check-in"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Pricebox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents firstname As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lastname As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents nights As TextBox
    Friend WithEvents connumber As TextBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
