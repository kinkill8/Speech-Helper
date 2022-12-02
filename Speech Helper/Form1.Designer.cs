namespace Speech_Helper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtleer = new System.Windows.Forms.TextBox();
            this.btnleer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btndetener = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnpausar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnguardar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnsalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btninfo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnirareconocimiento = new MaterialSkin.Controls.MaterialRaisedButton();
            this.cbseleccionvoz = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tbviolumen = new System.Windows.Forms.TrackBar();
            this.tbvelocidad = new System.Windows.Forms.TrackBar();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbviolumen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvelocidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtleer
            // 
            this.txtleer.BackColor = System.Drawing.Color.LightGray;
            this.txtleer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtleer.Location = new System.Drawing.Point(55, 77);
            this.txtleer.Multiline = true;
            this.txtleer.Name = "txtleer";
            this.txtleer.Size = new System.Drawing.Size(515, 350);
            this.txtleer.TabIndex = 1;
            // 
            // btnleer
            // 
            this.btnleer.Depth = 0;
            this.btnleer.Location = new System.Drawing.Point(642, 77);
            this.btnleer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnleer.Name = "btnleer";
            this.btnleer.Primary = true;
            this.btnleer.Size = new System.Drawing.Size(143, 51);
            this.btnleer.TabIndex = 8;
            this.btnleer.Text = "leer";
            this.btnleer.UseVisualStyleBackColor = true;
            this.btnleer.Click += new System.EventHandler(this.btnleer_Click);
            // 
            // btndetener
            // 
            this.btndetener.Depth = 0;
            this.btndetener.Location = new System.Drawing.Point(642, 144);
            this.btndetener.MouseState = MaterialSkin.MouseState.HOVER;
            this.btndetener.Name = "btndetener";
            this.btndetener.Primary = true;
            this.btndetener.Size = new System.Drawing.Size(143, 51);
            this.btndetener.TabIndex = 9;
            this.btndetener.Text = "DETENER";
            this.btndetener.UseVisualStyleBackColor = true;
            this.btndetener.Click += new System.EventHandler(this.btndetener_Click);
            // 
            // btnpausar
            // 
            this.btnpausar.Depth = 0;
            this.btnpausar.Location = new System.Drawing.Point(642, 210);
            this.btnpausar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnpausar.Name = "btnpausar";
            this.btnpausar.Primary = true;
            this.btnpausar.Size = new System.Drawing.Size(143, 51);
            this.btnpausar.TabIndex = 10;
            this.btnpausar.Text = "PAUSAR";
            this.btnpausar.UseVisualStyleBackColor = true;
            this.btnpausar.Click += new System.EventHandler(this.btnpausar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Depth = 0;
            this.btnguardar.Location = new System.Drawing.Point(642, 278);
            this.btnguardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Primary = true;
            this.btnguardar.Size = new System.Drawing.Size(143, 51);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Depth = 0;
            this.btnsalir.Location = new System.Drawing.Point(642, 346);
            this.btnsalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Primary = true;
            this.btnsalir.Size = new System.Drawing.Size(143, 51);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btninfo
            // 
            this.btninfo.Depth = 0;
            this.btninfo.Location = new System.Drawing.Point(642, 412);
            this.btninfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btninfo.Name = "btninfo";
            this.btninfo.Primary = true;
            this.btninfo.Size = new System.Drawing.Size(143, 51);
            this.btninfo.TabIndex = 13;
            this.btninfo.Text = "INFO";
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // btnirareconocimiento
            // 
            this.btnirareconocimiento.Depth = 0;
            this.btnirareconocimiento.Location = new System.Drawing.Point(642, 480);
            this.btnirareconocimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnirareconocimiento.Name = "btnirareconocimiento";
            this.btnirareconocimiento.Primary = true;
            this.btnirareconocimiento.Size = new System.Drawing.Size(143, 51);
            this.btnirareconocimiento.TabIndex = 14;
            this.btnirareconocimiento.Text = "IR A RECONOCIMIENTO DE VOZ";
            this.btnirareconocimiento.UseVisualStyleBackColor = true;
            this.btnirareconocimiento.Click += new System.EventHandler(this.btnirareconocimiento_Click);
            // 
            // cbseleccionvoz
            // 
            this.cbseleccionvoz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbseleccionvoz.FormattingEnabled = true;
            this.cbseleccionvoz.Location = new System.Drawing.Point(168, 457);
            this.cbseleccionvoz.Name = "cbseleccionvoz";
            this.cbseleccionvoz.Size = new System.Drawing.Size(268, 21);
            this.cbseleccionvoz.TabIndex = 15;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Gray;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(124, 459);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(38, 19);
            this.materialLabel1.TabIndex = 16;
            this.materialLabel1.Text = "VOZ";
            // 
            // tbviolumen
            // 
            this.tbviolumen.BackColor = System.Drawing.Color.Gray;
            this.tbviolumen.Location = new System.Drawing.Point(128, 514);
            this.tbviolumen.Maximum = 100;
            this.tbviolumen.Name = "tbviolumen";
            this.tbviolumen.Size = new System.Drawing.Size(442, 45);
            this.tbviolumen.TabIndex = 17;
            this.tbviolumen.TickFrequency = 25;
            this.tbviolumen.Value = 50;
            // 
            // tbvelocidad
            // 
            this.tbvelocidad.BackColor = System.Drawing.Color.Gray;
            this.tbvelocidad.Location = new System.Drawing.Point(128, 586);
            this.tbvelocidad.Minimum = -10;
            this.tbvelocidad.Name = "tbvelocidad";
            this.tbvelocidad.Size = new System.Drawing.Size(442, 45);
            this.tbvelocidad.TabIndex = 18;
            this.tbvelocidad.TickFrequency = 5;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Gray;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(45, 527);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(80, 19);
            this.materialLabel2.TabIndex = 19;
            this.materialLabel2.Text = "VOLUMEN";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Gray;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(35, 602);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(90, 19);
            this.materialLabel3.TabIndex = 20;
            this.materialLabel3.Text = "VELOCIDAD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(817, 662);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.tbvelocidad);
            this.Controls.Add(this.tbviolumen);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbseleccionvoz);
            this.Controls.Add(this.btnirareconocimiento);
            this.Controls.Add(this.btninfo);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.btnpausar);
            this.Controls.Add(this.btndetener);
            this.Controls.Add(this.btnleer);
            this.Controls.Add(this.txtleer);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Speech Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbviolumen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbvelocidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtleer;
        private MaterialSkin.Controls.MaterialRaisedButton btnleer;
        private MaterialSkin.Controls.MaterialRaisedButton btndetener;
        private MaterialSkin.Controls.MaterialRaisedButton btnpausar;
        private MaterialSkin.Controls.MaterialRaisedButton btnguardar;
        private MaterialSkin.Controls.MaterialRaisedButton btnsalir;
        private MaterialSkin.Controls.MaterialRaisedButton btninfo;
        private MaterialSkin.Controls.MaterialRaisedButton btnirareconocimiento;
        private System.Windows.Forms.ComboBox cbseleccionvoz;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TrackBar tbvelocidad;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.TrackBar tbviolumen;
    }
}

