/*
 * Created by SharpDevelop.
 * User: Irfan
 * Date: 10/12/2021
 * Time: 09.13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data;

using System.Data.OleDb;
using System.Data;
using MySql.Data.MySqlClient;

namespace Rumah_Sakit
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new
MySqlConnection("Server=localhost;uid=root;password=; database=rumahsakit2;");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			combobox();
			loadDataDokter();
			comboboxDok();
			loadDataPoli();
			comboboxPoli();
			loadDataObat();
			comboboxObat();
			setRM();
			loadRM();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
		}
		private void combobox()
		{
			
			MySqlDataAdapter da = new MySqlDataAdapter("select * from pasien", co);
			DataTable dt = new DataTable();
			try {
				da.Fill(dt);
				selectpasien.DataSource = dt;
				selectpasien.ValueMember = "no_identitas";
				selectpasien.DisplayMember = "nama_pasien";
			} catch (Exception ex) {
				// tampilkan pesan error
				MessageBox.Show(ex.Message);
			}
		}
		public bool dbOpen()
		{ 
			try { 
				co.Open(); 
			} catch { 
				MessageBox.Show("Tidak Terhubung"); 
				return false; 
			} 
			return true; 
		}
		void LoadbuttonClick(object sender, EventArgs e)
		{
			loadData();
		}
		public void loadData()
		{
			MySqlCommand comand = new MySqlCommand("select * from pasien", co);
			try {
				MySqlDataAdapter sda = new MySqlDataAdapter();
				sda.SelectCommand = comand;
				DataTable dataset = new DataTable();
				sda.Fill(dataset);
				BindingSource bsource = new BindingSource();
				
				bsource.DataSource = dataset;
				datapasien.DataSource = bsource;
				sda.Update(dataset);
			} catch (Exception er) {
				MessageBox.Show(er.Message);
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			try {
				co.Open();
				mycommand.Connection = co;
				if (nama.Text != ""){
					mycommand.CommandText = "insert into pasien (no_identitas, nama_pasien, jenis_kelamin, alamat, no_telpon) values ('" + nik.Text + "','" + nama.Text + "', '" + jenkel.Text + "', '" + alamat.Text + "','" + notel.Text + "')";
				} 
				if (mycommand.ExecuteNonQuery() == 1) { 
					MessageBox.Show("Data berhasil dimasukkan", "Informasi", 
						MessageBoxButtons.OK, MessageBoxIcon.Information); 
					loadData();
					combobox();
				}
				co.Close();
			} catch (Exception er) {
				MessageBox.Show(er.Message);
			}
			co.Close();
		}
		void DeletepasienClick(object sender, EventArgs e)
		{
			try { 
				co.Open(); 
				mycommand.Connection = co;
				mycommand.CommandText = "delete from pasien where no_identitas = '" + selectpasien.SelectedValue + "'"; 
				myadapter.SelectCommand = mycommand; 
				mycommand.ExecuteNonQuery(); 
				loadData();
				combobox();
				co.Close();
			} catch (Exception ex) { 
				MessageBox.Show(ex.ToString()); 
			} 
			co.Close();
		}
		public void loadDataDokter()
		{
			MySqlCommand comand = new MySqlCommand("select * from dokter", co);
			try {
				MySqlDataAdapter sda = new MySqlDataAdapter();
				sda.SelectCommand = comand;
				DataTable dataset = new DataTable();
				sda.Fill(dataset);
				BindingSource bsource = new BindingSource();
				
				bsource.DataSource = dataset;
				datadokter.DataSource = bsource;
				sda.Update(dataset);
			} catch (Exception er) {
				MessageBox.Show(er.Message);
			}
		}
		private void comboboxDok()
		{
			
			MySqlDataAdapter da = new MySqlDataAdapter("select * from dokter", co);
			DataTable dt = new DataTable();
			try {
				da.Fill(dt);
				combodok.DataSource = dt;
				combodok.ValueMember = "id_dokter";
				combodok.DisplayMember = "nama_dokter";
				doktercombo.DataSource = dt;
				doktercombo.ValueMember = "id_dokter";
				doktercombo.DisplayMember = "nama_dokter";
			} catch (Exception ex) {
				// tampilkan pesan error
				MessageBox.Show(ex.Message);
			}
		}
		void AdddokterClick(object sender, EventArgs e)
		{
			try {
				co.Open();
				mycommand.Connection = co;
				if (iddok.Text != "" && namadokter.Text != "" && spesialisdokter.Text != ""){
									mycommand.CommandText = "insert into dokter (id_dokter, nama_dokter, spesialis, alamat, no_telp) values ('" + iddok.Text + "','" + namadokter.Text + "', '" + spesialisdokter.Text + "','" + alamatdokter.Text + "','" + noteldokter.Text + "')";
				}
				if (mycommand.ExecuteNonQuery() == 1) { 
					MessageBox.Show("Data berhasil dimasukkan", "Informasi", 
						MessageBoxButtons.OK, MessageBoxIcon.Information); 
					loadDataDokter();
					comboboxDok();
				}
				co.Close();
			} catch (Exception er) {
				MessageBox.Show(er.Message);
			}
			co.Close();
		}
		void DeletedokterClick(object sender, EventArgs e)
		{
			try { 
				co.Open(); 
				mycommand.Connection = co;
				mycommand.CommandText = "delete from dokter where id_dokter = '" + combodok.SelectedValue + "'"; 
				myadapter.SelectCommand = mycommand; 
				mycommand.ExecuteNonQuery(); 
				loadDataDokter();
				comboboxDok();
				co.Close();
			} catch (Exception ex) { 
				MessageBox.Show(ex.ToString()); 
			} 
			co.Close();
		}
		private void loadDataPoli()
		{
			MySqlCommand comand = new MySqlCommand("select * from poliklinik", co);
			try {
				MySqlDataAdapter sda = new MySqlDataAdapter();
				sda.SelectCommand = comand;
				DataTable dataset = new DataTable();
				sda.Fill(dataset);
				BindingSource bsource = new BindingSource();
				
				bsource.DataSource = dataset;
				datapoli.DataSource = bsource;
				sda.Update(dataset);
			} catch (Exception er) {
				MessageBox.Show(er.Message);
			}
		}
		private void comboboxPoli()
		{
			
			MySqlDataAdapter da = new MySqlDataAdapter("select * from poliklinik", co);
			DataTable dt = new DataTable();
			try {
				da.Fill(dt);
				combopoli.DataSource = dt;
				combopoli.ValueMember = "id_poli";
				combopoli.DisplayMember = "nama_poli";
				policombo.DataSource = dt;
				policombo.ValueMember = "id_poli";
				policombo.DisplayMember = "nama_poli";
				
			} catch (Exception ex) {
				// tampilkan pesan error
				MessageBox.Show(ex.Message);
			}
		}
		void AddpoliClick(object sender, EventArgs e)
		{
			try {
				co.Open();
				mycommand.Connection = co;
				if (idpoli.Text != "" && namapoli.Text != "" && gedungpoli.Text != ""){
									mycommand.CommandText = "insert into poliklinik (id_poli, nama_poli, gedung) values ('" + idpoli.Text + "','" + namapoli.Text + "', '" + gedungpoli.Text + "')";
				}
				if (mycommand.ExecuteNonQuery() == 1) { 
					MessageBox.Show("Data berhasil dimasukkan", "Informasi", 
						MessageBoxButtons.OK, MessageBoxIcon.Information); 
					loadDataPoli();
					comboboxPoli();
				}
				co.Close();
			} catch (Exception er) {
				MessageBox.Show(er.Message);
			}
			co.Close();
		}
		void DeletepoliClick(object sender, EventArgs e)
		{
			try { 
				co.Open(); 
				mycommand.Connection = co;
				mycommand.CommandText = "delete from poliklinik where id_poli = '" + combopoli.SelectedValue + "'"; 
				myadapter.SelectCommand = mycommand; 
				mycommand.ExecuteNonQuery(); 
				loadDataPoli();
				comboboxPoli();
				co.Close();
			} catch (Exception ex) { 
				MessageBox.Show(ex.ToString()); 
			} 
			co.Close();
		}
		private void loadDataObat()
		{
			MySqlCommand comand = new MySqlCommand("select * from obat", co);
			try {
				MySqlDataAdapter sda = new MySqlDataAdapter();
				sda.SelectCommand = comand;
				DataTable dataset = new DataTable();
				sda.Fill(dataset);
				BindingSource bsource = new BindingSource();
				
				bsource.DataSource = dataset;
				dataobat.DataSource = bsource;
				sda.Update(dataset);
			} catch (Exception er) {
				MessageBox.Show(er.Message);
			}
		}
		private void comboboxObat()
		{
			
			MySqlDataAdapter da = new MySqlDataAdapter("select * from obat", co);
			DataTable dt = new DataTable();
			try {
				da.Fill(dt);
				comboobat.DataSource = dt;
				comboobat.ValueMember = "id_obat";
				comboobat.DisplayMember = "nama_obat";
				obatcombo.DataSource = dt;
				obatcombo.ValueMember = "id_obat";
				obatcombo.DisplayMember = "nama_obat";
			} catch (Exception ex) {
				// tampilkan pesan error
				MessageBox.Show(ex.Message);
			}
		}
		void AddobatClick(object sender, EventArgs e)
		{
			try {
				co.Open();
				mycommand.Connection = co;
				if (idobat.Text != "" && namaobat.Text != "" && ketobat.Text != ""){
									mycommand.CommandText = "insert into obat (id_obat, nama_obat, ket_obat) values ('" + idobat.Text + "','" + namaobat.Text + "', '" + ketobat.Text + "')";
				}
				if (mycommand.ExecuteNonQuery() == 1) { 
					MessageBox.Show("Data berhasil dimasukkan", "Informasi", 
						MessageBoxButtons.OK, MessageBoxIcon.Information); 
					loadDataObat();
					comboboxObat();
				}
				co.Close();
			} catch (Exception er) {
				MessageBox.Show(er.Message);
			}
			co.Close();
		}
		void DeleteobatClick(object sender, EventArgs e)
		{
			try { 
				co.Open(); 
				mycommand.Connection = co;
				mycommand.CommandText = "delete from obat where id_obat = '" + comboobat.SelectedValue + "'"; 
				myadapter.SelectCommand = mycommand; 
				mycommand.ExecuteNonQuery(); 
				loadDataObat();
				comboboxObat();
				co.Close();
			} catch (Exception ex) { 
				MessageBox.Show(ex.ToString()); 
			} 
			co.Close();
		}
		void setRM()
		{
			MySqlDataAdapter da = new MySqlDataAdapter("select * from pasien", co);
			DataTable dt = new DataTable();
			try {
				da.Fill(dt);
				pasienrm.DataSource = dt;
				pasienrm.ValueMember = "no_identitas";
				pasienrm.DisplayMember = "nama_pasien";
			} catch (Exception ex) {
				// tampilkan pesan error
				MessageBox.Show(ex.Message);
			}
		}
		void upRM()
		{
			try {
				co.Open();
				mycommand.Connection = co;
				mycommand.CommandText = "update rekam_medis set id_pasien = '"+pasienrm.SelectedValue+"', keluhan = '"+keluhan.Text+"', id_dokter = '"+doktercombo.SelectedValue+"', diagnosa='"+diagnosa.Text+"', id_poli = '"+policombo.SelectedValue+"', tgl_periksa = '"+tanggal.Text+"', id_obat = '"+obatcombo.SelectedValue+"' where id_pasien = '"+pasienrm.SelectedValue+"'";
			if (mycommand.ExecuteNonQuery() == 1) { 
					MessageBox.Show("Data berhasil Diupdate", "Informasi", 
						MessageBoxButtons.OK, MessageBoxIcon.Information); 
					loadRM();
				}
				co.Close();
			}catch (Exception er) {
				MessageBox.Show(er.Message);
			    co.Close();
			}
			co.Close();
			
			
		}
		void addRM(){
			try{
				co.Open(); 
				mycommand.Connection = co;
				if (keluhan.Text != ""  && diagnosa.Text != ""){
									mycommand.CommandText = "insert into rekam_medis (id_pasien, keluhan, id_dokter,diagnosa,id_poli,tgl_periksa,id_obat) values ('" + pasienrm.SelectedValue + "','" + keluhan.Text + "', '" + doktercombo.SelectedValue + "','"+diagnosa.Text+"','"+policombo.SelectedValue+"','"+tanggal.Text+"','"+obatcombo.SelectedValue+"')";
				}
			if (mycommand.ExecuteNonQuery() == 1) { 
					MessageBox.Show("Data berhasil dimasukkan", "Informasi", 
						MessageBoxButtons.OK, MessageBoxIcon.Information); 
					loadRM();
				}
				co.Close();}
				catch(Exception ez){
					MessageBox.Show(ez.Message);
				}
		}
		
		void loadRM(){
			MySqlCommand comand = new MySqlCommand("select * from rekam_medis join pasien on rekam_medis.id_pasien = pasien.no_identitas join dokter on rekam_medis.id_dokter=dokter.id_dokter join obat on rekam_medis.id_obat = obat.id_obat join poliklinik on rekam_medis.id_poli = poliklinik.id_poli", co);
			try {
				MySqlDataAdapter sda = new MySqlDataAdapter();
				sda.SelectCommand = comand;
				DataTable dataset = new DataTable();
				sda.Fill(dataset);
				BindingSource bsource = new BindingSource();
				
				bsource.DataSource = dataset;
				datarekam.DataSource = bsource;
				sda.Update(dataset);

			} catch (Exception er) {
				MessageBox.Show(er.Message);
			}

		}
		
		void Button2Click(object sender, EventArgs e)
		{
			addRM();
		}
		void DelrmClick(object sender, EventArgs e)
		{
		try { 
				co.Open(); 
				mycommand.Connection = co;
				mycommand.CommandText = "delete from rekam_medis where id_rm = '"+Int32.Parse(idrm.Text)+"'";
				myadapter.SelectCommand = mycommand; 
				mycommand.ExecuteNonQuery(); 
				loadRM();
				co.Close();
			} catch (Exception ex) { 
				MessageBox.Show(ex.ToString()); 
			} 
			co.Close();
		}
		void UpbutnClick(object sender, EventArgs e)
		{
			upRM();
		}
		
		
	}
}
