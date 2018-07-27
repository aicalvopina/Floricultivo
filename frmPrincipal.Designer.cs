namespace Floricultivo
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.mOptionStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mOptionNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mOptionConectionDB = new System.Windows.Forms.ToolStripMenuItem();
            this.mOptionNewDB = new System.Windows.Forms.ToolStripMenuItem();
            this.mOptionUpdateDB = new System.Windows.Forms.ToolStripMenuItem();
            this.mOptionSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mOptionSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mOptionDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mOptionUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mOptionHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mOptionInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.lblFecha = new System.Windows.Forms.Label();
            this.grbData = new System.Windows.Forms.GroupBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOptionStart,
            this.mOptionSettings,
            this.mOptionHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(875, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip2";
            // 
            // mOptionStart
            // 
            this.mOptionStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOptionNew,
            this.mOptionConectionDB,
            this.mOptionSalir});
            this.mOptionStart.Name = "mOptionStart";
            this.mOptionStart.Size = new System.Drawing.Size(48, 20);
            this.mOptionStart.Text = "Inicio";
            // 
            // mOptionNew
            // 
            this.mOptionNew.Name = "mOptionNew";
            this.mOptionNew.Size = new System.Drawing.Size(209, 22);
            this.mOptionNew.Text = "Nueva Consulta";
            this.mOptionNew.Click += new System.EventHandler(this.mOptionNew_Click);
            // 
            // mOptionConectionDB
            // 
            this.mOptionConectionDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOptionNewDB,
            this.mOptionUpdateDB});
            this.mOptionConectionDB.Name = "mOptionConectionDB";
            this.mOptionConectionDB.Size = new System.Drawing.Size(209, 22);
            this.mOptionConectionDB.Text = "Conexión a Base de Datos";
            // 
            // mOptionNewDB
            // 
            this.mOptionNewDB.Name = "mOptionNewDB";
            this.mOptionNewDB.Size = new System.Drawing.Size(202, 22);
            this.mOptionNewDB.Text = "Nueva Base Datos";
            // 
            // mOptionUpdateDB
            // 
            this.mOptionUpdateDB.Name = "mOptionUpdateDB";
            this.mOptionUpdateDB.Size = new System.Drawing.Size(202, 22);
            this.mOptionUpdateDB.Text = "Actualizar Base de Datos";
            // 
            // mOptionSalir
            // 
            this.mOptionSalir.Name = "mOptionSalir";
            this.mOptionSalir.Size = new System.Drawing.Size(209, 22);
            this.mOptionSalir.Text = "Salir";
            this.mOptionSalir.Click += new System.EventHandler(this.mOptionSalir_Click);
            // 
            // mOptionSettings
            // 
            this.mOptionSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOptionDelete,
            this.mOptionUpdate});
            this.mOptionSettings.Name = "mOptionSettings";
            this.mOptionSettings.Size = new System.Drawing.Size(95, 20);
            this.mOptionSettings.Text = "Configuracion";
            // 
            // mOptionDelete
            // 
            this.mOptionDelete.Name = "mOptionDelete";
            this.mOptionDelete.Size = new System.Drawing.Size(159, 22);
            this.mOptionDelete.Text = "Eliminar Datos";
            this.mOptionDelete.Click += new System.EventHandler(this.mOptionDelete_Click);
            // 
            // mOptionUpdate
            // 
            this.mOptionUpdate.Name = "mOptionUpdate";
            this.mOptionUpdate.Size = new System.Drawing.Size(159, 22);
            this.mOptionUpdate.Text = "Actualizar Datos";
            this.mOptionUpdate.Click += new System.EventHandler(this.mOptionUpdate_Click);
            // 
            // mOptionHelp
            // 
            this.mOptionHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOptionInformation});
            this.mOptionHelp.Name = "mOptionHelp";
            this.mOptionHelp.Size = new System.Drawing.Size(53, 20);
            this.mOptionHelp.Text = "Ayuda";
            // 
            // mOptionInformation
            // 
            this.mOptionInformation.Name = "mOptionInformation";
            this.mOptionInformation.Size = new System.Drawing.Size(152, 22);
            this.mOptionInformation.Text = "Información";
            this.mOptionInformation.Click += new System.EventHandler(this.mOptionInformation_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Swis721 Blk BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(39, 283);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(144, 62);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Cálculo";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(240, 283);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 62);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(402, 57);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(461, 211);
            this.dgvDatos.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lblFecha.Location = new System.Drawing.Point(23, 39);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(62, 19);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // grbData
            // 
            this.grbData.BackColor = System.Drawing.Color.Transparent;
            this.grbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbData.ForeColor = System.Drawing.Color.LemonChiffon;
            this.grbData.Location = new System.Drawing.Point(27, 76);
            this.grbData.Name = "grbData";
            this.grbData.Size = new System.Drawing.Size(348, 192);
            this.grbData.TabIndex = 6;
            this.grbData.TabStop = false;
            this.grbData.Text = "Datos";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(119, 39);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(224, 20);
            this.dtpDate.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 370);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.grbData);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.menuMain);
            this.Name = "frmMain";
            this.Text = "Programa de Grados Día en Cultivos";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem mOptionStart;
        private System.Windows.Forms.ToolStripMenuItem mOptionSettings;
        private System.Windows.Forms.ToolStripMenuItem mOptionHelp;
        private System.Windows.Forms.ToolStripMenuItem mOptionNew;
        private System.Windows.Forms.ToolStripMenuItem mOptionSalir;
        private System.Windows.Forms.ToolStripMenuItem mOptionInformation;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.GroupBox grbData;
        private System.Windows.Forms.ToolStripMenuItem mOptionConectionDB;
        private System.Windows.Forms.ToolStripMenuItem mOptionNewDB;
        private System.Windows.Forms.ToolStripMenuItem mOptionUpdateDB;
        private System.Windows.Forms.ToolStripMenuItem mOptionDelete;
        private System.Windows.Forms.ToolStripMenuItem mOptionUpdate;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}

