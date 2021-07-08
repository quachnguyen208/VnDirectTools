namespace IntegrationEndPoint
{
    partial class frmRequestFinance
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lbURL = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lbToken = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lbYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.ckhWrite = new System.Windows.Forms.CheckBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbResultGrid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSymbolGrid = new System.Windows.Forms.TextBox();
            this.bntGet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(323, 39);
            this.btnPost.Margin = new System.Windows.Forms.Padding(2);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(112, 58);
            this.btnPost.TabIndex = 0;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(59, 39);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(247, 20);
            this.txtURL.TabIndex = 1;
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(12, 42);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(29, 13);
            this.lbURL.TabIndex = 11;
            this.lbURL.Text = "URL";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(56, 200);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(37, 13);
            this.lbResult.TabIndex = 13;
            this.lbResult.Text = "Result";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(59, 168);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(376, 20);
            this.txtResult.TabIndex = 12;
            this.txtResult.Text = "Result Right Here!";
            // 
            // lbToken
            // 
            this.lbToken.AutoSize = true;
            this.lbToken.Location = new System.Drawing.Point(12, 120);
            this.lbToken.Name = "lbToken";
            this.lbToken.Size = new System.Drawing.Size(38, 13);
            this.lbToken.TabIndex = 15;
            this.lbToken.Text = "Token";
            // 
            // txtToken
            // 
            this.txtToken.Location = new System.Drawing.Point(59, 117);
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(247, 20);
            this.txtToken.TabIndex = 4;
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(12, 94);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(29, 13);
            this.lbYear.TabIndex = 17;
            this.lbYear.Text = "Year";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(59, 91);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(247, 20);
            this.txtYear.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Symbol";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(59, 65);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(247, 20);
            this.txtSymbol.TabIndex = 2;
            // 
            // ckhWrite
            // 
            this.ckhWrite.AutoSize = true;
            this.ckhWrite.Location = new System.Drawing.Point(323, 120);
            this.ckhWrite.Name = "ckhWrite";
            this.ckhWrite.Size = new System.Drawing.Size(85, 17);
            this.ckhWrite.TabIndex = 5;
            this.ckhWrite.Text = "Write To DB";
            this.ckhWrite.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ckhWrite.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(56, 152);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 21;
            this.lbStatus.Text = "Status!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(746, 222);
            this.dataGridView1.TabIndex = 22;
            // 
            // lbResultGrid
            // 
            this.lbResultGrid.AutoSize = true;
            this.lbResultGrid.Location = new System.Drawing.Point(56, 237);
            this.lbResultGrid.Name = "lbResultGrid";
            this.lbResultGrid.Size = new System.Drawing.Size(59, 13);
            this.lbResultGrid.TabIndex = 23;
            this.lbResultGrid.Text = "Result Grid";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Symbol";
            // 
            // txtSymbolGrid
            // 
            this.txtSymbolGrid.Location = new System.Drawing.Point(511, 39);
            this.txtSymbolGrid.Name = "txtSymbolGrid";
            this.txtSymbolGrid.Size = new System.Drawing.Size(247, 20);
            this.txtSymbolGrid.TabIndex = 25;
            // 
            // bntGet
            // 
            this.bntGet.Location = new System.Drawing.Point(511, 64);
            this.bntGet.Margin = new System.Windows.Forms.Padding(2);
            this.bntGet.Name = "bntGet";
            this.bntGet.Size = new System.Drawing.Size(247, 20);
            this.bntGet.TabIndex = 24;
            this.bntGet.Text = "GET";
            this.bntGet.UseVisualStyleBackColor = true;
            this.bntGet.Click += new System.EventHandler(this.bntGet_Click);
            // 
            // frmRequestFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(773, 499);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSymbolGrid);
            this.Controls.Add(this.bntGet);
            this.Controls.Add(this.lbResultGrid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.ckhWrite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lbToken);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnPost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmRequestFinance";
            this.Text = "RequestFinance";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lbToken;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.CheckBox ckhWrite;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbResultGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSymbolGrid;
        private System.Windows.Forms.Button bntGet;
    }
}