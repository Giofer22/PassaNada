Public Class frmMoradores
    Private Sub frmMoradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimparFormulario()
    End Sub

    Private Sub LimparFormulario()
        txtCep.Clear()
        txtCod.Clear()
        txtCpf.Clear()
        txtEmail.Clear()
        txtLogradouro.Clear()
        txtBairro.Clear()
        txtCidade.Clear()
        txtNumero.Clear()
        txtComplemento.Clear()
        txtResponsavel.Clear()
        txtWhatsapp.Clear()
        txtBuscar.Clear()
        cbEstado.SelectedIndex = -1
        txtResponsavel.Select()


    End Sub

    Private Sub mnNovo_Click(sender As Object, e As EventArgs) Handles mnNovo.Click
        If MsgBox("Deseja realmente criar um novo registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Novo") = MsgBoxResult.Yes Then
            LimparFormulario()
        End If
    End Sub

    Private Sub mnFechar_Click(sender As Object, e As EventArgs) Handles mnFechar.Click
        If MsgBox("Deseja realmente fechar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Fechar") = MsgBoxResult.Yes Then
            Me.Close()

        End If
    End Sub
End Class