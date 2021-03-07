
namespace WE_ARE_THE_CHAMPIONS
{
    partial class ColorsForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.nudBlue = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudGreen = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudRed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbColors = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(155, 357);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 29);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditColor
            // 
            this.btnEditColor.BackColor = System.Drawing.Color.Yellow;
            this.btnEditColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditColor.Location = new System.Drawing.Point(13, 357);
            this.btnEditColor.Name = "btnEditColor";
            this.btnEditColor.Size = new System.Drawing.Size(136, 29);
            this.btnEditColor.TabIndex = 19;
            this.btnEditColor.Text = "Edit Selected";
            this.btnEditColor.UseVisualStyleBackColor = false;
            this.btnEditColor.Click += new System.EventHandler(this.btnEditColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelEdit);
            this.groupBox1.Controls.Add(this.btnAddColor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pbPreview);
            this.groupBox1.Controls.Add(this.nudBlue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudGreen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudRed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtColorName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(298, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 334);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Color";
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.Red;
            this.btnCancelEdit.Location = new System.Drawing.Point(134, 278);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(120, 29);
            this.btnCancelEdit.TabIndex = 14;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnAddColor
            // 
            this.btnAddColor.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddColor.Location = new System.Drawing.Point(10, 278);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(120, 29);
            this.btnAddColor.TabIndex = 13;
            this.btnAddColor.Text = "Add Color";
            this.btnAddColor.UseVisualStyleBackColor = false;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Color Preview";
            // 
            // pbPreview
            // 
            this.pbPreview.BackColor = System.Drawing.Color.Transparent;
            this.pbPreview.Location = new System.Drawing.Point(153, 117);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(15, 146);
            this.pbPreview.TabIndex = 11;
            this.pbPreview.TabStop = false;
            // 
            // nudBlue
            // 
            this.nudBlue.Location = new System.Drawing.Point(10, 239);
            this.nudBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudBlue.Name = "nudBlue";
            this.nudBlue.Size = new System.Drawing.Size(120, 24);
            this.nudBlue.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Blue:";
            // 
            // nudGreen
            // 
            this.nudGreen.Location = new System.Drawing.Point(10, 178);
            this.nudGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudGreen.Name = "nudGreen";
            this.nudGreen.Size = new System.Drawing.Size(120, 24);
            this.nudGreen.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Green:";
            // 
            // nudRed
            // 
            this.nudRed.Location = new System.Drawing.Point(10, 117);
            this.nudRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudRed.Name = "nudRed";
            this.nudRed.Size = new System.Drawing.Size(120, 24);
            this.nudRed.TabIndex = 6;
            this.nudRed.ValueChanged += new System.EventHandler(this.nudRed_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Red:";
            // 
            // txtColorName
            // 
            this.txtColorName.Location = new System.Drawing.Point(10, 55);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Size = new System.Drawing.Size(128, 24);
            this.txtColorName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Color Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Colors";
            // 
            // lbColors
            // 
            this.lbColors.BackColor = System.Drawing.Color.AliceBlue;
            this.lbColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbColors.FormattingEnabled = true;
            this.lbColors.ItemHeight = 18;
            this.lbColors.Location = new System.Drawing.Point(13, 39);
            this.lbColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbColors.Name = "lbColors";
            this.lbColors.Size = new System.Drawing.Size(278, 310);
            this.lbColors.TabIndex = 16;
            // 
            // ColorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(587, 406);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditColor);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbColors);
            this.Name = "ColorsForm";
            this.Text = "ColorsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.NumericUpDown nudBlue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudGreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbColors;
    }
}