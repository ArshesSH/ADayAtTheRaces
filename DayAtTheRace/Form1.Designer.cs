namespace DayAtTheRace
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceTrack = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonRace = new System.Windows.Forms.Button();
            this.numericUpDownDogNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownCash = new System.Windows.Forms.NumericUpDown();
            this.buttonBets = new System.Windows.Forms.Button();
            this.labelBetterName = new System.Windows.Forms.Label();
            this.labelInform3 = new System.Windows.Forms.Label();
            this.labelInform2 = new System.Windows.Forms.Label();
            this.labelInform1 = new System.Windows.Forms.Label();
            this.radioButtonBetter3 = new System.Windows.Forms.RadioButton();
            this.radioButtonBetter2 = new System.Windows.Forms.RadioButton();
            this.radioButtonBetter1 = new System.Windows.Forms.RadioButton();
            this.labelBets = new System.Windows.Forms.Label();
            this.labelMinimumBet = new System.Windows.Forms.Label();
            this.pictureBoxDog1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDog4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDogNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog4)).BeginInit();
            this.SuspendLayout();
            // 
            // raceTrack
            // 
            this.raceTrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.raceTrack.Image = ((System.Drawing.Image)(resources.GetObject("raceTrack.Image")));
            this.raceTrack.Location = new System.Drawing.Point(45, 13);
            this.raceTrack.Name = "raceTrack";
            this.raceTrack.Size = new System.Drawing.Size(729, 240);
            this.raceTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.raceTrack.TabIndex = 0;
            this.raceTrack.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonRace);
            this.groupBox1.Controls.Add(this.numericUpDownDogNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDownCash);
            this.groupBox1.Controls.Add(this.buttonBets);
            this.groupBox1.Controls.Add(this.labelBetterName);
            this.groupBox1.Controls.Add(this.labelInform3);
            this.groupBox1.Controls.Add(this.labelInform2);
            this.groupBox1.Controls.Add(this.labelInform1);
            this.groupBox1.Controls.Add(this.radioButtonBetter3);
            this.groupBox1.Controls.Add(this.radioButtonBetter2);
            this.groupBox1.Controls.Add(this.radioButtonBetter1);
            this.groupBox1.Controls.Add(this.labelBets);
            this.groupBox1.Controls.Add(this.labelMinimumBet);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(10, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // buttonRace
            // 
            this.buttonRace.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRace.Location = new System.Drawing.Point(579, 178);
            this.buttonRace.Name = "buttonRace";
            this.buttonRace.Size = new System.Drawing.Size(185, 44);
            this.buttonRace.TabIndex = 8;
            this.buttonRace.Text = "Race!";
            this.buttonRace.UseVisualStyleBackColor = true;
            this.buttonRace.Click += new System.EventHandler(this.buttonRace_Click);
            // 
            // numericUpDownDogNum
            // 
            this.numericUpDownDogNum.Location = new System.Drawing.Point(354, 201);
            this.numericUpDownDogNum.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownDogNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDogNum.Name = "numericUpDownDogNum";
            this.numericUpDownDogNum.Size = new System.Drawing.Size(64, 21);
            this.numericUpDownDogNum.TabIndex = 7;
            this.numericUpDownDogNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDogNum.ValueChanged += new System.EventHandler(this.numericUpDownDogNum_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "bucks on dog number";
            // 
            // numericUpDownCash
            // 
            this.numericUpDownCash.Location = new System.Drawing.Point(149, 201);
            this.numericUpDownCash.Name = "numericUpDownCash";
            this.numericUpDownCash.Size = new System.Drawing.Size(64, 21);
            this.numericUpDownCash.TabIndex = 5;
            this.numericUpDownCash.ValueChanged += new System.EventHandler(this.numericUpDownCash_ValueChanged);
            // 
            // buttonBets
            // 
            this.buttonBets.Location = new System.Drawing.Point(68, 201);
            this.buttonBets.Name = "buttonBets";
            this.buttonBets.Size = new System.Drawing.Size(75, 21);
            this.buttonBets.TabIndex = 4;
            this.buttonBets.Text = "Bets";
            this.buttonBets.UseVisualStyleBackColor = true;
            this.buttonBets.Click += new System.EventHandler(this.buttonBets_Click);
            // 
            // labelBetterName
            // 
            this.labelBetterName.AutoSize = true;
            this.labelBetterName.Location = new System.Drawing.Point(23, 204);
            this.labelBetterName.Name = "labelBetterName";
            this.labelBetterName.Size = new System.Drawing.Size(39, 12);
            this.labelBetterName.TabIndex = 3;
            this.labelBetterName.Text = "Name";
            // 
            // labelInform3
            // 
            this.labelInform3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInform3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInform3.Location = new System.Drawing.Point(579, 111);
            this.labelInform3.Name = "labelInform3";
            this.labelInform3.Size = new System.Drawing.Size(185, 16);
            this.labelInform3.TabIndex = 2;
            this.labelInform3.Text = "Al\'s bet";
            // 
            // labelInform2
            // 
            this.labelInform2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInform2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInform2.Location = new System.Drawing.Point(579, 90);
            this.labelInform2.Name = "labelInform2";
            this.labelInform2.Size = new System.Drawing.Size(185, 16);
            this.labelInform2.TabIndex = 2;
            this.labelInform2.Text = "Bob\'s bet";
            // 
            // labelInform1
            // 
            this.labelInform1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInform1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInform1.Location = new System.Drawing.Point(579, 68);
            this.labelInform1.Name = "labelInform1";
            this.labelInform1.Size = new System.Drawing.Size(185, 16);
            this.labelInform1.TabIndex = 2;
            this.labelInform1.Text = "Joe\'s bet";
            // 
            // radioButtonBetter3
            // 
            this.radioButtonBetter3.AutoSize = true;
            this.radioButtonBetter3.Location = new System.Drawing.Point(23, 111);
            this.radioButtonBetter3.Name = "radioButtonBetter3";
            this.radioButtonBetter3.Size = new System.Drawing.Size(34, 16);
            this.radioButtonBetter3.TabIndex = 1;
            this.radioButtonBetter3.Text = "Al";
            this.radioButtonBetter3.UseVisualStyleBackColor = true;
            this.radioButtonBetter3.CheckedChanged += new System.EventHandler(this.radioButtonBetter3_CheckedChanged);
            // 
            // radioButtonBetter2
            // 
            this.radioButtonBetter2.AutoSize = true;
            this.radioButtonBetter2.Location = new System.Drawing.Point(23, 89);
            this.radioButtonBetter2.Name = "radioButtonBetter2";
            this.radioButtonBetter2.Size = new System.Drawing.Size(45, 16);
            this.radioButtonBetter2.TabIndex = 1;
            this.radioButtonBetter2.Text = "Bob";
            this.radioButtonBetter2.UseVisualStyleBackColor = true;
            this.radioButtonBetter2.CheckedChanged += new System.EventHandler(this.radioButtonBetter2_CheckedChanged);
            // 
            // radioButtonBetter1
            // 
            this.radioButtonBetter1.AutoSize = true;
            this.radioButtonBetter1.Checked = true;
            this.radioButtonBetter1.Location = new System.Drawing.Point(23, 67);
            this.radioButtonBetter1.Name = "radioButtonBetter1";
            this.radioButtonBetter1.Size = new System.Drawing.Size(43, 16);
            this.radioButtonBetter1.TabIndex = 1;
            this.radioButtonBetter1.TabStop = true;
            this.radioButtonBetter1.Text = "Joe";
            this.radioButtonBetter1.UseVisualStyleBackColor = true;
            this.radioButtonBetter1.CheckedChanged += new System.EventHandler(this.radioButtonBetter1_CheckedChanged);
            // 
            // labelBets
            // 
            this.labelBets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBets.AutoSize = true;
            this.labelBets.Font = new System.Drawing.Font("Fira Code Retina", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBets.Location = new System.Drawing.Point(576, 46);
            this.labelBets.Name = "labelBets";
            this.labelBets.Size = new System.Drawing.Size(99, 15);
            this.labelBets.TabIndex = 0;
            this.labelBets.Text = "Minimum bet";
            // 
            // labelMinimumBet
            // 
            this.labelMinimumBet.AutoSize = true;
            this.labelMinimumBet.Font = new System.Drawing.Font("Fira Code Retina", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMinimumBet.Location = new System.Drawing.Point(20, 46);
            this.labelMinimumBet.Name = "labelMinimumBet";
            this.labelMinimumBet.Size = new System.Drawing.Size(99, 15);
            this.labelMinimumBet.TabIndex = 0;
            this.labelMinimumBet.Text = "Minimum bet";
            // 
            // pictureBoxDog1
            // 
            this.pictureBoxDog1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDog1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxDog1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog1.Image")));
            this.pictureBoxDog1.Location = new System.Drawing.Point(53, 23);
            this.pictureBoxDog1.Name = "pictureBoxDog1";
            this.pictureBoxDog1.Size = new System.Drawing.Size(100, 29);
            this.pictureBoxDog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDog1.TabIndex = 2;
            this.pictureBoxDog1.TabStop = false;
            // 
            // pictureBoxDog2
            // 
            this.pictureBoxDog2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDog2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxDog2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog2.Image")));
            this.pictureBoxDog2.Location = new System.Drawing.Point(53, 78);
            this.pictureBoxDog2.Name = "pictureBoxDog2";
            this.pictureBoxDog2.Size = new System.Drawing.Size(100, 29);
            this.pictureBoxDog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDog2.TabIndex = 2;
            this.pictureBoxDog2.TabStop = false;
            // 
            // pictureBoxDog3
            // 
            this.pictureBoxDog3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDog3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxDog3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog3.Image")));
            this.pictureBoxDog3.Location = new System.Drawing.Point(53, 143);
            this.pictureBoxDog3.Name = "pictureBoxDog3";
            this.pictureBoxDog3.Size = new System.Drawing.Size(100, 29);
            this.pictureBoxDog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDog3.TabIndex = 2;
            this.pictureBoxDog3.TabStop = false;
            // 
            // pictureBoxDog4
            // 
            this.pictureBoxDog4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDog4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxDog4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDog4.Image")));
            this.pictureBoxDog4.Location = new System.Drawing.Point(53, 206);
            this.pictureBoxDog4.Name = "pictureBoxDog4";
            this.pictureBoxDog4.Size = new System.Drawing.Size(100, 29);
            this.pictureBoxDog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDog4.TabIndex = 2;
            this.pictureBoxDog4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 526);
            this.Controls.Add(this.pictureBoxDog4);
            this.Controls.Add(this.pictureBoxDog3);
            this.Controls.Add(this.pictureBoxDog2);
            this.Controls.Add(this.pictureBoxDog1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.raceTrack);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "A Day at the Races";
            ((System.ComponentModel.ISupportInitialize)(this.raceTrack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDogNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDog4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox raceTrack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelInform1;
        private System.Windows.Forms.Label labelBets;
        private System.Windows.Forms.Label labelInform3;
        private System.Windows.Forms.Label labelInform2;
        private System.Windows.Forms.Label labelMinimumBet;
        private System.Windows.Forms.RadioButton radioButtonBetter3;
        private System.Windows.Forms.RadioButton radioButtonBetter2;
        private System.Windows.Forms.RadioButton radioButtonBetter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownCash;
        private System.Windows.Forms.Button buttonBets;
        private System.Windows.Forms.Label labelBetterName;
        private System.Windows.Forms.Button buttonRace;
        private System.Windows.Forms.NumericUpDown numericUpDownDogNum;
        private System.Windows.Forms.PictureBox pictureBoxDog1;
        private System.Windows.Forms.PictureBox pictureBoxDog2;
        private System.Windows.Forms.PictureBox pictureBoxDog3;
        private System.Windows.Forms.PictureBox pictureBoxDog4;
    }
}

