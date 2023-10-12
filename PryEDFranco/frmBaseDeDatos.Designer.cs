namespace PryEDFranco
{
    partial class frmBaseDeDatos
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
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProyecSimple = new System.Windows.Forms.Button();
            this.btnProyecMulti = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelecMulti = new System.Windows.Forms.Button();
            this.btnSelecSimple = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.Union = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(12, 12);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(776, 226);
            this.dgvConsulta.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJuntar);
            this.groupBox1.Controls.Add(this.btnProyecMulti);
            this.groupBox1.Controls.Add(this.btnProyecSimple);
            this.groupBox1.Location = new System.Drawing.Point(24, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 173);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones De Proyeccion - SELECT";
            // 
            // btnProyecSimple
            // 
            this.btnProyecSimple.Location = new System.Drawing.Point(7, 33);
            this.btnProyecSimple.Name = "btnProyecSimple";
            this.btnProyecSimple.Size = new System.Drawing.Size(225, 23);
            this.btnProyecSimple.TabIndex = 0;
            this.btnProyecSimple.Text = "Proyeccion Simple";
            this.btnProyecSimple.UseVisualStyleBackColor = true;
            this.btnProyecSimple.Click += new System.EventHandler(this.btnProyecSimple_Click);
            // 
            // btnProyecMulti
            // 
            this.btnProyecMulti.Location = new System.Drawing.Point(7, 75);
            this.btnProyecMulti.Name = "btnProyecMulti";
            this.btnProyecMulti.Size = new System.Drawing.Size(225, 23);
            this.btnProyecMulti.TabIndex = 1;
            this.btnProyecMulti.Text = "Proyeccion multiatributo";
            this.btnProyecMulti.UseVisualStyleBackColor = true;
            this.btnProyecMulti.Click += new System.EventHandler(this.btnProyecMulti_Click);
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(7, 119);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(225, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnSelecMulti);
            this.groupBox2.Controls.Add(this.btnSelecSimple);
            this.groupBox2.Location = new System.Drawing.Point(286, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 173);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones De Seleccion - WHERE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seleccion Por Convolucion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSelecMulti
            // 
            this.btnSelecMulti.Location = new System.Drawing.Point(7, 75);
            this.btnSelecMulti.Name = "btnSelecMulti";
            this.btnSelecMulti.Size = new System.Drawing.Size(225, 23);
            this.btnSelecMulti.TabIndex = 1;
            this.btnSelecMulti.Text = "Seleccion Multiatributo";
            this.btnSelecMulti.UseVisualStyleBackColor = true;
            // 
            // btnSelecSimple
            // 
            this.btnSelecSimple.Location = new System.Drawing.Point(7, 33);
            this.btnSelecSimple.Name = "btnSelecSimple";
            this.btnSelecSimple.Size = new System.Drawing.Size(225, 23);
            this.btnSelecSimple.TabIndex = 0;
            this.btnSelecSimple.Text = "Seleccion Simple";
            this.btnSelecSimple.UseVisualStyleBackColor = true;
            this.btnSelecSimple.Click += new System.EventHandler(this.btnSelecSimple_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDiferencia);
            this.groupBox3.Controls.Add(this.btnInterseccion);
            this.groupBox3.Controls.Add(this.Union);
            this.groupBox3.Location = new System.Drawing.Point(550, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 173);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones de Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(7, 119);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(225, 23);
            this.btnDiferencia.TabIndex = 2;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(7, 75);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(225, 23);
            this.btnInterseccion.TabIndex = 1;
            this.btnInterseccion.Text = "Interseccion";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // Union
            // 
            this.Union.Location = new System.Drawing.Point(7, 33);
            this.Union.Name = "Union";
            this.Union.Size = new System.Drawing.Size(225, 23);
            this.Union.TabIndex = 0;
            this.Union.Text = "Union";
            this.Union.UseVisualStyleBackColor = true;
            // 
            // frmBaseDeDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvConsulta);
            this.Name = "frmBaseDeDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseDeDatos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyecMulti;
        private System.Windows.Forms.Button btnProyecSimple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelecMulti;
        private System.Windows.Forms.Button btnSelecSimple;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button Union;
    }
}