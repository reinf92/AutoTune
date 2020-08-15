namespace AutoTune
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.iMapper = new System.Windows.Forms.PictureBox();
            this.ItemCountText = new System.Windows.Forms.Label();
            this.ItemsCountSetting = new System.Windows.Forms.NumericUpDown();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.InventoryHeader = new System.Windows.Forms.Label();
            this.FailuresHeader = new System.Windows.Forms.Label();
            this.lb_Item3 = new System.Windows.Forms.Label();
            this.lb_Item5 = new System.Windows.Forms.Label();
            this.lb_Item7 = new System.Windows.Forms.Label();
            this.lb_Item8 = new System.Windows.Forms.Label();
            this.lb_Item6 = new System.Windows.Forms.Label();
            this.lb_Item4 = new System.Windows.Forms.Label();
            this.lb_Item2 = new System.Windows.Forms.Label();
            this.lb_Failure1 = new System.Windows.Forms.Label();
            this.lb_Failure2 = new System.Windows.Forms.Label();
            this.lb_Failure3 = new System.Windows.Forms.Label();
            this.lb_Failure4 = new System.Windows.Forms.Label();
            this.lb_Failure5 = new System.Windows.Forms.Label();
            this.lb_Failure6 = new System.Windows.Forms.Label();
            this.lb_Item1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iMapper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsCountSetting)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(14, 8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(238, 24);
            this.Title.TabIndex = 0;
            this.Title.Text = "AstroN Auto Tune Program";
            // 
            // iMapper
            // 
            this.iMapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.iMapper.ErrorImage = ((System.Drawing.Image)(resources.GetObject("iMapper.ErrorImage")));
            this.iMapper.Location = new System.Drawing.Point(19, 47);
            this.iMapper.Name = "iMapper";
            this.iMapper.Size = new System.Drawing.Size(230, 80);
            this.iMapper.TabIndex = 1;
            this.iMapper.TabStop = false;
            // 
            // ItemCountText
            // 
            this.ItemCountText.AutoSize = true;
            this.ItemCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCountText.Location = new System.Drawing.Point(15, 149);
            this.ItemCountText.Name = "ItemCountText";
            this.ItemCountText.Size = new System.Drawing.Size(147, 16);
            this.ItemCountText.TabIndex = 3;
            this.ItemCountText.Text = "Stop when num of items";
            // 
            // ItemsCountSetting
            // 
            this.ItemsCountSetting.Location = new System.Drawing.Point(176, 147);
            this.ItemsCountSetting.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.ItemsCountSetting.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ItemsCountSetting.Name = "ItemsCountSetting";
            this.ItemsCountSetting.Size = new System.Drawing.Size(76, 21);
            this.ItemsCountSetting.TabIndex = 4;
            this.ItemsCountSetting.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(361, 146);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(71, 21);
            this.btn_Start.TabIndex = 9;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Location = new System.Drawing.Point(283, 146);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(71, 21);
            this.btn_Stop.TabIndex = 10;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // InventoryHeader
            // 
            this.InventoryHeader.AutoSize = true;
            this.InventoryHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.InventoryHeader.Location = new System.Drawing.Point(280, 14);
            this.InventoryHeader.Name = "InventoryHeader";
            this.InventoryHeader.Size = new System.Drawing.Size(75, 17);
            this.InventoryHeader.TabIndex = 11;
            this.InventoryHeader.Text = "Inventory";
            // 
            // FailuresHeader
            // 
            this.FailuresHeader.AutoSize = true;
            this.FailuresHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.FailuresHeader.Location = new System.Drawing.Point(363, 15);
            this.FailuresHeader.Name = "FailuresHeader";
            this.FailuresHeader.Size = new System.Drawing.Size(66, 17);
            this.FailuresHeader.TabIndex = 12;
            this.FailuresHeader.Text = "Failures";
            // 
            // lb_Item3
            // 
            this.lb_Item3.AutoSize = true;
            this.lb_Item3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Item3.ForeColor = System.Drawing.Color.Green;
            this.lb_Item3.Location = new System.Drawing.Point(265, 65);
            this.lb_Item3.Name = "lb_Item3";
            this.lb_Item3.Size = new System.Drawing.Size(47, 13);
            this.lb_Item3.TabIndex = 14;
            this.lb_Item3.Text = "0 (100)";
            // 
            // lb_Item5
            // 
            this.lb_Item5.AutoSize = true;
            this.lb_Item5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Item5.ForeColor = System.Drawing.Color.Green;
            this.lb_Item5.Location = new System.Drawing.Point(265, 84);
            this.lb_Item5.Name = "lb_Item5";
            this.lb_Item5.Size = new System.Drawing.Size(47, 13);
            this.lb_Item5.TabIndex = 15;
            this.lb_Item5.Text = "0 (100)";
            // 
            // lb_Item7
            // 
            this.lb_Item7.AutoSize = true;
            this.lb_Item7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Item7.ForeColor = System.Drawing.Color.Green;
            this.lb_Item7.Location = new System.Drawing.Point(265, 104);
            this.lb_Item7.Name = "lb_Item7";
            this.lb_Item7.Size = new System.Drawing.Size(47, 13);
            this.lb_Item7.TabIndex = 16;
            this.lb_Item7.Text = "0 (100)";
            // 
            // lb_Item8
            // 
            this.lb_Item8.AutoSize = true;
            this.lb_Item8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Item8.ForeColor = System.Drawing.Color.Green;
            this.lb_Item8.Location = new System.Drawing.Point(312, 104);
            this.lb_Item8.Name = "lb_Item8";
            this.lb_Item8.Size = new System.Drawing.Size(47, 13);
            this.lb_Item8.TabIndex = 20;
            this.lb_Item8.Text = "0 (100)";
            // 
            // lb_Item6
            // 
            this.lb_Item6.AutoSize = true;
            this.lb_Item6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Item6.ForeColor = System.Drawing.Color.Green;
            this.lb_Item6.Location = new System.Drawing.Point(312, 84);
            this.lb_Item6.Name = "lb_Item6";
            this.lb_Item6.Size = new System.Drawing.Size(47, 13);
            this.lb_Item6.TabIndex = 19;
            this.lb_Item6.Text = "0 (100)";
            // 
            // lb_Item4
            // 
            this.lb_Item4.AutoSize = true;
            this.lb_Item4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Item4.ForeColor = System.Drawing.Color.Green;
            this.lb_Item4.Location = new System.Drawing.Point(312, 65);
            this.lb_Item4.Name = "lb_Item4";
            this.lb_Item4.Size = new System.Drawing.Size(47, 13);
            this.lb_Item4.TabIndex = 18;
            this.lb_Item4.Text = "0 (100)";
            // 
            // lb_Item2
            // 
            this.lb_Item2.AutoSize = true;
            this.lb_Item2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Item2.ForeColor = System.Drawing.Color.Green;
            this.lb_Item2.Location = new System.Drawing.Point(312, 45);
            this.lb_Item2.Name = "lb_Item2";
            this.lb_Item2.Size = new System.Drawing.Size(47, 13);
            this.lb_Item2.TabIndex = 17;
            this.lb_Item2.Text = "0 (100)";
            // 
            // lb_Failure1
            // 
            this.lb_Failure1.AutoSize = true;
            this.lb_Failure1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Failure1.ForeColor = System.Drawing.Color.Red;
            this.lb_Failure1.Location = new System.Drawing.Point(374, 38);
            this.lb_Failure1.Name = "lb_Failure1";
            this.lb_Failure1.Size = new System.Drawing.Size(41, 13);
            this.lb_Failure1.TabIndex = 21;
            this.lb_Failure1.Text = "V1 - 0";
            // 
            // lb_Failure2
            // 
            this.lb_Failure2.AutoSize = true;
            this.lb_Failure2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Failure2.ForeColor = System.Drawing.Color.Red;
            this.lb_Failure2.Location = new System.Drawing.Point(374, 55);
            this.lb_Failure2.Name = "lb_Failure2";
            this.lb_Failure2.Size = new System.Drawing.Size(41, 13);
            this.lb_Failure2.TabIndex = 22;
            this.lb_Failure2.Text = "V2 - 0";
            // 
            // lb_Failure3
            // 
            this.lb_Failure3.AutoSize = true;
            this.lb_Failure3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Failure3.ForeColor = System.Drawing.Color.Red;
            this.lb_Failure3.Location = new System.Drawing.Point(374, 72);
            this.lb_Failure3.Name = "lb_Failure3";
            this.lb_Failure3.Size = new System.Drawing.Size(41, 13);
            this.lb_Failure3.TabIndex = 23;
            this.lb_Failure3.Text = "V3 - 0";
            // 
            // lb_Failure4
            // 
            this.lb_Failure4.AutoSize = true;
            this.lb_Failure4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Failure4.ForeColor = System.Drawing.Color.Red;
            this.lb_Failure4.Location = new System.Drawing.Point(374, 88);
            this.lb_Failure4.Name = "lb_Failure4";
            this.lb_Failure4.Size = new System.Drawing.Size(41, 13);
            this.lb_Failure4.TabIndex = 24;
            this.lb_Failure4.Text = "V4 - 0";
            // 
            // lb_Failure5
            // 
            this.lb_Failure5.AutoSize = true;
            this.lb_Failure5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Failure5.ForeColor = System.Drawing.Color.Red;
            this.lb_Failure5.Location = new System.Drawing.Point(374, 105);
            this.lb_Failure5.Name = "lb_Failure5";
            this.lb_Failure5.Size = new System.Drawing.Size(41, 13);
            this.lb_Failure5.TabIndex = 25;
            this.lb_Failure5.Text = "V5 - 0";
            // 
            // lb_Failure6
            // 
            this.lb_Failure6.AutoSize = true;
            this.lb_Failure6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Failure6.ForeColor = System.Drawing.Color.Red;
            this.lb_Failure6.Location = new System.Drawing.Point(374, 122);
            this.lb_Failure6.Name = "lb_Failure6";
            this.lb_Failure6.Size = new System.Drawing.Size(41, 13);
            this.lb_Failure6.TabIndex = 26;
            this.lb_Failure6.Text = "V6 - 0";
            // 
            // lb_Item1
            // 
            this.lb_Item1.AutoSize = true;
            this.lb_Item1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Item1.ForeColor = System.Drawing.Color.Green;
            this.lb_Item1.Location = new System.Drawing.Point(265, 45);
            this.lb_Item1.Name = "lb_Item1";
            this.lb_Item1.Size = new System.Drawing.Size(47, 13);
            this.lb_Item1.TabIndex = 13;
            this.lb_Item1.Text = "0 (100)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 179);
            this.Controls.Add(this.lb_Failure6);
            this.Controls.Add(this.lb_Failure5);
            this.Controls.Add(this.lb_Failure4);
            this.Controls.Add(this.lb_Failure3);
            this.Controls.Add(this.lb_Failure2);
            this.Controls.Add(this.lb_Failure1);
            this.Controls.Add(this.lb_Item8);
            this.Controls.Add(this.lb_Item6);
            this.Controls.Add(this.lb_Item4);
            this.Controls.Add(this.lb_Item2);
            this.Controls.Add(this.lb_Item7);
            this.Controls.Add(this.lb_Item5);
            this.Controls.Add(this.lb_Item3);
            this.Controls.Add(this.lb_Item1);
            this.Controls.Add(this.FailuresHeader);
            this.Controls.Add(this.InventoryHeader);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.ItemsCountSetting);
            this.Controls.Add(this.ItemCountText);
            this.Controls.Add(this.iMapper);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AutoTune";
            ((System.ComponentModel.ISupportInitialize)(this.iMapper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsCountSetting)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox iMapper;
        private System.Windows.Forms.Label ItemCountText;
        private System.Windows.Forms.NumericUpDown ItemsCountSetting;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label InventoryHeader;
        private System.Windows.Forms.Label FailuresHeader;
        private System.Windows.Forms.Label lb_Item3;
        private System.Windows.Forms.Label lb_Item5;
        private System.Windows.Forms.Label lb_Item7;
        private System.Windows.Forms.Label lb_Item8;
        private System.Windows.Forms.Label lb_Item6;
        private System.Windows.Forms.Label lb_Item4;
        private System.Windows.Forms.Label lb_Item2;
        private System.Windows.Forms.Label lb_Failure1;
        private System.Windows.Forms.Label lb_Failure2;
        private System.Windows.Forms.Label lb_Failure3;
        private System.Windows.Forms.Label lb_Failure4;
        private System.Windows.Forms.Label lb_Failure5;
        private System.Windows.Forms.Label lb_Failure6;
        private System.Windows.Forms.Label lb_Item1;
    }
}

