
namespace Project_Listening.Frontend.UserControls
{
    partial class UserControlAddRap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxHasMelody = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxHasMelody
            // 
            this.checkBoxHasMelody.AutoSize = true;
            this.checkBoxHasMelody.Font = new System.Drawing.Font("Levenim MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkBoxHasMelody.Location = new System.Drawing.Point(28, 26);
            this.checkBoxHasMelody.Name = "checkBoxHasMelody";
            this.checkBoxHasMelody.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxHasMelody.Size = new System.Drawing.Size(130, 26);
            this.checkBoxHasMelody.TabIndex = 0;
            this.checkBoxHasMelody.Text = "Has Melody";
            this.checkBoxHasMelody.UseVisualStyleBackColor = true;
            // 
            // UserControlAddRap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxHasMelody);
            this.Name = "UserControlAddRap";
            this.Size = new System.Drawing.Size(259, 121);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxHasMelody;
    }
}
