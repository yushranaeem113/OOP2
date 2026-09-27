
namespace StudyManagement
{
    partial class AssessmentForm
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
            this.AsName = new System.Windows.Forms.Label();
            this.fullmark = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assessment Type";
            // 
            // AsName
            // 
            this.AsName.AutoSize = true;
            this.AsName.BackColor = System.Drawing.Color.Transparent;
            this.AsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsName.ForeColor = System.Drawing.Color.White;
            this.AsName.Location = new System.Drawing.Point(169, 169);
            this.AsName.Name = "AsName";
            this.AsName.Size = new System.Drawing.Size(86, 31);
            this.AsName.TabIndex = 1;
            this.AsName.Text = "Name";
            this.AsName.Click += new System.EventHandler(this.label2_Click);
            // 
            // fullmark
            // 
            this.fullmark.AutoSize = true;
            this.fullmark.BackColor = System.Drawing.Color.Transparent;
            this.fullmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullmark.ForeColor = System.Drawing.Color.White;
            this.fullmark.Location = new System.Drawing.Point(169, 231);
            this.fullmark.Name = "fullmark";
            this.fullmark.Size = new System.Drawing.Size(125, 31);
            this.fullmark.TabIndex = 2;
            this.fullmark.Text = "Full Mark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(169, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Achieved Mark";
            // 
            // AssessmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudyManagement.Properties.Resources.Black_Whute_Minimalist_Desktop_Wallpaper__3_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullmark);
            this.Controls.Add(this.AsName);
            this.Controls.Add(this.label1);
            this.Name = "AssessmentForm";
            this.Text = "Assessment Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AsName;
        private System.Windows.Forms.Label fullmark;
        private System.Windows.Forms.Label label2;
    }
}