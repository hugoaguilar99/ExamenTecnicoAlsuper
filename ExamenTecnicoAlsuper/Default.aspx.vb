Imports System.Data
Imports System.Data.SqlClient
Partial Class _Default
    Inherits Page
    Dim connect As New SqlConnection("Data Source=DESKTOP-DN21R3B\MSSQLSERVER01;Initial Catalog=BD_CRUD;User ID=test;Password=123456789")

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListProduct()
    End Sub

    Protected Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        connect.Open()
        cmd = New SqlCommand("Insert_Employee", connect)
        cmd2 = New SqlCommand("Insert_Mov", connect)
        cmd.CommandType = 4
        cmd2.CommandType = 4

        cmd2.Parameters.AddWithValue("@mov_id", CInt(Text_Id.Text.ToString))
        cmd2.Parameters.AddWithValue("@mov_type", "Alta")

        cmd.Parameters.AddWithValue("@idEmployee", CInt(Text_Id.Text.ToString))
        cmd.Parameters.AddWithValue("@name", Text_Name.Text.ToString)
        cmd.Parameters.AddWithValue("@lastP", Text_LastP.Text.ToString)
        cmd.Parameters.AddWithValue("@lastM", Text_LastM.Text.ToString)
        cmd.ExecuteNonQuery()
        cmd2.ExecuteNonQuery()
        MsgBox("succesfully Inserted", MsgBoxStyle.Information, "Message")
        ListProduct()
        connect.Close()

    End Sub

    Private Sub ListProduct()
        Dim cmd As New SqlCommand
        cmd = New SqlCommand("Show_Employees", connect)
        Dim sd As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sd.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()

        Dim cmd2 As New SqlCommand
        cmd2 = New SqlCommand("Read_Mov", connect)
        Dim sd2 As New SqlDataAdapter(cmd2)
        Dim dt2 As New DataTable
        sd2.Fill(dt2)
        Gridview2.DataSource = dt2
        Gridview2.DataBind()
    End Sub


    Protected Sub Btn_Update_Click(sender As Object, e As EventArgs) Handles Btn_Update.Click
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        connect.Open()
        cmd = New SqlCommand("Edit_Employee", connect)
        cmd2 = New SqlCommand("Insert_Mov", connect)
        cmd.CommandType = 4
        cmd2.CommandType = 4

        cmd2.Parameters.AddWithValue("@mov_id", CInt(Text_Id.Text.ToString))
        cmd2.Parameters.AddWithValue("@mov_type", "Cambios")

        cmd.Parameters.AddWithValue("@idEmployee", CInt(Text_Id.Text.ToString))
        cmd.Parameters.AddWithValue("@name", Text_Name.Text.ToString)
        cmd.Parameters.AddWithValue("@lastP", Text_LastP.Text.ToString)
        cmd.Parameters.AddWithValue("@lastM", Text_LastM.Text.ToString)
        cmd.ExecuteNonQuery()
        cmd2.ExecuteNonQuery()
        MsgBox("succesfully Updated", MsgBoxStyle.Information, "Message")
        ListProduct()
        connect.Close()
    End Sub

    Protected Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Dim cmd As New SqlCommand
        Dim cmd2 As New SqlCommand
        connect.Open()
        cmd = New SqlCommand("Delete_Employee", connect)
        cmd2 = New SqlCommand("Insert_Mov", connect)
        cmd.CommandType = 4
        cmd2.CommandType = 4

        cmd2.Parameters.AddWithValue("@mov_id", CInt(Text_Id.Text.ToString))
        cmd2.Parameters.AddWithValue("@mov_type", "Baja")

        cmd.Parameters.AddWithValue("@idEmployee", CInt(Text_Id.Text.ToString))
        cmd.ExecuteNonQuery()
        cmd2.ExecuteNonQuery()
        MsgBox("succesfully Deleted", MsgBoxStyle.Information, "Message")
        ListProduct()
        connect.Close()
    End Sub
End Class