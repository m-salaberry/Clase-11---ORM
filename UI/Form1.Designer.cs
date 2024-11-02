namespace UI
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
            txtDescripcion = new TextBox();
            dtpFecha = new DateTimePicker();
            btnAgregar = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label5 = new Label();
            txtIdMod = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnModificar = new Button();
            dtpFechaMod = new DateTimePicker();
            txtDescripMod = new TextBox();
            groupBox3 = new GroupBox();
            txtIdEliminar = new TextBox();
            label6 = new Label();
            btnEliminar = new Button();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(104, 38);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(259, 23);
            txtDescripcion.TabIndex = 0;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(104, 79);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(259, 23);
            dtpFecha.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(191, 120);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(78, 33);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(dtpFecha);
            groupBox1.Controls.Add(txtDescripcion);
            groupBox1.Location = new Point(31, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(369, 170);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cargar tarea";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 85);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Fecha:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 41);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Descripcion:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtIdMod);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(dtpFechaMod);
            groupBox2.Controls.Add(txtDescripMod);
            groupBox2.Location = new Point(31, 219);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(369, 214);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Modificar tarea";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 39);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 6;
            label5.Text = "ID:";
            // 
            // txtIdMod
            // 
            txtIdMod.Location = new Point(104, 31);
            txtIdMod.Name = "txtIdMod";
            txtIdMod.Size = new Size(259, 23);
            txtIdMod.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 120);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 5;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 76);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 4;
            label4.Text = "Descripcion:";
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(191, 155);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(78, 33);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // dtpFechaMod
            // 
            dtpFechaMod.Location = new Point(104, 114);
            dtpFechaMod.Name = "dtpFechaMod";
            dtpFechaMod.Size = new Size(259, 23);
            dtpFechaMod.TabIndex = 2;
            // 
            // txtDescripMod
            // 
            txtDescripMod.Location = new Point(104, 73);
            txtDescripMod.Name = "txtDescripMod";
            txtDescripMod.Size = new Size(259, 23);
            txtDescripMod.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtIdEliminar);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(btnEliminar);
            groupBox3.Location = new Point(31, 456);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(369, 145);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Eliminar tarea";
            // 
            // txtIdEliminar
            // 
            txtIdEliminar.Location = new Point(84, 59);
            txtIdEliminar.Name = "txtIdEliminar";
            txtIdEliminar.Size = new Size(259, 23);
            txtIdEliminar.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 62);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 7;
            label6.Text = "ID:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(166, 88);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(78, 33);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(434, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(411, 569);
            dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 617);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDescripcion;
        private DateTimePicker dtpFecha;
        private Button btnAgregar;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private Button btnModificar;
        private DateTimePicker dtpFechaMod;
        private TextBox txtDescripMod;
        private Label label5;
        private TextBox txtIdMod;
        private GroupBox groupBox3;
        private Button btnEliminar;
        private TextBox txtIdEliminar;
        private Label label6;
        private DataGridView dataGridView1;
    }
}
