using System.Windows.Forms;

namespace Ejercicio_I02___Registrate
{
    partial class Registro
    {
        
        //public string[] getCheckedBoxes(GroupBox group)
        //{
        //    string[] checkedBoxes = new string[3];
        //    foreach (Control control in group.Controls)
        //    {
        //        // Verifica si el control es un CheckBox y está marcado
        //        if (control is CheckBox checkBox && checkBox.Checked)
        //        {
                    
        //        }
        //    }

        //}



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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EdadInput = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DireccionInput = new System.Windows.Forms.TextBox();
            this.NombreInput = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GeneroInput = new System.Windows.Forms.GroupBox();
            this.Nobinario = new System.Windows.Forms.RadioButton();
            this.Femenino = new System.Windows.Forms.RadioButton();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.CursosInput = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.Cplusplus = new System.Windows.Forms.CheckBox();
            this.CSharp = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.inputGenero = new System.Windows.Forms.ListBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdadInput)).BeginInit();
            this.GeneroInput.SuspendLayout();
            this.CursosInput.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EdadInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DireccionInput);
            this.groupBox1.Controls.Add(this.NombreInput);
            this.groupBox1.Location = new System.Drawing.Point(30, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 165);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del usuario";
            // 
            // EdadInput
            // 
            this.EdadInput.Location = new System.Drawing.Point(77, 112);
            this.EdadInput.Name = "EdadInput";
            this.EdadInput.Size = new System.Drawing.Size(100, 20);
            this.EdadInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dirección ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // DireccionInput
            // 
            this.DireccionInput.Location = new System.Drawing.Point(76, 72);
            this.DireccionInput.Name = "DireccionInput";
            this.DireccionInput.Size = new System.Drawing.Size(101, 20);
            this.DireccionInput.TabIndex = 1;
            // 
            // NombreInput
            // 
            this.NombreInput.Location = new System.Drawing.Point(76, 35);
            this.NombreInput.Name = "NombreInput";
            this.NombreInput.Size = new System.Drawing.Size(101, 20);
            this.NombreInput.TabIndex = 0;
            // 
            // GeneroInput
            // 
            this.GeneroInput.Controls.Add(this.Nobinario);
            this.GeneroInput.Controls.Add(this.Femenino);
            this.GeneroInput.Controls.Add(this.Masculino);
            this.GeneroInput.Location = new System.Drawing.Point(261, 28);
            this.GeneroInput.Name = "GeneroInput";
            this.GeneroInput.Size = new System.Drawing.Size(117, 132);
            this.GeneroInput.TabIndex = 6;
            this.GeneroInput.TabStop = false;
            this.GeneroInput.Text = "Género";
            // 
            // Nobinario
            // 
            this.Nobinario.AutoSize = true;
            this.Nobinario.Location = new System.Drawing.Point(20, 84);
            this.Nobinario.Name = "Nobinario";
            this.Nobinario.Size = new System.Drawing.Size(73, 17);
            this.Nobinario.TabIndex = 8;
            this.Nobinario.TabStop = true;
            this.Nobinario.Text = "No binario";
            this.Nobinario.UseVisualStyleBackColor = true;
            // 
            // Femenino
            // 
            this.Femenino.AutoSize = true;
            this.Femenino.Location = new System.Drawing.Point(20, 61);
            this.Femenino.Name = "Femenino";
            this.Femenino.Size = new System.Drawing.Size(71, 17);
            this.Femenino.TabIndex = 7;
            this.Femenino.TabStop = true;
            this.Femenino.Text = "Femenino";
            this.Femenino.UseVisualStyleBackColor = true;
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Location = new System.Drawing.Point(20, 38);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(73, 17);
            this.Masculino.TabIndex = 6;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            // 
            // CursosInput
            // 
            this.CursosInput.Controls.Add(this.checkBox3);
            this.CursosInput.Controls.Add(this.Cplusplus);
            this.CursosInput.Controls.Add(this.CSharp);
            this.CursosInput.Location = new System.Drawing.Point(261, 178);
            this.CursosInput.Name = "CursosInput";
            this.CursosInput.Size = new System.Drawing.Size(117, 132);
            this.CursosInput.TabIndex = 7;
            this.CursosInput.TabStop = false;
            this.CursosInput.Text = "Cursos";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(20, 81);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(76, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "JavaScript";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Cplusplus
            // 
            this.Cplusplus.AutoSize = true;
            this.Cplusplus.Location = new System.Drawing.Point(20, 58);
            this.Cplusplus.Name = "Cplusplus";
            this.Cplusplus.Size = new System.Drawing.Size(45, 17);
            this.Cplusplus.TabIndex = 1;
            this.Cplusplus.Text = "C++";
            this.Cplusplus.UseVisualStyleBackColor = true;
            // 
            // CSharp
            // 
            this.CSharp.AutoSize = true;
            this.CSharp.Location = new System.Drawing.Point(20, 35);
            this.CSharp.Name = "CSharp";
            this.CSharp.Size = new System.Drawing.Size(40, 17);
            this.CSharp.TabIndex = 0;
            this.CSharp.Text = "C#";
            this.CSharp.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.inputGenero);
            this.groupBox4.Controls.Add(this.numericUpDown2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(30, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(199, 111);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "País";
            // 
            // PaisInput
            // 
            this.inputGenero.FormattingEnabled = true;
            this.inputGenero.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.inputGenero.Location = new System.Drawing.Point(0, 16);
            this.inputGenero.Name = "PaisInput";
            this.inputGenero.Size = new System.Drawing.Size(199, 95);
            this.inputGenero.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(77, 112);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 22);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.CursosInput);
            this.Controls.Add(this.GeneroInput);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdadInput)).EndInit();
            this.GeneroInput.ResumeLayout(false);
            this.GeneroInput.PerformLayout();
            this.CursosInput.ResumeLayout(false);
            this.CursosInput.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox DireccionInput;
        private System.Windows.Forms.TextBox NombreInput;
        private System.Windows.Forms.NumericUpDown EdadInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox GeneroInput;
        private System.Windows.Forms.RadioButton Nobinario;
        private System.Windows.Forms.RadioButton Femenino;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.GroupBox CursosInput;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox Cplusplus;
        private System.Windows.Forms.CheckBox CSharp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox inputGenero;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

