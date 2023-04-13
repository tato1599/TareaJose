namespace ProyectoU1P2
{
    partial class Carrocvja
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbcvjaProductos = new System.Windows.Forms.ListBox();
            this.lbcvjaPrecios = new System.Windows.Forms.ListBox();
            this.btncvjaQuitar = new System.Windows.Forms.Button();
            this.btncvjaRegresar = new System.Windows.Forms.Button();
            this.btncvjaComprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carro de compras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 1;
            // 
            // lbcvjaProductos
            // 
            this.lbcvjaProductos.FormattingEnabled = true;
            this.lbcvjaProductos.ItemHeight = 15;
            this.lbcvjaProductos.Location = new System.Drawing.Point(26, 103);
            this.lbcvjaProductos.Name = "lbcvjaProductos";
            this.lbcvjaProductos.Size = new System.Drawing.Size(673, 259);
            this.lbcvjaProductos.TabIndex = 2;
            // 
            // lbcvjaPrecios
            // 
            this.lbcvjaPrecios.FormattingEnabled = true;
            this.lbcvjaPrecios.ItemHeight = 15;
            this.lbcvjaPrecios.Location = new System.Drawing.Point(715, 103);
            this.lbcvjaPrecios.Name = "lbcvjaPrecios";
            this.lbcvjaPrecios.Size = new System.Drawing.Size(84, 259);
            this.lbcvjaPrecios.TabIndex = 3;
            // 
            // btncvjaQuitar
            // 
            this.btncvjaQuitar.Location = new System.Drawing.Point(702, 419);
            this.btncvjaQuitar.Name = "btncvjaQuitar";
            this.btncvjaQuitar.Size = new System.Drawing.Size(97, 31);
            this.btncvjaQuitar.TabIndex = 4;
            this.btncvjaQuitar.Text = "Quitar";
            this.btncvjaQuitar.UseVisualStyleBackColor = true;
            this.btncvjaQuitar.Click += new System.EventHandler(this.btncvjaQuitar_Click);
            // 
            // btncvjaRegresar
            // 
            this.btncvjaRegresar.Location = new System.Drawing.Point(12, 419);
            this.btncvjaRegresar.Name = "btncvjaRegresar";
            this.btncvjaRegresar.Size = new System.Drawing.Size(94, 31);
            this.btncvjaRegresar.TabIndex = 5;
            this.btncvjaRegresar.Text = "Regresar";
            this.btncvjaRegresar.UseVisualStyleBackColor = true;
            this.btncvjaRegresar.Click += new System.EventHandler(this.btncvjaRegresar_Click);
            // 
            // btncvjaComprar
            // 
            this.btncvjaComprar.Location = new System.Drawing.Point(348, 406);
            this.btncvjaComprar.Name = "btncvjaComprar";
            this.btncvjaComprar.Size = new System.Drawing.Size(97, 44);
            this.btncvjaComprar.TabIndex = 6;
            this.btncvjaComprar.Text = "Realizar compra";
            this.btncvjaComprar.UseVisualStyleBackColor = true;
            // 
            // Carrocvja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 462);
            this.Controls.Add(this.btncvjaComprar);
            this.Controls.Add(this.btncvjaRegresar);
            this.Controls.Add(this.btncvjaQuitar);
            this.Controls.Add(this.lbcvjaPrecios);
            this.Controls.Add(this.lbcvjaProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Carrocvja";
            this.Text = "Carro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ListBox lbcvjaProductos;
        private ListBox lbcvjaPrecios;
        private Button btncvjaQuitar;
        private Button btncvjaRegresar;
        private Button btncvjaComprar;
    }
}