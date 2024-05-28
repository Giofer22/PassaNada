Public Class frmVisitante
    Private Sub frmVisitante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimparFormulario()
        ListarMoradores()
    End Sub
    Private Sub LimparFormulario()
        txtCod.Clear()
        txtVisita.Clear()
        txtCpf.Clear()
        txtWhatsapp.Clear()
        txtVeiculo.Clear()

        cbMorador.SelectedIndex = -1
        txtWhatsappM.Clear()
        txtLogradouro.Clear()
        txtNumero.Clear()
        txtComplemento.Clear()
    End Sub
    Private Sub ListarMoradores()
        cbMorador.Items.Clear()

        Dim sql As String
        sql = "
            SELECT PK_MORADOR, RESPONSAVEL FROM MORADOR ORDER BY RESPONSAVEL
        "
        vgRegistros.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        vgRegistros.Open(sql, vgDados)

        If vgRegistros.RecordCount > 0 Then
            While Not vgRegistros.EOF
                cbMorador.Items.Add(vgRegistros("RESPONSAVEL").Value)
                vgRegistros.MoveNext()
            End While
        End If
        vgRegistros.Close()
    End Sub

End Class