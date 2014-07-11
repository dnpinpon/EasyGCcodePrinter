namespace EasyGCodePrinter.Ui
{
    partial class actions
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.print_button = new System.Windows.Forms.Button();
            this.viewprintbutton = new System.Windows.Forms.Button();
            this.Cancen_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // print_button
            // 
            this.print_button.Location = new System.Drawing.Point(38, 18);
            this.print_button.Name = "print_button";
            this.print_button.Size = new System.Drawing.Size(75, 23);
            this.print_button.TabIndex = 0;
            this.print_button.Text = "Print";
            this.print_button.UseVisualStyleBackColor = true;
            // 
            // viewprintbutton
            // 
            this.viewprintbutton.Location = new System.Drawing.Point(141, 18);
            this.viewprintbutton.Name = "viewprintbutton";
            this.viewprintbutton.Size = new System.Drawing.Size(116, 23);
            this.viewprintbutton.TabIndex = 1;
            this.viewprintbutton.Text = "View Code and Print";
            this.viewprintbutton.UseVisualStyleBackColor = true;
            // 
            // Cancen_button
            // 
            this.Cancen_button.Location = new System.Drawing.Point(281, 18);
            this.Cancen_button.Name = "Cancen_button";
            this.Cancen_button.Size = new System.Drawing.Size(75, 23);
            this.Cancen_button.TabIndex = 2;
            this.Cancen_button.Text = "Cancel";
            this.Cancen_button.UseVisualStyleBackColor = true;
            // 
            // actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Cancen_button);
            this.Controls.Add(this.viewprintbutton);
            this.Controls.Add(this.print_button);
            this.Name = "actions";
            this.Size = new System.Drawing.Size(485, 56);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button print_button;
        private System.Windows.Forms.Button viewprintbutton;
        private System.Windows.Forms.Button Cancen_button;
    }
}
