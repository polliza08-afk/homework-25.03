namespace Домашня_робота_25._03
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
            listView1 = new ListView();
            label1 = new Label();
            richTextBoxPath = new RichTextBox();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 76);
            listView1.Name = "listView1";
            listView1.Size = new Size(648, 311);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 21);
            label1.TabIndex = 1;
            label1.Text = "шлях до файлу";
            // 
            // richTextBoxPath
            // 
            richTextBoxPath.Location = new Point(12, 37);
            richTextBoxPath.Name = "richTextBoxPath";
            richTextBoxPath.Size = new Size(533, 33);
            richTextBoxPath.TabIndex = 2;
            richTextBoxPath.Text = "";
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnLoad.ForeColor = Color.Blue;
            btnLoad.Location = new Point(566, 9);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 59);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Показати вміст";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 400);
            Controls.Add(btnLoad);
            Controls.Add(richTextBoxPath);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private RichTextBox richTextBoxPath;
        private Button btnLoad;
    }
}
