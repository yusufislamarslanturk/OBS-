namespace WindowsFormsApp4
{
    partial class ogretErasmus
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogretErasmus));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ogrenciDataSet = new WindowsFormsApp4.ogrenciDataSet();
            this.ogrenciDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notlarTableAdapter = new WindowsFormsApp4.ogrenciDataSetTableAdapters.notlarTableAdapter();
            this.ogrenciDataSet1 = new WindowsFormsApp4.ogrenciDataSet1();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter = new WindowsFormsApp4.ogrenciDataSet1TableAdapters.ogrenciTableAdapter();
            this.ogrenciDataSet2 = new WindowsFormsApp4.ogrenciDataSet2();
            this.ogrenciBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter1 = new WindowsFormsApp4.ogrenciDataSet2TableAdapters.ogrenciTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(116, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(410, 44);
            this.label5.TabIndex = 12;
            this.label5.Text = "Erasmus Durum Görüntüle";
            // 
            // ogrenciDataSet
            // 
            this.ogrenciDataSet.DataSetName = "ogrenciDataSet";
            this.ogrenciDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciDataSetBindingSource
            // 
            this.ogrenciDataSetBindingSource.DataSource = this.ogrenciDataSet;
            this.ogrenciDataSetBindingSource.Position = 0;
            // 
            // notlarBindingSource
            // 
            this.notlarBindingSource.DataMember = "notlar";
            this.notlarBindingSource.DataSource = this.ogrenciDataSetBindingSource;
            // 
            // notlarTableAdapter
            // 
            this.notlarTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciDataSet1
            // 
            this.ogrenciDataSet1.DataSetName = "ogrenciDataSet1";
            this.ogrenciDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "ogrenci";
            this.ogrenciBindingSource.DataSource = this.ogrenciDataSet1;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciDataSet2
            // 
            this.ogrenciDataSet2.DataSetName = "ogrenciDataSet2";
            this.ogrenciDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource1
            // 
            this.ogrenciBindingSource1.DataMember = "ogrenci";
            this.ogrenciBindingSource1.DataSource = this.ogrenciDataSet2;
            // 
            // ogrenciTableAdapter1
            // 
            this.ogrenciTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 268);
            this.dataGridView1.TabIndex = 13;
            // 
            // ogretErasmus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ogretErasmus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ogretErasmus";
            this.Load += new System.EventHandler(this.ogretErasmus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource ogrenciDataSetBindingSource;
        private ogrenciDataSet ogrenciDataSet;
        private System.Windows.Forms.BindingSource notlarBindingSource;
        private ogrenciDataSetTableAdapters.notlarTableAdapter notlarTableAdapter;
        private ogrenciDataSet1 ogrenciDataSet1;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private ogrenciDataSet1TableAdapters.ogrenciTableAdapter ogrenciTableAdapter;
        private ogrenciDataSet2 ogrenciDataSet2;
        private System.Windows.Forms.BindingSource ogrenciBindingSource1;
        private ogrenciDataSet2TableAdapters.ogrenciTableAdapter ogrenciTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}