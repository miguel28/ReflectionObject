namespace ReflectionObject
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
            this.btnChangePropertly = new System.Windows.Forms.Button();
            this.btnCallMethod = new System.Windows.Forms.Button();
            this.btnCallJava = new System.Windows.Forms.Button();
            this.btnInject = new System.Windows.Forms.Button();
            this.webBrowser1 = new ReflectionObject.IEBrowser();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangePropertly
            // 
            this.btnChangePropertly.Location = new System.Drawing.Point(12, 12);
            this.btnChangePropertly.Name = "btnChangePropertly";
            this.btnChangePropertly.Size = new System.Drawing.Size(138, 23);
            this.btnChangePropertly.TabIndex = 0;
            this.btnChangePropertly.Text = "Change Propertly";
            this.btnChangePropertly.UseVisualStyleBackColor = true;
            this.btnChangePropertly.Click += new System.EventHandler(this.btnChangePropertly_Click);
            // 
            // btnCallMethod
            // 
            this.btnCallMethod.Location = new System.Drawing.Point(12, 41);
            this.btnCallMethod.Name = "btnCallMethod";
            this.btnCallMethod.Size = new System.Drawing.Size(138, 23);
            this.btnCallMethod.TabIndex = 1;
            this.btnCallMethod.Text = "call Method";
            this.btnCallMethod.UseVisualStyleBackColor = true;
            this.btnCallMethod.Click += new System.EventHandler(this.btnCallMethod_Click);
            // 
            // btnCallJava
            // 
            this.btnCallJava.Location = new System.Drawing.Point(185, 12);
            this.btnCallJava.Name = "btnCallJava";
            this.btnCallJava.Size = new System.Drawing.Size(106, 23);
            this.btnCallJava.TabIndex = 3;
            this.btnCallJava.Text = "Call Script";
            this.btnCallJava.UseVisualStyleBackColor = true;
            this.btnCallJava.Click += new System.EventHandler(this.btnCallJava_Click);
            // 
            // btnInject
            // 
            this.btnInject.Location = new System.Drawing.Point(185, 42);
            this.btnInject.Name = "btnInject";
            this.btnInject.Size = new System.Drawing.Size(106, 23);
            this.btnInject.TabIndex = 4;
            this.btnInject.Text = "Inject";
            this.btnInject.UseVisualStyleBackColor = true;
            this.btnInject.Click += new System.EventHandler(this.btnInject_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 70);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(873, 568);
            this.webBrowser1.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(324, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 650);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInject);
            this.Controls.Add(this.btnCallJava);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnCallMethod);
            this.Controls.Add(this.btnChangePropertly);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangePropertly;
        private System.Windows.Forms.Button btnCallMethod;
        private IEBrowser webBrowser1;
        private System.Windows.Forms.Button btnCallJava;
        private System.Windows.Forms.Button btnInject;
        private System.Windows.Forms.Button btnUpdate;
    }
}

