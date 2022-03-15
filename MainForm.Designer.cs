/*
 * Created by SharpDevelop.
 * User: Irfan
 * Date: 10/12/2021
 * Time: 09.13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Rumah_Sakit
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button loadbutton;
        private System.Windows.Forms.DataGridView datapasien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox jenkel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox notel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button deletepasien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox selectpasien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button deletedokter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox combodok;
        private System.Windows.Forms.Button adddokter;
        private System.Windows.Forms.TextBox spesialisdokter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox alamatdokter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView datadokter;
        private System.Windows.Forms.TextBox noteldokter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox iddok;
        private System.Windows.Forms.Label iddokter;
        private System.Windows.Forms.TextBox namadokter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button deletepoli;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox combopoli;
        private System.Windows.Forms.Button addpoli;
        private System.Windows.Forms.DataGridView datapoli;
        private System.Windows.Forms.TextBox gedungpoli;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox idpoli;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox namapoli;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox ketobat;
        private System.Windows.Forms.Button deleteobat;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboobat;
        private System.Windows.Forms.Button addobat;
        private System.Windows.Forms.DataGridView dataobat;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox idobat;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox namaobat;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox pasienrm;
        private System.Windows.Forms.ComboBox doktercombo;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox policombo;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.ComboBox obatcombo;
        private System.Windows.Forms.TextBox keluhan;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox diagnosa;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DateTimePicker tanggal;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView datarekam;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button delrm;
        private System.Windows.Forms.TextBox idrm;
        private System.Windows.Forms.Button upbutn;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
        }

        private void InitializeComponent()
        {
        	System.Windows.Forms.TabPage tambah;
        	this.deletepasien = new System.Windows.Forms.Button();
        	this.label7 = new System.Windows.Forms.Label();
        	this.selectpasien = new System.Windows.Forms.ComboBox();
        	this.loadbutton = new System.Windows.Forms.Button();
        	this.datapasien = new System.Windows.Forms.DataGridView();
        	this.button1 = new System.Windows.Forms.Button();
        	this.alamat = new System.Windows.Forms.TextBox();
        	this.label6 = new System.Windows.Forms.Label();
        	this.jenkel = new System.Windows.Forms.ComboBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.notel = new System.Windows.Forms.TextBox();
        	this.label4 = new System.Windows.Forms.Label();
        	this.nik = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.nama = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label1 = new System.Windows.Forms.Label();
        	this.tabControl1 = new System.Windows.Forms.TabControl();
        	this.tabPage2 = new System.Windows.Forms.TabPage();
        	this.ketobat = new System.Windows.Forms.TextBox();
        	this.deleteobat = new System.Windows.Forms.Button();
        	this.label19 = new System.Windows.Forms.Label();
        	this.comboobat = new System.Windows.Forms.ComboBox();
        	this.addobat = new System.Windows.Forms.Button();
        	this.dataobat = new System.Windows.Forms.DataGridView();
        	this.label20 = new System.Windows.Forms.Label();
        	this.idobat = new System.Windows.Forms.TextBox();
        	this.label21 = new System.Windows.Forms.Label();
        	this.namaobat = new System.Windows.Forms.TextBox();
        	this.label23 = new System.Windows.Forms.Label();
        	this.label24 = new System.Windows.Forms.Label();
        	this.deletepoli = new System.Windows.Forms.Button();
        	this.label15 = new System.Windows.Forms.Label();
        	this.combopoli = new System.Windows.Forms.ComboBox();
        	this.addpoli = new System.Windows.Forms.Button();
        	this.datapoli = new System.Windows.Forms.DataGridView();
        	this.gedungpoli = new System.Windows.Forms.TextBox();
        	this.label16 = new System.Windows.Forms.Label();
        	this.idpoli = new System.Windows.Forms.TextBox();
        	this.label17 = new System.Windows.Forms.Label();
        	this.namapoli = new System.Windows.Forms.TextBox();
        	this.label18 = new System.Windows.Forms.Label();
        	this.deletedokter = new System.Windows.Forms.Button();
        	this.label14 = new System.Windows.Forms.Label();
        	this.combodok = new System.Windows.Forms.ComboBox();
        	this.adddokter = new System.Windows.Forms.Button();
        	this.spesialisdokter = new System.Windows.Forms.TextBox();
        	this.label13 = new System.Windows.Forms.Label();
        	this.alamatdokter = new System.Windows.Forms.TextBox();
        	this.label11 = new System.Windows.Forms.Label();
        	this.datadokter = new System.Windows.Forms.DataGridView();
        	this.noteldokter = new System.Windows.Forms.TextBox();
        	this.label10 = new System.Windows.Forms.Label();
        	this.iddok = new System.Windows.Forms.TextBox();
        	this.iddokter = new System.Windows.Forms.Label();
        	this.namadokter = new System.Windows.Forms.TextBox();
        	this.label12 = new System.Windows.Forms.Label();
        	this.label9 = new System.Windows.Forms.Label();
        	this.label22 = new System.Windows.Forms.Label();
        	this.label8 = new System.Windows.Forms.Label();
        	this.tabPage1 = new System.Windows.Forms.TabPage();
        	this.idrm = new System.Windows.Forms.TextBox();
        	this.delrm = new System.Windows.Forms.Button();
        	this.label34 = new System.Windows.Forms.Label();
        	this.datarekam = new System.Windows.Forms.DataGridView();
        	this.button2 = new System.Windows.Forms.Button();
        	this.tanggal = new System.Windows.Forms.DateTimePicker();
        	this.label33 = new System.Windows.Forms.Label();
        	this.keluhan = new System.Windows.Forms.TextBox();
        	this.label32 = new System.Windows.Forms.Label();
        	this.diagnosa = new System.Windows.Forms.TextBox();
        	this.label31 = new System.Windows.Forms.Label();
        	this.label30 = new System.Windows.Forms.Label();
        	this.obatcombo = new System.Windows.Forms.ComboBox();
        	this.label29 = new System.Windows.Forms.Label();
        	this.policombo = new System.Windows.Forms.ComboBox();
        	this.doktercombo = new System.Windows.Forms.ComboBox();
        	this.pasienrm = new System.Windows.Forms.ComboBox();
        	this.label26 = new System.Windows.Forms.Label();
        	this.label27 = new System.Windows.Forms.Label();
        	this.label28 = new System.Windows.Forms.Label();
        	this.label25 = new System.Windows.Forms.Label();
        	this.upbutn = new System.Windows.Forms.Button();
        	tambah = new System.Windows.Forms.TabPage();
        	tambah.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.datapasien)).BeginInit();
        	this.tabControl1.SuspendLayout();
        	this.tabPage2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dataobat)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.datapoli)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.datadokter)).BeginInit();
        	this.tabPage1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.datarekam)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// tambah
        	// 
        	tambah.Controls.Add(this.deletepasien);
        	tambah.Controls.Add(this.label7);
        	tambah.Controls.Add(this.selectpasien);
        	tambah.Controls.Add(this.loadbutton);
        	tambah.Controls.Add(this.datapasien);
        	tambah.Controls.Add(this.button1);
        	tambah.Controls.Add(this.alamat);
        	tambah.Controls.Add(this.label6);
        	tambah.Controls.Add(this.jenkel);
        	tambah.Controls.Add(this.label5);
        	tambah.Controls.Add(this.notel);
        	tambah.Controls.Add(this.label4);
        	tambah.Controls.Add(this.nik);
        	tambah.Controls.Add(this.label3);
        	tambah.Controls.Add(this.nama);
        	tambah.Controls.Add(this.label2);
        	tambah.Controls.Add(this.label1);
        	tambah.Location = new System.Drawing.Point(4, 29);
        	tambah.Name = "tambah";
        	tambah.Padding = new System.Windows.Forms.Padding(3);
        	tambah.Size = new System.Drawing.Size(982, 1335);
        	tambah.TabIndex = 0;
        	tambah.Text = "Data Pasien";
        	tambah.UseVisualStyleBackColor = true;
        	// 
        	// deletepasien
        	// 
        	this.deletepasien.BackColor = System.Drawing.Color.Crimson;
        	this.deletepasien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.deletepasien.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        	this.deletepasien.Location = new System.Drawing.Point(271, 600);
        	this.deletepasien.Name = "deletepasien";
        	this.deletepasien.Size = new System.Drawing.Size(136, 51);
        	this.deletepasien.TabIndex = 16;
        	this.deletepasien.Text = "Hapus";
        	this.deletepasien.UseVisualStyleBackColor = false;
        	this.deletepasien.Click += new System.EventHandler(this.DeletepasienClick);
        	// 
        	// label7
        	// 
        	this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label7.Location = new System.Drawing.Point(22, 555);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(131, 23);
        	this.label7.TabIndex = 15;
        	this.label7.Text = "Pasien";
        	// 
        	// selectpasien
        	// 
        	this.selectpasien.FormattingEnabled = true;
        	this.selectpasien.Location = new System.Drawing.Point(172, 555);
        	this.selectpasien.Name = "selectpasien";
        	this.selectpasien.Size = new System.Drawing.Size(235, 28);
        	this.selectpasien.TabIndex = 14;
        	// 
        	// loadbutton
        	// 
        	this.loadbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.loadbutton.Location = new System.Drawing.Point(653, 473);
        	this.loadbutton.Name = "loadbutton";
        	this.loadbutton.Size = new System.Drawing.Size(132, 51);
        	this.loadbutton.TabIndex = 13;
        	this.loadbutton.Text = "Load Data";
        	this.loadbutton.UseVisualStyleBackColor = true;
        	this.loadbutton.Click += new System.EventHandler(this.LoadbuttonClick);
        	// 
        	// datapasien
        	// 
        	this.datapasien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
        	this.datapasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.datapasien.Location = new System.Drawing.Point(458, 119);
        	this.datapasien.Name = "datapasien";
        	this.datapasien.RowTemplate.Height = 28;
        	this.datapasien.Size = new System.Drawing.Size(485, 338);
        	this.datapasien.TabIndex = 12;
        	// 
        	// button1
        	// 
        	this.button1.BackColor = System.Drawing.Color.Chartreuse;
        	this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        	this.button1.Location = new System.Drawing.Point(271, 473);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(136, 51);
        	this.button1.TabIndex = 11;
        	this.button1.Text = "Tambah";
        	this.button1.UseVisualStyleBackColor = false;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// alamat
        	// 
        	this.alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.alamat.Location = new System.Drawing.Point(172, 360);
        	this.alamat.Multiline = true;
        	this.alamat.Name = "alamat";
        	this.alamat.Size = new System.Drawing.Size(235, 97);
        	this.alamat.TabIndex = 10;
        	// 
        	// label6
        	// 
        	this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label6.Location = new System.Drawing.Point(22, 360);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(131, 23);
        	this.label6.TabIndex = 9;
        	this.label6.Text = "Alamat";
        	// 
        	// jenkel
        	// 
        	this.jenkel.FormattingEnabled = true;
        	this.jenkel.Items.AddRange(new object[] {
			"L",
			"P"});
        	this.jenkel.Location = new System.Drawing.Point(172, 298);
        	this.jenkel.Name = "jenkel";
        	this.jenkel.Size = new System.Drawing.Size(235, 28);
        	this.jenkel.TabIndex = 8;
        	// 
        	// label5
        	// 
        	this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label5.Location = new System.Drawing.Point(22, 298);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(141, 23);
        	this.label5.TabIndex = 7;
        	this.label5.Text = "Jenis Kelamin";
        	// 
        	// notel
        	// 
        	this.notel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.notel.Location = new System.Drawing.Point(172, 236);
        	this.notel.Name = "notel";
        	this.notel.Size = new System.Drawing.Size(235, 26);
        	this.notel.TabIndex = 6;
        	// 
        	// label4
        	// 
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(22, 236);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(131, 23);
        	this.label4.TabIndex = 5;
        	this.label4.Text = "No Telepon";
        	// 
        	// nik
        	// 
        	this.nik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.nik.Location = new System.Drawing.Point(172, 179);
        	this.nik.Name = "nik";
        	this.nik.Size = new System.Drawing.Size(235, 26);
        	this.nik.TabIndex = 4;
        	// 
        	// label3
        	// 
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(22, 179);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(131, 23);
        	this.label3.TabIndex = 3;
        	this.label3.Text = "No Identitas";
        	// 
        	// nama
        	// 
        	this.nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.nama.Location = new System.Drawing.Point(172, 121);
        	this.nama.Name = "nama";
        	this.nama.Size = new System.Drawing.Size(235, 26);
        	this.nama.TabIndex = 2;
        	// 
        	// label2
        	// 
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(22, 119);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(100, 23);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "Nama";
        	// 
        	// label1
        	// 
        	this.label1.BackColor = System.Drawing.Color.LimeGreen;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.Color.White;
        	this.label1.Location = new System.Drawing.Point(0, 0);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(978, 90);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Data Pasien";
        	this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// tabControl1
        	// 
        	this.tabControl1.Controls.Add(tambah);
        	this.tabControl1.Controls.Add(this.tabPage2);
        	this.tabControl1.Controls.Add(this.tabPage1);
        	this.tabControl1.Location = new System.Drawing.Point(1, 0);
        	this.tabControl1.Name = "tabControl1";
        	this.tabControl1.SelectedIndex = 0;
        	this.tabControl1.Size = new System.Drawing.Size(990, 1368);
        	this.tabControl1.TabIndex = 0;
        	// 
        	// tabPage2
        	// 
        	this.tabPage2.Controls.Add(this.ketobat);
        	this.tabPage2.Controls.Add(this.deleteobat);
        	this.tabPage2.Controls.Add(this.label19);
        	this.tabPage2.Controls.Add(this.comboobat);
        	this.tabPage2.Controls.Add(this.addobat);
        	this.tabPage2.Controls.Add(this.dataobat);
        	this.tabPage2.Controls.Add(this.label20);
        	this.tabPage2.Controls.Add(this.idobat);
        	this.tabPage2.Controls.Add(this.label21);
        	this.tabPage2.Controls.Add(this.namaobat);
        	this.tabPage2.Controls.Add(this.label23);
        	this.tabPage2.Controls.Add(this.label24);
        	this.tabPage2.Controls.Add(this.deletepoli);
        	this.tabPage2.Controls.Add(this.label15);
        	this.tabPage2.Controls.Add(this.combopoli);
        	this.tabPage2.Controls.Add(this.addpoli);
        	this.tabPage2.Controls.Add(this.datapoli);
        	this.tabPage2.Controls.Add(this.gedungpoli);
        	this.tabPage2.Controls.Add(this.label16);
        	this.tabPage2.Controls.Add(this.idpoli);
        	this.tabPage2.Controls.Add(this.label17);
        	this.tabPage2.Controls.Add(this.namapoli);
        	this.tabPage2.Controls.Add(this.label18);
        	this.tabPage2.Controls.Add(this.deletedokter);
        	this.tabPage2.Controls.Add(this.label14);
        	this.tabPage2.Controls.Add(this.combodok);
        	this.tabPage2.Controls.Add(this.adddokter);
        	this.tabPage2.Controls.Add(this.spesialisdokter);
        	this.tabPage2.Controls.Add(this.label13);
        	this.tabPage2.Controls.Add(this.alamatdokter);
        	this.tabPage2.Controls.Add(this.label11);
        	this.tabPage2.Controls.Add(this.datadokter);
        	this.tabPage2.Controls.Add(this.noteldokter);
        	this.tabPage2.Controls.Add(this.label10);
        	this.tabPage2.Controls.Add(this.iddok);
        	this.tabPage2.Controls.Add(this.iddokter);
        	this.tabPage2.Controls.Add(this.namadokter);
        	this.tabPage2.Controls.Add(this.label12);
        	this.tabPage2.Controls.Add(this.label9);
        	this.tabPage2.Controls.Add(this.label22);
        	this.tabPage2.Controls.Add(this.label8);
        	this.tabPage2.Location = new System.Drawing.Point(4, 29);
        	this.tabPage2.Name = "tabPage2";
        	this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
        	this.tabPage2.Size = new System.Drawing.Size(982, 1335);
        	this.tabPage2.TabIndex = 1;
        	this.tabPage2.Text = "Data Master";
        	this.tabPage2.UseVisualStyleBackColor = true;
        	// 
        	// ketobat
        	// 
        	this.ketobat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.ketobat.Location = new System.Drawing.Point(160, 1146);
        	this.ketobat.Multiline = true;
        	this.ketobat.Name = "ketobat";
        	this.ketobat.Size = new System.Drawing.Size(235, 97);
        	this.ketobat.TabIndex = 51;
        	// 
        	// deleteobat
        	// 
        	this.deleteobat.BackColor = System.Drawing.Color.Crimson;
        	this.deleteobat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.deleteobat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        	this.deleteobat.Location = new System.Drawing.Point(795, 1259);
        	this.deleteobat.Name = "deleteobat";
        	this.deleteobat.Size = new System.Drawing.Size(136, 51);
        	this.deleteobat.TabIndex = 50;
        	this.deleteobat.Text = "Hapus";
        	this.deleteobat.UseVisualStyleBackColor = false;
        	this.deleteobat.Click += new System.EventHandler(this.DeleteobatClick);
        	// 
        	// label19
        	// 
        	this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label19.Location = new System.Drawing.Point(448, 1199);
        	this.label19.Name = "label19";
        	this.label19.Size = new System.Drawing.Size(144, 25);
        	this.label19.TabIndex = 49;
        	this.label19.Text = "Obat";
        	// 
        	// comboobat
        	// 
        	this.comboobat.FormattingEnabled = true;
        	this.comboobat.Location = new System.Drawing.Point(598, 1199);
        	this.comboobat.Name = "comboobat";
        	this.comboobat.Size = new System.Drawing.Size(333, 28);
        	this.comboobat.TabIndex = 48;
        	// 
        	// addobat
        	// 
        	this.addobat.BackColor = System.Drawing.Color.Chartreuse;
        	this.addobat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.addobat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        	this.addobat.Location = new System.Drawing.Point(259, 1263);
        	this.addobat.Name = "addobat";
        	this.addobat.Size = new System.Drawing.Size(136, 47);
        	this.addobat.TabIndex = 47;
        	this.addobat.Text = "Tambah";
        	this.addobat.UseVisualStyleBackColor = false;
        	this.addobat.Click += new System.EventHandler(this.AddobatClick);
        	// 
        	// dataobat
        	// 
        	this.dataobat.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
        	this.dataobat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataobat.Location = new System.Drawing.Point(446, 1028);
        	this.dataobat.Name = "dataobat";
        	this.dataobat.RowTemplate.Height = 28;
        	this.dataobat.Size = new System.Drawing.Size(485, 143);
        	this.dataobat.TabIndex = 46;
        	// 
        	// label20
        	// 
        	this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label20.Location = new System.Drawing.Point(10, 1145);
        	this.label20.Name = "label20";
        	this.label20.Size = new System.Drawing.Size(131, 23);
        	this.label20.TabIndex = 44;
        	this.label20.Text = "Ket Obat";
        	// 
        	// idobat
        	// 
        	this.idobat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.idobat.Location = new System.Drawing.Point(160, 1088);
        	this.idobat.Name = "idobat";
        	this.idobat.Size = new System.Drawing.Size(235, 26);
        	this.idobat.TabIndex = 43;
        	// 
        	// label21
        	// 
        	this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label21.Location = new System.Drawing.Point(10, 1088);
        	this.label21.Name = "label21";
        	this.label21.Size = new System.Drawing.Size(131, 23);
        	this.label21.TabIndex = 42;
        	this.label21.Text = "ID Obat";
        	// 
        	// namaobat
        	// 
        	this.namaobat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.namaobat.Location = new System.Drawing.Point(160, 1030);
        	this.namaobat.Name = "namaobat";
        	this.namaobat.Size = new System.Drawing.Size(235, 26);
        	this.namaobat.TabIndex = 41;
        	// 
        	// label23
        	// 
        	this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label23.Location = new System.Drawing.Point(10, 1028);
        	this.label23.Name = "label23";
        	this.label23.Size = new System.Drawing.Size(116, 28);
        	this.label23.TabIndex = 40;
        	this.label23.Text = "Nama Obat";
        	// 
        	// label24
        	// 
        	this.label24.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label24.Location = new System.Drawing.Point(7, 964);
        	this.label24.Name = "label24";
        	this.label24.Size = new System.Drawing.Size(214, 44);
        	this.label24.TabIndex = 39;
        	this.label24.Text = "Data Obat";
        	this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// deletepoli
        	// 
        	this.deletepoli.BackColor = System.Drawing.Color.Crimson;
        	this.deletepoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.deletepoli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        	this.deletepoli.Location = new System.Drawing.Point(795, 875);
        	this.deletepoli.Name = "deletepoli";
        	this.deletepoli.Size = new System.Drawing.Size(136, 51);
        	this.deletepoli.TabIndex = 38;
        	this.deletepoli.Text = "Hapus";
        	this.deletepoli.UseVisualStyleBackColor = false;
        	this.deletepoli.Click += new System.EventHandler(this.DeletepoliClick);
        	// 
        	// label15
        	// 
        	this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label15.Location = new System.Drawing.Point(448, 822);
        	this.label15.Name = "label15";
        	this.label15.Size = new System.Drawing.Size(144, 25);
        	this.label15.TabIndex = 37;
        	this.label15.Text = "Poli";
        	// 
        	// combopoli
        	// 
        	this.combopoli.FormattingEnabled = true;
        	this.combopoli.Location = new System.Drawing.Point(598, 822);
        	this.combopoli.Name = "combopoli";
        	this.combopoli.Size = new System.Drawing.Size(333, 28);
        	this.combopoli.TabIndex = 36;
        	// 
        	// addpoli
        	// 
        	this.addpoli.BackColor = System.Drawing.Color.Chartreuse;
        	this.addpoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.addpoli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        	this.addpoli.Location = new System.Drawing.Point(259, 829);
        	this.addpoli.Name = "addpoli";
        	this.addpoli.Size = new System.Drawing.Size(136, 47);
        	this.addpoli.TabIndex = 35;
        	this.addpoli.Text = "Tambah";
        	this.addpoli.UseVisualStyleBackColor = false;
        	this.addpoli.Click += new System.EventHandler(this.AddpoliClick);
        	// 
        	// datapoli
        	// 
        	this.datapoli.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
        	this.datapoli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.datapoli.Location = new System.Drawing.Point(446, 651);
        	this.datapoli.Name = "datapoli";
        	this.datapoli.RowTemplate.Height = 28;
        	this.datapoli.Size = new System.Drawing.Size(485, 143);
        	this.datapoli.TabIndex = 34;
        	// 
        	// gedungpoli
        	// 
        	this.gedungpoli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.gedungpoli.Location = new System.Drawing.Point(160, 768);
        	this.gedungpoli.Name = "gedungpoli";
        	this.gedungpoli.Size = new System.Drawing.Size(235, 26);
        	this.gedungpoli.TabIndex = 33;
        	// 
        	// label16
        	// 
        	this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label16.Location = new System.Drawing.Point(10, 768);
        	this.label16.Name = "label16";
        	this.label16.Size = new System.Drawing.Size(131, 23);
        	this.label16.TabIndex = 32;
        	this.label16.Text = "Gedung";
        	// 
        	// idpoli
        	// 
        	this.idpoli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.idpoli.Location = new System.Drawing.Point(160, 711);
        	this.idpoli.Name = "idpoli";
        	this.idpoli.Size = new System.Drawing.Size(235, 26);
        	this.idpoli.TabIndex = 31;
        	// 
        	// label17
        	// 
        	this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label17.Location = new System.Drawing.Point(10, 711);
        	this.label17.Name = "label17";
        	this.label17.Size = new System.Drawing.Size(131, 23);
        	this.label17.TabIndex = 30;
        	this.label17.Text = "ID Poli";
        	// 
        	// namapoli
        	// 
        	this.namapoli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.namapoli.Location = new System.Drawing.Point(160, 653);
        	this.namapoli.Name = "namapoli";
        	this.namapoli.Size = new System.Drawing.Size(235, 26);
        	this.namapoli.TabIndex = 29;
        	// 
        	// label18
        	// 
        	this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label18.Location = new System.Drawing.Point(10, 651);
        	this.label18.Name = "label18";
        	this.label18.Size = new System.Drawing.Size(116, 28);
        	this.label18.TabIndex = 28;
        	this.label18.Text = "Nama Poli";
        	// 
        	// deletedokter
        	// 
        	this.deletedokter.BackColor = System.Drawing.Color.Crimson;
        	this.deletedokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.deletedokter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        	this.deletedokter.Location = new System.Drawing.Point(793, 376);
        	this.deletedokter.Name = "deletedokter";
        	this.deletedokter.Size = new System.Drawing.Size(136, 51);
        	this.deletedokter.TabIndex = 27;
        	this.deletedokter.Text = "Hapus";
        	this.deletedokter.UseVisualStyleBackColor = false;
        	this.deletedokter.Click += new System.EventHandler(this.DeletedokterClick);
        	// 
        	// label14
        	// 
        	this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label14.Location = new System.Drawing.Point(446, 323);
        	this.label14.Name = "label14";
        	this.label14.Size = new System.Drawing.Size(144, 25);
        	this.label14.TabIndex = 26;
        	this.label14.Text = "Dokter";
        	// 
        	// combodok
        	// 
        	this.combodok.FormattingEnabled = true;
        	this.combodok.Location = new System.Drawing.Point(596, 323);
        	this.combodok.Name = "combodok";
        	this.combodok.Size = new System.Drawing.Size(333, 28);
        	this.combodok.TabIndex = 25;
        	// 
        	// adddokter
        	// 
        	this.adddokter.BackColor = System.Drawing.Color.Chartreuse;
        	this.adddokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.adddokter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        	this.adddokter.Location = new System.Drawing.Point(257, 499);
        	this.adddokter.Name = "adddokter";
        	this.adddokter.Size = new System.Drawing.Size(136, 51);
        	this.adddokter.TabIndex = 24;
        	this.adddokter.Text = "Tambah";
        	this.adddokter.UseVisualStyleBackColor = false;
        	this.adddokter.Click += new System.EventHandler(this.AdddokterClick);
        	// 
        	// spesialisdokter
        	// 
        	this.spesialisdokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.spesialisdokter.Location = new System.Drawing.Point(158, 322);
        	this.spesialisdokter.Name = "spesialisdokter";
        	this.spesialisdokter.Size = new System.Drawing.Size(235, 26);
        	this.spesialisdokter.TabIndex = 23;
        	// 
        	// label13
        	// 
        	this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label13.Location = new System.Drawing.Point(8, 322);
        	this.label13.Name = "label13";
        	this.label13.Size = new System.Drawing.Size(131, 23);
        	this.label13.TabIndex = 22;
        	this.label13.Text = "Spesialis";
        	// 
        	// alamatdokter
        	// 
        	this.alamatdokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.alamatdokter.Location = new System.Drawing.Point(158, 376);
        	this.alamatdokter.Multiline = true;
        	this.alamatdokter.Name = "alamatdokter";
        	this.alamatdokter.Size = new System.Drawing.Size(235, 97);
        	this.alamatdokter.TabIndex = 21;
        	// 
        	// label11
        	// 
        	this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label11.Location = new System.Drawing.Point(8, 376);
        	this.label11.Name = "label11";
        	this.label11.Size = new System.Drawing.Size(131, 23);
        	this.label11.TabIndex = 20;
        	this.label11.Text = "Alamat";
        	// 
        	// datadokter
        	// 
        	this.datadokter.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
        	this.datadokter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.datadokter.Location = new System.Drawing.Point(444, 152);
        	this.datadokter.Name = "datadokter";
        	this.datadokter.RowTemplate.Height = 28;
        	this.datadokter.Size = new System.Drawing.Size(485, 143);
        	this.datadokter.TabIndex = 19;
        	// 
        	// noteldokter
        	// 
        	this.noteldokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.noteldokter.Location = new System.Drawing.Point(158, 269);
        	this.noteldokter.Name = "noteldokter";
        	this.noteldokter.Size = new System.Drawing.Size(235, 26);
        	this.noteldokter.TabIndex = 18;
        	// 
        	// label10
        	// 
        	this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label10.Location = new System.Drawing.Point(8, 269);
        	this.label10.Name = "label10";
        	this.label10.Size = new System.Drawing.Size(131, 23);
        	this.label10.TabIndex = 17;
        	this.label10.Text = "No Telepon";
        	// 
        	// iddok
        	// 
        	this.iddok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.iddok.Location = new System.Drawing.Point(158, 212);
        	this.iddok.Name = "iddok";
        	this.iddok.Size = new System.Drawing.Size(235, 26);
        	this.iddok.TabIndex = 16;
        	// 
        	// iddokter
        	// 
        	this.iddokter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.iddokter.Location = new System.Drawing.Point(8, 212);
        	this.iddokter.Name = "iddokter";
        	this.iddokter.Size = new System.Drawing.Size(131, 23);
        	this.iddokter.TabIndex = 15;
        	this.iddokter.Text = "ID Dokter";
        	// 
        	// namadokter
        	// 
        	this.namadokter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.namadokter.Location = new System.Drawing.Point(158, 154);
        	this.namadokter.Name = "namadokter";
        	this.namadokter.Size = new System.Drawing.Size(235, 26);
        	this.namadokter.TabIndex = 14;
        	// 
        	// label12
        	// 
        	this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label12.Location = new System.Drawing.Point(8, 152);
        	this.label12.Name = "label12";
        	this.label12.Size = new System.Drawing.Size(100, 23);
        	this.label12.TabIndex = 13;
        	this.label12.Text = "Nama";
        	// 
        	// label9
        	// 
        	this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label9.Location = new System.Drawing.Point(3, 90);
        	this.label9.Name = "label9";
        	this.label9.Size = new System.Drawing.Size(214, 44);
        	this.label9.TabIndex = 2;
        	this.label9.Text = "Data Dokter";
        	this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// label22
        	// 
        	this.label22.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label22.Location = new System.Drawing.Point(7, 587);
        	this.label22.Name = "label22";
        	this.label22.Size = new System.Drawing.Size(214, 44);
        	this.label22.TabIndex = 4;
        	this.label22.Text = "Data Poli";
        	this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// label8
        	// 
        	this.label8.BackColor = System.Drawing.Color.LimeGreen;
        	this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label8.ForeColor = System.Drawing.Color.White;
        	this.label8.Location = new System.Drawing.Point(0, 0);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(978, 90);
        	this.label8.TabIndex = 1;
        	this.label8.Text = "Data Master";
        	this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// tabPage1
        	// 
        	this.tabPage1.Controls.Add(this.upbutn);
        	this.tabPage1.Controls.Add(this.idrm);
        	this.tabPage1.Controls.Add(this.delrm);
        	this.tabPage1.Controls.Add(this.label34);
        	this.tabPage1.Controls.Add(this.datarekam);
        	this.tabPage1.Controls.Add(this.button2);
        	this.tabPage1.Controls.Add(this.tanggal);
        	this.tabPage1.Controls.Add(this.label33);
        	this.tabPage1.Controls.Add(this.keluhan);
        	this.tabPage1.Controls.Add(this.label32);
        	this.tabPage1.Controls.Add(this.diagnosa);
        	this.tabPage1.Controls.Add(this.label31);
        	this.tabPage1.Controls.Add(this.label30);
        	this.tabPage1.Controls.Add(this.obatcombo);
        	this.tabPage1.Controls.Add(this.label29);
        	this.tabPage1.Controls.Add(this.policombo);
        	this.tabPage1.Controls.Add(this.doktercombo);
        	this.tabPage1.Controls.Add(this.pasienrm);
        	this.tabPage1.Controls.Add(this.label26);
        	this.tabPage1.Controls.Add(this.label27);
        	this.tabPage1.Controls.Add(this.label28);
        	this.tabPage1.Controls.Add(this.label25);
        	this.tabPage1.Location = new System.Drawing.Point(4, 29);
        	this.tabPage1.Name = "tabPage1";
        	this.tabPage1.Size = new System.Drawing.Size(982, 1335);
        	this.tabPage1.TabIndex = 2;
        	this.tabPage1.Text = "Rekam Medis";
        	this.tabPage1.UseVisualStyleBackColor = true;
        	// 
        	// idrm
        	// 
        	this.idrm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.idrm.Location = new System.Drawing.Point(577, 509);
        	this.idrm.Name = "idrm";
        	this.idrm.Size = new System.Drawing.Size(100, 26);
        	this.idrm.TabIndex = 62;
        	// 
        	// delrm
        	// 
        	this.delrm.Location = new System.Drawing.Point(795, 491);
        	this.delrm.Name = "delrm";
        	this.delrm.Size = new System.Drawing.Size(136, 44);
        	this.delrm.TabIndex = 61;
        	this.delrm.Text = "Hapus Data";
        	this.delrm.UseVisualStyleBackColor = true;
        	this.delrm.Click += new System.EventHandler(this.DelrmClick);
        	// 
        	// label34
        	// 
        	this.label34.Location = new System.Drawing.Point(387, 512);
        	this.label34.Name = "label34";
        	this.label34.Size = new System.Drawing.Size(162, 23);
        	this.label34.TabIndex = 60;
        	this.label34.Text = "ID Rekam Medis";
        	// 
        	// datarekam
        	// 
        	this.datarekam.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
        	this.datarekam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.datarekam.Location = new System.Drawing.Point(12, 550);
        	this.datarekam.Name = "datarekam";
        	this.datarekam.RowTemplate.Height = 28;
        	this.datarekam.Size = new System.Drawing.Size(952, 295);
        	this.datarekam.TabIndex = 59;
        	// 
        	// button2
        	// 
        	this.button2.BackColor = System.Drawing.Color.Chartreuse;
        	this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        	this.button2.Location = new System.Drawing.Point(795, 416);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(136, 51);
        	this.button2.TabIndex = 58;
        	this.button2.Text = "Tambah";
        	this.button2.UseVisualStyleBackColor = false;
        	this.button2.Click += new System.EventHandler(this.Button2Click);
        	// 
        	// tanggal
        	// 
        	this.tanggal.CustomFormat = "yyyy/MM/dd";
        	this.tanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        	this.tanggal.Location = new System.Drawing.Point(162, 416);
        	this.tanggal.Name = "tanggal";
        	this.tanggal.Size = new System.Drawing.Size(235, 26);
        	this.tanggal.TabIndex = 57;
        	// 
        	// label33
        	// 
        	this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label33.Location = new System.Drawing.Point(12, 416);
        	this.label33.Name = "label33";
        	this.label33.Size = new System.Drawing.Size(131, 26);
        	this.label33.TabIndex = 56;
        	this.label33.Text = "Tanggal";
        	// 
        	// keluhan
        	// 
        	this.keluhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.keluhan.Location = new System.Drawing.Point(696, 301);
        	this.keluhan.Multiline = true;
        	this.keluhan.Name = "keluhan";
        	this.keluhan.Size = new System.Drawing.Size(235, 98);
        	this.keluhan.TabIndex = 55;
        	// 
        	// label32
        	// 
        	this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label32.Location = new System.Drawing.Point(546, 300);
        	this.label32.Name = "label32";
        	this.label32.Size = new System.Drawing.Size(131, 31);
        	this.label32.TabIndex = 54;
        	this.label32.Text = "Keluhan";
        	// 
        	// diagnosa
        	// 
        	this.diagnosa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        	this.diagnosa.Location = new System.Drawing.Point(696, 169);
        	this.diagnosa.Multiline = true;
        	this.diagnosa.Name = "diagnosa";
        	this.diagnosa.Size = new System.Drawing.Size(235, 98);
        	this.diagnosa.TabIndex = 53;
        	// 
        	// label31
        	// 
        	this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label31.Location = new System.Drawing.Point(546, 168);
        	this.label31.Name = "label31";
        	this.label31.Size = new System.Drawing.Size(131, 31);
        	this.label31.TabIndex = 52;
        	this.label31.Text = "Diagnosa";
        	// 
        	// label30
        	// 
        	this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label30.Location = new System.Drawing.Point(12, 350);
        	this.label30.Name = "label30";
        	this.label30.Size = new System.Drawing.Size(131, 23);
        	this.label30.TabIndex = 50;
        	this.label30.Text = "Obat";
        	// 
        	// obatcombo
        	// 
        	this.obatcombo.FormattingEnabled = true;
        	this.obatcombo.Location = new System.Drawing.Point(162, 351);
        	this.obatcombo.Name = "obatcombo";
        	this.obatcombo.Size = new System.Drawing.Size(235, 28);
        	this.obatcombo.TabIndex = 49;
        	// 
        	// label29
        	// 
        	this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label29.Location = new System.Drawing.Point(12, 289);
        	this.label29.Name = "label29";
        	this.label29.Size = new System.Drawing.Size(131, 23);
        	this.label29.TabIndex = 38;
        	this.label29.Text = "Poli";
        	// 
        	// policombo
        	// 
        	this.policombo.FormattingEnabled = true;
        	this.policombo.Location = new System.Drawing.Point(162, 290);
        	this.policombo.Name = "policombo";
        	this.policombo.Size = new System.Drawing.Size(235, 28);
        	this.policombo.TabIndex = 37;
        	// 
        	// doktercombo
        	// 
        	this.doktercombo.FormattingEnabled = true;
        	this.doktercombo.Location = new System.Drawing.Point(162, 228);
        	this.doktercombo.Name = "doktercombo";
        	this.doktercombo.Size = new System.Drawing.Size(235, 28);
        	this.doktercombo.TabIndex = 26;
        	// 
        	// pasienrm
        	// 
        	this.pasienrm.FormattingEnabled = true;
        	this.pasienrm.Location = new System.Drawing.Point(162, 168);
        	this.pasienrm.Name = "pasienrm";
        	this.pasienrm.Size = new System.Drawing.Size(235, 28);
        	this.pasienrm.TabIndex = 22;
        	// 
        	// label26
        	// 
        	this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label26.Location = new System.Drawing.Point(12, 227);
        	this.label26.Name = "label26";
        	this.label26.Size = new System.Drawing.Size(131, 23);
        	this.label26.TabIndex = 20;
        	this.label26.Text = "ID Dokter";
        	// 
        	// label27
        	// 
        	this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label27.Location = new System.Drawing.Point(12, 167);
        	this.label27.Name = "label27";
        	this.label27.Size = new System.Drawing.Size(100, 23);
        	this.label27.TabIndex = 18;
        	this.label27.Text = "Nama";
        	// 
        	// label28
        	// 
        	this.label28.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label28.Location = new System.Drawing.Point(7, 105);
        	this.label28.Name = "label28";
        	this.label28.Size = new System.Drawing.Size(214, 44);
        	this.label28.TabIndex = 17;
        	this.label28.Text = "Tambah Data";
        	this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        	// 
        	// label25
        	// 
        	this.label25.BackColor = System.Drawing.Color.LimeGreen;
        	this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label25.ForeColor = System.Drawing.Color.White;
        	this.label25.Location = new System.Drawing.Point(0, 0);
        	this.label25.Name = "label25";
        	this.label25.Size = new System.Drawing.Size(978, 90);
        	this.label25.TabIndex = 2;
        	this.label25.Text = "Rekam Medis";
        	this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// upbutn
        	// 
        	this.upbutn.BackColor = System.Drawing.Color.Chartreuse;
        	this.upbutn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.upbutn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        	this.upbutn.Location = new System.Drawing.Point(628, 416);
        	this.upbutn.Name = "upbutn";
        	this.upbutn.Size = new System.Drawing.Size(136, 51);
        	this.upbutn.TabIndex = 63;
        	this.upbutn.Text = "Update";
        	this.upbutn.UseVisualStyleBackColor = false;
        	this.upbutn.Click += new System.EventHandler(this.UpbutnClick);
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.AutoScroll = true;
        	this.ClientSize = new System.Drawing.Size(1013, 834);
        	this.Controls.Add(this.tabControl1);
        	this.Name = "MainForm";
        	this.Text = "Rumah Sakit";
        	tambah.ResumeLayout(false);
        	tambah.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.datapasien)).EndInit();
        	this.tabControl1.ResumeLayout(false);
        	this.tabPage2.ResumeLayout(false);
        	this.tabPage2.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dataobat)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.datapoli)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.datadokter)).EndInit();
        	this.tabPage1.ResumeLayout(false);
        	this.tabPage1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.datarekam)).EndInit();
        	this.ResumeLayout(false);

        }

    }
}





