
namespace WE_ARE_THE_CHAMPIONS
{
    partial class TeamsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditTeam = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnDeleteColor = new System.Windows.Forms.Button();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.cboColors = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbColors = new System.Windows.Forms.ListBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Teams";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(200, 304);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.BackColor = System.Drawing.Color.Yellow;
            this.btnEditTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTeam.Location = new System.Drawing.Point(74, 304);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(120, 37);
            this.btnEditTeam.TabIndex = 13;
            this.btnEditTeam.Text = "Edit Selected";
            this.btnEditTeam.UseVisualStyleBackColor = false;
            this.btnEditTeam.Click += new System.EventHandler(this.btnEditTeam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelEdit);
            this.groupBox1.Controls.Add(this.btnAddTeam);
            this.groupBox1.Controls.Add(this.btnDeleteColor);
            this.groupBox1.Controls.Add(this.btnAddColor);
            this.groupBox1.Controls.Add(this.cboColors);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbColors);
            this.groupBox1.Controls.Add(this.txtTeamName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(355, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 262);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Team";
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.Color.Red;
            this.btnCancelEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEdit.Location = new System.Drawing.Point(240, 205);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(106, 37);
            this.btnCancelEdit.TabIndex = 10;
            this.btnCancelEdit.Text = "Cancel";
            this.btnCancelEdit.UseVisualStyleBackColor = false;
            this.btnCancelEdit.Visible = false;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.Location = new System.Drawing.Point(132, 205);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(102, 37);
            this.btnAddTeam.TabIndex = 9;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = false;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnDeleteColor
            // 
            this.btnDeleteColor.BackColor = System.Drawing.Color.Red;
            this.btnDeleteColor.Enabled = false;
            this.btnDeleteColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteColor.Location = new System.Drawing.Point(179, 105);
            this.btnDeleteColor.Name = "btnDeleteColor";
            this.btnDeleteColor.Size = new System.Drawing.Size(167, 36);
            this.btnDeleteColor.TabIndex = 7;
            this.btnDeleteColor.Text = "Delete Selected Color";
            this.btnDeleteColor.UseVisualStyleBackColor = false;
            this.btnDeleteColor.Click += new System.EventHandler(this.btnDeleteColor_Click);
            // 
            // btnAddColor
            // 
            this.btnAddColor.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddColor.Enabled = false;
            this.btnAddColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddColor.Location = new System.Drawing.Point(179, 67);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(167, 32);
            this.btnAddColor.TabIndex = 6;
            this.btnAddColor.Text = "Add Color";
            this.btnAddColor.UseVisualStyleBackColor = false;
            // 
            // cboColors
            // 
            this.cboColors.Enabled = false;
            this.cboColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboColors.FormattingEnabled = true;
            this.cboColors.Location = new System.Drawing.Point(250, 31);
            this.cboColors.Name = "cboColors";
            this.cboColors.Size = new System.Drawing.Size(96, 21);
            this.cboColors.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Add New Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Colors:";
            // 
            // lbColors
            // 
            this.lbColors.BackColor = System.Drawing.Color.AliceBlue;
            this.lbColors.Enabled = false;
            this.lbColors.FormattingEnabled = true;
            this.lbColors.ItemHeight = 18;
            this.lbColors.Location = new System.Drawing.Point(6, 48);
            this.lbColors.Name = "lbColors";
            this.lbColors.Size = new System.Drawing.Size(120, 166);
            this.lbColors.TabIndex = 2;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(132, 175);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(211, 24);
            this.txtTeamName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Team Name:";
            // 
            // lbTeams
            // 
            this.lbTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.Location = new System.Drawing.Point(12, 49);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.Size = new System.Drawing.Size(325, 251);
            this.lbTeams.TabIndex = 15;
            // 
            // btnPlayers
            // 
            this.btnPlayers.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayers.Location = new System.Drawing.Point(600, 306);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(120, 37);
            this.btnPlayers.TabIndex = 16;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = false;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(739, 369);
            this.Controls.Add(this.btnPlayers);
            this.Controls.Add(this.lbTeams);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditTeam);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TeamsForm";
            this.Text = "TeamsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditTeam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnDeleteColor;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.ComboBox cboColors;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbColors;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.Button btnPlayers;
    }
}