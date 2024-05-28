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
        Me.imgFoto = New System.Windows.Forms.PictureBox()
        Me.gbMorador = New System.Windows.Forms.GroupBox()
        Me.lblCodMorador = New System.Windows.Forms.Label()
        Me.txtCodMorador = New System.Windows.Forms.MaskedTextBox()
        Me.txtWhatsappM = New System.Windows.Forms.MaskedTextBox()
        Me.lblWhatsMorador = New System.Windows.Forms.Label()
        Me.lblResponsavel = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.MaskedTextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.MaskedTextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.MaskedTextBox()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.cbMorador = New System.Windows.Forms.ComboBox()
        Me.gbVisita.SuspendLayout()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbVisita.Controls.Add(Me.imgFoto)
        Me.gbVisita.Location = New System.Drawing.Point(12, 9)
        Me.gbVisita.Name = "gbVisita"
        Me.gbVisita.Size = New System.Drawing.Size(562, 157)
        Me.gbVisita.TabIndex = 0
        Me.gbVisita.TabStop = False
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
        Me.txtVeiculo.Location = New System.Drawing.Point(409, 87)
        Me.txtVeiculo.Name = "txtVeiculo"
        Me.txtVeiculo.Size = New System.Drawing.Size(141, 20)
        Me.txtVeiculo.TabIndex = 77
        '
        'lblVeiculo
        '
        Me.lblVeiculo.AutoSize = True
        Me.lblVeiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVeiculo.Location = New System.Drawing.Point(406, 69)
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
        Me.txtWhatsapp.Location = New System.Drawing.Point(300, 87)
        Me.txtWhatsapp.Mask = "(00)0,000-0000"
        Me.txtWhatsapp.Name = "txtWhatsapp"
        Me.txtWhatsapp.Size = New System.Drawing.Size(96, 20)
        Me.txtWhatsapp.TabIndex = 68
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(157, 87)
        Me.txtCpf.Mask = "000,000,000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(135, 20)
        Me.txtCpf.TabIndex = 67
        '
        'txtVisita
        '
        Me.txtVisita.Location = New System.Drawing.Point(257, 37)
        Me.txtVisita.Name = "txtVisita"
        Me.txtVisita.Size = New System.Drawing.Size(293, 20)
        Me.txtVisita.TabIndex = 66
        '
        'lblWhatsapp
        '
        Me.lblWhatsapp.AutoSize = True
        Me.lblWhatsapp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhatsapp.Location = New System.Drawing.Point(297, 69)
        Me.lblWhatsapp.Name = "lblWhatsapp"
        Me.lblWhatsapp.Size = New System.Drawing.Size(65, 15)
        Me.lblWhatsapp.TabIndex = 65
        Me.lblWhatsapp.Text = "Whatsapp:"
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpf.Location = New System.Drawing.Point(154, 69)
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
        'imgFoto
        '
        Me.imgFoto.BackgroundImage = CType(resources.GetObject("imgFoto.BackgroundImage"), System.Drawing.Image)
        Me.imgFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgFoto.Location = New System.Drawing.Point(6, 19)
        Me.imgFoto.Name = "imgFoto"
        Me.imgFoto.Size = New System.Drawing.Size(136, 125)
        Me.imgFoto.TabIndex = 9
        Me.imgFoto.TabStop = False
        '
        'gbMorador
        '
        Me.gbMorador.Controls.Add(Me.cbMorador)
        Me.gbMorador.Controls.Add(Me.lblCodMorador)
        Me.gbMorador.Controls.Add(Me.txtCodMorador)
        Me.gbMorador.Controls.Add(Me.txtWhatsappM)
        Me.gbMorador.Controls.Add(Me.lblWhatsMorador)
        Me.gbMorador.Controls.Add(Me.lblResponsavel)
        Me.gbMorador.Controls.Add(Me.txtComplemento)
        Me.gbMorador.Controls.Add(Me.lblComplemento)
        Me.gbMorador.Controls.Add(Me.txtNumero)
        Me.gbMorador.Controls.Add(Me.lblNumero)
        Me.gbMorador.Controls.Add(Me.txtLogradouro)
        Me.gbMorador.Controls.Add(Me.lblLogradouro)
        Me.gbMorador.Location = New System.Drawing.Point(12, 172)
        Me.gbMorador.Name = "gbMorador"
        Me.gbMorador.Size = New System.Drawing.Size(562, 160)
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
        'txtWhatsappM
        '
        Me.txtWhatsappM.Location = New System.Drawing.Point(448, 34)
        Me.txtWhatsappM.Mask = "(00)0,000-0000"
        Me.txtWhatsappM.Name = "txtWhatsappM"
        Me.txtWhatsappM.Size = New System.Drawing.Size(96, 20)
        Me.txtWhatsappM.TabIndex = 77
        '
        'lblWhatsMorador
        '
        Me.lblWhatsMorador.AutoSize = True
        Me.lblWhatsMorador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhatsMorador.Location = New System.Drawing.Point(445, 16)
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
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(333, 94)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(211, 20)
        Me.txtComplemento.TabIndex = 63
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
        'cbMorador
        '
        Me.cbMorador.FormattingEnabled = True
        Me.cbMorador.Location = New System.Drawing.Point(113, 34)
        Me.cbMorador.Name = "cbMorador"
        Me.cbMorador.Size = New System.Drawing.Size(329, 21)
        Me.cbMorador.TabIndex = 83
        '
        'frmVisitante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 333)
        Me.Controls.Add(Me.gbMorador)
        Me.Controls.Add(Me.gbVisita)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVisitante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visitante"
        Me.gbVisita.ResumeLayout(False)
        Me.gbVisita.PerformLayout()
        CType(Me.imgFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMorador.ResumeLayout(False)
        Me.gbMorador.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbVisita As GroupBox
    Friend WithEvents gbMorador As GroupBox
    Friend WithEvents imgFoto As PictureBox
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
    Friend WithEvents txtComplemento As MaskedTextBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents txtNumero As MaskedTextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtLogradouro As MaskedTextBox
    Friend WithEvents lblLogradouro As Label
    Friend WithEvents lblCodMorador As Label
    Friend WithEvents txtCodMorador As MaskedTextBox
    Friend WithEvents txtWhatsappM As MaskedTextBox
    Friend WithEvents lblWhatsMorador As Label
    Friend WithEvents lblResponsavel As Label
    Friend WithEvents btnFoto As Button
    Friend WithEvents cbMorador As ComboBox
End Class
