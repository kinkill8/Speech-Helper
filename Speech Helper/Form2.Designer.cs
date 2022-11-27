namespace Speech_Helper
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btniniciar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnvolver = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btndetener = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(547, 287);
            this.textBox1.TabIndex = 0;
            // 
            // btniniciar
            // 
            this.btniniciar.Depth = 0;
            this.btniniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btniniciar.Location = new System.Drawing.Point(94, 410);
            this.btniniciar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Primary = true;
            this.btniniciar.Size = new System.Drawing.Size(122, 47);
            this.btniniciar.TabIndex = 1;
            this.btniniciar.Text = "INICIAR";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.btniniciar_Click);
            // 
            // btnvolver
            // 
            this.btnvolver.Depth = 0;
            this.btnvolver.Location = new System.Drawing.Point(271, 410);
            this.btnvolver.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnvolver.Name = "btnvolver";
            this.btnvolver.Primary = true;
            this.btnvolver.Size = new System.Drawing.Size(122, 47);
            this.btnvolver.TabIndex = 2;
            this.btnvolver.Text = "VOLVER A LEER VOZ";
            this.btnvolver.UseVisualStyleBackColor = true;
            this.btnvolver.Click += new System.EventHandler(this.btnvolver_Click);
            // 
            // btndetener
            // 
            this.btndetener.Depth = 0;
            this.btndetener.Location = new System.Drawing.Point(444, 410);
            this.btndetener.MouseState = MaterialSkin.MouseState.HOVER;
            this.btndetener.Name = "btndetener";
            this.btndetener.Primary = true;
            this.btndetener.Size = new System.Drawing.Size(122, 47);
            this.btndetener.TabIndex = 3;
            this.btndetener.Text = "DETENER";
            this.btndetener.UseVisualStyleBackColor = true;
            this.btndetener.Click += new System.EventHandler(this.btndetener_Click);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(675, 551);
            this.Controls.Add(this.btndetener);
            this.Controls.Add(this.btnvolver);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btniniciar;
        private MaterialSkin.Controls.MaterialRaisedButton btnvolver;
        private MaterialSkin.Controls.MaterialRaisedButton btndetener;
    }
}