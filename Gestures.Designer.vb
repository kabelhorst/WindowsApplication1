﻿Imports System.Threading

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestures
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AccessibleName = "x-loc"
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AccessibleName = "y-loc"
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Y pos:"
        '
        'Label5
        '
        Me.Label5.AccessibleName = "y-loc"
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Status:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(5, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 162)
        Me.Panel1.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(2, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Resolution: "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1440x2560", "1080x1920", "768x1280", "720x1280", "720x1200", "480x800", "540x960", "240x320"})
        Me.ComboBox1.Location = New System.Drawing.Point(64, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(79, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "X pos:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.AutoSize = True
        Me.Button1.BackgroundImage = Global.AndroidControl.My.Resources.Resources.back
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(4, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 40)
        Me.Button1.TabIndex = 9
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.AutoSize = True
        Me.Button2.BackgroundImage = Global.AndroidControl.My.Resources.Resources.home
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(86, 214)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(58, 40)
        Me.Button2.TabIndex = 10
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.AutoSize = True
        Me.Button3.BackgroundImage = Global.AndroidControl.My.Resources.Resources.apps
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(168, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(58, 40)
        Me.Button3.TabIndex = 11
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Gestures
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(305, 255)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Gestures"
        Me.Text = "Gestures"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox




    Private Sub Gestures_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Call New Thread(AddressOf MouseCheck).Start()
        ' Process.GetCurrentProcess.WaitForExit()
        'MsgBox("Mouse moved 20 pixels!")
        Timer1.Interval = 10
        Timer1.Start()
        Me.Panel1.BackColor = Color.Red
        Me.TransparencyKey = Color.Red
    End Sub

    Private Shared Sub MouseCheck()
        'While True
        'If Cursor.Position.X > Gestures.Panel1.Location.X And Cursor.Position.X < Gestures.Panel1.Location.X + Gestures.Panel1.Width And Cursor.Position.Y > Gestures.Panel1.Location.Y And Cursor.Position.Y < Gestures.Panel1.Location.Y + Gestures.Panel1.Height Then
        Gestures.Label2.Text = Cursor.Position.X
        Gestures.Label4.Text = Cursor.Position.Y

        'End If

        'Thread.Sleep(1000 / 60)
        'End While
    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

    'Private Sub Gestures_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
    ' Me.Label2.Text = Cursor.Position.X
    'Me.Label4.Text = Cursor.Position.Y
    'End Sub



    Dim pos As Point
    Dim dest As Point
    Dim resX As String
    Dim resY As String
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Call MouseCheck()
        'MsgBox("tic")
        Dim BorderWidth As Integer
        'obliczenia pozycji kursora wewnatrz panelu aktywnego
        BorderWidth = (Me.Width - Me.ClientSize.Width) / 2
        pos.X = Cursor.Position.X - Me.Location.X - Me.Panel1.Location.X - BorderWidth
        pos.Y = Cursor.Position.Y - Me.Location.Y - Me.Panel1.Location.Y - (Me.Height - Me.ClientSize.Height - BorderWidth)

        ' sprawdzenie czy kursor jest w obrebie pola
        If pos.X > 0 And pos.X < Me.Panel1.Width And pos.Y > 0 And pos.Y < Me.Panel1.Height Then

            'przeliczenie do pozycji docelowej w wybranej rozdzielczosci
            'zmienilem wartosc 768 i 1280 na string resX oraz resY
            dest.X = pos.X / Panel1.Width * resX
            dest.Y = pos.Y / Panel1.Height * resY

            Me.Label1.Text = pos.X.ToString
            Me.Label4.Text = pos.Y.ToString

            Me.Label2.Text = dest.X.ToString
            Me.Label3.Text = dest.Y.ToString

        End If
    End Sub
    'zmiana rozdzielczosci w combobox
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "1440x2560" Then
            resX = 1440
            resY = 2560
        Else
            If ComboBox1.Text = "1080x1920" Then
                resX = 1080
                resY = 1920
            Else
                If ComboBox1.Text = "768x1280" Then
                    resX = 768
                    resY = 1280
                Else
                    If ComboBox1.Text = "720x1280" Then
                        resX = 720
                        resY = 1280
                    Else
                        If ComboBox1.Text = "720x1200" Then
                            resX = 720
                            resY = 1200
                        Else
                            If ComboBox1.Text = "540x960" Then
                                resX = 540
                                resY = 960
                            Else
                                If ComboBox1.Text = "480x800" Then
                                    resX = 480
                                    resY = 800
                                Else
                                    If ComboBox1.Text = "240x320" Then
                                        resX = 240
                                        resY = 320
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_BACK")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_HOME")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Shell("""Tools\adb.exe"" shell input keyevent KEYCODE_APP_SWITCH")
    End Sub
End Class
