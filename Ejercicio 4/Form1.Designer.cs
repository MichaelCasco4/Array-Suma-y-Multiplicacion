namespace Ejercicio_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtVentas = new System.Windows.Forms.TextBox();
            this.lstReporte = new System.Windows.Forms.ListBox();
            this.lblVentas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMostrarReporte = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVentas
            // 
            this.txtVentas.Location = new System.Drawing.Point(115, 30);
            this.txtVentas.Name = "txtVentas";
            this.txtVentas.Size = new System.Drawing.Size(297, 29);
            this.txtVentas.TabIndex = 4;
            // 
            // lstReporte
            // 
            this.lstReporte.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lstReporte.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReporte.ForeColor = System.Drawing.SystemColors.Window;
            this.lstReporte.FormattingEnabled = true;
            this.lstReporte.ItemHeight = 15;
            this.lstReporte.Location = new System.Drawing.Point(12, 84);
            this.lstReporte.Name = "lstReporte";
            this.lstReporte.Size = new System.Drawing.Size(240, 289);
            this.lstReporte.TabIndex = 0;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.Location = new System.Drawing.Point(12, 30);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(97, 15);
            this.lblVentas.TabIndex = 3;
            this.lblVentas.Text = "Sales per seller:";
            this.lblVentas.Click += new System.EventHandler(this.lblVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(298, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Sale";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Show me reporting";
            // 
            // btnMostrarReporte
            // 
            this.btnMostrarReporte.Image = global::Ejercicio_4.Properties.Resources.expediente;
            this.btnMostrarReporte.Location = new System.Drawing.Point(417, 84);
            this.btnMostrarReporte.Name = "btnMostrarReporte";
            this.btnMostrarReporte.Size = new System.Drawing.Size(53, 59);
            this.btnMostrarReporte.TabIndex = 1;
            this.btnMostrarReporte.UseVisualStyleBackColor = true;
            this.btnMostrarReporte.Click += new System.EventHandler(this.btnMostrarReporte_Click);
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Image = global::Ejercicio_4.Properties.Resources.agregar;
            this.btnAgregarVenta.Location = new System.Drawing.Point(417, 207);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(53, 52);
            this.btnAgregarVenta.TabIndex = 2;
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(525, 416);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstReporte);
            this.Controls.Add(this.btnMostrarReporte);
            this.Controls.Add(this.btnAgregarVenta);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.txtVentas);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Salarios Vendedores";
            this.Load += new System.EventHandler(this.btnAgregarVenta_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtVentas;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button btnMostrarReporte;
        private System.Windows.Forms.ListBox lstReporte;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}