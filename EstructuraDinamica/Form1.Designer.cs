namespace EstructuraDinamica
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
            this.listaEnlazada = new System.Windows.Forms.ListBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.btnAddStar = new System.Windows.Forms.Button();
            this.btnAddEnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaEnlazada
            // 
            this.listaEnlazada.FormattingEnabled = true;
            this.listaEnlazada.Location = new System.Drawing.Point(12, 12);
            this.listaEnlazada.Name = "listaEnlazada";
            this.listaEnlazada.Size = new System.Drawing.Size(115, 212);
            this.listaEnlazada.TabIndex = 0;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(133, 50);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(157, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // btnAddStar
            // 
            this.btnAddStar.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStar.Location = new System.Drawing.Point(134, 77);
            this.btnAddStar.Name = "btnAddStar";
            this.btnAddStar.Size = new System.Drawing.Size(156, 23);
            this.btnAddStar.TabIndex = 2;
            this.btnAddStar.Text = "Agregar Elmento al Inicio";
            this.btnAddStar.UseVisualStyleBackColor = false;
            this.btnAddStar.Click += new System.EventHandler(this.btnAddStar_Click);
            // 
            // btnAddEnd
            // 
            this.btnAddEnd.Location = new System.Drawing.Point(134, 106);
            this.btnAddEnd.Name = "btnAddEnd";
            this.btnAddEnd.Size = new System.Drawing.Size(156, 23);
            this.btnAddEnd.TabIndex = 2;
            this.btnAddEnd.Text = "Agregar Elmento al  Final";
            this.btnAddEnd.UseVisualStyleBackColor = true;
            this.btnAddEnd.Click += new System.EventHandler(this.btnAddEnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre del Nodo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddEnd);
            this.Controls.Add(this.btnAddStar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.listaEnlazada);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Elementos Lista Dinamina Nodo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaEnlazada;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnAddStar;
        private System.Windows.Forms.Button btnAddEnd;
        private System.Windows.Forms.Label label1;
    }
}

