Imports System.ComponentModel

Public Class frmLogin
    Private Sub LimparFormulario()
        txtEmail.Clear()
        txtSenha.Clear()
        txtEmail.Select()
    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click
        LimparFormulario()

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimparFormulario()
        conecta()

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmail.Text
        Dim senha As String = txtSenha.Text
        Dim sql As String

        If email = "" Or senha = "" Then
            MsgBox("Por favor preencha todos os campos", MsgBoxStyle.Exclamation, "Campo obrigatório")
            LimparFormulario()

        Else

            sql = "
                SELECT PK_USUARIO, NOME FROM USUARIO 
                WHERE EMAIL = '" & email & "' AND SENHA = '" & senha & "'
            "

            vgRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            vgRegistros.Open(sql, vgDados)

            If vgRegistros.RecordCount > 0 Then
                frmTelaInicial.ToolStripUsuario.Text = vgRegistros("NOME").Value
                vgRegistros.Close()
                Me.Visible = False
                frmTelaInicial.ShowDialog()
                Me.Visible = True
                LimparFormulario()
            Else
                vgRegistros.Close()
                MsgBox("email ou senha inválidos!", MsgBoxStyle.Critical, "Dados incorretos")
                LimparFormulario()
            End If
        End If
    End Sub

    Private Sub frmLogin_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        desconecta()
    End Sub
End Class
