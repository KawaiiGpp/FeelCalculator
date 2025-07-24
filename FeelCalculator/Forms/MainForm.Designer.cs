namespace FeelCalculator.Forms
{
    partial class MainForm
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
            gbInput = new GroupBox();
            lblWindSpeed = new Label();
            txtWindSpeed = new TextBox();
            lblHumidity = new Label();
            txtHumidity = new TextBox();
            txtTemp = new TextBox();
            lblTemp = new Label();
            gbOutput = new GroupBox();
            lblResult = new Label();
            gbInput.SuspendLayout();
            gbOutput.SuspendLayout();
            SuspendLayout();
            // 
            // gbInput
            // 
            gbInput.Controls.Add(lblWindSpeed);
            gbInput.Controls.Add(txtWindSpeed);
            gbInput.Controls.Add(lblHumidity);
            gbInput.Controls.Add(txtHumidity);
            gbInput.Controls.Add(txtTemp);
            gbInput.Controls.Add(lblTemp);
            gbInput.Location = new Point(29, 29);
            gbInput.Name = "gbInput";
            gbInput.Size = new Size(345, 182);
            gbInput.TabIndex = 0;
            gbInput.TabStop = false;
            gbInput.Text = "输入";
            // 
            // lblWindSpeed
            // 
            lblWindSpeed.Location = new Point(30, 117);
            lblWindSpeed.Name = "lblWindSpeed";
            lblWindSpeed.Size = new Size(100, 31);
            lblWindSpeed.TabIndex = 5;
            lblWindSpeed.Text = "风速(m/s)";
            lblWindSpeed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtWindSpeed
            // 
            txtWindSpeed.Font = new Font("Tahoma", 14.25F);
            txtWindSpeed.Location = new Point(148, 120);
            txtWindSpeed.Name = "txtWindSpeed";
            txtWindSpeed.Size = new Size(162, 30);
            txtWindSpeed.TabIndex = 4;
            txtWindSpeed.Text = "0";
            txtWindSpeed.TextAlign = HorizontalAlignment.Center;
            txtWindSpeed.TextChanged += txtWindSpeed_TextChanged;
            txtWindSpeed.KeyDown += HandleKey;
            // 
            // lblHumidity
            // 
            lblHumidity.Location = new Point(30, 79);
            lblHumidity.Name = "lblHumidity";
            lblHumidity.Size = new Size(100, 31);
            lblHumidity.TabIndex = 3;
            lblHumidity.Text = "湿度(%)";
            lblHumidity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtHumidity
            // 
            txtHumidity.Font = new Font("Tahoma", 14.25F);
            txtHumidity.Location = new Point(148, 82);
            txtHumidity.Name = "txtHumidity";
            txtHumidity.Size = new Size(162, 30);
            txtHumidity.TabIndex = 2;
            txtHumidity.Text = "60";
            txtHumidity.TextAlign = HorizontalAlignment.Center;
            txtHumidity.TextChanged += txtHumidity_TextChanged;
            txtHumidity.KeyDown += HandleKey;
            // 
            // txtTemp
            // 
            txtTemp.Font = new Font("Tahoma", 14.25F);
            txtTemp.Location = new Point(148, 44);
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(162, 30);
            txtTemp.TabIndex = 1;
            txtTemp.TextAlign = HorizontalAlignment.Center;
            txtTemp.TextChanged += txtTemp_TextChanged;
            txtTemp.KeyDown += HandleKey;
            // 
            // lblTemp
            // 
            lblTemp.Location = new Point(30, 41);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(100, 31);
            lblTemp.TabIndex = 0;
            lblTemp.Text = "气温(℃)";
            lblTemp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbOutput
            // 
            gbOutput.Controls.Add(lblResult);
            gbOutput.Location = new Point(29, 238);
            gbOutput.Name = "gbOutput";
            gbOutput.Size = new Size(345, 101);
            gbOutput.TabIndex = 1;
            gbOutput.TabStop = false;
            gbOutput.Text = "输出";
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(6, 43);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(333, 31);
            lblResult.TabIndex = 8;
            lblResult.Text = "--";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 377);
            Controls.Add(gbOutput);
            Controls.Add(gbInput);
            Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 134);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "体感温度计算器";
            gbInput.ResumeLayout(false);
            gbInput.PerformLayout();
            gbOutput.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbInput;
        private Label lblWindSpeed;
        private TextBox txtWindSpeed;
        private Label lblHumidity;
        private TextBox txtHumidity;
        private TextBox txtTemp;
        private Label lblTemp;
        private GroupBox gbOutput;
        private Label lblResult;
    }
}
