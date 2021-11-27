
namespace Calculator
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
            this.bt = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt
            // 
            this.bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt.Location = new System.Drawing.Point(288, 289);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(137, 39);
            this.bt.TabIndex = 0;
            this.bt.Text = "Kết quả";
            this.bt.UseVisualStyleBackColor = true;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(50, 109);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(73, 31);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Số a";
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb1.Location = new System.Drawing.Point(142, 102);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(137, 38);
            this.tb1.TabIndex = 2;
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb2.Location = new System.Drawing.Point(142, 166);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(137, 38);
            this.tb2.TabIndex = 4;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(50, 173);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(73, 31);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "Số a";
            // 
            // tb3
            // 
            this.tb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb3.Location = new System.Drawing.Point(142, 231);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(137, 38);
            this.tb3.TabIndex = 6;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(50, 238);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(73, 31);
            this.lb3.TabIndex = 5;
            this.lb3.Text = "Số a";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(159, 43);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(152, 31);
            this.lb.TabIndex = 7;
            this.lb.Text = "Phép cộng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 351);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.bt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb;
    }
}

