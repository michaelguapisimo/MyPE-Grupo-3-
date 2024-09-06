namespace Ejercicios_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TBTitulo = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LbLibros = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbcopia = new System.Windows.Forms.ListBox();
            this.btncopiar = new System.Windows.Forms.Button();
            this.btnmover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBTitulo
            // 
            this.TBTitulo.AcceptsReturn = true;
            this.TBTitulo.Location = new System.Drawing.Point(317, 59);
            this.TBTitulo.Name = "TBTitulo";
            this.TBTitulo.ShortcutsEnabled = false;
            this.TBTitulo.Size = new System.Drawing.Size(255, 26);
            this.TBTitulo.TabIndex = 1;
            this.TBTitulo.TextChanged += new System.EventHandler(this.TBTitulo_TextChanged);
            this.TBTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBTitulo_KeyPress);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(603, 62);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LbLibros
            // 
            this.LbLibros.FormattingEnabled = true;
            this.LbLibros.ItemHeight = 20;
            this.LbLibros.Location = new System.Drawing.Point(40, 144);
            this.LbLibros.Name = "LbLibros";
            this.LbLibros.Size = new System.Drawing.Size(387, 164);
            this.LbLibros.TabIndex = 3;
            this.LbLibros.SelectedIndexChanged += new System.EventHandler(this.LbLibros_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Libros agregados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbcopia
            // 
            this.lbcopia.FormattingEnabled = true;
            this.lbcopia.ItemHeight = 20;
            this.lbcopia.Location = new System.Drawing.Point(449, 144);
            this.lbcopia.Name = "lbcopia";
            this.lbcopia.Size = new System.Drawing.Size(387, 164);
            this.lbcopia.TabIndex = 5;
            this.lbcopia.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btncopiar
            // 
            this.btncopiar.Location = new System.Drawing.Point(340, 97);
            this.btncopiar.Name = "btncopiar";
            this.btncopiar.Size = new System.Drawing.Size(75, 23);
            this.btncopiar.TabIndex = 6;
            this.btncopiar.Text = "copiar";
            this.btncopiar.UseVisualStyleBackColor = true;
            this.btncopiar.Click += new System.EventHandler(this.btncopiar_Click);
            // 
            // btnmover
            // 
            this.btnmover.Location = new System.Drawing.Point(432, 97);
            this.btnmover.Name = "btnmover";
            this.btnmover.Size = new System.Drawing.Size(75, 23);
            this.btnmover.TabIndex = 7;
            this.btnmover.Text = "mover";
            this.btnmover.UseVisualStyleBackColor = true;
            this.btnmover.Click += new System.EventHandler(this.btnmover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnmover);
            this.Controls.Add(this.btncopiar);
            this.Controls.Add(this.lbcopia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbLibros);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TBTitulo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Libros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBTitulo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ListBox LbLibros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbcopia;
        private System.Windows.Forms.Button btncopiar;
        private System.Windows.Forms.Button btnmover;
    }
}

