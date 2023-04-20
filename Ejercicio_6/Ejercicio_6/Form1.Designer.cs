namespace Ejercicio_6
{
    partial class Frm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_operaciones = new System.Windows.Forms.ComboBox();
            this.btn_generar = new System.Windows.Forms.Button();
            this.txt_ingresar = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROGRAMA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESAR VALOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOS NUMEROS SON :\r\n";
            // 
            // combo_operaciones
            // 
            this.combo_operaciones.FormattingEnabled = true;
            this.combo_operaciones.Location = new System.Drawing.Point(396, 86);
            this.combo_operaciones.Name = "combo_operaciones";
            this.combo_operaciones.Size = new System.Drawing.Size(121, 21);
            this.combo_operaciones.TabIndex = 3;
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(562, 86);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(101, 55);
            this.btn_generar.TabIndex = 4;
            this.btn_generar.Text = "GENERAR";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // txt_ingresar
            // 
            this.txt_ingresar.Location = new System.Drawing.Point(192, 86);
            this.txt_ingresar.Name = "txt_ingresar";
            this.txt_ingresar.Size = new System.Drawing.Size(100, 20);
            this.txt_ingresar.TabIndex = 5;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(178, 142);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(255, 173);
            this.listBox.TabIndex = 8;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.txt_ingresar);
            this.Controls.Add(this.btn_generar);
            this.Controls.Add(this.combo_operaciones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm";
            this.Text = "FORUMULARIO";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_operaciones;
        private System.Windows.Forms.Button btn_generar;
        private System.Windows.Forms.TextBox txt_ingresar;
        private System.Windows.Forms.ListBox listBox;
    }
}

