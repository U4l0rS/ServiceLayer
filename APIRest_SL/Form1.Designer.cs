namespace APIRest_SL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConexion = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTipos = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscaItem = new System.Windows.Forms.Button();
            this.btnCreaItem = new System.Windows.Forms.Button();
            this.txtItemType = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetOrdVenta = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.txtOdrTaxCode = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtOdrPrice = new System.Windows.Forms.TextBox();
            this.txtOdrQuantity = new System.Windows.Forms.TextBox();
            this.txtOdrItemCode = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtOdrDocDueDate = new System.Windows.Forms.TextBox();
            this.txtOdrDocDate = new System.Windows.Forms.TextBox();
            this.txtOdrCardCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDocNum = new System.Windows.Forms.TextBox();
            this.btnBuscarOV = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btntbludf = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConexion
            // 
            this.btnConexion.Location = new System.Drawing.Point(15, 19);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.Size = new System.Drawing.Size(179, 75);
            this.btnConexion.TabIndex = 0;
            this.btnConexion.Text = "&Abrir Conexion";
            this.btnConexion.UseVisualStyleBackColor = true;
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConexion);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 104);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verificar Conexión";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTipos);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.btnCrear);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtRfc);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(457, 131);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Business Partner";
            // 
            // txtTipos
            // 
            this.txtTipos.Location = new System.Drawing.Point(75, 99);
            this.txtTipos.Name = "txtTipos";
            this.txtTipos.Size = new System.Drawing.Size(155, 20);
            this.txtTipos.TabIndex = 10;
            this.txtTipos.Text = "cCustomer";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(258, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(179, 48);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(258, 19);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(179, 48);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "&Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "&Tipo:";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(75, 73);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(155, 20);
            this.txtRfc.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(155, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(75, 23);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(155, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "&RFC:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "&Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "&Codigo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscaItem);
            this.groupBox3.Controls.Add(this.btnCreaItem);
            this.groupBox3.Controls.Add(this.txtItemType);
            this.groupBox3.Controls.Add(this.txtItemName);
            this.groupBox3.Controls.Add(this.txtItemCode);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Location = new System.Drawing.Point(12, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(457, 128);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Item Master Data";
            // 
            // btnBuscaItem
            // 
            this.btnBuscaItem.Location = new System.Drawing.Point(258, 73);
            this.btnBuscaItem.Name = "btnBuscaItem";
            this.btnBuscaItem.Size = new System.Drawing.Size(179, 48);
            this.btnBuscaItem.TabIndex = 9;
            this.btnBuscaItem.Text = "&Buscar";
            this.btnBuscaItem.UseVisualStyleBackColor = true;
            this.btnBuscaItem.Click += new System.EventHandler(this.btnBuscaItem_Click);
            // 
            // btnCreaItem
            // 
            this.btnCreaItem.Location = new System.Drawing.Point(258, 19);
            this.btnCreaItem.Name = "btnCreaItem";
            this.btnCreaItem.Size = new System.Drawing.Size(179, 48);
            this.btnCreaItem.TabIndex = 8;
            this.btnCreaItem.Text = "&Crear";
            this.btnCreaItem.UseVisualStyleBackColor = true;
            this.btnCreaItem.Click += new System.EventHandler(this.btnCreaItem_Click);
            // 
            // txtItemType
            // 
            this.txtItemType.Location = new System.Drawing.Point(80, 80);
            this.txtItemType.Name = "txtItemType";
            this.txtItemType.Size = new System.Drawing.Size(155, 20);
            this.txtItemType.TabIndex = 5;
            this.txtItemType.Text = "itItems";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(80, 56);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(155, 20);
            this.txtItemName.TabIndex = 4;
            // 
            // txtItemCode
            // 
            this.txtItemCode.Location = new System.Drawing.Point(80, 30);
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.Size = new System.Drawing.Size(155, 20);
            this.txtItemCode.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "&Tipo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "&Descripcion:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "&Codigo:";
            // 
            // rtxtResult
            // 
            this.rtxtResult.Location = new System.Drawing.Point(19, 17);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.Size = new System.Drawing.Size(310, 361);
            this.rtxtResult.TabIndex = 13;
            this.rtxtResult.Text = "";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(662, 150);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(126, 27);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "&Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btntbludf);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Controls.Add(this.btnGetOrdVenta);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.btnLimpiar);
            this.groupBox4.Location = new System.Drawing.Point(12, 399);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(808, 308);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Orden de Venta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(641, 122);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnGetOrdVenta
            // 
            this.btnGetOrdVenta.Location = new System.Drawing.Point(662, 22);
            this.btnGetOrdVenta.Name = "btnGetOrdVenta";
            this.btnGetOrdVenta.Size = new System.Drawing.Size(126, 122);
            this.btnGetOrdVenta.TabIndex = 2;
            this.btnGetOrdVenta.Text = "&Crear Documento";
            this.btnGetOrdVenta.UseVisualStyleBackColor = true;
            this.btnGetOrdVenta.Click += new System.EventHandler(this.btnGetOrdVenta_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAddLine);
            this.groupBox6.Controls.Add(this.txtOdrTaxCode);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.txtOdrPrice);
            this.groupBox6.Controls.Add(this.txtOdrQuantity);
            this.groupBox6.Controls.Add(this.txtOdrItemCode);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Location = new System.Drawing.Point(337, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(319, 155);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "&Detalle";
            // 
            // btnAddLine
            // 
            this.btnAddLine.Location = new System.Drawing.Point(198, 126);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(98, 23);
            this.btnAddLine.TabIndex = 14;
            this.btnAddLine.Text = "&Agregar";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // txtOdrTaxCode
            // 
            this.txtOdrTaxCode.Location = new System.Drawing.Point(141, 94);
            this.txtOdrTaxCode.Name = "txtOdrTaxCode";
            this.txtOdrTaxCode.Size = new System.Drawing.Size(155, 20);
            this.txtOdrTaxCode.TabIndex = 13;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 101);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "&Codigo Impuesto:";
            // 
            // txtOdrPrice
            // 
            this.txtOdrPrice.Location = new System.Drawing.Point(141, 69);
            this.txtOdrPrice.Name = "txtOdrPrice";
            this.txtOdrPrice.Size = new System.Drawing.Size(155, 20);
            this.txtOdrPrice.TabIndex = 11;
            // 
            // txtOdrQuantity
            // 
            this.txtOdrQuantity.Location = new System.Drawing.Point(141, 45);
            this.txtOdrQuantity.Name = "txtOdrQuantity";
            this.txtOdrQuantity.Size = new System.Drawing.Size(155, 20);
            this.txtOdrQuantity.TabIndex = 10;
            // 
            // txtOdrItemCode
            // 
            this.txtOdrItemCode.Location = new System.Drawing.Point(141, 19);
            this.txtOdrItemCode.Name = "txtOdrItemCode";
            this.txtOdrItemCode.Size = new System.Drawing.Size(155, 20);
            this.txtOdrItemCode.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "&Precio:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "&Cantidad:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "&Codigo Articulo:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtOdrDocDueDate);
            this.groupBox5.Controls.Add(this.txtOdrDocDate);
            this.groupBox5.Controls.Add(this.txtOdrCardCode);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(12, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(319, 149);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "&Encabezado";
            // 
            // txtOdrDocDueDate
            // 
            this.txtOdrDocDueDate.Location = new System.Drawing.Point(142, 79);
            this.txtOdrDocDueDate.Name = "txtOdrDocDueDate";
            this.txtOdrDocDueDate.Size = new System.Drawing.Size(155, 20);
            this.txtOdrDocDueDate.TabIndex = 11;
            // 
            // txtOdrDocDate
            // 
            this.txtOdrDocDate.Location = new System.Drawing.Point(141, 55);
            this.txtOdrDocDate.Name = "txtOdrDocDate";
            this.txtOdrDocDate.Size = new System.Drawing.Size(155, 20);
            this.txtOdrDocDate.TabIndex = 10;
            // 
            // txtOdrCardCode
            // 
            this.txtOdrCardCode.Location = new System.Drawing.Point(141, 29);
            this.txtOdrCardCode.Name = "txtOdrCardCode";
            this.txtOdrCardCode.Size = new System.Drawing.Size(155, 20);
            this.txtOdrCardCode.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "&Fecha Vencimiento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "&Fecha Contabilizacion:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "&Codigo Socio:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 7;
            this.label20.Text = "&DocNum:";
            // 
            // txtDocNum
            // 
            this.txtDocNum.Location = new System.Drawing.Point(64, 32);
            this.txtDocNum.Name = "txtDocNum";
            this.txtDocNum.Size = new System.Drawing.Size(116, 20);
            this.txtDocNum.TabIndex = 5;
            // 
            // btnBuscarOV
            // 
            this.btnBuscarOV.Location = new System.Drawing.Point(112, 58);
            this.btnBuscarOV.Name = "btnBuscarOV";
            this.btnBuscarOV.Size = new System.Drawing.Size(68, 32);
            this.btnBuscarOV.TabIndex = 4;
            this.btnBuscarOV.Text = "&Buscar";
            this.btnBuscarOV.UseVisualStyleBackColor = true;
            this.btnBuscarOV.Click += new System.EventHandler(this.btnBuscarOV_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rtxtResult);
            this.groupBox7.Location = new System.Drawing.Point(475, 8);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(345, 385);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "&Resultados";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtDocNum);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.btnBuscarOV);
            this.groupBox8.Location = new System.Drawing.Point(226, 8);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 104);
            this.groupBox8.TabIndex = 17;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "&Buscar Orden de Venta";
            // 
            // btntbludf
            // 
            this.btntbludf.Location = new System.Drawing.Point(663, 184);
            this.btntbludf.Name = "btntbludf";
            this.btntbludf.Size = new System.Drawing.Size(125, 117);
            this.btntbludf.TabIndex = 15;
            this.btntbludf.Text = "&Contenido TBL UDF";
            this.btntbludf.UseVisualStyleBackColor = true;
            this.btntbludf.Click += new System.EventHandler(this.btntbludf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 713);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Layer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConexion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscaItem;
        private System.Windows.Forms.Button btnCreaItem;
        private System.Windows.Forms.TextBox txtItemType;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox rtxtResult;
        private System.Windows.Forms.TextBox txtTipos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGetOrdVenta;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtOdrTaxCode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtOdrPrice;
        private System.Windows.Forms.TextBox txtOdrQuantity;
        private System.Windows.Forms.TextBox txtOdrItemCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtOdrDocDueDate;
        private System.Windows.Forms.TextBox txtOdrDocDate;
        private System.Windows.Forms.TextBox txtOdrCardCode;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuscarOV;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDocNum;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button btntbludf;
    }
}

