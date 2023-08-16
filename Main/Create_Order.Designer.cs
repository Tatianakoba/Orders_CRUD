namespace Main
{
    partial class Create_Order
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Order));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ProviderINN = new System.Windows.Forms.ComboBox();
            this.providerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDataSet1 = new Main.OrdersDataSet1();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerTableAdapter = new Main.OrdersDataSet1TableAdapters.ProviderTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDataSetClients = new Main.OrdersDataSetClients();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Main.OrdersDataSetClientsTableAdapters.ClientsTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDataSetProducts = new Main.OrdersDataSetProducts();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Main.OrdersDataSetProductsTableAdapters.ProductsTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.productsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDataSetProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSetClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSetProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSetProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(428, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Оформление заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(79, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Выбор Поставщика";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(79, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выбор Покупателя (паспорт)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(79, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Выбор продукта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(79, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Количество";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(314, 281);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(360, 22);
            this.textBox4.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(736, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Создать нового Поставщика";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(736, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Создать нового Покупателя";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(736, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(298, 31);
            this.button3.TabIndex = 5;
            this.button3.Text = "Создать новый продукт";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(736, 283);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(298, 29);
            this.button4.TabIndex = 5;
            this.button4.Text = "Добавить строку в заказ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(736, 332);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(298, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "Удалить строку из заказа";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(736, 392);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(298, 29);
            this.button6.TabIndex = 5;
            this.button6.Text = "Отменить заказ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(344, 533);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(410, 40);
            this.button7.TabIndex = 5;
            this.button7.Text = "Просмотр заказа";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(79, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Выбор продукта";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(79, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Количество";
            this.label7.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(313, 410);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(360, 22);
            this.textBox6.TabIndex = 4;
            this.textBox6.Visible = false;
            // 
            // ProviderINN
            // 
            this.ProviderINN.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.providerBindingSource1, "Name", true));
            this.ProviderINN.DataSource = this.providerBindingSource;
            this.ProviderINN.DisplayMember = "Name";
            this.ProviderINN.FormattingEnabled = true;
            this.ProviderINN.Location = new System.Drawing.Point(313, 106);
            this.ProviderINN.Name = "ProviderINN";
            this.ProviderINN.Size = new System.Drawing.Size(360, 24);
            this.ProviderINN.TabIndex = 6;
            this.ProviderINN.ValueMember = "Name";
            this.ProviderINN.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // providerBindingSource1
            // 
            this.providerBindingSource1.DataMember = "Provider";
            this.providerBindingSource1.DataSource = this.ordersDataSet1;
            // 
            // ordersDataSet1
            // 
            this.ordersDataSet1.DataSetName = "OrdersDataSet1";
            this.ordersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.ordersDataSet1;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientsBindingSource1, "Passport", true));
            this.comboBox2.DataSource = this.clientsBindingSource;
            this.comboBox2.DisplayMember = "Passport";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(314, 158);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(359, 24);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "Passport";
            // 
            // clientsBindingSource1
            // 
            this.clientsBindingSource1.DataMember = "Clients";
            this.clientsBindingSource1.DataSource = this.ordersDataSetClients;
            // 
            // ordersDataSetClients
            // 
            this.ordersDataSetClients.DataSetName = "OrdersDataSetClients";
            this.ordersDataSetClients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.ordersDataSetClients;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource1, "Item", true));
            this.comboBox3.DataSource = this.productsBindingSource;
            this.comboBox3.DisplayMember = "Item";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(314, 238);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(360, 24);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.ValueMember = "Item";
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.ordersDataSetProducts;
            // 
            // ordersDataSetProducts
            // 
            this.ordersDataSetProducts.DataSetName = "OrdersDataSetProducts";
            this.ordersDataSetProducts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.ordersDataSetProducts;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productsBindingSource3, "Item", true));
            this.comboBox4.DataSource = this.productsBindingSource2;
            this.comboBox4.DisplayMember = "Item";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(314, 362);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(360, 24);
            this.comboBox4.TabIndex = 8;
            this.comboBox4.ValueMember = "Item";
            // 
            // productsBindingSource3
            // 
            this.productsBindingSource3.DataMember = "Products";
            this.productsBindingSource3.DataSource = this.ordersDataSetProducts;
            // 
            // productsBindingSource2
            // 
            this.productsBindingSource2.DataMember = "Products";
            this.productsBindingSource2.DataSource = this.ordersDataSetProductsBindingSource;
            // 
            // ordersDataSetProductsBindingSource
            // 
            this.ordersDataSetProductsBindingSource.DataSource = this.ordersDataSetProducts;
            this.ordersDataSetProductsBindingSource.Position = 0;
            // 
            // Create_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1067, 653);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.ProviderINN);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Create_Order";
            this.Text = "Создание и редактирование заказов";
            this.Load += new System.EventHandler(this.Create_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSetClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSetProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSetProductsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox ProviderINN;
        private OrdersDataSet1 ordersDataSet1;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private OrdersDataSet1TableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.BindingSource providerBindingSource1;
        private System.Windows.Forms.ComboBox comboBox2;
        private OrdersDataSetClients ordersDataSetClients;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private OrdersDataSetClientsTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.ComboBox comboBox3;
        private OrdersDataSetProducts ordersDataSetProducts;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private OrdersDataSetProductsTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource productsBindingSource3;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private System.Windows.Forms.BindingSource ordersDataSetProductsBindingSource;
    }
}