using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Ejercicio_Integrador
{
    partial class MiCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiCalculadora));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.primerOperando = new System.Windows.Forms.TextBox();
            this.segundoOperando = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.radioButtonBinario = new System.Windows.Forms.RadioButton();
            this.radioButtonDecimal = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Operar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(144, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "RESULTADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(12, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer operando";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(304, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer operando";
            // 
            // primerOperando
            // 
            this.primerOperando.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.primerOperando.Location = new System.Drawing.Point(12, 207);
            this.primerOperando.Name = "primerOperando";
            this.primerOperando.Size = new System.Drawing.Size(158, 30);
            this.primerOperando.TabIndex = 1;
            // 
            // segundoOperando
            // 
            this.segundoOperando.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.segundoOperando.Location = new System.Drawing.Point(304, 207);
            this.segundoOperando.Name = "segundoOperando";
            this.segundoOperando.Size = new System.Drawing.Size(158, 30);
            this.segundoOperando.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(186, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Operación";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox.BackColor = System.Drawing.Color.LightGray;
            this.groupBox.Controls.Add(this.radioButtonBinario);
            this.groupBox.Controls.Add(this.radioButtonDecimal);
            this.groupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox.Location = new System.Drawing.Point(98, 87);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(262, 61);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Representar resultado en:";
            // 
            // radioButtonBinario
            // 
            this.radioButtonBinario.AutoSize = true;
            this.radioButtonBinario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.radioButtonBinario.Location = new System.Drawing.Point(150, 28);
            this.radioButtonBinario.Name = "radioButtonBinario";
            this.radioButtonBinario.Size = new System.Drawing.Size(57, 17);
            this.radioButtonBinario.TabIndex = 6;
            this.radioButtonBinario.TabStop = true;
            this.radioButtonBinario.Text = "Binario";
            this.radioButtonBinario.UseVisualStyleBackColor = false;
            // 
            // radioButtonDecimal
            // 
            this.radioButtonDecimal.AutoSize = true;
            this.radioButtonDecimal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.radioButtonDecimal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.radioButtonDecimal.Location = new System.Drawing.Point(52, 28);
            this.radioButtonDecimal.Name = "radioButtonDecimal";
            this.radioButtonDecimal.Size = new System.Drawing.Size(63, 17);
            this.radioButtonDecimal.TabIndex = 8;
            this.radioButtonDecimal.TabStop = true;
            this.radioButtonDecimal.Text = "Decimal";
            this.radioButtonDecimal.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "+ ",
            "-",
            "/",
            "*"});
            this.comboBox1.Location = new System.Drawing.Point(184, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 32);
            this.comboBox1.TabIndex = 3;
            // 
            // Operar
            // 
            this.Operar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Operar.Location = new System.Drawing.Point(12, 243);
            this.Operar.Name = "Operar";
            this.Operar.Size = new System.Drawing.Size(156, 35);
            this.Operar.TabIndex = 2;
            this.Operar.Text = "Operar";
            this.Operar.UseVisualStyleBackColor = true;
            // 
            // Cerrar
            // 
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.Location = new System.Drawing.Point(304, 243);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(156, 35);
            this.Cerrar.TabIndex = 6;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = true;
            // 
            // Limpiar
            // 
            this.Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Limpiar.Location = new System.Drawing.Point(184, 245);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(105, 35);
            this.Limpiar.TabIndex = 4;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            // 
            // MiCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(474, 287);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Operar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.segundoOperando);
            this.Controls.Add(this.primerOperando);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Falcone Alejo";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox primerOperando;
        private System.Windows.Forms.TextBox segundoOperando;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButtonDecimal;
        private System.Windows.Forms.RadioButton radioButtonBinario;
        private System.Windows.Forms.Button Operar;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Button Limpiar;
    }
}

