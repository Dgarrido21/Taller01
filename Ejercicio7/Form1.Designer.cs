﻿namespace Ejercicio7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxVehiculo = new GroupBox();
            labelId = new Label();
            textBoxiD = new TextBox();
            buttonActualizar = new Button();
            label2 = new Label();
            textBoxManiobrabilidad = new TextBox();
            labelVelocidad = new Label();
            textBoxVelocidad = new TextBox();
            labelAnio = new Label();
            textBoxAnio = new TextBox();
            textBoxModelo = new TextBox();
            labelModelo = new Label();
            textBoxFabricante = new TextBox();
            labelFabricante = new Label();
            dataGridView1 = new DataGridView();
            groupBoxVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxVehiculo
            // 
            groupBoxVehiculo.Controls.Add(labelId);
            groupBoxVehiculo.Controls.Add(textBoxiD);
            groupBoxVehiculo.Controls.Add(buttonActualizar);
            groupBoxVehiculo.Controls.Add(label2);
            groupBoxVehiculo.Controls.Add(textBoxManiobrabilidad);
            groupBoxVehiculo.Controls.Add(labelVelocidad);
            groupBoxVehiculo.Controls.Add(textBoxVelocidad);
            groupBoxVehiculo.Controls.Add(labelAnio);
            groupBoxVehiculo.Controls.Add(textBoxAnio);
            groupBoxVehiculo.Controls.Add(textBoxModelo);
            groupBoxVehiculo.Controls.Add(labelModelo);
            groupBoxVehiculo.Controls.Add(textBoxFabricante);
            groupBoxVehiculo.Controls.Add(labelFabricante);
            groupBoxVehiculo.Controls.Add(dataGridView1);
            groupBoxVehiculo.Location = new Point(12, 12);
            groupBoxVehiculo.Name = "groupBoxVehiculo";
            groupBoxVehiculo.Size = new Size(592, 337);
            groupBoxVehiculo.TabIndex = 0;
            groupBoxVehiculo.TabStop = false;
            groupBoxVehiculo.Text = "Vehiculo";
            groupBoxVehiculo.Enter += groupBoxVehiculo_Enter;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(479, 25);
            labelId.Name = "labelId";
            labelId.Size = new Size(17, 15);
            labelId.TabIndex = 16;
            labelId.Text = "Id";
            // 
            // textBoxiD
            // 
            textBoxiD.Location = new Point(502, 22);
            textBoxiD.Name = "textBoxiD";
            textBoxiD.ReadOnly = true;
            textBoxiD.Size = new Size(84, 23);
            textBoxiD.TabIndex = 15;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(511, 133);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(75, 23);
            buttonActualizar.TabIndex = 14;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            buttonActualizar.Click += buttonActualizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 141);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 10;
            label2.Text = "Maniobrabilidad";
            // 
            // textBoxManiobrabilidad
            // 
            textBoxManiobrabilidad.Location = new Point(106, 138);
            textBoxManiobrabilidad.Name = "textBoxManiobrabilidad";
            textBoxManiobrabilidad.Size = new Size(68, 23);
            textBoxManiobrabilidad.TabIndex = 9;
            textBoxManiobrabilidad.TextChanged += textBoxManiobrabilidad_TextChanged;
            // 
            // labelVelocidad
            // 
            labelVelocidad.AutoSize = true;
            labelVelocidad.Location = new Point(42, 112);
            labelVelocidad.Name = "labelVelocidad";
            labelVelocidad.Size = new Size(58, 15);
            labelVelocidad.TabIndex = 8;
            labelVelocidad.Text = "Velocidad";
            // 
            // textBoxVelocidad
            // 
            textBoxVelocidad.Location = new Point(106, 109);
            textBoxVelocidad.Name = "textBoxVelocidad";
            textBoxVelocidad.Size = new Size(68, 23);
            textBoxVelocidad.TabIndex = 7;
            // 
            // labelAnio
            // 
            labelAnio.AutoSize = true;
            labelAnio.Location = new Point(71, 83);
            labelAnio.Name = "labelAnio";
            labelAnio.Size = new Size(29, 15);
            labelAnio.TabIndex = 6;
            labelAnio.Text = "Año";
            // 
            // textBoxAnio
            // 
            textBoxAnio.Location = new Point(106, 80);
            textBoxAnio.Name = "textBoxAnio";
            textBoxAnio.Size = new Size(68, 23);
            textBoxAnio.TabIndex = 5;
            // 
            // textBoxModelo
            // 
            textBoxModelo.Location = new Point(106, 51);
            textBoxModelo.Name = "textBoxModelo";
            textBoxModelo.Size = new Size(242, 23);
            textBoxModelo.TabIndex = 4;
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(52, 54);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(48, 15);
            labelModelo.TabIndex = 3;
            labelModelo.Text = "Modelo";
            // 
            // textBoxFabricante
            // 
            textBoxFabricante.Location = new Point(106, 22);
            textBoxFabricante.Name = "textBoxFabricante";
            textBoxFabricante.Size = new Size(242, 23);
            textBoxFabricante.TabIndex = 2;
            // 
            // labelFabricante
            // 
            labelFabricante.AutoSize = true;
            labelFabricante.Location = new Point(38, 25);
            labelFabricante.Name = "labelFabricante";
            labelFabricante.Size = new Size(62, 15);
            labelFabricante.TabIndex = 1;
            labelFabricante.Text = "Fabricante";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(9, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(577, 164);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 361);
            Controls.Add(groupBoxVehiculo);
            Name = "Form1";
            Text = "Vehiculo";
            groupBoxVehiculo.ResumeLayout(false);
            groupBoxVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxVehiculo;
        private TextBox textBoxModelo;
        private Label labelModelo;
        private TextBox textBoxFabricante;
        private Label labelFabricante;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox textBoxManiobrabilidad;
        private Label labelVelocidad;
        private TextBox textBoxVelocidad;
        private Label labelAnio;
        private TextBox textBoxAnio;
        private Button buttonActualizar;
        private Label labelId;
        private TextBox textBoxiD;
    }
}