namespace PROJECT_3
{
    partial class Billing_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCUSTPHAR = new System.Windows.Forms.Button();
            this.grd_invoice_details = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_add_item_bill = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cus_id = new System.Windows.Forms.TextBox();
            this.LBL_TOTALPRICE = new System.Windows.Forms.Label();
            this.txt_total_price = new System.Windows.Forms.TextBox();
            this.cmb_item_name = new System.Windows.Forms.ComboBox();
            this.txt_pharmacist_id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_order_quantity = new System.Windows.Forms.TextBox();
            this.order_quantity = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_invoice_num = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cus_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_submit_order = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_invoice_details)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 749);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LimeGreen;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(27, 444);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 59);
            this.button6.TabIndex = 11;
            this.button6.Text = "Other Info";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LimeGreen;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(27, 698);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 10;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(27, 224);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 59);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete Item";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(27, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 59);
            this.button2.TabIndex = 7;
            this.button2.Text = "Update Item";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(27, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(123, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pharmacy";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(69, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sheikh";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(1351, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.btn_submit_order);
            this.panel3.Controls.Add(this.btnCUSTPHAR);
            this.panel3.Controls.Add(this.grd_invoice_details);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.btn_add_item_bill);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txt_cus_id);
            this.panel3.Controls.Add(this.LBL_TOTALPRICE);
            this.panel3.Controls.Add(this.txt_total_price);
            this.panel3.Controls.Add(this.cmb_item_name);
            this.panel3.Controls.Add(this.txt_pharmacist_id);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_order_quantity);
            this.panel3.Controls.Add(this.order_quantity);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_invoice_num);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_cus_name);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(372, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(924, 486);
            this.panel3.TabIndex = 3;
            // 
            // btnCUSTPHAR
            // 
            this.btnCUSTPHAR.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCUSTPHAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCUSTPHAR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCUSTPHAR.Location = new System.Drawing.Point(213, 173);
            this.btnCUSTPHAR.Name = "btnCUSTPHAR";
            this.btnCUSTPHAR.Size = new System.Drawing.Size(110, 31);
            this.btnCUSTPHAR.TabIndex = 25;
            this.btnCUSTPHAR.Text = "Add Item";
            this.btnCUSTPHAR.UseVisualStyleBackColor = false;
            this.btnCUSTPHAR.Click += new System.EventHandler(this.btnCUSTPHAR_Click);
            // 
            // grd_invoice_details
            // 
            this.grd_invoice_details.AllowUserToOrderColumns = true;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Navy;
            this.grd_invoice_details.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.grd_invoice_details.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.grd_invoice_details.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_invoice_details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.grd_invoice_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_invoice_details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grd_invoice_details.Location = new System.Drawing.Point(401, 54);
            this.grd_invoice_details.Name = "grd_invoice_details";
            this.grd_invoice_details.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grd_invoice_details.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.grd_invoice_details.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.grd_invoice_details.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.grd_invoice_details.Size = new System.Drawing.Size(476, 354);
            this.grd_invoice_details.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(23, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Customer Number";
            // 
            // btn_add_item_bill
            // 
            this.btn_add_item_bill.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_add_item_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_item_bill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_add_item_bill.Location = new System.Drawing.Point(213, 316);
            this.btn_add_item_bill.Name = "btn_add_item_bill";
            this.btn_add_item_bill.Size = new System.Drawing.Size(110, 29);
            this.btn_add_item_bill.TabIndex = 21;
            this.btn_add_item_bill.Text = "Add Item";
            this.btn_add_item_bill.UseVisualStyleBackColor = false;
            this.btn_add_item_bill.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Green;
            this.label8.Location = new System.Drawing.Point(23, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "Invoice Number";
            // 
            // txt_cus_id
            // 
            this.txt_cus_id.Location = new System.Drawing.Point(172, 54);
            this.txt_cus_id.Name = "txt_cus_id";
            this.txt_cus_id.Size = new System.Drawing.Size(148, 20);
            this.txt_cus_id.TabIndex = 19;
            // 
            // LBL_TOTALPRICE
            // 
            this.LBL_TOTALPRICE.AutoSize = true;
            this.LBL_TOTALPRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TOTALPRICE.ForeColor = System.Drawing.Color.Green;
            this.LBL_TOTALPRICE.Location = new System.Drawing.Point(671, 426);
            this.LBL_TOTALPRICE.Name = "LBL_TOTALPRICE";
            this.LBL_TOTALPRICE.Size = new System.Drawing.Size(46, 18);
            this.LBL_TOTALPRICE.TabIndex = 17;
            this.LBL_TOTALPRICE.Text = "Total";
            this.LBL_TOTALPRICE.Click += new System.EventHandler(this.LBL_TOTALPRICE_Click);
            // 
            // txt_total_price
            // 
            this.txt_total_price.Location = new System.Drawing.Point(760, 426);
            this.txt_total_price.Name = "txt_total_price";
            this.txt_total_price.Size = new System.Drawing.Size(117, 20);
            this.txt_total_price.TabIndex = 16;
            this.txt_total_price.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cmb_item_name
            // 
            this.cmb_item_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_item_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_item_name.FormattingEnabled = true;
            this.cmb_item_name.Location = new System.Drawing.Point(169, 244);
            this.cmb_item_name.Name = "cmb_item_name";
            this.cmb_item_name.Size = new System.Drawing.Size(151, 21);
            this.cmb_item_name.TabIndex = 2;
            this.cmb_item_name.SelectedIndexChanged += new System.EventHandler(this.cmb_item_name_SelectedIndexChanged);
            // 
            // txt_pharmacist_id
            // 
            this.txt_pharmacist_id.Location = new System.Drawing.Point(172, 147);
            this.txt_pharmacist_id.Name = "txt_pharmacist_id";
            this.txt_pharmacist_id.Size = new System.Drawing.Size(148, 20);
            this.txt_pharmacist_id.TabIndex = 5;
            this.txt_pharmacist_id.TextChanged += new System.EventHandler(this.txt_pharmacist_id_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Green;
            this.label11.Location = new System.Drawing.Point(23, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Pharmacist ID";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txt_order_quantity
            // 
            this.txt_order_quantity.Location = new System.Drawing.Point(169, 281);
            this.txt_order_quantity.Name = "txt_order_quantity";
            this.txt_order_quantity.Size = new System.Drawing.Size(148, 20);
            this.txt_order_quantity.TabIndex = 4;
            // 
            // order_quantity
            // 
            this.order_quantity.AutoSize = true;
            this.order_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_quantity.ForeColor = System.Drawing.Color.Green;
            this.order_quantity.Location = new System.Drawing.Point(23, 281);
            this.order_quantity.Name = "order_quantity";
            this.order_quantity.Size = new System.Drawing.Size(107, 18);
            this.order_quantity.TabIndex = 10;
            this.order_quantity.Text = "Item Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Green;
            this.label9.Location = new System.Drawing.Point(594, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Invoice";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_invoice_num
            // 
            this.txt_invoice_num.Location = new System.Drawing.Point(172, 113);
            this.txt_invoice_num.Name = "txt_invoice_num";
            this.txt_invoice_num.Size = new System.Drawing.Size(148, 20);
            this.txt_invoice_num.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(23, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Item Name";
            // 
            // txt_cus_name
            // 
            this.txt_cus_name.Location = new System.Drawing.Point(172, 83);
            this.txt_cus_name.Name = "txt_cus_name";
            this.txt_cus_name.Size = new System.Drawing.Size(148, 20);
            this.txt_cus_name.TabIndex = 1;
            this.txt_cus_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(23, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(750, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Billing Module";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Item Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Price";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total Price";
            this.Column4.Name = "Column4";
            // 
            // btn_submit_order
            // 
            this.btn_submit_order.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_submit_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submit_order.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_submit_order.Location = new System.Drawing.Point(760, 452);
            this.btn_submit_order.Name = "btn_submit_order";
            this.btn_submit_order.Size = new System.Drawing.Size(117, 31);
            this.btn_submit_order.TabIndex = 26;
            this.btn_submit_order.Text = "Submit";
            this.btn_submit_order.UseVisualStyleBackColor = false;
            this.btn_submit_order.Click += new System.EventHandler(this.btn_submit_order_Click);
            // 
            // Billing_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.phar_view_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_invoice_details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_invoice_num;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cus_name;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_pharmacist_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_order_quantity;
        private System.Windows.Forms.Label order_quantity;
        private System.Windows.Forms.ComboBox cmb_item_name;
        private System.Windows.Forms.TextBox txt_total_price;
        private System.Windows.Forms.Label LBL_TOTALPRICE;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txt_cus_id;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_add_item_bill;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grd_invoice_details;
        private System.Windows.Forms.Button btnCUSTPHAR;
        private System.Windows.Forms.Button btn_submit_order;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

