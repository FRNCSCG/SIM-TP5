
namespace WindowsFormsApp1
{
    partial class TP5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.clEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clReloj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRndAutoColon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTpoLlegadasColon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProxLlegadaColon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRndAutoUrquiza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTpoLlegadasUrquiza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clProxLlegadaUrquiza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEstSemaforoColon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clColaColon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCambioSemColon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEstSemaforoUrquiza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clColaUrquiza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCambioSemUrquiza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRndCruce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTiempoCruce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clContadorAutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAcumPermanencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSimular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.AllowUserToResizeRows = false;
            this.grilla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clEvento,
            this.clReloj,
            this.clDia,
            this.clRndAutoColon,
            this.clTpoLlegadasColon,
            this.clProxLlegadaColon,
            this.clRndAutoUrquiza,
            this.clTpoLlegadasUrquiza,
            this.clProxLlegadaUrquiza,
            this.clEstSemaforoColon,
            this.clColaColon,
            this.clCambioSemColon,
            this.clEstSemaforoUrquiza,
            this.clColaUrquiza,
            this.clCambioSemUrquiza,
            this.clRndCruce,
            this.clTiempoCruce,
            this.clContadorAutos,
            this.clAcumPermanencia});
            this.grilla.Location = new System.Drawing.Point(25, 105);
            this.grilla.Name = "grilla";
            this.grilla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grilla.RowHeadersVisible = false;
            this.grilla.Size = new System.Drawing.Size(951, 468);
            this.grilla.TabIndex = 0;
            // 
            // clEvento
            // 
            this.clEvento.HeaderText = "Evento";
            this.clEvento.Name = "clEvento";
            // 
            // clReloj
            // 
            this.clReloj.HeaderText = "Reloj";
            this.clReloj.Name = "clReloj";
            // 
            // clDia
            // 
            this.clDia.HeaderText = "Dias";
            this.clDia.Name = "clDia";
            // 
            // clRndAutoColon
            // 
            this.clRndAutoColon.HeaderText = "Rnd auto Colon";
            this.clRndAutoColon.Name = "clRndAutoColon";
            // 
            // clTpoLlegadasColon
            // 
            this.clTpoLlegadasColon.HeaderText = "Tiempo entre llegadas colon";
            this.clTpoLlegadasColon.Name = "clTpoLlegadasColon";
            // 
            // clProxLlegadaColon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clProxLlegadaColon.DefaultCellStyle = dataGridViewCellStyle1;
            this.clProxLlegadaColon.HeaderText = "Proxima llegada colon";
            this.clProxLlegadaColon.Name = "clProxLlegadaColon";
            // 
            // clRndAutoUrquiza
            // 
            this.clRndAutoUrquiza.HeaderText = "Rnd auto Urquiza";
            this.clRndAutoUrquiza.Name = "clRndAutoUrquiza";
            // 
            // clTpoLlegadasUrquiza
            // 
            this.clTpoLlegadasUrquiza.HeaderText = "Tiempo entre llegadas urquiza";
            this.clTpoLlegadasUrquiza.Name = "clTpoLlegadasUrquiza";
            // 
            // clProxLlegadaUrquiza
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clProxLlegadaUrquiza.DefaultCellStyle = dataGridViewCellStyle2;
            this.clProxLlegadaUrquiza.HeaderText = "Proxima llegada urquiza";
            this.clProxLlegadaUrquiza.Name = "clProxLlegadaUrquiza";
            // 
            // clEstSemaforoColon
            // 
            this.clEstSemaforoColon.HeaderText = "Estado Semaforo colon";
            this.clEstSemaforoColon.Name = "clEstSemaforoColon";
            // 
            // clColaColon
            // 
            this.clColaColon.HeaderText = "cola colon";
            this.clColaColon.Name = "clColaColon";
            // 
            // clCambioSemColon
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clCambioSemColon.DefaultCellStyle = dataGridViewCellStyle3;
            this.clCambioSemColon.HeaderText = "Proximo cambio sem colon";
            this.clCambioSemColon.Name = "clCambioSemColon";
            // 
            // clEstSemaforoUrquiza
            // 
            this.clEstSemaforoUrquiza.HeaderText = "Estado Semaforo urquiza";
            this.clEstSemaforoUrquiza.Name = "clEstSemaforoUrquiza";
            // 
            // clColaUrquiza
            // 
            this.clColaUrquiza.HeaderText = "cola urquiza";
            this.clColaUrquiza.Name = "clColaUrquiza";
            // 
            // clCambioSemUrquiza
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clCambioSemUrquiza.DefaultCellStyle = dataGridViewCellStyle4;
            this.clCambioSemUrquiza.HeaderText = "Proximo Cambio Sem Urquiza";
            this.clCambioSemUrquiza.Name = "clCambioSemUrquiza";
            // 
            // clRndCruce
            // 
            this.clRndCruce.HeaderText = "Rnd cruce";
            this.clRndCruce.Name = "clRndCruce";
            // 
            // clTiempoCruce
            // 
            this.clTiempoCruce.HeaderText = "tiempo cruce";
            this.clTiempoCruce.Name = "clTiempoCruce";
            // 
            // clContadorAutos
            // 
            this.clContadorAutos.HeaderText = "ContadorAutos";
            this.clContadorAutos.Name = "clContadorAutos";
            // 
            // clAcumPermanencia
            // 
            this.clAcumPermanencia.HeaderText = "Acumulador permanencia";
            this.clAcumPermanencia.Name = "clAcumPermanencia";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(12, 32);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(124, 41);
            this.btnSimular.TabIndex = 1;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // TP5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 585);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.grilla);
            this.Name = "TP5";
            this.Text = "TP3";
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clReloj;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRndAutoColon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTpoLlegadasColon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProxLlegadaColon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRndAutoUrquiza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTpoLlegadasUrquiza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clProxLlegadaUrquiza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEstSemaforoColon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clColaColon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCambioSemColon;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEstSemaforoUrquiza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clColaUrquiza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCambioSemUrquiza;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRndCruce;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTiempoCruce;
        private System.Windows.Forms.DataGridViewTextBoxColumn clContadorAutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAcumPermanencia;
    }
}