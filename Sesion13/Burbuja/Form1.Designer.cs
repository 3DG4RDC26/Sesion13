namespace Burbuja
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
         this.label1 = new System.Windows.Forms.Label();
         this.tbNumber = new System.Windows.Forms.TextBox();
         this.btnAdd = new System.Windows.Forms.Button();
         this.lbNums = new System.Windows.Forms.ListBox();
         this.btnSort = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(12, 41);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(115, 15);
         this.label1.TabIndex = 0;
         this.label1.Text = "Ingresa un numero:";
         // 
         // tbNumber
         // 
         this.tbNumber.Location = new System.Drawing.Point(133, 41);
         this.tbNumber.Name = "tbNumber";
         this.tbNumber.Size = new System.Drawing.Size(100, 20);
         this.tbNumber.TabIndex = 1;
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(241, 39);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(75, 23);
         this.btnAdd.TabIndex = 2;
         this.btnAdd.Text = "Agregar";
         this.btnAdd.UseVisualStyleBackColor = true;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // lbNums
         // 
         this.lbNums.FormattingEnabled = true;
         this.lbNums.Location = new System.Drawing.Point(133, 80);
         this.lbNums.Name = "lbNums";
         this.lbNums.Size = new System.Drawing.Size(100, 82);
         this.lbNums.TabIndex = 3;
         // 
         // btnSort
         // 
         this.btnSort.Location = new System.Drawing.Point(241, 80);
         this.btnSort.Name = "btnSort";
         this.btnSort.Size = new System.Drawing.Size(75, 23);
         this.btnSort.TabIndex = 4;
         this.btnSort.Text = "Ordenar";
         this.btnSort.UseVisualStyleBackColor = true;
         this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(420, 391);
         this.Controls.Add(this.btnSort);
         this.Controls.Add(this.lbNums);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.tbNumber);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox tbNumber;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.ListBox lbNums;
      private System.Windows.Forms.Button btnSort;
   }
}

