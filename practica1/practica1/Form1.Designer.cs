namespace practica1
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemA1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemA2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemA3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemB1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemB2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemB3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(28, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(522, 305);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Compilar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 48);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(116, 26);
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.archivoToolStripMenuItem1.Text = "Archivo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem2,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem2
            // 
            this.archivoToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemA1,
            this.MenuItemA2,
            this.MenuItemA3});
            this.archivoToolStripMenuItem2.Name = "archivoToolStripMenuItem2";
            this.archivoToolStripMenuItem2.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem2.Text = "Archivo";
            // 
            // MenuItemA1
            // 
            this.MenuItemA1.Name = "MenuItemA1";
            this.MenuItemA1.Size = new System.Drawing.Size(152, 22);
            this.MenuItemA1.Text = "Abrir";
            // 
            // MenuItemA2
            // 
            this.MenuItemA2.Name = "MenuItemA2";
            this.MenuItemA2.Size = new System.Drawing.Size(152, 22);
            this.MenuItemA2.Text = "Guardar";
            // 
            // MenuItemA3
            // 
            this.MenuItemA3.Name = "MenuItemA3";
            this.MenuItemA3.Size = new System.Drawing.Size(152, 22);
            this.MenuItemA3.Text = "Salir";
            this.MenuItemA3.Click += new System.EventHandler(this.MenuItemA3_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemB1,
            this.MenuItemB2,
            this.MenuItemB3});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // MenuItemB1
            // 
            this.MenuItemB1.Name = "MenuItemB1";
            this.MenuItemB1.Size = new System.Drawing.Size(172, 22);
            this.MenuItemB1.Text = "Manual técnico";
            // 
            // MenuItemB2
            // 
            this.MenuItemB2.Name = "MenuItemB2";
            this.MenuItemB2.Size = new System.Drawing.Size(172, 22);
            this.MenuItemB2.Text = "Manual de usuario";
            // 
            // MenuItemB3
            // 
            this.MenuItemB3.Name = "MenuItemB3";
            this.MenuItemB3.Size = new System.Drawing.Size(172, 22);
            this.MenuItemB3.Text = "Acerca de";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 380);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemA1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemA2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemA3;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemB1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemB2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemB3;
    }
}

