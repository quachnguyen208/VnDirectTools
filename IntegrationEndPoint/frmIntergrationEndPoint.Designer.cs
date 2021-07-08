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
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.lbRequest = new System.Windows.Forms.Label();
            this.txtFromDate = new System.Windows.Forms.TextBox();
            this.txtToDate = new System.Windows.Forms.TextBox();
            this.lbToDate = new System.Windows.Forms.Label();
            this.lbFromDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(311, 76);
            this.btnPost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(112, 114);
            this.btnPost.TabIndex = 0;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtValue1
            // 
            this.txtValue1.Location = new System.Drawing.Point(116, 53);
            this.txtValue1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValue1.Name = "txtValue1";
            this.txtValue1.Size = new System.Drawing.Size(190, 20);
            this.txtValue1.TabIndex = 1;
            // 
            // txtValue2
            // 
            this.txtValue2.Location = new System.Drawing.Point(116, 76);
            this.txtValue2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValue2.Name = "txtValue2";
            this.txtValue2.Size = new System.Drawing.Size(190, 20);
            this.txtValue2.TabIndex = 2;
            // 
            // txtValue3
            // 
            this.txtValue3.Location = new System.Drawing.Point(116, 98);
            this.txtValue3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtValue3.Name = "txtValue3";
            this.txtValue3.Size = new System.Drawing.Size(190, 20);
            this.txtValue3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Value 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Value 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Value 3";
            // 
            // chkCustomer
            // 
            this.chkCustomer.AutoSize = true;
            this.chkCustomer.Location = new System.Drawing.Point(116, 31);
            this.chkCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkCustomer.Name = "chkCustomer";
            this.chkCustomer.Size = new System.Drawing.Size(70, 17);
            this.chkCustomer.TabIndex = 7;
            this.chkCustomer.Text = "Customer";
            this.chkCustomer.UseVisualStyleBackColor = true;
            // 
            // chkSalesOrderDetail
            // 
            this.chkSalesOrderDetail.AutoSize = true;
            this.chkSalesOrderDetail.Location = new System.Drawing.Point(310, 31);
            this.chkSalesOrderDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSalesOrderDetail.Name = "chkSalesOrderDetail";
            this.chkSalesOrderDetail.Size = new System.Drawing.Size(111, 17);
            this.chkSalesOrderDetail.TabIndex = 8;
            this.chkSalesOrderDetail.Text = "Sales Order Detail";
            this.chkSalesOrderDetail.UseVisualStyleBackColor = true;
            // 
            // chkSalesOrder
            // 
            this.chkSalesOrder.AutoSize = true;
            this.chkSalesOrder.Location = new System.Drawing.Point(226, 31);
            this.chkSalesOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSalesOrder.Name = "chkSalesOrder";
            this.chkSalesOrder.Size = new System.Drawing.Size(81, 17);
            this.chkSalesOrder.TabIndex = 9;
            this.chkSalesOrder.Text = "Sales Order";
            this.chkSalesOrder.UseVisualStyleBackColor = true;
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(116, 145);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(190, 20);
            this.txtSymbol.TabIndex = 10;
            // 
            // lbRequest
            // 
            this.lbRequest.AutoSize = true;
            this.lbRequest.Location = new System.Drawing.Point(49, 148);
            this.lbRequest.Name = "lbRequest";
            this.lbRequest.Size = new System.Drawing.Size(41, 13);
            this.lbRequest.TabIndex = 11;
            this.lbRequest.Text = "Symbol";
            // 
            // txtFromDate
            // 
            this.txtFromDate.Location = new System.Drawing.Point(116, 171);
            this.txtFromDate.Name = "txtFromDate";
            this.txtFromDate.Size = new System.Drawing.Size(190, 20);
            this.txtFromDate.TabIndex = 12;
            // 
            // txtToDate
            // 
            this.txtToDate.Location = new System.Drawing.Point(116, 197);
            this.txtToDate.Name = "txtToDate";
            this.txtToDate.Size = new System.Drawing.Size(190, 20);
            this.txtToDate.TabIndex = 13;
            // 
            // lbToDate
            // 
            this.lbToDate.AutoSize = true;
            this.lbToDate.Location = new System.Drawing.Point(49, 204);
            this.lbToDate.Name = "lbToDate";
            this.lbToDate.Size = new System.Drawing.Size(46, 13);
            this.lbToDate.TabIndex = 14;
            this.lbToDate.Text = "To Date";
            // 
            // lbFromDate
            // 
            this.lbFromDate.AutoSize = true;
            this.lbFromDate.Location = new System.Drawing.Point(49, 177);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(56, 13);
            this.lbFromDate.TabIndex = 15;
            this.lbFromDate.Text = "From Date";
            // 
            // frmIntergrationEndPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lbFromDate);
            this.Controls.Add(this.lbToDate);
            this.Controls.Add(this.txtToDate);
            this.Controls.Add(this.txtFromDate);
            this.Controls.Add(this.lbRequest);
            this.Controls.Add(this.txtSymbol);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label lbRequest;
        private System.Windows.Forms.TextBox txtFromDate;
        private System.Windows.Forms.TextBox txtToDate;
        private System.Windows.Forms.Label lbToDate;
        private System.Windows.Forms.Label lbFromDate;
    }
}