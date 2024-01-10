namespace ProduceStore
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.exitButton = new System.Windows.Forms.Button();
			this.ordersButton = new System.Windows.Forms.Button();
			this.storeButton = new System.Windows.Forms.Button();
			this.produceGridView = new System.Windows.Forms.DataGridView();
			this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productAvailability = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buyButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.produceGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.exitButton);
			this.panel1.Controls.Add(this.ordersButton);
			this.panel1.Controls.Add(this.storeButton);
			this.panel1.Location = new System.Drawing.Point(-3, -5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(152, 305);
			this.panel1.TabIndex = 0;
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(3, 158);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(149, 37);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "Exit";
			this.exitButton.UseVisualStyleBackColor = true;
			// 
			// ordersButton
			// 
			this.ordersButton.Location = new System.Drawing.Point(3, 115);
			this.ordersButton.Name = "ordersButton";
			this.ordersButton.Size = new System.Drawing.Size(149, 37);
			this.ordersButton.TabIndex = 1;
			this.ordersButton.Text = "Orders";
			this.ordersButton.UseVisualStyleBackColor = true;
			this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
			// 
			// storeButton
			// 
			this.storeButton.Location = new System.Drawing.Point(3, 72);
			this.storeButton.Name = "storeButton";
			this.storeButton.Size = new System.Drawing.Size(149, 37);
			this.storeButton.TabIndex = 0;
			this.storeButton.Text = "Store";
			this.storeButton.UseVisualStyleBackColor = true;
			this.storeButton.Click += new System.EventHandler(this.storeButton_Click);
			// 
			// produceGridView
			// 
			this.produceGridView.AllowUserToAddRows = false;
			this.produceGridView.AllowUserToDeleteRows = false;
			this.produceGridView.AllowUserToResizeColumns = false;
			this.produceGridView.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.produceGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.produceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.produceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product,
            this.productAmount,
            this.productPrice,
            this.productAvailability});
			this.produceGridView.Location = new System.Drawing.Point(276, 57);
			this.produceGridView.Name = "produceGridView";
			this.produceGridView.ReadOnly = true;
			this.produceGridView.RowHeadersVisible = false;
			this.produceGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.produceGridView.Size = new System.Drawing.Size(404, 150);
			this.produceGridView.TabIndex = 1;
			// 
			// product
			// 
			this.product.HeaderText = "Product";
			this.product.Name = "product";
			this.product.ReadOnly = true;
			// 
			// productAmount
			// 
			this.productAmount.HeaderText = "Amount";
			this.productAmount.Name = "productAmount";
			this.productAmount.ReadOnly = true;
			// 
			// productPrice
			// 
			this.productPrice.HeaderText = "Price";
			this.productPrice.Name = "productPrice";
			this.productPrice.ReadOnly = true;
			// 
			// productAvailability
			// 
			this.productAvailability.HeaderText = "Availability";
			this.productAvailability.Name = "productAvailability";
			this.productAvailability.ReadOnly = true;
			// 
			// buyButton
			// 
			this.buyButton.Location = new System.Drawing.Point(276, 213);
			this.buyButton.Name = "buyButton";
			this.buyButton.Size = new System.Drawing.Size(111, 41);
			this.buyButton.TabIndex = 2;
			this.buyButton.Text = "Buy";
			this.buyButton.UseVisualStyleBackColor = true;
			this.buyButton.Click += new System.EventHandler(this.buyButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 298);
			this.Controls.Add(this.buyButton);
			this.Controls.Add(this.produceGridView);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.produceGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button ordersButton;
		private System.Windows.Forms.Button storeButton;
		private System.Windows.Forms.DataGridView produceGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn product;
		private System.Windows.Forms.DataGridViewTextBoxColumn productAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn productAvailability;
		private System.Windows.Forms.Button buyButton;
	}
}

