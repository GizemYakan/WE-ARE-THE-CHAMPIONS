
namespace WE_ARE_THE_CHAMPIONS
{
    partial class NewMatchForm
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
            this.cboTeam1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTeam2 = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddMatch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team";
            // 
            // cboTeam1
            // 
            this.cboTeam1.BackColor = System.Drawing.Color.AliceBlue;
            this.cboTeam1.FormattingEnabled = true;
            this.cboTeam1.Location = new System.Drawing.Point(109, 24);
            this.cboTeam1.Name = "cboTeam1";
            this.cboTeam1.Size = new System.Drawing.Size(159, 21);
            this.cboTeam1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Other Team";
            // 
            // cboTeam2
            // 
            this.cboTeam2.BackColor = System.Drawing.Color.AliceBlue;
            this.cboTeam2.FormattingEnabled = true;
            this.cboTeam2.Location = new System.Drawing.Point(109, 66);
            this.cboTeam2.Name = "cboTeam2";
            this.cboTeam2.Size = new System.Drawing.Size(159, 21);
            this.cboTeam2.TabIndex = 5;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(170, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 32);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMatch.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddMatch.Location = new System.Drawing.Point(72, 218);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Size = new System.Drawing.Size(92, 32);
            this.btnAddMatch.TabIndex = 12;
            this.btnAddMatch.Text = "Add Match";
            this.btnAddMatch.UseVisualStyleBackColor = false;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "-";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 62;
            this.label8.Text = "-";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "-";
            this.label7.Visible = false;
            // 
            // nudMonth
            // 
            this.nudMonth.Location = new System.Drawing.Point(89, 146);
            this.nudMonth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(41, 20);
            this.nudMonth.TabIndex = 60;
            this.nudMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDay
            // 
            this.nudDay.Location = new System.Drawing.Point(21, 146);
            this.nudDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(44, 20);
            this.nudDay.TabIndex = 59;
            this.nudDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudYear
            // 
            this.nudYear.Location = new System.Drawing.Point(154, 146);
            this.nudYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudYear.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(64, 20);
            this.nudYear.TabIndex = 58;
            this.nudYear.Value = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(92, 176);
            this.nudMinute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(41, 20);
            this.nudMinute.TabIndex = 57;
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(21, 176);
            this.nudHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(44, 20);
            this.nudHour.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "Date && Time";
            // 
            // NewMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(291, 283);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudMonth);
            this.Controls.Add(this.nudDay);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddMatch);
            this.Controls.Add(this.cboTeam2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTeam1);
            this.Controls.Add(this.label1);
            this.Name = "NewMatchForm";
            this.Text = "NewMatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTeam1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTeam2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddMatch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.Label label4;
    }
}