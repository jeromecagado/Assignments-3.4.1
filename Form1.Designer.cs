namespace Assignments_3._4._1
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
            dataGridView1 = new DataGridView();
            cmbRoast = new ComboBox();
            txtBrand = new TextBox();
            cmbVolume = new ComboBox();
            chkIsDecaf = new CheckBox();
            btnAdd = new Button();
            btnDelete = new Button();
            lvlBrand = new Label();
            lblVolumeInOz = new Label();
            lblRoastType = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(514, 271);
            dataGridView1.TabIndex = 0;
            // 
            // cmbRoast
            // 
            cmbRoast.FormattingEnabled = true;
            cmbRoast.Location = new Point(585, 175);
            cmbRoast.Name = "cmbRoast";
            cmbRoast.Size = new Size(151, 28);
            cmbRoast.TabIndex = 1;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(611, 108);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(125, 27);
            txtBrand.TabIndex = 2;
            // 
            // cmbVolume
            // 
            cmbVolume.FormattingEnabled = true;
            cmbVolume.Location = new Point(585, 141);
            cmbVolume.Name = "cmbVolume";
            cmbVolume.Size = new Size(151, 28);
            cmbVolume.TabIndex = 3;
            // 
            // chkIsDecaf
            // 
            chkIsDecaf.AutoSize = true;
            chkIsDecaf.Location = new Point(635, 209);
            chkIsDecaf.Name = "chkIsDecaf";
            chkIsDecaf.Size = new Size(77, 24);
            chkIsDecaf.TabIndex = 4;
            chkIsDecaf.Text = "Decaf?";
            chkIsDecaf.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(522, 242);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Coffee";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(654, 242);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete Coffee";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lvlBrand
            // 
            lvlBrand.AutoSize = true;
            lvlBrand.Location = new Point(522, 115);
            lvlBrand.Name = "lvlBrand";
            lvlBrand.Size = new Size(48, 20);
            lvlBrand.TabIndex = 7;
            lvlBrand.Text = "Brand";
            // 
            // lblVolumeInOz
            // 
            lblVolumeInOz.AutoSize = true;
            lblVolumeInOz.Location = new Point(520, 149);
            lblVolumeInOz.Name = "lblVolumeInOz";
            lblVolumeInOz.Size = new Size(59, 20);
            lblVolumeInOz.TabIndex = 8;
            lblVolumeInOz.Text = "Volume";
            // 
            // lblRoastType
            // 
            lblRoastType.AutoSize = true;
            lblRoastType.Location = new Point(522, 183);
            lblRoastType.Name = "lblRoastType";
            lblRoastType.Size = new Size(46, 20);
            lblRoastType.TabIndex = 9;
            lblRoastType.Text = "Roast";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRoastType);
            Controls.Add(lblVolumeInOz);
            Controls.Add(lvlBrand);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(chkIsDecaf);
            Controls.Add(cmbVolume);
            Controls.Add(txtBrand);
            Controls.Add(cmbRoast);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbRoast;
        private TextBox txtBrand;
        private ComboBox cmbVolume;
        private CheckBox chkIsDecaf;
        private Button btnAdd;
        private Button btnDelete;
        private Label lvlBrand;
        private Label lblVolumeInOz;
        private Label lblRoastType;
    }
}
