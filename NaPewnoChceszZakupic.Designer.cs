
namespace po
{
	partial class NaPewnoChceszZakupic
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
			if(disposing && ( components != null ))
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
			this.ZakupMiejsceTxt = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ZakupMiejsceTxt
			// 
			this.ZakupMiejsceTxt.AutoSize = true;
			this.ZakupMiejsceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ZakupMiejsceTxt.Location = new System.Drawing.Point(39, 9);
			this.ZakupMiejsceTxt.MaximumSize = new System.Drawing.Size(350, 0);
			this.ZakupMiejsceTxt.Name = "ZakupMiejsceTxt";
			this.ZakupMiejsceTxt.Size = new System.Drawing.Size(299, 66);
			this.ZakupMiejsceTxt.TabIndex = 0;
			this.ZakupMiejsceTxt.Text = "Czy na pewno chcesz zakupić miejsce";
			this.ZakupMiejsceTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ZakupMiejsceTxt.Click += new System.EventHandler(this.label1_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.Location = new System.Drawing.Point(45, 115);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 62);
			this.button1.TabIndex = 1;
			this.button1.Text = "Tak";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.TakButton);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button2.Location = new System.Drawing.Point(231, 115);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 62);
			this.button2.TabIndex = 2;
			this.button2.Text = "Nie";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.NieButton);
			// 
			// NaPewnoChceszZakupic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(379, 189);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.ZakupMiejsceTxt);
			this.Name = "NaPewnoChceszZakupic";
			this.Text = "NaPewnoChceszZakupic";
			this.Load += new System.EventHandler(this.NaPewnoChceszZakupic_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label ZakupMiejsceTxt;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}