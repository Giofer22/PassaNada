<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTelaInicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTelaInicial))
        Me.btnHistorico = New System.Windows.Forms.Button()
        Me.btnMoradores = New System.Windows.Forms.Button()
        Me.BtnVisitantes = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.VisitantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoradoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnHistorico
        '
        Me.btnHistorico.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnHistorico.Location = New System.Drawing.Point(7, 271)
        Me.btnHistorico.Name = "btnHistorico"
        Me.btnHistorico.Size = New System.Drawing.Size(253, 101)
        Me.btnHistorico.TabIndex = 8
        Me.btnHistorico.Text = "Historico"
        Me.btnHistorico.UseVisualStyleBackColor = True
        '
        'btnMoradores
        '
        Me.btnMoradores.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnMoradores.Location = New System.Drawing.Point(7, 57)
        Me.btnMoradores.Name = "btnMoradores"
        Me.btnMoradores.Size = New System.Drawing.Size(253, 102)
        Me.btnMoradores.TabIndex = 7
        Me.btnMoradores.Text = "Moradores"
        Me.btnMoradores.UseVisualStyleBackColor = True
        '
        'BtnVisitantes
        '
        Me.BtnVisitantes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnVisitantes.Location = New System.Drawing.Point(7, 165)
        Me.BtnVisitantes.Name = "BtnVisitantes"
        Me.BtnVisitantes.Size = New System.Drawing.Size(253, 100)
        Me.BtnVisitantes.TabIndex = 6
        Me.BtnVisitantes.Text = "Visitantes"
        Me.BtnVisitantes.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisitantesToolStripMenuItem, Me.HistóricoToolStripMenuItem, Me.MoradoresToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip2.TabIndex = 11
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'VisitantesToolStripMenuItem
        '
        Me.VisitantesToolStripMenuItem.Name = "VisitantesToolStripMenuItem"
        Me.VisitantesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.VisitantesToolStripMenuItem.Text = "&Visitantes"
        Me.VisitantesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'HistóricoToolStripMenuItem
        '
        Me.HistóricoToolStripMenuItem.Name = "HistóricoToolStripMenuItem"
        Me.HistóricoToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.HistóricoToolStripMenuItem.Text = "&Histórico"
        Me.HistóricoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MoradoresToolStripMenuItem
        '
        Me.MoradoresToolStripMenuItem.Name = "MoradoresToolStripMenuItem"
        Me.MoradoresToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.MoradoresToolStripMenuItem.Text = "&Moradores"
        Me.MoradoresToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FecharToolStripMenuItem.Text = "&Fechar"
        Me.FecharToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripUsuario})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 376)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripUsuario
        '
        Me.ToolStripUsuario.Name = "ToolStripUsuario"
        Me.ToolStripUsuario.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripUsuario.Text = "ToolStripStatusLabel1"
        '
        'frmTelaInicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 398)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnHistorico)
        Me.Controls.Add(Me.btnMoradores)
        Me.Controls.Add(Me.BtnVisitantes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTelaInicial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tela Inicial"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHistorico As Button
    Friend WithEvents btnMoradores As Button
    Friend WithEvents BtnVisitantes As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents VisitantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HistóricoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MoradoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FecharToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripUsuario As ToolStripStatusLabel
End Class
