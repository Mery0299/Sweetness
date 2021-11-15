
namespace Sweetness
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
            this.listView = new System.Windows.Forms.ListView();
            this.label_info = new System.Windows.Forms.Label();
            this.label_count = new System.Windows.Forms.Label();
            this.button_take = new System.Windows.Forms.Button();
            this.button_refill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 43);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(205, 257);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Location = new System.Drawing.Point(267, 83);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(38, 15);
            this.label_info.TabIndex = 1;
            this.label_info.Text = "label1";
            // 
            // label_count
            // 
            this.label_count.AutoSize = true;
            this.label_count.Location = new System.Drawing.Point(12, 13);
            this.label_count.Name = "label_count";
            this.label_count.Size = new System.Drawing.Size(38, 15);
            this.label_count.TabIndex = 2;
            this.label_count.Text = "label2";
            // 
            // button_take
            // 
            this.button_take.Location = new System.Drawing.Point(323, 43);
            this.button_take.Name = "button_take";
            this.button_take.Size = new System.Drawing.Size(75, 23);
            this.button_take.TabIndex = 3;
            this.button_take.Text = "button1";
            this.button_take.UseVisualStyleBackColor = true;
            // 
            // button_refill
            // 
            this.button_refill.Location = new System.Drawing.Point(363, 9);
            this.button_refill.Name = "button_refill";
            this.button_refill.Size = new System.Drawing.Size(119, 23);
            this.button_refill.TabIndex = 4;
            this.button_refill.Text = "button2";
            this.button_refill.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 312);
            this.Controls.Add(this.button_refill);
            this.Controls.Add(this.button_take);
            this.Controls.Add(this.label_count);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Автомат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_count;
        private System.Windows.Forms.Button button_take;
        private System.Windows.Forms.Button button_refill;
    }
}
