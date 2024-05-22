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

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim email As String = txtEmail.Text
        Dim senha As String = txtSenha.Text

        If email = "" Or senha = "" Then
            MsgBox("Por favor preencha todos os campos", MsgBoxStyle.Exclamation, "Campo obrigatório")
            LimparFormulario()

        Else
            If email = "admin" And senha = "1234" Then
                Me.Visible = False
                frmTelaInicial.ShowDialog()
                Me.Visible = True
                LimparFormulario()
            Else
                MsgBox("email ou senha inválidos!", MsgBoxStyle.Critical, "Dados incorretos")
                LimparFormulario()
            End If
        End If
    End Sub
End Class
