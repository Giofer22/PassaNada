<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoradores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMoradores))
        Me.lblCod = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.MaskedTextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.txtCidade = New System.Windows.Forms.MaskedTextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.MaskedTextBox()
        Me.lblBairro = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.MaskedTextBox()
        Me.lblComplemento = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.MaskedTextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.txtLogradouro = New System.Windows.Forms.MaskedTextBox()
        Me.lblLogradouro = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.MaskedTextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtWhatsapp = New System.Windows.Forms.MaskedTextBox()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtResponsavel = New System.Windows.Forms.MaskedTextBox()
        Me.lblWhatsapp = New System.Windows.Forms.Label()
        Me.lblCpf = New System.Windows.Forms.Label()
        Me.lblResponsavel = New System.Windows.Forms.Label()
        Me.lblCadastro = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnNovo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnSalvar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnExcluir = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnFechar = New System.Windows.Forms.ToolStripMenuItem()
        Me.lsvDados = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCod
        '
        Me.lblCod.AutoSize = True
        Me.lblCod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCod.Location = New System.Drawing.Point(12, 57)
        Me.lblCod.Name = "lblCod"
        Me.lblCod.Size = New System.Drawing.Size(32, 15)
        Me.lblCod.TabIndex = 62
        Me.lblCod.Text = "Cod:"
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(15, 75)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.ReadOnly = True
        Me.txtCod.Size = New System.Drawing.Size(90, 20)
        Me.txtCod.TabIndex = 61
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(713, 225)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 60
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(515, 227)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(179, 20)
        Me.txtBuscar.TabIndex = 59
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(512, 209)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(48, 15)
        Me.lblBuscar.TabIndex = 58
        Me.lblBuscar.Text = "Buscar:"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(512, 146)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(48, 15)
        Me.lblEstado.TabIndex = 57
        Me.lblEstado.Text = "Estado:"
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Items.AddRange(New Object() {"AC, Acre", "AL, Alagoas", "AP, Amapá", "AM, Amazonas", "BA, Bahia", "CE, Ceará", "DF, Distrito Federal", "ES, Espirito Santo", "GO, Goiás", "MA, Maranhão", "MS, Mato Grosso do Sul", "MT, Mato Grosso", "MG, Minas Gerais", "PA, Pará", "PB, Paraíba", "PR, Paraná", "PE, Pernambuco", "PI, Piauí", "RJ, Rio de Janeiro", "RN, Rio Grande do Norte", "RS, Rio Grande do Sul", "RO, Rondônia", "RR, Roraima", "SC, Santa Catarina", "SP, São Paulo", "SE, Sergipe", "TO, Tocantins"})
        Me.cbEstado.Location = New System.Drawing.Point(515, 164)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(142, 21)
        Me.cbEstado.TabIndex = 56
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(312, 166)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(197, 20)
        Me.txtCidade.TabIndex = 53
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCidade.Location = New System.Drawing.Point(313, 148)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(49, 15)
        Me.lblCidade.TabIndex = 52
        Me.lblCidade.Text = "Cidade:"
        '
        'txtBairro
        '
        Me.txtBairro.Location = New System.Drawing.Point(15, 166)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(291, 20)
        Me.txtBairro.TabIndex = 51
        '
        'lblBairro
        '
        Me.lblBairro.AutoSize = True
        Me.lblBairro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBairro.Location = New System.Drawing.Point(15, 148)
        Me.lblBairro.Name = "lblBairro"
        Me.lblBairro.Size = New System.Drawing.Size(43, 15)
        Me.lblBairro.TabIndex = 50
        Me.lblBairro.Text = "Bairro:"
        '
        'txtComplemento
        '
        Me.txtComplemento.Location = New System.Drawing.Point(458, 117)
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(330, 20)
        Me.txtComplemento.TabIndex = 49
        '
        'lblComplemento
        '
        Me.lblComplemento.AutoSize = True
        Me.lblComplemento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComplemento.Location = New System.Drawing.Point(458, 99)
        Me.lblComplemento.Name = "lblComplemento"
        Me.lblComplemento.Size = New System.Drawing.Size(88, 15)
        Me.lblComplemento.TabIndex = 48
        Me.lblComplemento.Text = "Complemento:"
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(317, 117)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(135, 20)
        Me.txtNumero.TabIndex = 47
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumero.Location = New System.Drawing.Point(320, 99)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(55, 15)
        Me.lblNumero.TabIndex = 46
        Me.lblNumero.Text = "Número:"
        '
        'txtLogradouro
        '
        Me.txtLogradouro.Location = New System.Drawing.Point(15, 117)
        Me.txtLogradouro.Name = "txtLogradouro"
        Me.txtLogradouro.Size = New System.Drawing.Size(296, 20)
        Me.txtLogradouro.TabIndex = 45
        '
        'lblLogradouro
        '
        Me.lblLogradouro.AutoSize = True
        Me.lblLogradouro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogradouro.Location = New System.Drawing.Point(15, 99)
        Me.lblLogradouro.Name = "lblLogradouro"
        Me.lblLogradouro.Size = New System.Drawing.Size(74, 15)
        Me.lblLogradouro.TabIndex = 44
        Me.lblLogradouro.Text = "Logradouro:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(566, 75)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(222, 20)
        Me.txtEmail.TabIndex = 43
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(566, 57)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(46, 15)
        Me.lblEmail.TabIndex = 42
        Me.lblEmail.Text = "E-mail:"
        '
        'txtWhatsapp
        '
        Me.txtWhatsapp.Location = New System.Drawing.Point(464, 75)
        Me.txtWhatsapp.Mask = "(00)0,000-0000"
        Me.txtWhatsapp.Name = "txtWhatsapp"
        Me.txtWhatsapp.Size = New System.Drawing.Size(96, 20)
        Me.txtWhatsapp.TabIndex = 41
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(317, 75)
        Me.txtCpf.Mask = "000,000,000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(135, 20)
        Me.txtCpf.TabIndex = 40
        '
        'txtResponsavel
        '
        Me.txtResponsavel.Location = New System.Drawing.Point(111, 75)
        Me.txtResponsavel.Name = "txtResponsavel"
        Me.txtResponsavel.Size = New System.Drawing.Size(203, 20)
        Me.txtResponsavel.TabIndex = 39
        '
        'lblWhatsapp
        '
        Me.lblWhatsapp.AutoSize = True
        Me.lblWhatsapp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWhatsapp.Location = New System.Drawing.Point(461, 57)
        Me.lblWhatsapp.Name = "lblWhatsapp"
        Me.lblWhatsapp.Size = New System.Drawing.Size(65, 15)
        Me.lblWhatsapp.TabIndex = 38
        Me.lblWhatsapp.Text = "Whatsapp:"
        '
        'lblCpf
        '
        Me.lblCpf.AutoSize = True
        Me.lblCpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCpf.Location = New System.Drawing.Point(314, 57)
        Me.lblCpf.Name = "lblCpf"
        Me.lblCpf.Size = New System.Drawing.Size(33, 15)
        Me.lblCpf.TabIndex = 37
        Me.lblCpf.Text = "CPF:"
        '
        'lblResponsavel
        '
        Me.lblResponsavel.AutoSize = True
        Me.lblResponsavel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsavel.Location = New System.Drawing.Point(108, 57)
        Me.lblResponsavel.Name = "lblResponsavel"
        Me.lblResponsavel.Size = New System.Drawing.Size(81, 15)
        Me.lblResponsavel.TabIndex = 36
        Me.lblResponsavel.Text = "Responsável:"
        '
        'lblCadastro
        '
        Me.lblCadastro.AutoSize = True
        Me.lblCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCadastro.Location = New System.Drawing.Point(15, 31)
        Me.lblCadastro.Name = "lblCadastro"
        Me.lblCadastro.Size = New System.Drawing.Size(70, 16)
        Me.lblCadastro.TabIndex = 35
        Me.lblCadastro.Text = "Cadastro"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnNovo, Me.mnSalvar, Me.mnExcluir, Me.mnFechar})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnNovo
        '
        Me.mnNovo.Name = "mnNovo"
        Me.mnNovo.Size = New System.Drawing.Size(48, 20)
        Me.mnNovo.Text = "&Novo"
        Me.mnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnSalvar
        '
        Me.mnSalvar.Name = "mnSalvar"
        Me.mnSalvar.Size = New System.Drawing.Size(50, 20)
        Me.mnSalvar.Text = "&Salvar"
        Me.mnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnExcluir
        '
        Me.mnExcluir.Name = "mnExcluir"
        Me.mnExcluir.Size = New System.Drawing.Size(54, 20)
        Me.mnExcluir.Text = "&Excluir"
        Me.mnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mnFechar
        '
        Me.mnFechar.Name = "mnFechar"
        Me.mnFechar.Size = New System.Drawing.Size(54, 20)
        Me.mnFechar.Text = "&Fechar"
        Me.mnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'lsvDados
        '
        Me.lsvDados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lsvDados.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lsvDados.FullRowSelect = True
        Me.lsvDados.GridLines = True
        Me.lsvDados.HideSelection = False
        Me.lsvDados.Location = New System.Drawing.Point(0, 260)
        Me.lsvDados.Name = "lsvDados"
        Me.lsvDados.Size = New System.Drawing.Size(800, 187)
        Me.lsvDados.TabIndex = 63
        Me.lsvDados.UseCompatibleStateImageBehavior = False
        Me.lsvDados.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Cod"
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Responsável"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CPF"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Whatsapp"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 167
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "E-mail"
        Me.ColumnHeader5.Width = 241
        '
        'frmMoradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 447)
        Me.Controls.Add(Me.lsvDados)
        Me.Controls.Add(Me.lblCod)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.lblBairro)
        Me.Controls.Add(Me.txtComplemento)
        Me.Controls.Add(Me.lblComplemento)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.txtLogradouro)
        Me.Controls.Add(Me.lblLogradouro)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtWhatsapp)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.txtResponsavel)
        Me.Controls.Add(Me.lblWhatsapp)
        Me.Controls.Add(Me.lblCpf)
        Me.Controls.Add(Me.lblResponsavel)
        Me.Controls.Add(Me.lblCadastro)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMoradores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Moradores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCod As Label
    Friend WithEvents txtCod As MaskedTextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscar As MaskedTextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents cbEstado As ComboBox
    Friend WithEvents txtCidade As MaskedTextBox
    Friend WithEvents lblCidade As Label
    Friend WithEvents txtBairro As MaskedTextBox
    Friend WithEvents lblBairro As Label
    Friend WithEvents txtComplemento As MaskedTextBox
    Friend WithEvents lblComplemento As Label
    Friend WithEvents txtNumero As MaskedTextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents txtLogradouro As MaskedTextBox
    Friend WithEvents lblLogradouro As Label
    Friend WithEvents txtEmail As MaskedTextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtWhatsapp As MaskedTextBox
    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents txtResponsavel As MaskedTextBox
    Friend WithEvents lblWhatsapp As Label
    Friend WithEvents lblCpf As Label
    Friend WithEvents lblResponsavel As Label
    Friend WithEvents lblCadastro As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnNovo As ToolStripMenuItem
    Friend WithEvents mnSalvar As ToolStripMenuItem
    Friend WithEvents mnExcluir As ToolStripMenuItem
    Friend WithEvents mnFechar As ToolStripMenuItem
    Friend WithEvents lsvDados As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
