namespace IntegrationEndPoint
{
    partial class frmIntergrationEndPoint
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
            this.btnPost = new System.Windows.Forms.Button();
            this.txtValue1 = new System.Windows.Forms.TextBox();
            this.txtValue2 = new System.Windows.Forms.TextBox();
            this.txtValue3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkCustomer = new System.Windows.Forms.CheckBox();
            this.chkSalesOrderDetail = new System.Windows.Forms.CheckBox();
            this.chkSalesOrder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(413, 65);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(149, 78);
            this.btnPost.TabIndex = 0;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(155, 65);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(252, 22);
            this.txtValue1.TabIndex = 1;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(155, 93);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(252, 22);
            this.txtValue2.TabIndex = 2;
            // 
            // txtValue3
            // 
            this.txtValue3.Location = new System.Drawing.Point(155, 121);
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.Size = new System.Drawing.Size(252, 22);
            this.txtValue3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Value 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Value 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Value 3";
            // 
            // chkCustomer
            // 
            this.chkCustomer.AutoSize = true;
            this.chkCustomer.Location = new System.Drawing.Point(155, 38);
            this.chkCustomer.Name = "chkCustomer";
            this.chkCustomer.Size = new System.Drawing.Size(90, 21);
            this.chkCustomer.TabIndex = 7;
            this.chkCustomer.Text = "Customer";
            this.chkCustomer.UseVisualStyleBackColor = true;
            // 
            // chkSalesOrderDetail
            // 
            this.chkSalesOrderDetail.AutoSize = true;
            this.chkSalesOrderDetail.Location = new System.Drawing.Point(413, 38);
            this.chkSalesOrderDetail.Name = "chkSalesOrderDetail";
            this.chkSalesOrderDetail.Size = new System.Drawing.Size(146, 21);
            this.chkSalesOrderDetail.TabIndex = 8;
            this.chkSalesOrderDetail.Text = "Sales Order Detail";
            this.chkSalesOrderDetail.UseVisualStyleBackColor = true;
            // 
            // chkSalesOrder
            // 
            this.chkSalesOrder.AutoSize = true;
            this.chkSalesOrder.Location = new System.Drawing.Point(301, 38);
            this.chkSalesOrder.Name = "chkSalesOrder";
            this.chkSalesOrder.Size = new System.Drawing.Size(106, 21);
            this.chkSalesOrder.TabIndex = 9;
            this.chkSalesOrder.Text = "Sales Order";
            this.chkSalesOrder.UseVisualStyleBackColor = true;
            // 
            // frmIntergrationEndPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkSalesOrder);
            this.Controls.Add(this.chkSalesOrderDetail);
            this.Controls.Add(this.chkCustomer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue3);
            this.Controls.Add(this.txtValue2);
            this.Controls.Add(this.txtValue1);
            this.Controls.Add(this.btnPost);
            this.Name = "frmIntergrationEndPoint";
            this.Text = "frmIntergrationEndPoint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtValue1;
        private System.Windows.Forms.TextBox txtValue2;
        private System.Windows.Forms.TextBox txtValue3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkCustomer;
        private System.Windows.Forms.CheckBox chkSalesOrderDetail;
        private System.Windows.Forms.CheckBox chkSalesOrder;
    }
}