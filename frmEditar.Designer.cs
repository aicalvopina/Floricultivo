namespace Floricultivo
{
    partial class frmEditar
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
            this.btnLookFor = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.txtTempOcaso = new System.Windows.Forms.TextBox();
            this.txtTempMax = new System.Windows.Forms.TextBox();
            this.txtTempAmanecer = new System.Windows.Forms.TextBox();
            this.lblTempMax = new System.Windows.Forms.Label();
            this.lblTempOcaso = new System.Windows.Forms.Label();
            this.lblTempAmanecer = new System.Windows.Forms.Label();
            this.txtHoraOcaso = new System.Windows.Forms.TextBox();
            this.txtHoraMaxTemp = new System.Windows.Forms.TextBox();
            this.txtHoraAmanecer = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblHoraMaxTemp = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHoraOcaso = new System.Windows.Forms.Label();
            this.lblHoraAmanecer = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdateRegister = new System.Windows.Forms.Button();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLookFor
            // 
            this.btnLookFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookFor.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookFor.Location = new System.Drawing.Point(31, 282);
            this.btnLookFor.Name = "btnLookFor";
            this.btnLookFor.Size = new System.Drawing.Size(107, 62);
            this.btnLookFor.TabIndex = 21;
            this.btnLookFor.Text = "Buscar Registro";
            this.btnLookFor.UseVisualStyleBackColor = true;
            this.btnLookFor.Click += new System.EventHandler(this.btnLookFor_Click);
            // 
            // gbData
            // 
            this.gbData.BackColor = System.Drawing.Color.Transparent;
            this.gbData.Controls.Add(this.txtTempOcaso);
            this.gbData.Controls.Add(this.txtTempMax);
            this.gbData.Controls.Add(this.txtTempAmanecer);
            this.gbData.Controls.Add(this.lblTempMax);
            this.gbData.Controls.Add(this.lblTempOcaso);
            this.gbData.Controls.Add(this.lblTempAmanecer);
            this.gbData.Controls.Add(this.txtHoraOcaso);
            this.gbData.Controls.Add(this.txtHoraMaxTemp);
            this.gbData.Controls.Add(this.txtHoraAmanecer);
            this.gbData.Controls.Add(this.txtFecha);
            this.gbData.Controls.Add(this.lblHoraMaxTemp);
            this.gbData.Controls.Add(this.lblFecha);
            this.gbData.Controls.Add(this.lblHoraOcaso);
            this.gbData.Controls.Add(this.lblHoraAmanecer);
            this.gbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbData.Location = new System.Drawing.Point(12, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(417, 255);
            this.gbData.TabIndex = 20;
            this.gbData.TabStop = false;
            this.gbData.Text = "Datos";
            // 
            // txtTempOcaso
            // 
            this.txtTempOcaso.Location = new System.Drawing.Point(252, 224);
            this.txtTempOcaso.Name = "txtTempOcaso";
            this.txtTempOcaso.Size = new System.Drawing.Size(150, 22);
            this.txtTempOcaso.TabIndex = 27;
            // 
            // txtTempMax
            // 
            this.txtTempMax.Location = new System.Drawing.Point(252, 196);
            this.txtTempMax.Name = "txtTempMax";
            this.txtTempMax.Size = new System.Drawing.Size(150, 22);
            this.txtTempMax.TabIndex = 26;
            // 
            // txtTempAmanecer
            // 
            this.txtTempAmanecer.Location = new System.Drawing.Point(252, 161);
            this.txtTempAmanecer.Name = "txtTempAmanecer";
            this.txtTempAmanecer.Size = new System.Drawing.Size(150, 22);
            this.txtTempAmanecer.TabIndex = 25;
            // 
            // lblTempMax
            // 
            this.lblTempMax.AutoSize = true;
            this.lblTempMax.BackColor = System.Drawing.Color.Transparent;
            this.lblTempMax.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempMax.ForeColor = System.Drawing.Color.Black;
            this.lblTempMax.Location = new System.Drawing.Point(42, 197);
            this.lblTempMax.Name = "lblTempMax";
            this.lblTempMax.Size = new System.Drawing.Size(166, 16);
            this.lblTempMax.TabIndex = 23;
            this.lblTempMax.Text = "Temperatura Maxima:";
            // 
            // lblTempOcaso
            // 
            this.lblTempOcaso.AutoSize = true;
            this.lblTempOcaso.BackColor = System.Drawing.Color.Transparent;
            this.lblTempOcaso.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempOcaso.ForeColor = System.Drawing.Color.Black;
            this.lblTempOcaso.Location = new System.Drawing.Point(42, 225);
            this.lblTempOcaso.Name = "lblTempOcaso";
            this.lblTempOcaso.Size = new System.Drawing.Size(156, 16);
            this.lblTempOcaso.TabIndex = 24;
            this.lblTempOcaso.Text = "Temperatura Ocaso:";
            // 
            // lblTempAmanecer
            // 
            this.lblTempAmanecer.AutoSize = true;
            this.lblTempAmanecer.BackColor = System.Drawing.Color.Transparent;
            this.lblTempAmanecer.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempAmanecer.ForeColor = System.Drawing.Color.Black;
            this.lblTempAmanecer.Location = new System.Drawing.Point(42, 162);
            this.lblTempAmanecer.Name = "lblTempAmanecer";
            this.lblTempAmanecer.Size = new System.Drawing.Size(184, 16);
            this.lblTempAmanecer.TabIndex = 22;
            this.lblTempAmanecer.Text = "Temperatura Amanecer:";
            // 
            // txtHoraOcaso
            // 
            this.txtHoraOcaso.Location = new System.Drawing.Point(252, 135);
            this.txtHoraOcaso.Name = "txtHoraOcaso";
            this.txtHoraOcaso.Size = new System.Drawing.Size(150, 22);
            this.txtHoraOcaso.TabIndex = 21;
            // 
            // txtHoraMaxTemp
            // 
            this.txtHoraMaxTemp.Location = new System.Drawing.Point(252, 107);
            this.txtHoraMaxTemp.Name = "txtHoraMaxTemp";
            this.txtHoraMaxTemp.Size = new System.Drawing.Size(150, 22);
            this.txtHoraMaxTemp.TabIndex = 20;
            // 
            // txtHoraAmanecer
            // 
            this.txtHoraAmanecer.Location = new System.Drawing.Point(252, 72);
            this.txtHoraAmanecer.Name = "txtHoraAmanecer";
            this.txtHoraAmanecer.Size = new System.Drawing.Size(150, 22);
            this.txtHoraAmanecer.TabIndex = 19;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(252, 42);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(150, 22);
            this.txtFecha.TabIndex = 18;
            // 
            // lblHoraMaxTemp
            // 
            this.lblHoraMaxTemp.AutoSize = true;
            this.lblHoraMaxTemp.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraMaxTemp.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraMaxTemp.ForeColor = System.Drawing.Color.Black;
            this.lblHoraMaxTemp.Location = new System.Drawing.Point(42, 108);
            this.lblHoraMaxTemp.Name = "lblHoraMaxTemp";
            this.lblHoraMaxTemp.Size = new System.Drawing.Size(179, 16);
            this.lblHoraMaxTemp.TabIndex = 16;
            this.lblHoraMaxTemp.Text = "Hora Max Temperatura:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(42, 43);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 16);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblHoraOcaso
            // 
            this.lblHoraOcaso.AutoSize = true;
            this.lblHoraOcaso.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraOcaso.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraOcaso.ForeColor = System.Drawing.Color.Black;
            this.lblHoraOcaso.Location = new System.Drawing.Point(42, 136);
            this.lblHoraOcaso.Name = "lblHoraOcaso";
            this.lblHoraOcaso.Size = new System.Drawing.Size(97, 16);
            this.lblHoraOcaso.TabIndex = 17;
            this.lblHoraOcaso.Text = "Hora Ocaso:";
            // 
            // lblHoraAmanecer
            // 
            this.lblHoraAmanecer.AutoSize = true;
            this.lblHoraAmanecer.BackColor = System.Drawing.Color.Transparent;
            this.lblHoraAmanecer.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraAmanecer.ForeColor = System.Drawing.Color.Black;
            this.lblHoraAmanecer.Location = new System.Drawing.Point(42, 73);
            this.lblHoraAmanecer.Name = "lblHoraAmanecer";
            this.lblHoraAmanecer.Size = new System.Drawing.Size(125, 16);
            this.lblHoraAmanecer.TabIndex = 15;
            this.lblHoraAmanecer.Text = "Hora Amanecer:";
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(307, 282);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 62);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Cerrar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdateRegister
            // 
            this.btnUpdateRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRegister.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRegister.Location = new System.Drawing.Point(168, 282);
            this.btnUpdateRegister.Name = "btnUpdateRegister";
            this.btnUpdateRegister.Size = new System.Drawing.Size(107, 62);
            this.btnUpdateRegister.TabIndex = 18;
            this.btnUpdateRegister.Text = "Modificar Registro";
            this.btnUpdateRegister.UseVisualStyleBackColor = true;
            // 
            // frmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(447, 366);
            this.Controls.Add(this.btnLookFor);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateRegister);
            this.Name = "frmEditar";
            this.Text = "Edicion de Datos";
            this.Load += new System.EventHandler(this.frmEditar_Load);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLookFor;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TextBox txtTempOcaso;
        private System.Windows.Forms.TextBox txtTempMax;
        private System.Windows.Forms.TextBox txtTempAmanecer;
        private System.Windows.Forms.Label lblTempMax;
        private System.Windows.Forms.Label lblTempOcaso;
        private System.Windows.Forms.Label lblTempAmanecer;
        private System.Windows.Forms.TextBox txtHoraOcaso;
        private System.Windows.Forms.TextBox txtHoraMaxTemp;
        private System.Windows.Forms.TextBox txtHoraAmanecer;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblHoraMaxTemp;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHoraOcaso;
        private System.Windows.Forms.Label lblHoraAmanecer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdateRegister;
    }
}