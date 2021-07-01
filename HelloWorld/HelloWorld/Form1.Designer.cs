
namespace HelloWorld
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
            this.btn1HelloWorld = new System.Windows.Forms.Button();
            this.btn1Click = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1HelloWorld
            // 
            this.btn1HelloWorld.Location = new System.Drawing.Point(176, 260);
            this.btn1HelloWorld.Name = "btn1HelloWorld";
            this.btn1HelloWorld.Size = new System.Drawing.Size(374, 95);
            this.btn1HelloWorld.TabIndex = 0;
            this.btn1HelloWorld.Text = "Click Here";
            this.btn1HelloWorld.UseVisualStyleBackColor = true;
            this.btn1HelloWorld.Click += new System.EventHandler(this.btn1HelloWorld_Click);
            // 
            // btn1Click
            // 
            this.btn1Click.AutoSize = true;
            this.btn1Click.Location = new System.Drawing.Point(190, 156);
            this.btn1Click.Name = "btn1Click";
            this.btn1Click.Size = new System.Drawing.Size(0, 13);
            this.btn1Click.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1Click);
            this.Controls.Add(this.btn1HelloWorld);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1HelloWorld;
        private System.Windows.Forms.Label btn1Click;
    }
}

