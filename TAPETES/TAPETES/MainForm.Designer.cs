/*
 * Created by SharpDevelop.
 * User: CC2-PC14
 * Date: 13/11/2024
 * Time: 08:01 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TAPETES
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lblTamaño = new System.Windows.Forms.Label();
			this.txtLargo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCosto = new System.Windows.Forms.TextBox();
			this.lblCosto = new System.Windows.Forms.Label();
			this.txtCantidadUsada1 = new System.Windows.Forms.TextBox();
			this.lblCantidad = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtCantidadUsada4 = new System.Windows.Forms.TextBox();
			this.txtCostoPorDocena = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.txtCantidadUsada5 = new System.Windows.Forms.TextBox();
			this.txtCostoPorLitro = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.txtNumeroDeIntegrantes = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.txtAncho = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.txtHorasDeDiseño = new System.Windows.Forms.TextBox();
			this.txtCostoDeCadaHora = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.txtCostoManoDeObra = new System.Windows.Forms.TextBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.lblPrecioFinal = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTamaño
			// 
			this.lblTamaño.BackColor = System.Drawing.Color.Silver;
			this.lblTamaño.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTamaño.Location = new System.Drawing.Point(12, 43);
			this.lblTamaño.Name = "lblTamaño";
			this.lblTamaño.Size = new System.Drawing.Size(202, 28);
			this.lblTamaño.TabIndex = 0;
			this.lblTamaño.Text = "datos del tapete";
			// 
			// txtLargo
			// 
			this.txtLargo.BackColor = System.Drawing.Color.Silver;
			this.txtLargo.Location = new System.Drawing.Point(228, 60);
			this.txtLargo.Name = "txtLargo";
			this.txtLargo.Size = new System.Drawing.Size(100, 20);
			this.txtLargo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Silver;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Aserrin: ";
			// 
			// txtCosto
			// 
			this.txtCosto.BackColor = System.Drawing.Color.Silver;
			this.txtCosto.Location = new System.Drawing.Point(228, 136);
			this.txtCosto.Name = "txtCosto";
			this.txtCosto.Size = new System.Drawing.Size(100, 20);
			this.txtCosto.TabIndex = 3;
			// 
			// lblCosto
			// 
			this.lblCosto.BackColor = System.Drawing.Color.Silver;
			this.lblCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCosto.Location = new System.Drawing.Point(228, 100);
			this.lblCosto.Name = "lblCosto";
			this.lblCosto.Size = new System.Drawing.Size(100, 23);
			this.lblCosto.TabIndex = 4;
			this.lblCosto.Text = "Costo Por costal";
			// 
			// txtCantidadUsada1
			// 
			this.txtCantidadUsada1.BackColor = System.Drawing.Color.Silver;
			this.txtCantidadUsada1.Location = new System.Drawing.Point(352, 136);
			this.txtCantidadUsada1.Name = "txtCantidadUsada1";
			this.txtCantidadUsada1.Size = new System.Drawing.Size(100, 20);
			this.txtCantidadUsada1.TabIndex = 5;
			// 
			// lblCantidad
			// 
			this.lblCantidad.BackColor = System.Drawing.Color.Silver;
			this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCantidad.Location = new System.Drawing.Point(352, 103);
			this.lblCantidad.Name = "lblCantidad";
			this.lblCantidad.Size = new System.Drawing.Size(100, 20);
			this.lblCantidad.TabIndex = 6;
			this.lblCantidad.Text = "Cantidad ";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Silver;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(78, 217);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(94, 30);
			this.label8.TabIndex = 17;
			this.label8.Text = "Flores:";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Silver;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(217, 210);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 23);
			this.label9.TabIndex = 18;
			this.label9.Text = "Costo por docena ";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Silver;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(352, 210);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(118, 23);
			this.label10.TabIndex = 19;
			this.label10.Text = "Cantidad Usada";
			// 
			// txtCantidadUsada4
			// 
			this.txtCantidadUsada4.BackColor = System.Drawing.Color.Silver;
			this.txtCantidadUsada4.Location = new System.Drawing.Point(352, 236);
			this.txtCantidadUsada4.Name = "txtCantidadUsada4";
			this.txtCantidadUsada4.Size = new System.Drawing.Size(100, 20);
			this.txtCantidadUsada4.TabIndex = 20;
			// 
			// txtCostoPorDocena
			// 
			this.txtCostoPorDocena.BackColor = System.Drawing.Color.Silver;
			this.txtCostoPorDocena.Location = new System.Drawing.Point(217, 236);
			this.txtCostoPorDocena.Name = "txtCostoPorDocena";
			this.txtCostoPorDocena.Size = new System.Drawing.Size(100, 20);
			this.txtCostoPorDocena.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Silver;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(66, 317);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(84, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "Agua:";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Silver;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(334, 288);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(118, 23);
			this.label12.TabIndex = 23;
			this.label12.Text = "cantidad";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Silver;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(181, 288);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(118, 23);
			this.label13.TabIndex = 24;
			this.label13.Text = "costo por cada litro";
			// 
			// txtCantidadUsada5
			// 
			this.txtCantidadUsada5.BackColor = System.Drawing.Color.Silver;
			this.txtCantidadUsada5.Location = new System.Drawing.Point(334, 314);
			this.txtCantidadUsada5.Name = "txtCantidadUsada5";
			this.txtCantidadUsada5.Size = new System.Drawing.Size(100, 20);
			this.txtCantidadUsada5.TabIndex = 25;
			// 
			// txtCostoPorLitro
			// 
			this.txtCostoPorLitro.BackColor = System.Drawing.Color.Silver;
			this.txtCostoPorLitro.Location = new System.Drawing.Point(181, 317);
			this.txtCostoPorLitro.Name = "txtCostoPorLitro";
			this.txtCostoPorLitro.Size = new System.Drawing.Size(100, 20);
			this.txtCostoPorLitro.TabIndex = 26;
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Silver;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(51, 381);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(130, 23);
			this.label14.TabIndex = 27;
			this.label14.Text = "Integrantes: ";
			// 
			// txtNumeroDeIntegrantes
			// 
			this.txtNumeroDeIntegrantes.BackColor = System.Drawing.Color.Silver;
			this.txtNumeroDeIntegrantes.Location = new System.Drawing.Point(228, 384);
			this.txtNumeroDeIntegrantes.Name = "txtNumeroDeIntegrantes";
			this.txtNumeroDeIntegrantes.Size = new System.Drawing.Size(100, 20);
			this.txtNumeroDeIntegrantes.TabIndex = 28;
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Silver;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(531, 78);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(231, 23);
			this.label15.TabIndex = 29;
			this.label15.Text = "Tiempo de diseño :";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Silver;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(228, 361);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(144, 20);
			this.label16.TabIndex = 30;
			this.label16.Text = "num de personas ";
			// 
			// txtAncho
			// 
			this.txtAncho.BackColor = System.Drawing.Color.Silver;
			this.txtAncho.Location = new System.Drawing.Point(352, 60);
			this.txtAncho.Name = "txtAncho";
			this.txtAncho.Size = new System.Drawing.Size(100, 20);
			this.txtAncho.TabIndex = 31;
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Silver;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(228, 9);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 23);
			this.label17.TabIndex = 32;
			this.label17.Text = "Largo";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Silver;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(352, 9);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 23);
			this.label18.TabIndex = 33;
			this.label18.Text = "Ancho";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Silver;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(511, 129);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(118, 23);
			this.label19.TabIndex = 34;
			this.label19.Text = "Horas de trabajo";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Silver;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(511, 200);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(118, 23);
			this.label20.TabIndex = 35;
			this.label20.Text = "Costo por hora";
			// 
			// txtHorasDeDiseño
			// 
			this.txtHorasDeDiseño.BackColor = System.Drawing.Color.Silver;
			this.txtHorasDeDiseño.Location = new System.Drawing.Point(691, 132);
			this.txtHorasDeDiseño.Name = "txtHorasDeDiseño";
			this.txtHorasDeDiseño.Size = new System.Drawing.Size(100, 20);
			this.txtHorasDeDiseño.TabIndex = 36;
			// 
			// txtCostoDeCadaHora
			// 
			this.txtCostoDeCadaHora.BackColor = System.Drawing.Color.Silver;
			this.txtCostoDeCadaHora.Location = new System.Drawing.Point(681, 200);
			this.txtCostoDeCadaHora.Name = "txtCostoDeCadaHora";
			this.txtCostoDeCadaHora.Size = new System.Drawing.Size(100, 20);
			this.txtCostoDeCadaHora.TabIndex = 37;
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Silver;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(12, 441);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(231, 23);
			this.label21.TabIndex = 38;
			this.label21.Text = "Costo de la mano de obra";
			// 
			// txtCostoManoDeObra
			// 
			this.txtCostoManoDeObra.BackColor = System.Drawing.Color.Silver;
			this.txtCostoManoDeObra.Location = new System.Drawing.Point(292, 444);
			this.txtCostoManoDeObra.Name = "txtCostoManoDeObra";
			this.txtCostoManoDeObra.Size = new System.Drawing.Size(100, 20);
			this.txtCostoManoDeObra.TabIndex = 39;
			// 
			// btnCalcular
			// 
			this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalcular.Location = new System.Drawing.Point(228, 486);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(133, 33);
			this.btnCalcular.TabIndex = 40;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.BtnCalcularClick);
			// 
			// lblPrecioFinal
			// 
			this.lblPrecioFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.lblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrecioFinal.Location = new System.Drawing.Point(487, 370);
			this.lblPrecioFinal.Name = "lblPrecioFinal";
			this.lblPrecioFinal.Size = new System.Drawing.Size(332, 129);
			this.lblPrecioFinal.TabIndex = 41;
			this.lblPrecioFinal.Text = "////";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Red;
			this.label22.Location = new System.Drawing.Point(594, 317);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(100, 23);
			this.label22.TabIndex = 42;
			this.label22.Text = "Precio Final ";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(831, 521);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.lblPrecioFinal);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.txtCostoManoDeObra);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.txtCostoDeCadaHora);
			this.Controls.Add(this.txtHorasDeDiseño);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.txtAncho);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.txtNumeroDeIntegrantes);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtCostoPorLitro);
			this.Controls.Add(this.txtCantidadUsada5);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.txtCostoPorDocena);
			this.Controls.Add(this.txtCantidadUsada4);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.lblCantidad);
			this.Controls.Add(this.txtCantidadUsada1);
			this.Controls.Add(this.lblCosto);
			this.Controls.Add(this.txtCosto);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtLargo);
			this.Controls.Add(this.lblTamaño);
			this.Name = "MainForm";
			this.Text = "TAPETES";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label lblPrecioFinal;
		private System.Windows.Forms.Button btnCalcular;
		private System.Windows.Forms.TextBox txtCostoManoDeObra;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox txtCostoDeCadaHora;
		private System.Windows.Forms.TextBox txtHorasDeDiseño;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox txtAncho;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox txtNumeroDeIntegrantes;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtCostoPorLitro;
		private System.Windows.Forms.TextBox txtCantidadUsada5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtCostoPorDocena;
		private System.Windows.Forms.TextBox txtCantidadUsada4;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblCantidad;
		private System.Windows.Forms.TextBox txtCantidadUsada1;
		private System.Windows.Forms.Label lblCosto;
		private System.Windows.Forms.TextBox txtCosto;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLargo;
		private System.Windows.Forms.Label lblTamaño;
	}
}
