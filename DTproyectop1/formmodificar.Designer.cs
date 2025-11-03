namespace DTproyectop1
{
    partial class frmmodificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmodificar));
            this.grpcita = new System.Windows.Forms.GroupBox();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.rbsi = new System.Windows.Forms.RadioButton();
            this.grpsucursales = new System.Windows.Forms.GroupBox();
            this.chbgalerias = new System.Windows.Forms.CheckBox();
            this.chbnorte = new System.Windows.Forms.CheckBox();
            this.chbtrojes = new System.Windows.Forms.CheckBox();
            this.chbmatriz = new System.Windows.Forms.CheckBox();
            this.gprprep = new System.Windows.Forms.GroupBox();
            this.chbmetal = new System.Windows.Forms.CheckBox();
            this.chbhigiene = new System.Windows.Forms.CheckBox();
            this.chbmicro = new System.Windows.Forms.CheckBox();
            this.chbcrea = new System.Windows.Forms.CheckBox();
            this.chbvejiga = new System.Windows.Forms.CheckBox();
            this.chbayuno = new System.Windows.Forms.CheckBox();
            this.gprdatos = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtestudio = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.lnklblregreso = new System.Windows.Forms.LinkLabel();
            this.lnklblsalir = new System.Windows.Forms.LinkLabel();
            this.grpcita.SuspendLayout();
            this.grpsucursales.SuspendLayout();
            this.gprprep.SuspendLayout();
            this.gprdatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpcita
            // 
            this.grpcita.Controls.Add(this.rbno);
            this.grpcita.Controls.Add(this.rbsi);
            this.grpcita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(140)))), ((int)(((byte)(83)))));
            this.grpcita.Location = new System.Drawing.Point(42, 205);
            this.grpcita.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.grpcita.Name = "grpcita";
            this.grpcita.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.grpcita.Size = new System.Drawing.Size(203, 100);
            this.grpcita.TabIndex = 8;
            this.grpcita.TabStop = false;
            this.grpcita.Text = "Requiere cita";
            // 
            // rbno
            // 
            this.rbno.AutoSize = true;
            this.rbno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(140)))), ((int)(((byte)(83)))));
            this.rbno.Location = new System.Drawing.Point(111, 39);
            this.rbno.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rbno.Name = "rbno";
            this.rbno.Size = new System.Drawing.Size(63, 29);
            this.rbno.TabIndex = 1;
            this.rbno.TabStop = true;
            this.rbno.Text = "NO";
            this.rbno.UseVisualStyleBackColor = true;
            // 
            // rbsi
            // 
            this.rbsi.AutoSize = true;
            this.rbsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(140)))), ((int)(((byte)(83)))));
            this.rbsi.Location = new System.Drawing.Point(33, 39);
            this.rbsi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rbsi.Name = "rbsi";
            this.rbsi.Size = new System.Drawing.Size(50, 29);
            this.rbsi.TabIndex = 0;
            this.rbsi.TabStop = true;
            this.rbsi.Text = "SI";
            this.rbsi.UseVisualStyleBackColor = true;
            // 
            // grpsucursales
            // 
            this.grpsucursales.Controls.Add(this.chbgalerias);
            this.grpsucursales.Controls.Add(this.chbnorte);
            this.grpsucursales.Controls.Add(this.chbtrojes);
            this.grpsucursales.Controls.Add(this.chbmatriz);
            this.grpsucursales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(89)))));
            this.grpsucursales.Location = new System.Drawing.Point(275, 202);
            this.grpsucursales.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.grpsucursales.Name = "grpsucursales";
            this.grpsucursales.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.grpsucursales.Size = new System.Drawing.Size(252, 132);
            this.grpsucursales.TabIndex = 7;
            this.grpsucursales.TabStop = false;
            this.grpsucursales.Text = "Sucursales";
            // 
            // chbgalerias
            // 
            this.chbgalerias.AutoSize = true;
            this.chbgalerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(89)))));
            this.chbgalerias.Location = new System.Drawing.Point(139, 36);
            this.chbgalerias.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.chbgalerias.Name = "chbgalerias";
            this.chbgalerias.Size = new System.Drawing.Size(105, 29);
            this.chbgalerias.TabIndex = 2;
            this.chbgalerias.Text = "Galerias";
            this.chbgalerias.UseVisualStyleBackColor = true;
            // 
            // chbnorte
            // 
            this.chbnorte.AutoSize = true;
            this.chbnorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(89)))));
            this.chbnorte.Location = new System.Drawing.Point(24, 78);
            this.chbnorte.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.chbnorte.Name = "chbnorte";
            this.chbnorte.Size = new System.Drawing.Size(86, 29);
            this.chbnorte.TabIndex = 1;
            this.chbnorte.Text = "Norte";
            this.chbnorte.UseVisualStyleBackColor = true;
            // 
            // chbtrojes
            // 
            this.chbtrojes.AutoSize = true;
            this.chbtrojes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(89)))));
            this.chbtrojes.Location = new System.Drawing.Point(139, 78);
            this.chbtrojes.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.chbtrojes.Name = "chbtrojes";
            this.chbtrojes.Size = new System.Drawing.Size(89, 29);
            this.chbtrojes.TabIndex = 3;
            this.chbtrojes.Text = "Trojes";
            this.chbtrojes.UseVisualStyleBackColor = true;
            // 
            // chbmatriz
            // 
            this.chbmatriz.AutoSize = true;
            this.chbmatriz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(89)))));
            this.chbmatriz.Location = new System.Drawing.Point(24, 36);
            this.chbmatriz.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.chbmatriz.Name = "chbmatriz";
            this.chbmatriz.Size = new System.Drawing.Size(92, 29);
            this.chbmatriz.TabIndex = 0;
            this.chbmatriz.Text = "Matriz";
            this.chbmatriz.UseVisualStyleBackColor = true;
            // 
            // gprprep
            // 
            this.gprprep.Controls.Add(this.chbmetal);
            this.gprprep.Controls.Add(this.chbhigiene);
            this.gprprep.Controls.Add(this.chbmicro);
            this.gprprep.Controls.Add(this.chbcrea);
            this.gprprep.Controls.Add(this.chbvejiga);
            this.gprprep.Controls.Add(this.chbayuno);
            this.gprprep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.gprprep.Location = new System.Drawing.Point(541, 196);
            this.gprprep.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gprprep.Name = "gprprep";
            this.gprprep.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gprprep.Size = new System.Drawing.Size(396, 154);
            this.gprprep.TabIndex = 6;
            this.gprprep.TabStop = false;
            this.gprprep.Text = "Preparaciones";
            // 
            // chbmetal
            // 
            this.chbmetal.AutoSize = true;
            this.chbmetal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.chbmetal.Location = new System.Drawing.Point(195, 102);
            this.chbmetal.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.chbmetal.Name = "chbmetal";
            this.chbmetal.Size = new System.Drawing.Size(117, 29);
            this.chbmetal.TabIndex = 5;
            this.chbmetal.Text = "Sin metal";
            this.chbmetal.UseVisualStyleBackColor = true;
            // 
            // chbhigiene
            // 
            this.chbhigiene.AutoSize = true;
            this.chbhigiene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.chbhigiene.Location = new System.Drawing.Point(195, 69);
            this.chbhigiene.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.chbhigiene.Name = "chbhigiene";
            this.chbhigiene.Size = new System.Drawing.Size(186, 29);
            this.chbhigiene.TabIndex = 4;
            this.chbhigiene.Text = "Higiene personal";
            this.chbhigiene.UseVisualStyleBackColor = true;
            // 
            // chbmicro
            // 
            this.chbmicro.AutoSize = true;
            this.chbmicro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.chbmicro.Location = new System.Drawing.Point(195, 34);
            this.chbmicro.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.chbmicro.Name = "chbmicro";
            this.chbmicro.Size = new System.Drawing.Size(113, 29);
            this.chbmicro.TabIndex = 3;
            this.chbmicro.Text = "Microlax";
            this.chbmicro.UseVisualStyleBackColor = true;
            // 
            // chbcrea
            // 
            this.chbcrea.AutoSize = true;
            this.chbcrea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.chbcrea.Location = new System.Drawing.Point(39, 102);
            this.chbcrea.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.chbcrea.Name = "chbcrea";
            this.chbcrea.Size = new System.Drawing.Size(125, 29);
            this.chbcrea.TabIndex = 2;
            this.chbcrea.Text = "Creatinina";
            this.chbcrea.UseVisualStyleBackColor = true;
            // 
            // chbvejiga
            // 
            this.chbvejiga.AutoSize = true;
            this.chbvejiga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.chbvejiga.Location = new System.Drawing.Point(39, 69);
            this.chbvejiga.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.chbvejiga.Name = "chbvejiga";
            this.chbvejiga.Size = new System.Drawing.Size(146, 29);
            this.chbvejiga.TabIndex = 1;
            this.chbvejiga.Text = "Vejiga Llena ";
            this.chbvejiga.UseVisualStyleBackColor = true;
            // 
            // chbayuno
            // 
            this.chbayuno.AutoSize = true;
            this.chbayuno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.chbayuno.Location = new System.Drawing.Point(39, 34);
            this.chbayuno.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.chbayuno.Name = "chbayuno";
            this.chbayuno.Size = new System.Drawing.Size(94, 29);
            this.chbayuno.TabIndex = 0;
            this.chbayuno.Text = "Ayuno";
            this.chbayuno.UseVisualStyleBackColor = true;
            // 
            // gprdatos
            // 
            this.gprdatos.Controls.Add(this.txtid);
            this.gprdatos.Controls.Add(this.lblid);
            this.gprdatos.Controls.Add(this.gprprep);
            this.gprdatos.Controls.Add(this.grpsucursales);
            this.gprdatos.Controls.Add(this.grpcita);
            this.gprdatos.Controls.Add(this.button1);
            this.gprdatos.Controls.Add(this.txtcosto);
            this.gprdatos.Controls.Add(this.txtestudio);
            this.gprdatos.Controls.Add(this.lbl2);
            this.gprdatos.Controls.Add(this.lbl1);
            this.gprdatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(89)))));
            this.gprdatos.Location = new System.Drawing.Point(30, 31);
            this.gprdatos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gprdatos.Name = "gprdatos";
            this.gprdatos.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gprdatos.Size = new System.Drawing.Size(947, 341);
            this.gprdatos.TabIndex = 5;
            this.gprdatos.TabStop = false;
            this.gprdatos.Text = "Estudio";
            this.gprdatos.Enter += new System.EventHandler(this.gprdatos_Enter);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(188, 27);
            this.txtid.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(220, 31);
            this.txtid.TabIndex = 10;
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(89)))));
            this.lblid.Location = new System.Drawing.Point(116, 33);
            this.lblid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(32, 25);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "ID";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.Location = new System.Drawing.Point(447, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtcosto
            // 
            this.txtcosto.Location = new System.Drawing.Point(187, 130);
            this.txtcosto.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(220, 31);
            this.txtcosto.TabIndex = 3;
            // 
            // txtestudio
            // 
            this.txtestudio.Location = new System.Drawing.Point(187, 75);
            this.txtestudio.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtestudio.Name = "txtestudio";
            this.txtestudio.Size = new System.Drawing.Size(620, 31);
            this.txtestudio.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(89)))));
            this.lbl2.Location = new System.Drawing.Point(115, 136);
            this.lbl2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(64, 25);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Costo";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(89)))));
            this.lbl1.Location = new System.Drawing.Point(30, 77);
            this.lbl1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(151, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Tipo de Estudio";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(64)))));
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnguardar.Location = new System.Drawing.Point(477, 403);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(164, 55);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // lnklblregreso
            // 
            this.lnklblregreso.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(140)))), ((int)(((byte)(80)))));
            this.lnklblregreso.AutoSize = true;
            this.lnklblregreso.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblregreso.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(140)))), ((int)(((byte)(80)))));
            this.lnklblregreso.Location = new System.Drawing.Point(400, 499);
            this.lnklblregreso.Name = "lnklblregreso";
            this.lnklblregreso.Size = new System.Drawing.Size(115, 31);
            this.lnklblregreso.TabIndex = 10;
            this.lnklblregreso.TabStop = true;
            this.lnklblregreso.Text = "Regresar";
            this.lnklblregreso.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(140)))), ((int)(((byte)(80)))));
            this.lnklblregreso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblregreso_LinkClicked);
            // 
            // lnklblsalir
            // 
            this.lnklblsalir.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(89)))));
            this.lnklblsalir.AutoSize = true;
            this.lnklblsalir.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblsalir.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(89)))));
            this.lnklblsalir.Location = new System.Drawing.Point(671, 499);
            this.lnklblsalir.Name = "lnklblsalir";
            this.lnklblsalir.Size = new System.Drawing.Size(65, 31);
            this.lnklblsalir.TabIndex = 11;
            this.lnklblsalir.TabStop = true;
            this.lnklblsalir.Text = "Salir";
            this.lnklblsalir.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(89)))));
            this.lnklblsalir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblsalir_LinkClicked);
            // 
            // frmmodificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 582);
            this.Controls.Add(this.lnklblsalir);
            this.Controls.Add(this.lnklblregreso);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.gprdatos);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmmodificar";
            this.Text = "Modificar Estudio";
            this.grpcita.ResumeLayout(false);
            this.grpcita.PerformLayout();
            this.grpsucursales.ResumeLayout(false);
            this.grpsucursales.PerformLayout();
            this.gprprep.ResumeLayout(false);
            this.gprprep.PerformLayout();
            this.gprdatos.ResumeLayout(false);
            this.gprdatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpcita;
        private System.Windows.Forms.GroupBox grpsucursales;
        private System.Windows.Forms.GroupBox gprprep;
        private System.Windows.Forms.GroupBox gprdatos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.LinkLabel lnklblregreso;
        private System.Windows.Forms.LinkLabel lnklblsalir;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.RadioButton rbno;
        public System.Windows.Forms.RadioButton rbsi;
        public System.Windows.Forms.CheckBox chbgalerias;
        public System.Windows.Forms.CheckBox chbnorte;
        public System.Windows.Forms.CheckBox chbtrojes;
        public System.Windows.Forms.CheckBox chbmatriz;
        public System.Windows.Forms.CheckBox chbmetal;
        public System.Windows.Forms.CheckBox chbhigiene;
        public System.Windows.Forms.CheckBox chbmicro;
        public System.Windows.Forms.CheckBox chbcrea;
        public System.Windows.Forms.CheckBox chbvejiga;
        public System.Windows.Forms.CheckBox chbayuno;
        public System.Windows.Forms.TextBox txtcosto;
        public System.Windows.Forms.TextBox txtestudio;
        public System.Windows.Forms.Label lbl2;
        public System.Windows.Forms.Label lbl1;
    }
}