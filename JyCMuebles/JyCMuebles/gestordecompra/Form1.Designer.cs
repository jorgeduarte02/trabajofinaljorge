namespace gestordecompra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Profit = new System.Windows.Forms.Label();
            this.lbl_Sale = new System.Windows.Forms.Label();
            this.btn_ShowProd = new System.Windows.Forms.Button();
            this.panel_Sales = new System.Windows.Forms.Panel();
            this.btn_CalcProfit = new System.Windows.Forms.Button();
            this.btn_CalcSale = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.nud_Quantity = new System.Windows.Forms.NumericUpDown();
            this.dgv_Prods = new System.Windows.Forms.DataGridView();
            this.btn_Search = new System.Windows.Forms.Button();
            this.txtb_Search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Product = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.nud_Warranty = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.cbx_Country = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nud_MayorCant = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cbx_Brand = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nud_MayorPrice = new System.Windows.Forms.NumericUpDown();
            this.nud_UnitPrice = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_Cost = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtb_Desc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtb_Model = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_Code = new System.Windows.Forms.NumericUpDown();
            this.panel_FKs = new System.Windows.Forms.Panel();
            this.btn_AddBrand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_AddCountry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_Country = new System.Windows.Forms.TextBox();
            this.txtb_Brand = new System.Windows.Forms.TextBox();
            this.panel_Sales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prods)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Warranty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MayorCant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MayorPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_UnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Code)).BeginInit();
            this.panel_FKs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Profit
            // 
            this.lbl_Profit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Profit.AutoSize = true;
            this.lbl_Profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Profit.Location = new System.Drawing.Point(342, 394);
            this.lbl_Profit.Name = "lbl_Profit";
            this.lbl_Profit.Size = new System.Drawing.Size(14, 13);
            this.lbl_Profit.TabIndex = 38;
            this.lbl_Profit.Text = "$";
            // 
            // lbl_Sale
            // 
            this.lbl_Sale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Sale.AutoSize = true;
            this.lbl_Sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Sale.Location = new System.Drawing.Point(342, 371);
            this.lbl_Sale.Name = "lbl_Sale";
            this.lbl_Sale.Size = new System.Drawing.Size(14, 13);
            this.lbl_Sale.TabIndex = 37;
            this.lbl_Sale.Text = "$";
            // 
            // btn_ShowProd
            // 
            this.btn_ShowProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ShowProd.Location = new System.Drawing.Point(342, 337);
            this.btn_ShowProd.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_ShowProd.Name = "btn_ShowProd";
            this.btn_ShowProd.Size = new System.Drawing.Size(504, 23);
            this.btn_ShowProd.TabIndex = 36;
            this.btn_ShowProd.Text = "Mostrar producto seleccionado";
            this.btn_ShowProd.UseVisualStyleBackColor = true;
            // 
            // panel_Sales
            // 
            this.panel_Sales.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_Sales.Controls.Add(this.btn_CalcProfit);
            this.panel_Sales.Controls.Add(this.btn_CalcSale);
            this.panel_Sales.Controls.Add(this.label13);
            this.panel_Sales.Controls.Add(this.nud_Quantity);
            this.panel_Sales.Location = new System.Drawing.Point(212, 340);
            this.panel_Sales.Name = "panel_Sales";
            this.panel_Sales.Size = new System.Drawing.Size(124, 74);
            this.panel_Sales.TabIndex = 35;
            // 
            // btn_CalcProfit
            // 
            this.btn_CalcProfit.Location = new System.Drawing.Point(3, 49);
            this.btn_CalcProfit.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_CalcProfit.Name = "btn_CalcProfit";
            this.btn_CalcProfit.Size = new System.Drawing.Size(118, 23);
            this.btn_CalcProfit.TabIndex = 26;
            this.btn_CalcProfit.Text = "Calcular ganancia";
            this.btn_CalcProfit.UseVisualStyleBackColor = true;
            // 
            // btn_CalcSale
            // 
            this.btn_CalcSale.BackColor = System.Drawing.Color.Transparent;
            this.btn_CalcSale.Location = new System.Drawing.Point(3, 26);
            this.btn_CalcSale.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_CalcSale.Name = "btn_CalcSale";
            this.btn_CalcSale.Size = new System.Drawing.Size(118, 23);
            this.btn_CalcSale.TabIndex = 25;
            this.btn_CalcSale.Text = "Calcular venta";
            this.btn_CalcSale.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Cantidad:";
            // 
            // nud_Quantity
            // 
            this.nud_Quantity.Location = new System.Drawing.Point(61, 3);
            this.nud_Quantity.Name = "nud_Quantity";
            this.nud_Quantity.Size = new System.Drawing.Size(60, 20);
            this.nud_Quantity.TabIndex = 25;
            // 
            // dgv_Prods
            // 
            this.dgv_Prods.AllowUserToAddRows = false;
            this.dgv_Prods.AllowUserToDeleteRows = false;
            this.dgv_Prods.AllowUserToOrderColumns = true;
            this.dgv_Prods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Prods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Prods.Location = new System.Drawing.Point(212, 5);
            this.dgv_Prods.Name = "dgv_Prods";
            this.dgv_Prods.ReadOnly = true;
            this.dgv_Prods.Size = new System.Drawing.Size(634, 329);
            this.dgv_Prods.TabIndex = 34;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Search.Location = new System.Drawing.Point(696, -23);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(150, 23);
            this.btn_Search.TabIndex = 31;
            this.btn_Search.Text = "Buscar";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // txtb_Search
            // 
            this.txtb_Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_Search.Location = new System.Drawing.Point(212, -21);
            this.txtb_Search.Name = "txtb_Search";
            this.txtb_Search.Size = new System.Drawing.Size(478, 20);
            this.txtb_Search.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_Product);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.nud_Warranty);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbx_Country);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.nud_MayorCant);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbx_Brand);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nud_MayorPrice);
            this.panel1.Controls.Add(this.nud_UnitPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nud_Cost);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtb_Desc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtb_Model);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nud_Code);
            this.panel1.Location = new System.Drawing.Point(-45, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 287);
            this.panel1.TabIndex = 33;
            // 
            // btn_Product
            // 
            this.btn_Product.Location = new System.Drawing.Point(3, 262);
            this.btn_Product.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_Product.Name = "btn_Product";
            this.btn_Product.Size = new System.Drawing.Size(245, 23);
            this.btn_Product.TabIndex = 6;
            this.btn_Product.Text = "Agregar";
            this.btn_Product.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 241);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Garantía:";
            // 
            // nud_Warranty
            // 
            this.nud_Warranty.Location = new System.Drawing.Point(98, 239);
            this.nud_Warranty.Name = "nud_Warranty";
            this.nud_Warranty.Size = new System.Drawing.Size(150, 20);
            this.nud_Warranty.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "País de origen:";
            // 
            // cbx_Country
            // 
            this.cbx_Country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Country.FormattingEnabled = true;
            this.cbx_Country.Location = new System.Drawing.Point(98, 212);
            this.cbx_Country.Name = "cbx_Country";
            this.cbx_Country.Size = new System.Drawing.Size(150, 21);
            this.cbx_Country.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cantidad minima:";
            // 
            // nud_MayorCant
            // 
            this.nud_MayorCant.Location = new System.Drawing.Point(98, 186);
            this.nud_MayorCant.Name = "nud_MayorCant";
            this.nud_MayorCant.Size = new System.Drawing.Size(150, 20);
            this.nud_MayorCant.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Marca:";
            // 
            // cbx_Brand
            // 
            this.cbx_Brand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Brand.FormattingEnabled = true;
            this.cbx_Brand.Location = new System.Drawing.Point(98, 159);
            this.cbx_Brand.Name = "cbx_Brand";
            this.cbx_Brand.Size = new System.Drawing.Size(150, 21);
            this.cbx_Brand.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Precio por mayor:";
            // 
            // nud_MayorPrice
            // 
            this.nud_MayorPrice.Location = new System.Drawing.Point(98, 133);
            this.nud_MayorPrice.Name = "nud_MayorPrice";
            this.nud_MayorPrice.Size = new System.Drawing.Size(150, 20);
            this.nud_MayorPrice.TabIndex = 15;
            // 
            // nud_UnitPrice
            // 
            this.nud_UnitPrice.Location = new System.Drawing.Point(98, 107);
            this.nud_UnitPrice.Name = "nud_UnitPrice";
            this.nud_UnitPrice.Size = new System.Drawing.Size(150, 20);
            this.nud_UnitPrice.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Precio unitario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Costo:";
            // 
            // nud_Cost
            // 
            this.nud_Cost.Location = new System.Drawing.Point(98, 81);
            this.nud_Cost.Name = "nud_Cost";
            this.nud_Cost.Size = new System.Drawing.Size(150, 20);
            this.nud_Cost.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descripción:";
            // 
            // txtb_Desc
            // 
            this.txtb_Desc.Location = new System.Drawing.Point(98, 55);
            this.txtb_Desc.Name = "txtb_Desc";
            this.txtb_Desc.Size = new System.Drawing.Size(150, 20);
            this.txtb_Desc.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modelo:";
            // 
            // txtb_Model
            // 
            this.txtb_Model.Location = new System.Drawing.Point(98, 29);
            this.txtb_Model.Name = "txtb_Model";
            this.txtb_Model.Size = new System.Drawing.Size(150, 20);
            this.txtb_Model.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código:";
            // 
            // nud_Code
            // 
            this.nud_Code.Location = new System.Drawing.Point(98, 3);
            this.nud_Code.Name = "nud_Code";
            this.nud_Code.Size = new System.Drawing.Size(150, 20);
            this.nud_Code.TabIndex = 7;
            // 
            // panel_FKs
            // 
            this.panel_FKs.BackColor = System.Drawing.Color.Transparent;
            this.panel_FKs.Controls.Add(this.btn_AddBrand);
            this.panel_FKs.Controls.Add(this.label1);
            this.panel_FKs.Controls.Add(this.btn_AddCountry);
            this.panel_FKs.Controls.Add(this.label2);
            this.panel_FKs.Controls.Add(this.txtb_Country);
            this.panel_FKs.Controls.Add(this.txtb_Brand);
            this.panel_FKs.Location = new System.Drawing.Point(-45, -23);
            this.panel_FKs.Name = "panel_FKs";
            this.panel_FKs.Size = new System.Drawing.Size(251, 123);
            this.panel_FKs.TabIndex = 30;
            // 
            // btn_AddBrand
            // 
            this.btn_AddBrand.Location = new System.Drawing.Point(98, 98);
            this.btn_AddBrand.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_AddBrand.Name = "btn_AddBrand";
            this.btn_AddBrand.Size = new System.Drawing.Size(150, 23);
            this.btn_AddBrand.TabIndex = 5;
            this.btn_AddBrand.Text = "Agregar";
            this.btn_AddBrand.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "País:";
            // 
            // btn_AddCountry
            // 
            this.btn_AddCountry.Location = new System.Drawing.Point(98, 26);
            this.btn_AddCountry.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_AddCountry.Name = "btn_AddCountry";
            this.btn_AddCountry.Size = new System.Drawing.Size(150, 23);
            this.btn_AddCountry.TabIndex = 2;
            this.btn_AddCountry.Text = "Agregar";
            this.btn_AddCountry.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marca";
            // 
            // txtb_Country
            // 
            this.txtb_Country.Location = new System.Drawing.Point(98, 3);
            this.txtb_Country.Name = "txtb_Country";
            this.txtb_Country.Size = new System.Drawing.Size(150, 20);
            this.txtb_Country.TabIndex = 3;
            // 
            // txtb_Brand
            // 
            this.txtb_Brand.Location = new System.Drawing.Point(98, 75);
            this.txtb_Brand.Name = "txtb_Brand";
            this.txtb_Brand.Size = new System.Drawing.Size(150, 20);
            this.txtb_Brand.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestordecompra.Properties.Resources.fondo2;
            this.ClientSize = new System.Drawing.Size(801, 392);
            this.Controls.Add(this.lbl_Profit);
            this.Controls.Add(this.lbl_Sale);
            this.Controls.Add(this.btn_ShowProd);
            this.Controls.Add(this.panel_Sales);
            this.Controls.Add(this.dgv_Prods);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txtb_Search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_FKs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_Sales.ResumeLayout(false);
            this.panel_Sales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prods)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Warranty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MayorCant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MayorPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_UnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Code)).EndInit();
            this.panel_FKs.ResumeLayout(false);
            this.panel_FKs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Profit;
        private System.Windows.Forms.Label lbl_Sale;
        private System.Windows.Forms.Button btn_ShowProd;
        private System.Windows.Forms.Panel panel_Sales;
        private System.Windows.Forms.Button btn_CalcProfit;
        private System.Windows.Forms.Button btn_CalcSale;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nud_Quantity;
        private System.Windows.Forms.DataGridView dgv_Prods;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.TextBox txtb_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Product;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nud_Warranty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbx_Country;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nud_MayorCant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbx_Brand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_MayorPrice;
        private System.Windows.Forms.NumericUpDown nud_UnitPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_Cost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb_Desc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb_Model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_Code;
        private System.Windows.Forms.Panel panel_FKs;
        private System.Windows.Forms.Button btn_AddBrand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_AddCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_Country;
        private System.Windows.Forms.TextBox txtb_Brand;
    }
}

