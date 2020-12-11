namespace ProblemaPilas
{
	partial class F_Pilas
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
			this.TB_Formula = new System.Windows.Forms.TextBox();
			this.BTN_Analisis = new System.Windows.Forms.Button();
			this.L_Analisis = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TB_Formula
			// 
			this.TB_Formula.Location = new System.Drawing.Point(67, 29);
			this.TB_Formula.Name = "TB_Formula";
			this.TB_Formula.Size = new System.Drawing.Size(340, 20);
			this.TB_Formula.TabIndex = 0;
			// 
			// BTN_Analisis
			// 
			this.BTN_Analisis.Location = new System.Drawing.Point(188, 99);
			this.BTN_Analisis.Name = "BTN_Analisis";
			this.BTN_Analisis.Size = new System.Drawing.Size(75, 23);
			this.BTN_Analisis.TabIndex = 1;
			this.BTN_Analisis.Text = "Analizar";
			this.BTN_Analisis.UseVisualStyleBackColor = true;
			this.BTN_Analisis.Click += new System.EventHandler(this.BTN_Analisis_Click);
			// 
			// L_Analisis
			// 
			this.L_Analisis.AutoSize = true;
			this.L_Analisis.Location = new System.Drawing.Point(190, 70);
			this.L_Analisis.Name = "L_Analisis";
			this.L_Analisis.Size = new System.Drawing.Size(73, 13);
			this.L_Analisis.TabIndex = 2;
			this.L_Analisis.Text = "No hay datos.";
			this.L_Analisis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// F_Pilas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 143);
			this.Controls.Add(this.L_Analisis);
			this.Controls.Add(this.BTN_Analisis);
			this.Controls.Add(this.TB_Formula);
			this.Name = "F_Pilas";
			this.Text = "Ejercicio de Aplicación: Pilas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TB_Formula;
		private System.Windows.Forms.Button BTN_Analisis;
		private System.Windows.Forms.Label L_Analisis;
	}
}

