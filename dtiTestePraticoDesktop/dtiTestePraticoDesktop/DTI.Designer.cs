namespace dtiTestePraticoDesktop
{
    partial class DTI
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
            this.btnCriar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLembrete = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.listViewLembretes = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCriar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCriar.Location = new System.Drawing.Point(359, 195);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(160, 46);
            this.btnCriar.TabIndex = 0;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Novo Lembrete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(46, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data";
            // 
            // txtLembrete
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 106);
            this.txtNome.Name = "txtLembrete";
            this.txtNome.Size = new System.Drawing.Size(426, 23);
            this.txtNome.TabIndex = 4;
            // 
            // dataLembrete
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(93, 147);
            this.dateTimePicker.Name = "dataLembrete";
            this.dateTimePicker.Size = new System.Drawing.Size(426, 23);
            this.dateTimePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(35, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Lista de Lembretes";
            // 
            // lblLembrete
            // 
            this.lblLembrete.AutoSize = true;
            this.lblLembrete.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLembrete.Location = new System.Drawing.Point(280, 529);
            this.lblLembrete.Name = "lblLembrete";
            this.lblLembrete.Size = new System.Drawing.Size(97, 25);
            this.lblLembrete.TabIndex = 7;
            this.lblLembrete.Text = "Lembrete:";
            this.lblLembrete.Visible = false;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblData.Location = new System.Drawing.Point(46, 467);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(57, 25);
            this.lblData.TabIndex = 8;
            this.lblData.Text = "Data:";
            this.lblData.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(46, 293);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(473, 150);
            this.dataGridView.TabIndex = 9;
            // 
            // listView1
            // 
            this.listViewLembretes.Location = new System.Drawing.Point(46, 513);
            this.listViewLembretes.Name = "listView1";
            this.listViewLembretes.Size = new System.Drawing.Size(121, 97);
            this.listViewLembretes.TabIndex = 10;
            this.listViewLembretes.UseCompatibleStateImageBehavior = false;
            // 
            // DTI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 720);
            this.Controls.Add(this.listViewLembretes);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblLembrete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriar);
            this.Name = "DTI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DTI";
            this.Load += new System.EventHandler(this.DTI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCriar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private DateTimePicker dateTimePicker;
        private Label label4;
        private ListView listViewLembretes;
        private TextBox textBox1;
        private ListView listView1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}