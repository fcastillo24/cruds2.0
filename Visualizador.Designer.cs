namespace cruds2._0
{
    partial class Visualizador
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
            this.tablero = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Vin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Carro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Modelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Año = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Conductor = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablero)).BeginInit();
            this.SuspendLayout();
            // 
            // tablero
            // 
            this.tablero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablero.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tablero.Location = new System.Drawing.Point(32, 123);
            this.tablero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablero.Name = "tablero";
            this.tablero.ReadOnly = true;
            this.tablero.RowHeadersWidth = 51;
            this.tablero.Size = new System.Drawing.Size(875, 513);
            this.tablero.TabIndex = 1;
            this.tablero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tablero_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(961, 279);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Crear vehiculo y conductor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vin
            // 
            this.Vin.Location = new System.Drawing.Point(192, 64);
            this.Vin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Vin.Name = "Vin";
            this.Vin.Size = new System.Drawing.Size(132, 22);
            this.Vin.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "VIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Carro";
            // 
            // Carro
            // 
            this.Carro.Location = new System.Drawing.Point(372, 63);
            this.Carro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Carro.Name = "Carro";
            this.Carro.Size = new System.Drawing.Size(132, 22);
            this.Carro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modelo";
            // 
            // Modelo
            // 
            this.Modelo.Location = new System.Drawing.Point(564, 63);
            this.Modelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Modelo.Name = "Modelo";
            this.Modelo.Size = new System.Drawing.Size(132, 22);
            this.Modelo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Año";
            // 
            // Año
            // 
            this.Año.Location = new System.Drawing.Point(729, 64);
            this.Año.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(132, 22);
            this.Año.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(923, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Conductor";
            // 
            // Conductor
            // 
            this.Conductor.Location = new System.Drawing.Point(927, 64);
            this.Conductor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Conductor.Name = "Conductor";
            this.Conductor.Size = new System.Drawing.Size(132, 22);
            this.Conductor.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(961, 145);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 13;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(961, 181);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 60);
            this.button3.TabIndex = 14;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "ID";
            // 
            // Id
            // 
            this.Id.Enabled = false;
            this.Id.Location = new System.Drawing.Point(32, 64);
            this.Id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(132, 22);
            this.Id.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1127, 60);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 17;
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Visualizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 753);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Conductor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Año);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Modelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Carro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Vin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tablero);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Visualizador";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.tablero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Vin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Carro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Modelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Año;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Conductor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Button button4;
    }
}