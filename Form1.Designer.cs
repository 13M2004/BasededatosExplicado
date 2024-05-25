namespace Wfdb
{
    partial class Form1
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
            this.dataGridViewPersonajes = new System.Windows.Forms.DataGridView();
            this.buttonCargaData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxRaza = new System.Windows.Forms.TextBox();
            this.numericUpDownNivelPoder = new System.Windows.Forms.NumericUpDown();
            this.comboBoxRaza = new System.Windows.Forms.ComboBox();
            this.buttonInsertar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonTestCon = new System.Windows.Forms.Button();
            this.labelfecha = new System.Windows.Forms.Label();
            this.dateTimePickerfecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHistoria = new System.Windows.Forms.TextBox();
            this.buttonfecha_creacion = new System.Windows.Forms.Button();
            this.buttonreciente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPersonajes
            // 
            this.dataGridViewPersonajes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPersonajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonajes.Location = new System.Drawing.Point(34, 387);
            this.dataGridViewPersonajes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewPersonajes.Name = "dataGridViewPersonajes";
            this.dataGridViewPersonajes.RowHeadersWidth = 51;
            this.dataGridViewPersonajes.RowTemplate.Height = 24;
            this.dataGridViewPersonajes.Size = new System.Drawing.Size(986, 246);
            this.dataGridViewPersonajes.TabIndex = 0;
            // 
            // buttonCargaData
            // 
            this.buttonCargaData.BackColor = System.Drawing.Color.Black;
            this.buttonCargaData.ForeColor = System.Drawing.Color.White;
            this.buttonCargaData.Location = new System.Drawing.Point(1039, 387);
            this.buttonCargaData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCargaData.Name = "buttonCargaData";
            this.buttonCargaData.Size = new System.Drawing.Size(99, 40);
            this.buttonCargaData.TabIndex = 1;
            this.buttonCargaData.Text = "Cargar";
            this.buttonCargaData.UseVisualStyleBackColor = false;
            this.buttonCargaData.Click += new System.EventHandler(this.buttonCargaData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nivel de Poder";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.DarkOrange;
            this.textBoxID.ForeColor = System.Drawing.Color.White;
            this.textBoxID.Location = new System.Drawing.Point(113, 9);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(72, 26);
            this.textBoxID.TabIndex = 6;
            this.textBoxID.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.OrangeRed;
            this.textBoxNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxNombre.ForeColor = System.Drawing.Color.White;
            this.textBoxNombre.Location = new System.Drawing.Point(179, 50);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(727, 26);
            this.textBoxNombre.TabIndex = 7;
            // 
            // textBoxRaza
            // 
            this.textBoxRaza.BackColor = System.Drawing.Color.OrangeRed;
            this.textBoxRaza.ForeColor = System.Drawing.Color.White;
            this.textBoxRaza.Location = new System.Drawing.Point(183, 95);
            this.textBoxRaza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxRaza.Name = "textBoxRaza";
            this.textBoxRaza.Size = new System.Drawing.Size(727, 26);
            this.textBoxRaza.TabIndex = 8;
            // 
            // numericUpDownNivelPoder
            // 
            this.numericUpDownNivelPoder.BackColor = System.Drawing.Color.OrangeRed;
            this.numericUpDownNivelPoder.Location = new System.Drawing.Point(216, 186);
            this.numericUpDownNivelPoder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownNivelPoder.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownNivelPoder.Name = "numericUpDownNivelPoder";
            this.numericUpDownNivelPoder.Size = new System.Drawing.Size(135, 26);
            this.numericUpDownNivelPoder.TabIndex = 9;
            // 
            // comboBoxRaza
            // 
            this.comboBoxRaza.BackColor = System.Drawing.Color.OrangeRed;
            this.comboBoxRaza.FormattingEnabled = true;
            this.comboBoxRaza.Location = new System.Drawing.Point(181, 140);
            this.comboBoxRaza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxRaza.Name = "comboBoxRaza";
            this.comboBoxRaza.Size = new System.Drawing.Size(136, 28);
            this.comboBoxRaza.TabIndex = 10;
            // 
            // buttonInsertar
            // 
            this.buttonInsertar.BackColor = System.Drawing.Color.Black;
            this.buttonInsertar.ForeColor = System.Drawing.Color.White;
            this.buttonInsertar.Location = new System.Drawing.Point(780, 178);
            this.buttonInsertar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonInsertar.Name = "buttonInsertar";
            this.buttonInsertar.Size = new System.Drawing.Size(130, 41);
            this.buttonInsertar.TabIndex = 11;
            this.buttonInsertar.Text = "Insertar";
            this.buttonInsertar.UseVisualStyleBackColor = false;
            this.buttonInsertar.Click += new System.EventHandler(this.buttonInsertar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.Black;
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBuscar.Location = new System.Drawing.Point(1070, 35);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(84, 41);
            this.buttonBuscar.TabIndex = 12;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonTestCon
            // 
            this.buttonTestCon.BackColor = System.Drawing.Color.Black;
            this.buttonTestCon.ForeColor = System.Drawing.Color.White;
            this.buttonTestCon.Location = new System.Drawing.Point(998, 92);
            this.buttonTestCon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonTestCon.Name = "buttonTestCon";
            this.buttonTestCon.Size = new System.Drawing.Size(202, 29);
            this.buttonTestCon.TabIndex = 13;
            this.buttonTestCon.Text = "Prueba Conexion";
            this.buttonTestCon.UseVisualStyleBackColor = false;
            this.buttonTestCon.Click += new System.EventHandler(this.buttonTestCon_Click);
            // 
            // labelfecha
            // 
            this.labelfecha.AutoSize = true;
            this.labelfecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfecha.ForeColor = System.Drawing.Color.White;
            this.labelfecha.Location = new System.Drawing.Point(34, 235);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(166, 23);
            this.labelfecha.TabIndex = 14;
            this.labelfecha.Text = "Fecha_Creacion";
            // 
            // dateTimePickerfecha
            // 
            this.dateTimePickerfecha.CalendarMonthBackground = System.Drawing.Color.OrangeRed;
            this.dateTimePickerfecha.CalendarTitleBackColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerfecha.CalendarTitleForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerfecha.CalendarTrailingForeColor = System.Drawing.Color.OrangeRed;
            this.dateTimePickerfecha.Location = new System.Drawing.Point(216, 233);
            this.dateTimePickerfecha.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerfecha.Name = "dateTimePickerfecha";
            this.dateTimePickerfecha.Size = new System.Drawing.Size(480, 26);
            this.dateTimePickerfecha.TabIndex = 15;
            this.dateTimePickerfecha.Value = new System.DateTime(2024, 5, 21, 22, 4, 22, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Historia";
            // 
            // textBoxHistoria
            // 
            this.textBoxHistoria.BackColor = System.Drawing.Color.OrangeRed;
            this.textBoxHistoria.Location = new System.Drawing.Point(179, 280);
            this.textBoxHistoria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxHistoria.Name = "textBoxHistoria";
            this.textBoxHistoria.Size = new System.Drawing.Size(727, 26);
            this.textBoxHistoria.TabIndex = 17;
            // 
            // buttonfecha_creacion
            // 
            this.buttonfecha_creacion.BackColor = System.Drawing.Color.Black;
            this.buttonfecha_creacion.ForeColor = System.Drawing.Color.White;
            this.buttonfecha_creacion.Location = new System.Drawing.Point(1039, 472);
            this.buttonfecha_creacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonfecha_creacion.Name = "buttonfecha_creacion";
            this.buttonfecha_creacion.Size = new System.Drawing.Size(115, 59);
            this.buttonfecha_creacion.TabIndex = 18;
            this.buttonfecha_creacion.Text = "Ordenar por fecha";
            this.buttonfecha_creacion.UseVisualStyleBackColor = false;
            this.buttonfecha_creacion.Click += new System.EventHandler(this.buttonfecha_creacion_Click);
            // 
            // buttonreciente
            // 
            this.buttonreciente.BackColor = System.Drawing.Color.Black;
            this.buttonreciente.ForeColor = System.Drawing.Color.White;
            this.buttonreciente.Location = new System.Drawing.Point(1039, 563);
            this.buttonreciente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonreciente.Name = "buttonreciente";
            this.buttonreciente.Size = new System.Drawing.Size(136, 70);
            this.buttonreciente.TabIndex = 19;
            this.buttonreciente.Text = "Agregados Recientemente";
            this.buttonreciente.UseVisualStyleBackColor = false;
            this.buttonreciente.Click += new System.EventHandler(this.buttonreciente_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1055, 276);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "CERRAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1683, 780);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonreciente);
            this.Controls.Add(this.buttonfecha_creacion);
            this.Controls.Add(this.textBoxHistoria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerfecha);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.buttonTestCon);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonInsertar);
            this.Controls.Add(this.comboBoxRaza);
            this.Controls.Add(this.numericUpDownNivelPoder);
            this.Controls.Add(this.textBoxRaza);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCargaData);
            this.Controls.Add(this.dataGridViewPersonajes);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNivelPoder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPersonajes;
        private System.Windows.Forms.Button buttonCargaData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxRaza;
        private System.Windows.Forms.NumericUpDown numericUpDownNivelPoder;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.Button buttonInsertar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonTestCon;
        private System.Windows.Forms.Label labelfecha;
        private System.Windows.Forms.DateTimePicker dateTimePickerfecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxHistoria;
        private System.Windows.Forms.Button buttonfecha_creacion;
        private System.Windows.Forms.Button buttonreciente;
        private System.Windows.Forms.Button button1;
    }
}

