using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IsTakipUygulamasi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bIMSERDataSet.IsTakipTanim' table. You can move, or remove it, as needed.
            this.isTakipTanimTableAdapter.Fill(this.bIMSERDataSet.IsTakipTanim);
            // TODO: This line of code loads data into the 'bIMSERDataSet.SorumluTanim' table. You can move, or remove it, as needed.
            this.sorumluTanimTableAdapter.Fill(this.bIMSERDataSet.SorumluTanim);
            // TODO: This line of code loads data into the 'bIMSERDataSet.MusteriTanim' table. You can move, or remove it, as needed.
            this.musteriTanimTableAdapter.Fill(this.bIMSERDataSet.MusteriTanim);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            gridView1.AddNewRow();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
            {
                if (XtraMessageBox.Show("Satır silinsin mi?", "Mesaj", MessageBoxButtons.YesNo) != DialogResult.Yes) return;
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
        }

        private void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            //gridView1.SetRowCellValue(e.RowHandle, "IsTakipTanim_rowid", 0);
            gridView1.SetRowCellValue(e.RowHandle, "sTicketNumarasi", "");
            gridView1.SetRowCellValue(e.RowHandle, "pMusteri", 0);
            gridView1.SetRowCellValue(e.RowHandle, "sKonu", "");
            gridView1.SetRowCellValue(e.RowHandle, "sAciklama", "");
            gridView1.SetRowCellValue(e.RowHandle, "sUstAciklama", "");
            gridView1.SetRowCellValue(e.RowHandle, "pSorumlu", 0);
            gridView1.SetRowCellValue(e.RowHandle, "dtPlanlamaTarihi", DateTime.Now.Date);
            gridView1.SetRowCellValue(e.RowHandle, "dtTamamlamaTarihi", DateTime.Now.Date);
            gridView1.SetRowCellValue(e.RowHandle, "sDurum", "");
            gridView1.SetRowCellValue(e.RowHandle, "bMailGonder", 0);
            gridView1.UpdateCurrentRow();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)  gridView1.FindFilterText = txtSearch.Text;
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            this.isTakipTanimTableAdapter.Adapter.Update(this.bIMSERDataSet.IsTakipTanim);
        }

        private void btnMailGonder_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRowCellDisplayText("pSorumlu") != "")
            {
                if (XtraMessageBox.Show($"{(gridView1.GetFocusedRowCellDisplayText("pSorumlu"))} mail gönderilsin mi?", "Mesaj", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    XtraMessageBox.Show("Mail gönderiliyor...");
                }
            }
        }
    }
}
