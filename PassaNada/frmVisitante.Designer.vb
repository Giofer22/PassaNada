<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisitante
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisitante))
        Me.gbVisita = New System.Windows.Forms.GroupBox()
        Me.btnFoto = New System.Windows.Forms.Button()
        Me.txtVeiculo = New System.Windows.Forms.MaskedTextBox()
        Me.lblVeiculo = New System.Windows.Forms.Label()
        Me.lblCod = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.MaskedTextBox()
        Me.txtWhatsapp = New System.Windows.Forms.MaskedTextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtVisita = New System.Windows.Forms.MaskedTextBox()
        Me.lblWhatsapp = New System.Windows.Forms.Label()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblVisitante = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbMorador = New System.Windows.Forms.GroupBox()
        Me.lblCodMorador = New System.Windows.Forms.Label()
        Me.txtCodMorador = New System.Windows.Forms.MaskedTextBox()
        Me.txtWhatsMorador = New System.Windows.Forms.MaskedTextBox()
        Me.txtResponsavel = New System.Windows.Forms.MaskedTextBox()
        Me.lblWhatsMorador = New System.Windows.Forms.Label()
        Me.lblResponsavel = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.lblCep = New System.Windows.Forms.Label()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.MaskedTextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.MaskedTextBox()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.gbVisita.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMorador.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbVisita
        '
        Me.gbVisita.Controls.Add(Me.btnFoto)
        Me.gbVisita.Controls.Add(Me.txtVeiculo)
        Me.gbVisita.Controls.Add(Me.lblVeiculo)
        Me.gbVisita.Controls.Add(Me.lblCod)
        Me.gbVisita.Controls.Add(Me.txtCod)
        Me.gbVisita.Controls.Add(Me.txtWhatsapp)
        Me.gbVisita.Controls.Add(Me.txtCpf)
        Me.gbVisita.Controls.Add(Me.txtVisita)
        Me.gbVisita.Controls.Add(Me.lblWhatsapp)
        Me.gbVisita.Controls.Add(Me.lblCpf)
        Me.gbVisita.Controls.Add(Me.lblVisitante)
        Me.gbVisita.Controls.Add(Me.PictureBox1)
        Me.gbVisita.Location = New System.Drawing.Point(12, 9)
        Me.gbVisita.Name = "gbVisita"
        Me.gbVisita.Size = New System.Drawing.Size(774, 157)
        Me.gbVisita.TabIndex = 0
        Me.gbVisita.TabStop = False
        Me.gbVisita.Text = "Visitante"
        '
        'btnFoto
        '
        Me.btnFoto.Location = New System.Drawing.Point(157, 121)
        Me.btnFoto.Name = "btnFoto"
        Me.btnFoto.Size = New System.Drawing.Size(75, 23)
        Me.btnFoto.TabIndex = 78
        Me.btnFoto.Text = "Foto"
        Me.btnFoto.UseVisualStyleBackColor = True
        '
        'txtVeiculo
        '
        Me.txtVeiculo.Location = New System.Drawing.Point(157, 87)
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.Size = New System.Drawing.Size(141, 20)
        Me.txtVeiculo.TabIndex = 77
        '
        'lblVeiculo
        '
        Me.lblVeiculo.AutoSize = True
        Me.lblVeiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeiculo.Location = New System.Drawing.Point(154, 69)
        Me.lblVeiculo.Name = "lblVeiculo"
        Me.lblVeiculo.Size = New System.Drawing.Size(50, 15)
        Me.lblVeiculo.TabIndex = 76
        Me.lblVeiculo.Text = "Veiculo:"
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod.Location = New System.Drawing.Point(154, 19)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(32, 15)
        Me.lblCod.TabIndex = 75
        Me.lblCod.Text = "Cod:"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(157, 37)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.ReadOnly = True
        Me.txtCod.Size = New System.Drawing.Size(90, 20)
        Me.txtCod.TabIndex = 74
        '
        'txtWhatsapp
        '
        Me.txtWhatsapp.Location = New System.Drawing.Point(644, 37)
        Me.txtWhatsapp.Mask = "(00)0,000-0000"
        Me.txtWhatsapp.Name = "txtWhatsapp"
        Me.txtWhatsapp.Size = New System.Drawing.Size(96, 20)
        Me.txtWhatsapp.TabIndex = 68
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(501, 37)
        Me.txtCpf.Mask = "000,000,000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(135, 20)
        Me.txtCpf.TabIndex = 67
        '
        'txtVisita
        '
        Me.txtVisita.Location = New System.Drawing.Point(257, 37)
        Me.txtVisita.Name = "txtVisita"
        Me.txtVisita.Size = New System.Drawing.Size(232, 20)
        Me.txtVisita.TabIndex = 66
        '
        'lblWhatsapp
        '
        Me.lblWhatsapp.AutoSize = True
        Me.lblWhatsapp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhatsapp.Location = New System.Drawing.Point(641, 19)
        Me.lblWhatsapp.Name = "lblWhatsapp"
        Me.lblWhatsapp.Size = New System.Drawing.Size(65, 15)
        Me.lblWhatsapp.TabIndex = 65
        Me.lblWhatsapp.Text = "Whatsapp:"
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpf.Location = New System.Drawing.Point(498, 19)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(33, 15)
        Me.lblCpf.TabIndex = 64
        Me.lblCpf.Text = "CPF:"
        '
        'lblVisitante
        '
        Me.lblVisitante.AutoSize = True
        Me.lblVisitante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisitante.Location = New System.Drawing.Point(254, 19)
        Me.lblVisitante.Name = "lblVisitante"
        Me.lblVisitante.Size = New System.Drawing.Size(44, 15)
        Me.lblVisitante.TabIndex = 63
        Me.lblVisitante.Text = "Nome:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 125)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'gbMorador
        '
        Me.gbMorador.Controls.Add(Me.lblCodMorador)
        Me.gbMorador.Controls.Add(Me.txtCodMorador)
        Me.gbMorador.Controls.Add(Me.txtWhatsMorador)
        Me.gbMorador.Controls.Add(Me.txtResponsavel)
        Me.gbMorador.Controls.Add(Me.lblWhatsMorador)
        Me.gbMorador.Controls.Add(Me.lblResponsavel)
        Me.gbMorador.Controls.Add(Me.lblEstado)
        Me.gbMorador.Controls.Add(Me.cbEstado)
        Me.gbMorador.Controls.Add(Me.txtCep)
        Me.gbMorador.Controls.Add(Me.lblCep)
        Me.gbMorador.Controls.Add(Me.MaskedTextBox3)
        Me.gbMorador.Controls.Add(Me.lblCidade)
        Me.gbMorador.Controls.Add(Me.MaskedTextBox4)
        Me.gbMorador.Controls.Add(Me.lblBairro)
        Me.gbMorador.Controls.Add(Me.MaskedTextBox1)
        Me.gbMorador.Controls.Add(Me.lblComplemento)
        Me.gbMorador.Controls.Add(Me.txtNumero)
        Me.gbMorador.Controls.Add(Me.lblNumero)
        Me.gbMorador.Controls.Add(Me.txtLogradouro)
        Me.gbMorador.Controls.Add(Me.lblLogradouro)
        Me.gbMorador.Location = New System.Drawing.Point(12, 172)
        Me.gbMorador.Name = "gbMorador"
        Me.gbMorador.Size = New System.Drawing.Size(774, 266)
        Me.gbMorador.TabIndex = 1
        Me.gbMorador.TabStop = False
        Me.gbMorador.Text = "Morador"
        '
        'lblCodMorador
        '
        Me.lblCodMorador.AutoSize = True
        Me.lblCodMorador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodMorador.Location = New System.Drawing.Point(14, 16)
        Me.lblCodMorador.Name = "lblCodMorador"
        Me.lblCodMorador.Size = New System.Drawing.Size(32, 15)
        Me.lblCodMorador.TabIndex = 82
        Me.lblCodMorador.Text = "Cod:"
        '
        'txtCodMorador
        '
        Me.txtCodMorador.Location = New System.Drawing.Point(17, 34)
        Me.txtCodMorador.Name = "txtCodMorador"
        Me.txtCodMorador.ReadOnly = True
        Me.txtCodMorador.Size = New System.Drawing.Size(90, 20)
        Me.txtCodMorador.TabIndex = 81
        '
        'txtWhatsMorador
        '
        Me.txtWhatsMorador.Location = New System.Drawing.Point(325, 34)
        Me.txtWhatsMorador.Mask = "(00)0,000-0000"
        Me.txtWhatsMorador.Name = "txtWhatsMorador"
        Me.txtWhatsMorador.Size = New System.Drawing.Size(96, 20)
        Me.txtWhatsMorador.TabIndex = 77
        '
        'txtResponsavel
        '
        Me.txtResponsavel.Location = New System.Drawing.Point(113, 34)
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(203, 20)
        Me.txtResponsavel.TabIndex = 75
        '
        'lblWhatsMorador
        '
        Me.lblWhatsMorador.AutoSize = True
        Me.lblWhatsMorador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhatsMorador.Location = New System.Drawing.Point(322, 16)
        Me.lblWhatsMorador.Name = "lblWhatsMorador"
        Me.lblWhatsMorador.Size = New System.Drawing.Size(65, 15)
        Me.lblWhatsMorador.TabIndex = 74
        Me.lblWhatsMorador.Text = "Whatsapp:"
        '
        'lblResponsavel
        '
        Me.lblResponsavel.AutoSize = True
        Me.lblResponsavel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsavel.Location = New System.Drawing.Point(110, 16)
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Size = New System.Drawing.Size(81, 15)
        Me.lblResponsavel.TabIndex = 72
        Me.lblResponsavel.Text = "Responsável:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(397, 124)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(48, 15)
        Me.lblEstado.TabIndex = 71
        Me.lblEstado.Text = "Estado:"
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"AC, Acre", "AL, Alagoas", "AP, Amapá", "AM, Amazonas", "BA, Bahia", "CE, Ceará", "DF, Distrito Federal", "ES, Espirito Santo", "GO, Goiás", "MA, Maranhão", "MS, Mato Grosso do Sul", "MT, Mato Grosso", "MG, Minas Gerais", "PA, Pará", "PB, Paraíba", "PR, Paraná", "PE, Pernambuco", "PI, Piauí", "RJ, Rio de Janeiro", "RN, Rio Grande do Norte", "RS, Rio Grande do Sul", "RO, Rondônia", "RR, Roraima", "SC, Santa Catarina", "SP, São Paulo", "SE, Sergipe", "TO, Tocantins"})
        Me.cbEstado.Location = New System.Drawing.Point(400, 142)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(142, 21)
        Me.cbEstado.TabIndex = 70
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(548, 143)
        Me.txtCep.Mask = "00000-000"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(192, 20)
        Me.txtCep.TabIndex = 69
        '
        'lblCep
        '
        Me.lblCep.AutoSize = True
        Me.lblCep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCep.Location = New System.Drawing.Point(545, 125)
        Me.lblCep.Name = "lblCep"
        Me.lblCep.Size = New System.Drawing.Size(34, 15)
        Me.lblCep.TabIndex = 68
        Me.lblCep.Text = "CEP:"
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(228, 142)
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(159, 20)
        Me.MaskedTextBox3.TabIndex = 67
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(225, 124)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(49, 15)
        Me.lblCidade.TabIndex = 66
        Me.lblCidade.Text = "Cidade:"
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(11, 142)
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(206, 20)
        Me.MaskedTextBox4.TabIndex = 65
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(11, 124)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(43, 15)
        Me.lblBairro.TabIndex = 64
        Me.lblBairro.Text = "Bairro:"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(333, 94)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(407, 20)
        Me.MaskedTextBox1.TabIndex = 63
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplemento.Location = New System.Drawing.Point(333, 76)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(88, 15)
        Me.lblComplemento.TabIndex = 62
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(229, 94)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(92, 20)
        Me.txtNumero.TabIndex = 61
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(225, 76)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(55, 15)
        Me.lblNumero.TabIndex = 60
        Me.lblNumero.Text = "Número:"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(14, 94)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(203, 20)
        Me.txtLogradouro.TabIndex = 59
        '
        'lblLogradouro
        '
        Me.lblLogradouro.AutoSize = True
        Me.lblLogradouro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogradouro.Location = New System.Drawing.Point(14, 76)
        Me.lblLogradouro.Name = "lblLogradouro"
        Me.lblLogradouro.Size = New System.Drawing.Size(74, 15)
        Me.lblLogradouro.TabIndex = 58
        Me.lblLogradouro.Text = "Logradouro:"
        '
        'frmVisitante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gbMorador)
        Me.Controls.Add(Me.gbVisita)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVisitante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visitante"
        Me.gbVisita.ResumeLayout(False)
        Me.gbVisita.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMorador.ResumeLayout(False)
        Me.gbMorador.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbVisita As GroupBox
    Friend WithEvents gbMorador As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCod As Label
    Friend WithEvents txtCod As MaskedTextBox
    Friend WithEvents txtWhatsapp As MaskedTextBox
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents txtVisita As MaskedTextBox
    Friend WithEvents lblWhatsapp As Label
    Friend WithEvents lblCpf As Label
    Friend WithEvents lblVisitante As Label
    Friend WithEvents txtVeiculo As MaskedTextBox
    Friend WithEvents lblVeiculo As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents txtCep As MaskedTextBox
    Friend WithEvents lblCep As Label
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents txtNumero As MaskedTextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtLogradouro As MaskedTextBox
    Friend WithEvents lblLogradouro As Label
    Friend WithEvents lblCodMorador As Label
    Friend WithEvents txtCodMorador As MaskedTextBox
    Friend WithEvents txtWhatsMorador As MaskedTextBox
    Friend WithEvents txtResponsavel As MaskedTextBox
    Friend WithEvents lblWhatsMorador As Label
    Friend WithEvents lblResponsavel As Label
    Friend WithEvents btnFoto As Button
End Class
