namespace FindStringFile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCarpeta = new TextBox();
            btnBuscarCarpeta = new Button();
            btnProcesar = new Button();
            label2 = new Label();
            txtFiltro = new TextBox();
            dgvResultado = new DataGridView();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResultado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 22);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 0;
            label1.Text = "Carpeta:";
            // 
            // txtCarpeta
            // 
            txtCarpeta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCarpeta.Location = new Point(101, 19);
            txtCarpeta.Name = "txtCarpeta";
            txtCarpeta.Size = new Size(628, 31);
            txtCarpeta.TabIndex = 1;
            // 
            // btnBuscarCarpeta
            // 
            btnBuscarCarpeta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarCarpeta.Location = new Point(735, 17);
            btnBuscarCarpeta.Name = "btnBuscarCarpeta";
            btnBuscarCarpeta.Size = new Size(53, 34);
            btnBuscarCarpeta.TabIndex = 2;
            btnBuscarCarpeta.Text = "...";
            btnBuscarCarpeta.UseVisualStyleBackColor = true;
            btnBuscarCarpeta.Click += btnBuscarCarpeta_Click;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(18, 131);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(112, 34);
            btnProcesar.TabIndex = 3;
            btnProcesar.Text = "Buscar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 77);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 4;
            label2.Text = "Filtro:";
            // 
            // txtFiltro
            // 
            txtFiltro.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFiltro.Location = new Point(101, 74);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(628, 31);
            txtFiltro.TabIndex = 5;
            // 
            // dgvResultado
            // 
            dgvResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultado.Location = new Point(18, 185);
            dgvResultado.Name = "dgvResultado";
            dgvResultado.RowHeadersWidth = 62;
            dgvResultado.Size = new Size(770, 331);
            dgvResultado.TabIndex = 6;
            // 
            // btnExportar
            // 
            btnExportar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportar.Location = new Point(676, 131);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(112, 34);
            btnExportar.TabIndex = 7;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(btnExportar);
            Controls.Add(dgvResultado);
            Controls.Add(txtFiltro);
            Controls.Add(label2);
            Controls.Add(btnProcesar);
            Controls.Add(btnBuscarCarpeta);
            Controls.Add(txtCarpeta);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvResultado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCarpeta;
        private Button btnBuscarCarpeta;
        private Button btnProcesar;
        private Label label2;
        private TextBox txtFiltro;
        private DataGridView dgvResultado;
        private Button btnExportar;
    }
}
