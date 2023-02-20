﻿Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text

Module Modul

    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public da As SqlDataAdapter
    Public dr As SqlDataReader
    Public dt As DataTable

    Sub koneksi()
        conn = New SqlConnection("Data Source=DESKTOP-E1JB7KO\SQLEXPRESS;Initial Catalog=dblaundry2;Integrated Security=True")
        If conn.State = conn.State.Closed Then
            conn.Open()
        End If
    End Sub

    Sub closekoneksi()
        conn.Close()
        cmd.Dispose()
    End Sub

    Function hash256(ByVal inputString) As String
        Dim sha256 As SHA256 = SHA256Managed.Create()
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(inputString)
        Dim hash As Byte() = sha256.ComputeHash(bytes)
        Dim stringBuilder As New StringBuilder()
        For i As Integer = 0 To hash.Length - 1
            stringBuilder.Append(hash(i).ToString("X2"))
        Next
        Return stringBuilder.ToString.ToLower
    End Function

    Function adakosong(gb As GroupBox)
        Dim status As Boolean = False
        For Each ct As Control In gb.Controls
            If TypeOf ct Is TextBox Then
                If CType(ct, TextBox).Text = "" Then
                    status = True
                    Exit For
                End If
            End If

            If TypeOf ct Is PictureBox Then
                If CType(ct, PictureBox).ImageLocation = Nothing Then
                    status = True
                    Exit For
                End If
            End If

            If TypeOf ct Is ComboBox Then
                If CType(ct, ComboBox).SelectedIndex < 0 Then
                    status = True
                    Exit For
                End If
            End If

            If TypeOf ct Is NumericUpDown Then
                If CType(ct, NumericUpDown).Value = 0 Then
                    status = True
                    Exit For
                End If
            End If
        Next
        Return status
    End Function

    Function getdata(sql As String)
        koneksi()
        Try
            da = New SqlDataAdapter
            dt = New DataTable
            cmd = New SqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(dt)
            Return dt
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            closekoneksi()
        End Try
    End Function

    Function getCount(sql As String)
        koneksi()
        Try
            da = New SqlDataAdapter
            dt = New DataTable
            cmd = New SqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(dt)
            Return dt.Rows.Count
        Catch ex As Exception
            Return 0
        Finally
            closekoneksi()
        End Try
    End Function

    Function getValue(sql As String, col As String)
        koneksi()
        Try
            cmd = New SqlCommand(sql, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If IsDBNull(dr.Item(col)) Then
                Return ""
            Else
                Return dr.Item(col)
            End If
        Catch ex As Exception
            Return ""
        Finally
            closekoneksi()
        End Try
    End Function


    Function excNonMSg(sql As String)
        koneksi()

        Try
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            ' MsgBox(ex.Message)
            Return False
        Finally
            closekoneksi()
        End Try
    End Function
    Function exc(sql As String)
        koneksi()

        Try
            cmd = New SqlCommand(sql, conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            closekoneksi()
        End Try
    End Function

    Sub clearForm(gb As GroupBox)
        For Each ct As Control In gb.Controls
            If TypeOf ct Is TextBox Then
                CType(ct, TextBox).Text = ""
            End If

            If TypeOf ct Is PictureBox Then
                CType(ct, PictureBox).ImageLocation = Nothing
            End If

            If TypeOf ct Is CheckBox Then
                CType(ct, CheckBox).Checked = False
            End If

            If TypeOf ct Is ComboBox Then
                Try
                    CType(ct, ComboBox).SelectedIndex = 0
                Catch ex As Exception

                End Try

            End If

            If TypeOf ct Is NumericUpDown Then
                Try
                    CType(ct, NumericUpDown).Value = 0
                Catch ex As Exception

                End Try
            End If
        Next
    End Sub

    Function dialog(txt As String)
        Dim ds As DialogResult = MessageBox.Show(txt, "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ds = DialogResult.Yes Then
            Return True
        Else
            Return False
        End If
    End Function

    Function numberFor(te As String)
        Dim uang As Double
        Try
            uang = Double.Parse(te)
        Catch ex As Exception
            uang = 0
        End Try
        Return uang
    End Function

    Sub onlyNumber(e As KeyPressEventArgs)
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True

            End If


        End If
    End Sub

    Function isEmail(email As String)
        Try
            Dim mail = New MailAddress(email)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


End Module

