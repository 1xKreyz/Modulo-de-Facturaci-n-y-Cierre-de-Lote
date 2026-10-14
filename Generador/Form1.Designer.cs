namespace Generador
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitulo;
        private Label lblSubtitulo;
        private GroupBox grpTotalFacturado;
        private Label lblMontoTotal;
        private GroupBox grpHistorialLogs;
        private TextBox txtHistorialLogs;
        private GroupBox grpReporteConsolidado;
        private TextBox txtReporteConsolidado;
        private Button btnCerrarLote;
        private Label lblEstadoLote;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            grpTotalFacturado = new GroupBox();
            lblMontoTotal = new Label();
            grpHistorialLogs = new GroupBox();
            txtHistorialLogs = new TextBox();
            grpReporteConsolidado = new GroupBox();
            txtReporteConsolidado = new TextBox();
            btnCerrarLote = new Button();
            lblEstadoLote = new Label();

            SuspendLayout();

            // lblTitulo
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(240, 240, 240);
            lblTitulo.Location = new Point(25, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(460, 28);
            lblTitulo.Text = "Módulo de Facturación y Cierre de Lote";

            // lblSubtitulo
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblSubtitulo.ForeColor = Color.FromArgb(180, 190, 200);
            lblSubtitulo.Location = new Point(28, 48);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(310, 19);
            lblSubtitulo.Text = "Tema 7 — Generador de Reporte Consolidado";

            // grpTotalFacturado
            grpTotalFacturado.Controls.Add(lblMontoTotal);
            grpTotalFacturado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTotalFacturado.ForeColor = Color.FromArgb(100, 210, 255);
            grpTotalFacturado.Location = new Point(28, 85);
            grpTotalFacturado.Name = "grpTotalFacturado";
            grpTotalFacturado.Size = new Size(350, 95);
            grpTotalFacturado.TabIndex = 0;
            grpTotalFacturado.TabStop = false;
            grpTotalFacturado.Text = "Total Facturado (Tema 10)";

            // lblMontoTotal
            lblMontoTotal.Dock = DockStyle.Fill;
            lblMontoTotal.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblMontoTotal.ForeColor = Color.FromArgb(80, 250, 123);
            lblMontoTotal.Location = new Point(3, 21);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(344, 71);
            lblMontoTotal.Text = "$ 0.00";
            lblMontoTotal.TextAlign = ContentAlignment.MiddleCenter;

            // grpHistorialLogs
            grpHistorialLogs.Controls.Add(txtHistorialLogs);
            grpHistorialLogs.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpHistorialLogs.ForeColor = Color.FromArgb(100, 210, 255);
            grpHistorialLogs.Location = new Point(28, 195);
            grpHistorialLogs.Name = "grpHistorialLogs";
            grpHistorialLogs.Size = new Size(350, 220);
            grpHistorialLogs.TabIndex = 1;
            grpHistorialLogs.TabStop = false;
            grpHistorialLogs.Text = "Historial de Logs / Auditoría (Tema 9)";

            // txtHistorialLogs
            txtHistorialLogs.BackColor = Color.FromArgb(30, 34, 42);
            txtHistorialLogs.BorderStyle = BorderStyle.FixedSingle;
            txtHistorialLogs.Dock = DockStyle.Fill;
            txtHistorialLogs.Font = new Font("Consolas", 9.5F, FontStyle.Regular);
            txtHistorialLogs.ForeColor = Color.FromArgb(220, 220, 220);
            txtHistorialLogs.Location = new Point(3, 21);
            txtHistorialLogs.Multiline = true;
            txtHistorialLogs.Name = "txtHistorialLogs";
            txtHistorialLogs.ReadOnly = true;
            txtHistorialLogs.ScrollBars = ScrollBars.Vertical;
            txtHistorialLogs.Size = new Size(344, 196);

            // grpReporteConsolidado
            grpReporteConsolidado.Controls.Add(txtReporteConsolidado);
            grpReporteConsolidado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpReporteConsolidado.ForeColor = Color.FromArgb(100, 210, 255);
            grpReporteConsolidado.Location = new Point(400, 85);
            grpReporteConsolidado.Name = "grpReporteConsolidado";
            grpReporteConsolidado.Size = new Size(370, 260);
            grpReporteConsolidado.TabIndex = 2;
            grpReporteConsolidado.TabStop = false;
            grpReporteConsolidado.Text = "Reporte Consolidado";

            // txtReporteConsolidado
            txtReporteConsolidado.BackColor = Color.FromArgb(30, 34, 42);
            txtReporteConsolidado.BorderStyle = BorderStyle.FixedSingle;
            txtReporteConsolidado.Dock = DockStyle.Fill;
            txtReporteConsolidado.Font = new Font("Consolas", 9.5F, FontStyle.Regular);
            txtReporteConsolidado.ForeColor = Color.FromArgb(240, 240, 240);
            txtReporteConsolidado.Location = new Point(3, 21);
            txtReporteConsolidado.Multiline = true;
            txtReporteConsolidado.Name = "txtReporteConsolidado";
            txtReporteConsolidado.ReadOnly = true;
            txtReporteConsolidado.ScrollBars = ScrollBars.Vertical;
            txtReporteConsolidado.Size = new Size(364, 236);

            // lblEstadoLote
            lblEstadoLote.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoLote.ForeColor = Color.FromArgb(255, 184, 108);
            lblEstadoLote.Location = new Point(400, 353);
            lblEstadoLote.Name = "lblEstadoLote";
            lblEstadoLote.Size = new Size(370, 22);
            lblEstadoLote.Text = "Estado: Turno en Curso (Pendiente de Cierre)";
            lblEstadoLote.TextAlign = ContentAlignment.MiddleCenter;

            // btnCerrarLote
            btnCerrarLote.BackColor = Color.FromArgb(0, 122, 204);
            btnCerrarLote.Cursor = Cursors.Hand;
            btnCerrarLote.FlatAppearance.BorderSize = 0;
            btnCerrarLote.FlatStyle = FlatStyle.Flat;
            btnCerrarLote.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCerrarLote.ForeColor = Color.White;
            btnCerrarLote.Location = new Point(400, 380);
            btnCerrarLote.Name = "btnCerrarLote";
            btnCerrarLote.Size = new Size(370, 42);
            btnCerrarLote.TabIndex = 3;
            btnCerrarLote.Text = "Finalizar Turno y Cerrar Lote";
            btnCerrarLote.UseVisualStyleBackColor = false;
            btnCerrarLote.Click += btnCerrarLote_Click;

            // Form1
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 24, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(grpTotalFacturado);
            Controls.Add(grpHistorialLogs);
            Controls.Add(grpReporteConsolidado);
            Controls.Add(lblEstadoLote);
            Controls.Add(btnCerrarLote);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Generador de Reporte Consolidado - Tema 7";

            grpTotalFacturado.ResumeLayout(false);
            grpHistorialLogs.ResumeLayout(false);
            grpHistorialLogs.PerformLayout();
            grpReporteConsolidado.ResumeLayout(false);
            grpReporteConsolidado.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}