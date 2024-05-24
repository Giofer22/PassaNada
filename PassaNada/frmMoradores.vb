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

    Private Sub mnSalvar_Click(sender As Object, e As EventArgs) Handles mnSalvar.Click
        If txtResponsavel.Text = "" Or txtEmail.Text = "" Then
            MsgBox("Por favor, preencha os campos obrigatorios!", MsgBoxStyle.Information, "Campo obrigatóro")
        Else
            Dim item As New ListViewItem
            With lsvDados.Items.Add(item)
                .Text = txtCod.Text
                .SubItems.Add(txtResponsavel.Text)
                .SubItems.Add(txtCpf.Text)
                .SubItems.Add(txtWhatsapp.Text)
                .SubItems.Add(txtEmail.Text)
            End With
            LimparFormulario()
        End If

    End Sub

    Private Sub lsvDados_DoubleClick(sender As Object, e As EventArgs) Handles lsvDados.DoubleClick
        txtCod.Text = lsvDados.SelectedItems(0).Text
        txtResponsavel.Text = lsvDados.SelectedItems(0).SubItems(0).Text
        txtCpf.Text = lsvDados.SelectedItems(0).SubItems(1).Text
        txtWhatsapp.Text = lsvDados.SelectedItems(0).SubItems(2).Text
        txtEmail.Text = lsvDados.SelectedItems(0).SubItems(3).Text



    End Sub
End Class