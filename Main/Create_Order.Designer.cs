﻿namespace Main
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
            this.CreateProviderButton = new System.Windows.Forms.Button();
            this.CreateClient = new System.Windows.Forms.Button();
            this.CreateProduct = new System.Windows.Forms.Button();
            this.CancelOrder = new System.Windows.Forms.Button();
            this.ViewOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProductQuantity = new System.Windows.Forms.TextBox();
            this.ProviderINN = new System.Windows.Forms.ComboBox();
            this.providerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDataSet1 = new Main.OrdersDataSet1();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerTableAdapter = new Main.OrdersDataSet1TableAdapters.ProviderTableAdapter();
            this.clientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDataSetClients = new Main.OrdersDataSetClients();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new Main.OrdersDataSetClientsTableAdapters.ClientsTableAdapter();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDataSetProducts = new Main.OrdersDataSetProducts();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new Main.OrdersDataSetProductsTableAdapters.ProductsTableAdapter();
            this.productsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDataSetProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientPassport = new System.Windows.Forms.ComboBox();
            this.clientsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDataSet2 = new Main.OrdersDataSet2();
            this.clientsTableAdapter1 = new Main.OrdersDataSet2TableAdapters.ClientsTableAdapter();
            this.ProductSelection = new System.Windows.Forms.ComboBox();
            this.AddString = new System.Windows.Forms.Button();
            this.DeleteString = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet2)).BeginInit();
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
            // CreateProviderButton
            // 
            this.CreateProviderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateProviderButton.Location = new System.Drawing.Point(736, 99);
            this.CreateProviderButton.Name = "CreateProviderButton";
            this.CreateProviderButton.Size = new System.Drawing.Size(298, 35);
            this.CreateProviderButton.TabIndex = 5;
            this.CreateProviderButton.Text = "Создать нового Поставщика";
            this.CreateProviderButton.UseVisualStyleBackColor = true;
            this.CreateProviderButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CreateClient
            // 
            this.CreateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateClient.Location = new System.Drawing.Point(736, 154);
            this.CreateClient.Name = "CreateClient";
            this.CreateClient.Size = new System.Drawing.Size(298, 30);
            this.CreateClient.TabIndex = 5;
            this.CreateClient.Text = "Создать нового Покупателя";
            this.CreateClient.UseVisualStyleBackColor = true;
            this.CreateClient.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // CreateProduct
            // 
            this.CreateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateProduct.Location = new System.Drawing.Point(736, 231);
            this.CreateProduct.Name = "CreateProduct";
            this.CreateProduct.Size = new System.Drawing.Size(298, 31);
            this.CreateProduct.TabIndex = 5;
            this.CreateProduct.Text = "Создать новый продукт";
            this.CreateProduct.UseVisualStyleBackColor = true;
            this.CreateProduct.Click += new System.EventHandler(this.CreateProduct_Click);
            // 
            // CancelOrder
            // 
            this.CancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelOrder.Location = new System.Drawing.Point(736, 401);
            this.CancelOrder.Name = "CancelOrder";
            this.CancelOrder.Size = new System.Drawing.Size(298, 29);
            this.CancelOrder.TabIndex = 5;
            this.CancelOrder.Text = "Отменить заказ";
            this.CancelOrder.UseVisualStyleBackColor = true;
            this.CancelOrder.Click += new System.EventHandler(this.button6_Click);
            // 
            // ViewOrder
            // 
            this.ViewOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewOrder.Location = new System.Drawing.Point(344, 533);
            this.ViewOrder.Name = "ViewOrder";
            this.ViewOrder.Size = new System.Drawing.Size(410, 40);
            this.ViewOrder.TabIndex = 5;
            this.ViewOrder.Text = "Просмотр заказа";
            this.ViewOrder.UseVisualStyleBackColor = true;
            this.ViewOrder.Click += new System.EventHandler(this.button7_Click_1);
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
            // ProductQuantity
            // 
            this.ProductQuantity.Location = new System.Drawing.Point(314, 410);
            this.ProductQuantity.Name = "ProductQuantity";
            this.ProductQuantity.Size = new System.Drawing.Size(360, 22);
            this.ProductQuantity.TabIndex = 4;
            this.ProductQuantity.Visible = false;
            // 
            // ProviderINN
            // 
            this.ProviderINN.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.providerBindingSource1, "Name", true));
            this.ProviderINN.FormattingEnabled = true;
            this.ProviderINN.Location = new System.Drawing.Point(313, 106);
            this.ProviderINN.Name = "ProviderINN";
            this.ProviderINN.Size = new System.Drawing.Size(360, 24);
            this.ProviderINN.TabIndex = 6;
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
            this.comboBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
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
            // ClientPassport
            // 
            this.ClientPassport.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientsBindingSource2, "ClientPassport", true));
            this.ClientPassport.FormattingEnabled = true;
            this.ClientPassport.Location = new System.Drawing.Point(313, 158);
            this.ClientPassport.Name = "ClientPassport";
            this.ClientPassport.Size = new System.Drawing.Size(360, 24);
            this.ClientPassport.TabIndex = 6;
            this.ClientPassport.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // clientsBindingSource2
            // 
            this.clientsBindingSource2.DataMember = "Clients";
            this.clientsBindingSource2.DataSource = this.ordersDataSet2;
            // 
            // ordersDataSet2
            // 
            this.ordersDataSet2.DataSetName = "OrdersDataSet2";
            this.ordersDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter1
            // 
            this.clientsTableAdapter1.ClearBeforeFill = true;
            // 
            // ProductSelection
            // 
            this.ProductSelection.FormattingEnabled = true;
            this.ProductSelection.Location = new System.Drawing.Point(313, 366);
            this.ProductSelection.Name = "ProductSelection";
            this.ProductSelection.Size = new System.Drawing.Size(360, 24);
            this.ProductSelection.TabIndex = 9;
            this.ProductSelection.Visible = false;
            // 
            // AddString
            // 
            this.AddString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddString.Location = new System.Drawing.Point(736, 278);
            this.AddString.Name = "AddString";
            this.AddString.Size = new System.Drawing.Size(298, 31);
            this.AddString.TabIndex = 5;
            this.AddString.Text = "Добавить строку";
            this.AddString.UseVisualStyleBackColor = true;
            this.AddString.Click += new System.EventHandler(this.AddString_Click);
            // 
            // DeleteString
            // 
            this.DeleteString.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteString.Location = new System.Drawing.Point(736, 355);
            this.DeleteString.Name = "DeleteString";
            this.DeleteString.Size = new System.Drawing.Size(298, 31);
            this.DeleteString.TabIndex = 5;
            this.DeleteString.Text = "Удалить строку";
            this.DeleteString.UseVisualStyleBackColor = true;
            this.DeleteString.Click += new System.EventHandler(this.DeleteString_Click);
            // 
            // Create_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1067, 653);
            this.Controls.Add(this.ProductSelection);
            this.Controls.Add(this.ClientPassport);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.ProviderINN);
            this.Controls.Add(this.ViewOrder);
            this.Controls.Add(this.CancelOrder);
            this.Controls.Add(this.DeleteString);
            this.Controls.Add(this.AddString);
            this.Controls.Add(this.CreateProduct);
            this.Controls.Add(this.CreateClient);
            this.Controls.Add(this.CreateProviderButton);
            this.Controls.Add(this.ProductQuantity);
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
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataSet2)).EndInit();
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
        private System.Windows.Forms.Button CreateProviderButton;
        private System.Windows.Forms.Button CreateClient;
        private System.Windows.Forms.Button CreateProduct;
        private System.Windows.Forms.Button CancelOrder;
        private System.Windows.Forms.Button ViewOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ProductQuantity;
        private System.Windows.Forms.ComboBox ProviderINN;
        private OrdersDataSet1 ordersDataSet1;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private OrdersDataSet1TableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.BindingSource providerBindingSource1;
        private OrdersDataSetClients ordersDataSetClients;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private OrdersDataSetClientsTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource1;
        private System.Windows.Forms.ComboBox comboBox3;
        private OrdersDataSetProducts ordersDataSetProducts;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private OrdersDataSetProductsTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private System.Windows.Forms.BindingSource productsBindingSource3;
        private System.Windows.Forms.BindingSource productsBindingSource2;
        private System.Windows.Forms.BindingSource ordersDataSetProductsBindingSource;
        private System.Windows.Forms.ComboBox ClientPassport;
        private OrdersDataSet2 ordersDataSet2;
        private System.Windows.Forms.BindingSource clientsBindingSource2;
        private OrdersDataSet2TableAdapters.ClientsTableAdapter clientsTableAdapter1;
        private System.Windows.Forms.ComboBox ProductSelection;
        private System.Windows.Forms.Button AddString;
        private System.Windows.Forms.Button DeleteString;
    }
}