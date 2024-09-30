namespace Registro
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
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.tbFirstName = new System.Windows.Forms.TextBox();
         this.tbLastName = new System.Windows.Forms.TextBox();
         this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
         this.btnAdd = new System.Windows.Forms.Button();
         this.btnSort = new System.Windows.Forms.Button();
         this.dgvPersons = new System.Windows.Forms.DataGridView();
         ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(73, 36);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(58, 15);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nombres:";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(71, 71);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(60, 15);
         this.label2.TabIndex = 1;
         this.label2.Text = "Apellidos:";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(12, 103);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(119, 15);
         this.label3.TabIndex = 2;
         this.label3.Text = "Fecha de nacimiento:";
         // 
         // tbFirstName
         // 
         this.tbFirstName.Location = new System.Drawing.Point(137, 36);
         this.tbFirstName.Name = "tbFirstName";
         this.tbFirstName.Size = new System.Drawing.Size(242, 20);
         this.tbFirstName.TabIndex = 3;
         // 
         // tbLastName
         // 
         this.tbLastName.Location = new System.Drawing.Point(137, 69);
         this.tbLastName.Name = "tbLastName";
         this.tbLastName.Size = new System.Drawing.Size(242, 20);
         this.tbLastName.TabIndex = 4;
         // 
         // dtpBirthdate
         // 
         this.dtpBirthdate.Location = new System.Drawing.Point(137, 103);
         this.dtpBirthdate.Name = "dtpBirthdate";
         this.dtpBirthdate.Size = new System.Drawing.Size(242, 20);
         this.dtpBirthdate.TabIndex = 5;
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(162, 156);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(75, 23);
         this.btnAdd.TabIndex = 6;
         this.btnAdd.Text = "Agregar";
         this.btnAdd.UseVisualStyleBackColor = true;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // btnSort
         // 
         this.btnSort.Location = new System.Drawing.Point(273, 156);
         this.btnSort.Name = "btnSort";
         this.btnSort.Size = new System.Drawing.Size(75, 23);
         this.btnSort.TabIndex = 7;
         this.btnSort.Text = "Ordenar";
         this.btnSort.UseVisualStyleBackColor = true;
         // 
         // dgvPersons
         // 
         this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dgvPersons.Location = new System.Drawing.Point(76, 199);
         this.dgvPersons.Name = "dgvPersons";
         this.dgvPersons.Size = new System.Drawing.Size(303, 151);
         this.dgvPersons.TabIndex = 8;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(551, 445);
         this.Controls.Add(this.dgvPersons);
         this.Controls.Add(this.btnSort);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.dtpBirthdate);
         this.Controls.Add(this.tbLastName);
         this.Controls.Add(this.tbFirstName);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "Form1";
         this.Text = "Form1";
         ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox tbFirstName;
      private System.Windows.Forms.TextBox tbLastName;
      private System.Windows.Forms.DateTimePicker dtpBirthdate;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Button btnSort;
      private System.Windows.Forms.DataGridView dgvPersons;
   }
}

