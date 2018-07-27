namespace Floricultivo
{
    partial class frmEliminar
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
            this.btnConnectDB = new System.Windows.Forms.Button();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHoraOcaso = new System.Windows.Forms.TextBox();
            this.txtHoraMaxTemp = new System.Windows.Forms.TextBox();
            this.txtHoraAmanecer = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHoraAmanecer = new System.Windows.Forms.Label();
            this.txtTempOcaso = new System.Windows.Forms.TextBox();
            this.txtTempMax = new System.Windows.Forms.TextBox();
            this.txtTempAmanecer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnectDB
            // 
            this.btnConnectDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnectDB.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDB.Location = new System.Drawing.Point(307, 282);
            this.btnConnectDB.Name = "btnConnectDB";
            this.btnConnectDB.Size = new System.Drawing.Size(107, 62);
            this.btnConnectDB.TabIndex = 15;
            this.btnConnectDB.Text = "Cerrar";
            this.btnConnectDB.UseVisualStyleBackColor = true;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestConnection.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnection.Location = new System.Drawing.Point(174, 282);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(107, 62);
            this.btnTestConnection.TabIndex = 14;
            this.btnTestConnection.Text = "Borrar Registro";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.txtTempOcaso);
            this.gbData.Controls.Add(this.txtTempMax);
            this.gbData.Controls.Add(this.txtTempAmanecer);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.label4);
            this.gbData.Controls.Add(this.label5);
            this.gbData.Controls.Add(this.txtHoraOcaso);
            this.gbData.Controls.Add(this.txtHoraMaxTemp);
            this.gbData.Controls.Add(this.txtHoraAmanecer);
            this.gbData.Controls.Add(this.txtFecha);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.lblFecha);
            this.gbData.Controls.Add(this.label3);
            this.gbData.Controls.Add(this.lblHoraAmanecer);
            this.gbData.Location = new System.Drawing.Point(12, 12);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(417, 255);
            this.gbData.TabIndex = 16;
            this.gbData.TabStop = false;
            this.gbData.Text = "Datos";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(31, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 62);
            this.button1.TabIndex = 17;
            this.button1.Text = "Borrar Registro";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtHoraOcaso
            // 
            this.txtHoraOcaso.Location = new System.Drawing.Point(252, 135);
            this.txtHoraOcaso.Name = "txtHoraOcaso";
            this.txtHoraOcaso.Size = new System.Drawing.Size(150, 20);
            this.txtHoraOcaso.TabIndex = 21;
            // 
            // txtHoraMaxTemp
            // 
            this.txtHoraMaxTemp.Location = new System.Drawing.Point(252, 107);
            this.txtHoraMaxTemp.Name = "txtHoraMaxTemp";
            this.txtHoraMaxTemp.Size = new System.Drawing.Size(150, 20);
            this.txtHoraMaxTemp.TabIndex = 20;
            // 
            // txtHoraAmanecer
            // 
            this.txtHoraAmanecer.Location = new System.Drawing.Point(252, 72);
            this.txtHoraAmanecer.Name = "txtHoraAmanecer";
            this.txtHoraAmanecer.Size = new System.Drawing.Size(150, 20);
            this.txtHoraAmanecer.TabIndex = 19;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(252, 42);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(150, 20);
            this.txtFecha.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hora Max Temperatura:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(42, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hora Ocaso:";
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
            // txtTempOcaso
            // 
            this.txtTempOcaso.Location = new System.Drawing.Point(252, 224);
            this.txtTempOcaso.Name = "txtTempOcaso";
            this.txtTempOcaso.Size = new System.Drawing.Size(150, 20);
            this.txtTempOcaso.TabIndex = 27;
            // 
            // txtTempMax
            // 
            this.txtTempMax.Location = new System.Drawing.Point(252, 196);
            this.txtTempMax.Name = "txtTempMax";
            this.txtTempMax.Size = new System.Drawing.Size(150, 20);
            this.txtTempMax.TabIndex = 26;
            // 
            // txtTempAmanecer
            // 
            this.txtTempAmanecer.Location = new System.Drawing.Point(252, 161);
            this.txtTempAmanecer.Name = "txtTempAmanecer";
            this.txtTempAmanecer.Size = new System.Drawing.Size(150, 20);
            this.txtTempAmanecer.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Temperatura Maxima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(42, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Temperatura Ocaso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(42, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Temperatura Amanecer:";
            // 
            // frmEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.btnConnectDB);
            this.Controls.Add(this.btnTestConnection);
            this.Name = "frmEliminar";
            this.Text = "Eliminación de Datos";
            this.Load += new System.EventHandler(this.frmEliminar_Load);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConnectDB;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHoraOcaso;
        private System.Windows.Forms.TextBox txtHoraMaxTemp;
        private System.Windows.Forms.TextBox txtHoraAmanecer;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHoraAmanecer;
        private System.Windows.Forms.TextBox txtTempOcaso;
        private System.Windows.Forms.TextBox txtTempMax;
        private System.Windows.Forms.TextBox txtTempAmanecer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

    }
}