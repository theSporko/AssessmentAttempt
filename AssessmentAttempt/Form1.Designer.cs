namespace AssessmentAttempt
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
            btnFileSelect = new Button();
            txtboxResult = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // btnFileSelect
            // 
            btnFileSelect.Location = new Point(388, 145);
            btnFileSelect.Name = "btnFileSelect";
            btnFileSelect.Size = new Size(75, 23);
            btnFileSelect.TabIndex = 0;
            btnFileSelect.Text = "Select";
            btnFileSelect.UseVisualStyleBackColor = true;
            btnFileSelect.Click += btnFileSelect_Click;
            // 
            // txtboxResult
            // 
            txtboxResult.Location = new Point(388, 174);
            txtboxResult.Name = "txtboxResult";
            txtboxResult.Size = new Size(100, 23);
            txtboxResult.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 149);
            label1.Name = "label1";
            label1.Size = new Size(136, 15);
            label1.TabIndex = 2;
            label1.Text = "Click to Select a CSV file:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 177);
            label2.Name = "label2";
            label2.Size = new Size(203, 15);
            label2.TabIndex = 3;
            label2.Text = "Sum of the last 10 digits of every line:";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(372, 335);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(10, 8);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtboxResult);
            Controls.Add(btnFileSelect);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFileSelect;
        private TextBox txtboxResult;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
    }
}
