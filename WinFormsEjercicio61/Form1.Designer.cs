namespace WinFormsEjercicio61
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            btnSalir = new Button();
            button2 = new Button();
            btnOk = new Button();
            txtDecimal = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            colDecimal = new DataGridViewTextBoxColumn();
            colBinario = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnSalir);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(btnOk);
            splitContainer1.Panel1.Controls.Add(txtDecimal);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(656, 52);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 54);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(218, 168);
            button2.Name = "button2";
            button2.Size = new Size(75, 52);
            button2.TabIndex = 3;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(74, 168);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 52);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // txtDecimal
            // 
            txtDecimal.Location = new Point(181, 88);
            txtDecimal.Name = "txtDecimal";
            txtDecimal.Size = new Size(100, 23);
            txtDecimal.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 91);
            label1.Name = "label1";
            label1.Size = new Size(152, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un numero decimal";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colDecimal, colBinario });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 180);
            dataGridView1.TabIndex = 0;
            // 
            // colDecimal
            // 
            colDecimal.HeaderText = "Numero Decimal";
            colDecimal.Name = "colDecimal";
            colDecimal.ReadOnly = true;
            // 
            // colBinario
            // 
            colBinario.HeaderText = "Binario";
            colBinario.Name = "colBinario";
            colBinario.ReadOnly = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnSalir;
        private Button button2;
        private Button btnOk;
        private TextBox txtDecimal;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colDecimal;
        private DataGridViewTextBoxColumn colBinario;
        private ErrorProvider errorProvider1;
    }
}