namespace DTproyectop1
{
    partial class frmsi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmsi));
            this.gprdatos = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcosto = new System.Windows.Forms.TextBox();
            this.txtestudio = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.gprprep = new System.Windows.Forms.GroupBox();
            this.chbmetal = new System.Windows.Forms.CheckBox();
            this.chbhigiene = new System.Windows.Forms.CheckBox();
            this.chbmicro = new System.Windows.Forms.CheckBox();
            this.chbcrea = new System.Windows.Forms.CheckBox();
            this.chbvejiga = new System.Windows.Forms.CheckBox();
            this.chbayuno = new System.Windows.Forms.CheckBox();
            this.grpsucursales = new System.Windows.Forms.GroupBox();
            this.chbgalerias = new System.Windows.Forms.CheckBox();
            this.chbnorte = new System.Windows.Forms.CheckBox();
            this.chbtrojes = new System.Windows.Forms.CheckBox();
            this.chbmatriz = new System.Windows.Forms.CheckBox();
            this.grpcita = new System.Windows.Forms.GroupBox();
            this.rbno = new System.Windows.Forms.RadioButton();
            this.rbsi = new System.Windows.Forms.RadioButton();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.lblsalida = new System.Windows.Forms.Label();
            this.lnklbl = new System.Windows.Forms.LinkLabel();
            this.gprdatos.SuspendLayout();
            this.gprprep.SuspendLayout();
            this.grpsucursales.SuspendLayout();
            this.grpcita.SuspendLayout();
            this.SuspendLayout();
            // 
            // gprdatos
            // 
            this.gprdatos.Controls.Add(this.txtid);
            this.gprdatos.Controls.Add(this.lblid);
            this.gprdatos.Controls.Add(this.button1);
            this.gprdatos.Controls.Add(this.txtcosto);
            this.gprdatos.Controls.Add(this.txtestudio);
            this.gprdatos.Controls.Add(this.lbl2);
            this.gprdatos.Controls.Add(this.lbl1);
            this.gprdatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(89)))));
            this.gprdatos.Location = new System.Drawing.Point(75, 24);
            this.gprdatos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gprdatos.Name = "gprdatos";
            this.gprdatos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gprdatos.Size = new System.Drawing.Size(726, 188);
            this.gprdatos.TabIndex = 0;
            this.gprdatos.TabStop = false;
            this.gprdatos.Text = "Estudio";
            // 
            // txtid
            // 
            this.txtid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtid.Location = new System.Drawing.Point(222, 24);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(148, 31);
            this.txtid.TabIndex = 10;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(89)))));
            this.lblid.Location = new System.Drawing.Point(179, 24);
            this.lblid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(32, 25);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "ID";
            this.lblid.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.Location = new System.Drawing.Point(399, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcosto
            // 
            this.txtcosto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtcosto.Location = new System.Drawing.Point(222, 114);
            this.txtcosto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcosto.Name = "txtcosto";
            this.txtcosto.Size = new System.Drawing.Size(148, 31);
            this.txtcosto.TabIndex = 3;
            // 
            // txtestudio
            // 
            this.txtestudio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtestudio.Location = new System.Drawing.Point(222, 66);
            this.txtestudio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtestudio.Name = "txtestudio";
            this.txtestudio.Size = new System.Drawing.Size(415, 31);
            this.txtestudio.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(89)))));
            this.lbl2.Location = new System.Drawing.Point(147, 117);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(64, 25);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Costo";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(89)))));
            this.lbl1.Location = new System.Drawing.Point(60, 66);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(151, 25);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Tipo de Estudio";
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
            this.gprprep.Location = new System.Drawing.Point(118, 232);
            this.gprprep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gprprep.Name = "gprprep";
            this.gprprep.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gprprep.Size = new System.Drawing.Size(475, 189);
            this.gprprep.TabIndex = 1;
            this.gprprep.TabStop = false;
            this.gprprep.Text = "Preparaciones";
            // 
            // chbmetal
            // 
            this.chbmetal.AutoSize = true;
            this.chbmetal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbmetal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.chbmetal.Location = new System.Drawing.Point(207, 121);
            this.chbmetal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbmetal.Name = "chbmetal";
            this.chbmetal.Size = new System.Drawing.Size(117, 29);
            this.chbmetal.TabIndex = 5;
            this.chbmetal.Text = "Sin metal";
            this.chbmetal.UseVisualStyleBackColor = true;
            // 
            // chbhigiene
            // 
            this.chbhigiene.AutoSize = true;
            this.chbhigiene.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbhigiene.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.chbhigiene.Location = new System.Drawing.Point(208, 80);
            this.chbhigiene.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbhigiene.Name = "chbhigiene";
            this.chbhigiene.Size = new System.Drawing.Size(186, 29);
            this.chbhigiene.TabIndex = 4;
            this.chbhigiene.Text = "Higiene personal";
            this.chbhigiene.UseVisualStyleBackColor = true;
            // 
            // chbmicro
            // 
            this.chbmicro.AutoSize = true;
            this.chbmicro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbmicro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.chbmicro.Location = new System.Drawing.Point(208, 38);
            this.chbmicro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbmicro.Name = "chbmicro";
            this.chbmicro.Size = new System.Drawing.Size(113, 29);
            this.chbmicro.TabIndex = 3;
            this.chbmicro.Text = "Microlax";
            this.chbmicro.UseVisualStyleBackColor = true;
            // 
            // chbcrea
            // 
            this.chbcrea.AutoSize = true;
            this.chbcrea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbcrea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.chbcrea.Location = new System.Drawing.Point(44, 121);
            this.chbcrea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbcrea.Name = "chbcrea";
            this.chbcrea.Size = new System.Drawing.Size(125, 29);
            this.chbcrea.TabIndex = 2;
            this.chbcrea.Text = "Creatinina";
            this.chbcrea.UseVisualStyleBackColor = true;
            // 
            // chbvejiga
            // 
            this.chbvejiga.AutoSize = true;
            this.chbvejiga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbvejiga.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.chbvejiga.Location = new System.Drawing.Point(45, 80);
            this.chbvejiga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbvejiga.Name = "chbvejiga";
            this.chbvejiga.Size = new System.Drawing.Size(146, 29);
            this.chbvejiga.TabIndex = 1;
            this.chbvejiga.Text = "Vejiga Llena ";
            this.chbvejiga.UseVisualStyleBackColor = true;
            // 
            // chbayuno
            // 
            this.chbayuno.AutoSize = true;
            this.chbayuno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbayuno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.chbayuno.Location = new System.Drawing.Point(45, 38);
            this.chbayuno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbayuno.Name = "chbayuno";
            this.chbayuno.Size = new System.Drawing.Size(94, 29);
            this.chbayuno.TabIndex = 0;
            this.chbayuno.Text = "Ayuno";
            this.chbayuno.UseVisualStyleBackColor = true;
            // 
            // grpsucursales
            // 
            this.grpsucursales.Controls.Add(this.chbgalerias);
            this.grpsucursales.Controls.Add(this.chbnorte);
            this.grpsucursales.Controls.Add(this.chbtrojes);
            this.grpsucursales.Controls.Add(this.chbmatriz);
            this.grpsucursales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(89)))));
            this.grpsucursales.Location = new System.Drawing.Point(683, 232);
            this.grpsucursales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpsucursales.Name = "grpsucursales";
            this.grpsucursales.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpsucursales.Size = new System.Drawing.Size(290, 136);
            this.grpsucursales.TabIndex = 2;
            this.grpsucursales.TabStop = false;
            this.grpsucursales.Text = "Sucursales";
            // 
            // chbgalerias
            // 
            this.chbgalerias.AutoSize = true;
            this.chbgalerias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbgalerias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(89)))));
            this.chbgalerias.Location = new System.Drawing.Point(142, 39);
            this.chbgalerias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbgalerias.Name = "chbgalerias";
            this.chbgalerias.Size = new System.Drawing.Size(105, 29);
            this.chbgalerias.TabIndex = 2;
            this.chbgalerias.Text = "Galerias";
            this.chbgalerias.UseVisualStyleBackColor = true;
            this.chbgalerias.CheckedChanged += new System.EventHandler(this.chbgalerias_CheckedChanged);
            // 
            // chbnorte
            // 
            this.chbnorte.AutoSize = true;
            this.chbnorte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbnorte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(89)))));
            this.chbnorte.Location = new System.Drawing.Point(16, 81);
            this.chbnorte.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbnorte.Name = "chbnorte";
            this.chbnorte.Size = new System.Drawing.Size(86, 29);
            this.chbnorte.TabIndex = 1;
            this.chbnorte.Text = "Norte";
            this.chbnorte.UseVisualStyleBackColor = true;
            this.chbnorte.CheckedChanged += new System.EventHandler(this.chbnorte_CheckedChanged);
            // 
            // chbtrojes
            // 
            this.chbtrojes.AutoSize = true;
            this.chbtrojes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbtrojes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(89)))));
            this.chbtrojes.Location = new System.Drawing.Point(142, 80);
            this.chbtrojes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbtrojes.Name = "chbtrojes";
            this.chbtrojes.Size = new System.Drawing.Size(89, 29);
            this.chbtrojes.TabIndex = 3;
            this.chbtrojes.Text = "Trojes";
            this.chbtrojes.UseVisualStyleBackColor = true;
            this.chbtrojes.CheckedChanged += new System.EventHandler(this.chbtrojes_CheckedChanged);
            // 
            // chbmatriz
            // 
            this.chbmatriz.AutoSize = true;
            this.chbmatriz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbmatriz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(89)))));
            this.chbmatriz.Location = new System.Drawing.Point(16, 40);
            this.chbmatriz.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chbmatriz.Name = "chbmatriz";
            this.chbmatriz.Size = new System.Drawing.Size(92, 29);
            this.chbmatriz.TabIndex = 0;
            this.chbmatriz.Text = "Matriz";
            this.chbmatriz.UseVisualStyleBackColor = true;
            this.chbmatriz.CheckedChanged += new System.EventHandler(this.chbmatriz_CheckedChanged);
            // 
            // grpcita
            // 
            this.grpcita.Controls.Add(this.rbno);
            this.grpcita.Controls.Add(this.rbsi);
            this.grpcita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(140)))), ((int)(((byte)(83)))));
            this.grpcita.Location = new System.Drawing.Point(817, 53);
            this.grpcita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpcita.Name = "grpcita";
            this.grpcita.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpcita.Size = new System.Drawing.Size(156, 144);
            this.grpcita.TabIndex = 4;
            this.grpcita.TabStop = false;
            this.grpcita.Text = "Requiere cita";
            // 
            // rbno
            // 
            this.rbno.AutoSize = true;
            this.rbno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(140)))), ((int)(((byte)(83)))));
            this.rbno.Location = new System.Drawing.Point(33, 95);
            this.rbno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.rbsi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbsi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(140)))), ((int)(((byte)(83)))));
            this.rbsi.Location = new System.Drawing.Point(33, 34);
            this.rbsi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbsi.Name = "rbsi";
            this.rbsi.Size = new System.Drawing.Size(50, 29);
            this.rbsi.TabIndex = 0;
            this.rbsi.TabStop = true;
            this.rbsi.Text = "SI";
            this.rbsi.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(64)))));
            this.btnagregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnagregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnagregar.Location = new System.Drawing.Point(107, 418);
            this.btnagregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(184, 50);
            this.btnagregar.TabIndex = 5;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(82)))));
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btneliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btneliminar.Location = new System.Drawing.Point(360, 418);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(184, 50);
            this.btneliminar.TabIndex = 6;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(64)))));
            this.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnmodificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnmodificar.Location = new System.Drawing.Point(619, 418);
            this.btnmodificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(184, 50);
            this.btnmodificar.TabIndex = 7;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnconsultar
            // 
            this.btnconsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(140)))), ((int)(((byte)(82)))));
            this.btnconsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnconsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnconsultar.Location = new System.Drawing.Point(861, 418);
            this.btnconsultar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(184, 50);
            this.btnconsultar.TabIndex = 8;
            this.btnconsultar.Text = "Consultar";
            this.btnconsultar.UseVisualStyleBackColor = false;
            this.btnconsultar.Click += new System.EventHandler(this.btnconsultar_Click);
            // 
            // lblsalida
            // 
            this.lblsalida.AutoSize = true;
            this.lblsalida.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.lblsalida.Location = new System.Drawing.Point(469, 495);
            this.lblsalida.Name = "lblsalida";
            this.lblsalida.Size = new System.Drawing.Size(153, 25);
            this.lblsalida.TabIndex = 9;
            this.lblsalida.Text = "¿Ya terminaste?";
            // 
            // lnklbl
            // 
            this.lnklbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.lnklbl.AutoSize = true;
            this.lnklbl.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(17)))), ((int)(((byte)(64)))));
            this.lnklbl.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(89)))));
            this.lnklbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(89)))));
            this.lnklbl.Location = new System.Drawing.Point(646, 495);
            this.lnklbl.Name = "lnklbl";
            this.lnklbl.Size = new System.Drawing.Size(66, 25);
            this.lnklbl.TabIndex = 10;
            this.lnklbl.TabStop = true;
            this.lnklbl.Text = "SALIR";
            this.lnklbl.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(115)))), ((int)(((byte)(71)))));
            this.lnklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_LinkClicked);
            // 
            // frmsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1128, 564);
            this.Controls.Add(this.lnklbl);
            this.Controls.Add(this.lblsalida);
            this.Controls.Add(this.btnconsultar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.grpcita);
            this.Controls.Add(this.grpsucursales);
            this.Controls.Add(this.gprprep);
            this.Controls.Add(this.gprdatos);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmsi";
            this.Text = "Listado de Estudios";
            this.gprdatos.ResumeLayout(false);
            this.gprdatos.PerformLayout();
            this.gprprep.ResumeLayout(false);
            this.gprprep.PerformLayout();
            this.grpsucursales.ResumeLayout(false);
            this.grpsucursales.PerformLayout();
            this.grpcita.ResumeLayout(false);
            this.grpcita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gprdatos;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.GroupBox gprprep;
        private System.Windows.Forms.GroupBox grpsucursales;
        private System.Windows.Forms.GroupBox grpcita;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblsalida;
        private System.Windows.Forms.LinkLabel lnklbl;
        private System.Windows.Forms.Label lblid;
        public System.Windows.Forms.CheckBox chbayuno;
        public System.Windows.Forms.CheckBox chbcrea;
        public System.Windows.Forms.CheckBox chbvejiga;
        public System.Windows.Forms.CheckBox chbmatriz;
        public System.Windows.Forms.CheckBox chbgalerias;
        public System.Windows.Forms.CheckBox chbnorte;
        public System.Windows.Forms.CheckBox chbtrojes;
        public System.Windows.Forms.RadioButton rbno;
        public System.Windows.Forms.RadioButton rbsi;
        public System.Windows.Forms.TextBox txtcosto;
        public System.Windows.Forms.TextBox txtestudio;
        public System.Windows.Forms.CheckBox chbmetal;
        public System.Windows.Forms.CheckBox chbhigiene;
        public System.Windows.Forms.CheckBox chbmicro;
        public System.Windows.Forms.TextBox txtid;
    }
}

