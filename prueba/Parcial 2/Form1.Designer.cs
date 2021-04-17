
namespace Parcial_2
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
            this.listBoxResultado = new System.Windows.Forms.ListBox();
            this.textBoxArchivo = new System.Windows.Forms.TextBox();
            this.buttonPromedioporParcial = new System.Windows.Forms.Button();
            this.buttonPromedioporSeccion = new System.Windows.Forms.Button();
            this.buttonPromedioGeneralSeccion = new System.Windows.Forms.Button();
            this.buttonClasificarAlumnos = new System.Windows.Forms.Button();
            this.buttonNotaMayor = new System.Windows.Forms.Button();
            this.buttonNotaButtMayorGeuttneral = new System.Windows.Forms.Button();
            this.buttonCargarArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxResultado
            // 
            this.listBoxResultado.BackColor = System.Drawing.Color.Purple;
            this.listBoxResultado.ForeColor = System.Drawing.SystemColors.Window;
            this.listBoxResultado.FormattingEnabled = true;
            this.listBoxResultado.ItemHeight = 20;
            this.listBoxResultado.Location = new System.Drawing.Point(501, 80);
            this.listBoxResultado.Name = "listBoxResultado";
            this.listBoxResultado.Size = new System.Drawing.Size(289, 404);
            this.listBoxResultado.TabIndex = 0;
            // 
            // textBoxArchivo
            // 
            this.textBoxArchivo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxArchivo.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxArchivo.Location = new System.Drawing.Point(24, 80);
            this.textBoxArchivo.Multiline = true;
            this.textBoxArchivo.Name = "textBoxArchivo";
            this.textBoxArchivo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxArchivo.Size = new System.Drawing.Size(333, 404);
            this.textBoxArchivo.TabIndex = 1;
            this.textBoxArchivo.TextChanged += new System.EventHandler(this.textBoxArchivo_TextChanged);
            // 
            // buttonPromedioporParcial
            // 
            this.buttonPromedioporParcial.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonPromedioporParcial.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromedioporParcial.Location = new System.Drawing.Point(363, 80);
            this.buttonPromedioporParcial.Name = "buttonPromedioporParcial";
            this.buttonPromedioporParcial.Size = new System.Drawing.Size(132, 74);
            this.buttonPromedioporParcial.TabIndex = 2;
            this.buttonPromedioporParcial.Text = "PROMEDIO POR PARCIAL";
            this.buttonPromedioporParcial.UseVisualStyleBackColor = false;
            this.buttonPromedioporParcial.Click += new System.EventHandler(this.buttonPromedioporParcial_Click);
            // 
            // buttonPromedioporSeccion
            // 
            this.buttonPromedioporSeccion.BackColor = System.Drawing.Color.Gold;
            this.buttonPromedioporSeccion.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromedioporSeccion.Location = new System.Drawing.Point(363, 160);
            this.buttonPromedioporSeccion.Name = "buttonPromedioporSeccion";
            this.buttonPromedioporSeccion.Size = new System.Drawing.Size(132, 74);
            this.buttonPromedioporSeccion.TabIndex = 3;
            this.buttonPromedioporSeccion.Text = "PROMEDIO POR SECCIÓN";
            this.buttonPromedioporSeccion.UseVisualStyleBackColor = false;
            this.buttonPromedioporSeccion.Click += new System.EventHandler(this.buttonPromedioporSeccion_Click);
            // 
            // buttonPromedioGeneralSeccion
            // 
            this.buttonPromedioGeneralSeccion.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPromedioGeneralSeccion.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPromedioGeneralSeccion.Location = new System.Drawing.Point(363, 240);
            this.buttonPromedioGeneralSeccion.Name = "buttonPromedioGeneralSeccion";
            this.buttonPromedioGeneralSeccion.Size = new System.Drawing.Size(132, 74);
            this.buttonPromedioGeneralSeccion.TabIndex = 4;
            this.buttonPromedioGeneralSeccion.Text = "PROMEDIO GENERAL";
            this.buttonPromedioGeneralSeccion.UseVisualStyleBackColor = false;
            this.buttonPromedioGeneralSeccion.Click += new System.EventHandler(this.buttonPromedioGeneralSeccion_Click);
            // 
            // buttonClasificarAlumnos
            // 
            this.buttonClasificarAlumnos.BackColor = System.Drawing.Color.DimGray;
            this.buttonClasificarAlumnos.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClasificarAlumnos.Location = new System.Drawing.Point(363, 320);
            this.buttonClasificarAlumnos.Name = "buttonClasificarAlumnos";
            this.buttonClasificarAlumnos.Size = new System.Drawing.Size(132, 87);
            this.buttonClasificarAlumnos.TabIndex = 5;
            this.buttonClasificarAlumnos.Text = "CLASIFICAR LISTA DE ALUMNOS";
            this.buttonClasificarAlumnos.UseVisualStyleBackColor = false;
            this.buttonClasificarAlumnos.Click += new System.EventHandler(this.buttonClasificarAlumnos_Click);
            // 
            // buttonNotaMayor
            // 
            this.buttonNotaMayor.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonNotaMayor.Location = new System.Drawing.Point(644, 490);
            this.buttonNotaMayor.Name = "buttonNotaMayor";
            this.buttonNotaMayor.Size = new System.Drawing.Size(146, 53);
            this.buttonNotaMayor.TabIndex = 6;
            this.buttonNotaMayor.Text = "NOTA MAYOR INDIVIDUAL";
            this.buttonNotaMayor.UseVisualStyleBackColor = false;
            this.buttonNotaMayor.Click += new System.EventHandler(this.buttonNotaMayor_Click);
            // 
            // buttonNotaButtMayorGeuttneral
            // 
            this.buttonNotaButtMayorGeuttneral.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonNotaButtMayorGeuttneral.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotaButtMayorGeuttneral.Location = new System.Drawing.Point(363, 408);
            this.buttonNotaButtMayorGeuttneral.Name = "buttonNotaButtMayorGeuttneral";
            this.buttonNotaButtMayorGeuttneral.Size = new System.Drawing.Size(132, 76);
            this.buttonNotaButtMayorGeuttneral.TabIndex = 7;
            this.buttonNotaButtMayorGeuttneral.Text = "NOTA MAYOR EN GENERAL";
            this.buttonNotaButtMayorGeuttneral.UseVisualStyleBackColor = false;
            this.buttonNotaButtMayorGeuttneral.Click += new System.EventHandler(this.buttonNotaMayorGeneral_Click);
            // 
            // buttonCargarArchivo
            // 
            this.buttonCargarArchivo.BackColor = System.Drawing.Color.Yellow;
            this.buttonCargarArchivo.Font = new System.Drawing.Font("Playbill", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCargarArchivo.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonCargarArchivo.Location = new System.Drawing.Point(132, 25);
            this.buttonCargarArchivo.Name = "buttonCargarArchivo";
            this.buttonCargarArchivo.Size = new System.Drawing.Size(146, 49);
            this.buttonCargarArchivo.TabIndex = 8;
            this.buttonCargarArchivo.Text = "Cargar Archivo";
            this.buttonCargarArchivo.UseVisualStyleBackColor = false;
            this.buttonCargarArchivo.Click += new System.EventHandler(this.buttonCargarArchivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(842, 605);
            this.Controls.Add(this.buttonCargarArchivo);
            this.Controls.Add(this.buttonNotaButtMayorGeuttneral);
            this.Controls.Add(this.buttonNotaMayor);
            this.Controls.Add(this.buttonClasificarAlumnos);
            this.Controls.Add(this.buttonPromedioGeneralSeccion);
            this.Controls.Add(this.buttonPromedioporSeccion);
            this.Controls.Add(this.buttonPromedioporParcial);
            this.Controls.Add(this.textBoxArchivo);
            this.Controls.Add(this.listBoxResultado);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxResultado;
        private System.Windows.Forms.TextBox textBoxArchivo;
        private System.Windows.Forms.Button buttonPromedioporParcial;
        private System.Windows.Forms.Button buttonPromedioporSeccion;
        private System.Windows.Forms.Button buttonPromedioGeneralSeccion;
        private System.Windows.Forms.Button buttonClasificarAlumnos;
        private System.Windows.Forms.Button buttonNotaMayor;
        private System.Windows.Forms.Button buttonNotaButtMayorGeuttneral;
        private System.Windows.Forms.Button buttonCargarArchivo;
    }
}

