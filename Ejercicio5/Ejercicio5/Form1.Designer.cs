
namespace Ejercicio5
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
            this.ejecutar_btn = new System.Windows.Forms.Button();
            this.col_txt = new System.Windows.Forms.TextBox();
            this.fila_txt = new System.Windows.Forms.TextBox();
            this.num_col = new System.Windows.Forms.Label();
            this.num_fila = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ejecutar_btn
            // 
            this.ejecutar_btn.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejecutar_btn.Location = new System.Drawing.Point(243, 261);
            this.ejecutar_btn.Name = "ejecutar_btn";
            this.ejecutar_btn.Size = new System.Drawing.Size(216, 49);
            this.ejecutar_btn.TabIndex = 9;
            this.ejecutar_btn.Text = "EJECUTAR";
            this.ejecutar_btn.UseVisualStyleBackColor = true;
            this.ejecutar_btn.Click += new System.EventHandler(this.ejecutar_btn_Click);
            // 
            // col_txt
            // 
            this.col_txt.Location = new System.Drawing.Point(359, 181);
            this.col_txt.Name = "col_txt";
            this.col_txt.Size = new System.Drawing.Size(202, 20);
            this.col_txt.TabIndex = 8;
            // 
            // fila_txt
            // 
            this.fila_txt.Location = new System.Drawing.Point(332, 141);
            this.fila_txt.Name = "fila_txt";
            this.fila_txt.Size = new System.Drawing.Size(202, 20);
            this.fila_txt.TabIndex = 7;
            // 
            // num_col
            // 
            this.num_col.AutoSize = true;
            this.num_col.Location = new System.Drawing.Point(240, 184);
            this.num_col.Name = "num_col";
            this.num_col.Size = new System.Drawing.Size(113, 13);
            this.num_col.TabIndex = 6;
            this.num_col.Text = "Número de columnas: ";
            // 
            // num_fila
            // 
            this.num_fila.AutoSize = true;
            this.num_fila.Location = new System.Drawing.Point(240, 144);
            this.num_fila.Name = "num_fila";
            this.num_fila.Size = new System.Drawing.Size(86, 13);
            this.num_fila.TabIndex = 5;
            this.num_fila.Text = "Número de filas: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ejecutar_btn);
            this.Controls.Add(this.col_txt);
            this.Controls.Add(this.fila_txt);
            this.Controls.Add(this.num_col);
            this.Controls.Add(this.num_fila);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ejecutar_btn;
        private System.Windows.Forms.TextBox col_txt;
        private System.Windows.Forms.TextBox fila_txt;
        private System.Windows.Forms.Label num_col;
        private System.Windows.Forms.Label num_fila;
    }
}

