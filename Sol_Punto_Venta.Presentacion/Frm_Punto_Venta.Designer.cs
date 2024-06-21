namespace Sol_Punto_Venta.Presentacion
{
    partial class Frm_Punto_Venta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Punto_Venta));
            this.Tbc_principal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Lbl_total_registros = new System.Windows.Forms.Label();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Txt_Buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_Listado = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Btn_Retornar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Actualizar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Pnl_titulo_form = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Tbc_principal.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.Pnl_titulo_form.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tbc_principal
            // 
            this.Tbc_principal.Controls.Add(this.tabPage1);
            this.Tbc_principal.Controls.Add(this.tabPage2);
            this.Tbc_principal.ItemSize = new System.Drawing.Size(100, 30);
            this.Tbc_principal.Location = new System.Drawing.Point(9, 53);
            this.Tbc_principal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Tbc_principal.Name = "Tbc_principal";
            this.Tbc_principal.SelectedIndex = 0;
            this.Tbc_principal.Size = new System.Drawing.Size(542, 402);
            this.Tbc_principal.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Lbl_total_registros);
            this.tabPage1.Controls.Add(this.Btn_Buscar);
            this.tabPage1.Controls.Add(this.Txt_Buscar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.Dgv_Listado);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(534, 364);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Lbl_total_registros
            // 
            this.Lbl_total_registros.AutoSize = true;
            this.Lbl_total_registros.Location = new System.Drawing.Point(427, 333);
            this.Lbl_total_registros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_total_registros.Name = "Lbl_total_registros";
            this.Lbl_total_registros.Size = new System.Drawing.Size(97, 15);
            this.Lbl_total_registros.TabIndex = 4;
            this.Lbl_total_registros.Text = "Total registros: 0";
            this.Lbl_total_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.Btn_Buscar.Location = new System.Drawing.Point(308, 30);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(94, 28);
            this.Btn_Buscar.TabIndex = 3;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // Txt_Buscar
            // 
            this.Txt_Buscar.Location = new System.Drawing.Point(76, 37);
            this.Txt_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Buscar.Name = "Txt_Buscar";
            this.Txt_Buscar.Size = new System.Drawing.Size(184, 20);
            this.Txt_Buscar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // Dgv_Listado
            // 
            this.Dgv_Listado.AllowUserToAddRows = false;
            this.Dgv_Listado.AllowUserToDeleteRows = false;
            this.Dgv_Listado.AllowUserToOrderColumns = true;
            this.Dgv_Listado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(145)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Listado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Listado.ColumnHeadersHeight = 30;
            this.Dgv_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Dgv_Listado.EnableHeadersVisualStyles = false;
            this.Dgv_Listado.Location = new System.Drawing.Point(22, 76);
            this.Dgv_Listado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_Listado.Name = "Dgv_Listado";
            this.Dgv_Listado.ReadOnly = true;
            this.Dgv_Listado.RowHeadersWidth = 51;
            this.Dgv_Listado.RowTemplate.Height = 24;
            this.Dgv_Listado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgv_Listado.Size = new System.Drawing.Size(490, 247);
            this.Dgv_Listado.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Btn_Retornar);
            this.tabPage2.Controls.Add(this.Btn_Guardar);
            this.tabPage2.Controls.Add(this.Btn_Cancelar);
            this.tabPage2.Controls.Add(this.Txt_descripcion);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(534, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Btn_Retornar
            // 
            this.Btn_Retornar.BackColor = System.Drawing.Color.DarkCyan;
            this.Btn_Retornar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Retornar.ForeColor = System.Drawing.Color.White;
            this.Btn_Retornar.Location = new System.Drawing.Point(312, 80);
            this.Btn_Retornar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Retornar.Name = "Btn_Retornar";
            this.Btn_Retornar.Size = new System.Drawing.Size(94, 28);
            this.Btn_Retornar.TabIndex = 6;
            this.Btn_Retornar.Text = "Retornar";
            this.Btn_Retornar.UseVisualStyleBackColor = false;
            this.Btn_Retornar.Visible = false;
            this.Btn_Retornar.Click += new System.EventHandler(this.Btn_Retornar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.Location = new System.Drawing.Point(210, 79);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(94, 28);
            this.Btn_Guardar.TabIndex = 5;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Visible = false;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.IndianRed;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancelar.Location = new System.Drawing.Point(105, 79);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(94, 28);
            this.Btn_Cancelar.TabIndex = 4;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Visible = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.Location = new System.Drawing.Point(105, 46);
            this.Txt_descripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.ReadOnly = true;
            this.Txt_descripcion.Size = new System.Drawing.Size(302, 20);
            this.Txt_descripcion.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Punto de Venta (*):";
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.Btn_Nuevo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.ImageKey = "nuevo.png";
            this.Btn_Nuevo.ImageList = this.imageList1;
            this.Btn_Nuevo.Location = new System.Drawing.Point(12, 466);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(70, 61);
            this.Btn_Nuevo.TabIndex = 1;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "nuevo.png");
            this.imageList1.Images.SetKeyName(1, "actualizar.png");
            this.imageList1.Images.SetKeyName(2, "eliminar.png");
            this.imageList1.Images.SetKeyName(3, "reporte.png");
            this.imageList1.Images.SetKeyName(4, "salir.png");
            // 
            // Btn_Actualizar
            // 
            this.Btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.Btn_Actualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.Btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Actualizar.ImageKey = "actualizar.png";
            this.Btn_Actualizar.ImageList = this.imageList1;
            this.Btn_Actualizar.Location = new System.Drawing.Point(130, 466);
            this.Btn_Actualizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Actualizar.Name = "Btn_Actualizar";
            this.Btn_Actualizar.Size = new System.Drawing.Size(70, 61);
            this.Btn_Actualizar.TabIndex = 2;
            this.Btn_Actualizar.Text = "Actualizar";
            this.Btn_Actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Actualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Actualizar.UseVisualStyleBackColor = false;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.Btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.ImageKey = "eliminar.png";
            this.Btn_Eliminar.ImageList = this.imageList1;
            this.Btn_Eliminar.Location = new System.Drawing.Point(245, 466);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(70, 61);
            this.Btn_Eliminar.TabIndex = 3;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.Btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reporte.ImageKey = "reporte.png";
            this.Btn_Reporte.ImageList = this.imageList1;
            this.Btn_Reporte.Location = new System.Drawing.Point(361, 466);
            this.Btn_Reporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(70, 61);
            this.Btn_Reporte.TabIndex = 4;
            this.Btn_Reporte.Text = "Reporte";
            this.Btn_Reporte.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.Btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(198)))), ((int)(((byte)(198)))));
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.ImageKey = "salir.png";
            this.Btn_Salir.ImageList = this.imageList1;
            this.Btn_Salir.Location = new System.Drawing.Point(477, 466);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(70, 61);
            this.Btn_Salir.TabIndex = 5;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            // 
            // Pnl_titulo_form
            // 
            this.Pnl_titulo_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(145)))), ((int)(((byte)(194)))));
            this.Pnl_titulo_form.Controls.Add(this.label3);
            this.Pnl_titulo_form.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_titulo_form.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Pnl_titulo_form.Location = new System.Drawing.Point(0, 0);
            this.Pnl_titulo_form.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Pnl_titulo_form.Name = "Pnl_titulo_form";
            this.Pnl_titulo_form.Size = new System.Drawing.Size(739, 48);
            this.Pnl_titulo_form.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Punto de Venta";
            // 
            // Frm_Punto_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 554);
            this.Controls.Add(this.Pnl_titulo_form);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Reporte);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Actualizar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Tbc_principal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_Punto_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Punto_Venta";
            this.Load += new System.EventHandler(this.Frm_Punto_Venta_Load);
            this.Tbc_principal.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Listado)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Pnl_titulo_form.ResumeLayout(false);
            this.Pnl_titulo_form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tbc_principal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_Listado;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.TextBox Txt_Buscar;
        private System.Windows.Forms.Button Btn_Retornar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Actualizar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Pnl_titulo_form;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_total_registros;
    }
}