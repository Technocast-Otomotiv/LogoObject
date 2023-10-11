using System.Data;
using System.Data.OleDb;

namespace LogoObject
{
    public partial class Malzeme : Form
    {
        public Malzeme()
        {
            InitializeComponent();
        }

        private void btnexcelsec_Click(object sender, EventArgs e)
        {
            try
            {

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    using (OleDbConnection connect = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0;", openFileDialog1.FileName)))
                    {
                        DataTable dt = new DataTable();
                        OleDbDataAdapter cmd = new OleDbDataAdapter("Select * from [MALZEME$] ", connect);
                        cmd.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            UnityObjects.UnityApplication unityApp = new UnityObjects.UnityApplication();
            if (unityApp.Login(txtkullaniciadi.Text, txtsifre.Text, int.Parse(txtfirma.Text), int.Parse(txtdonem.Text)))
            {
                for (int i = 0; i < int.Parse(dataGridView1.RowCount.ToString()) - 1; i = i + 1)
                {
                    UnityObjects.Data malzemeKarti = unityApp.NewDataObject(UnityObjects.DataObjectType.doMaterial);
                    malzemeKarti.New();
                    malzemeKarti.DataFields.FieldByName("CARD_TYPE").Value = dataGridView1.Rows[i].Cells[0].Value;
                    malzemeKarti.DataFields.FieldByName("CODE").Value = dataGridView1.Rows[i].Cells[1].Value;
                    malzemeKarti.DataFields.FieldByName("NAME").Value = dataGridView1.Rows[i].Cells[2].Value;
                    malzemeKarti.DataFields.FieldByName("UNITSET_CODE").Value = dataGridView1.Rows[i].Cells[3].Value;// "BÝRÝM SET KODU (LOGODA BULUNMALI)";                                                                                                        
                    malzemeKarti.DataFields.FieldByName("AUXIL_CODE").Value = dataGridView1.Rows[i].Cells[4].Value;// "ÖZEL KOD 1";                                                                                                                
                    malzemeKarti.DataFields.FieldByName("USEF_PURCHASING").Value = 1;
                    malzemeKarti.DataFields.FieldByName("USEF_SALES").Value = 1;
                    malzemeKarti.DataFields.FieldByName("USEF_MM").Value = 1;
                    malzemeKarti.DataFields.FieldByName("VAT").Value = 20; //KDV ORANI SATINALMA
                    malzemeKarti.DataFields.FieldByName("SELVAT").Value = 20; // KDV ORANI SATIÞ
                    malzemeKarti.DataFields.FieldByName("RETURNVAT").Value = 20; // KDV ORANI ÝADE 
                    malzemeKarti.DataFields.FieldByName("SELPRVAT").Value = 20; // KDV ORANI PERAKENDE SATIÞ
                    malzemeKarti.DataFields.FieldByName("RETURNPRVAT").Value = 20; // KDV ORANI PERAKENDE ÝADE
                    UnityObjects.Lines units_lines = malzemeKarti.DataFields.FieldByName("UNITS").Lines;
                    units_lines.AppendLine();
                    units_lines[units_lines.Count - 1].FieldByName("UNIT_CODE").Value = dataGridView1.Rows[i].Cells[3].Value;// "BÝRÝM KODU (BÝRÝM SETÝNÝN ALTINDA BU BÝRÝM BULUNMALI)";
                    units_lines[units_lines.Count - 1].FieldByName("USEF_MTRLCLASS").Value = 1;
                    units_lines[units_lines.Count - 1].FieldByName("USEF_PURCHCLAS").Value = 1;
                    units_lines[units_lines.Count - 1].FieldByName("USEF_SALESCLAS").Value = 1;
                    units_lines[units_lines.Count - 1].FieldByName("CONV_FACT1").Value = 1; // BÝRÝM DÖNÜÞÜMLERÝ
                    units_lines[units_lines.Count - 1].FieldByName("CONV_FACT2").Value = 1; // BÝRÝM DÖNÜÞÜMLERÝ


                    if (malzemeKarti.Post() == true)
                    {
                        MessageBox.Show("" + dataGridView1.Rows[i].Cells[1].Value + " kodlu malzeme aktarýlmýþtýr", "OK");
                    }
                    else
                    {
                        if (malzemeKarti.ErrorCode != 0)
                        {
                            MessageBox.Show("DBError("
                            + malzemeKarti.ErrorCode.ToString()
                            + ")-"
                            + malzemeKarti.ErrorDesc
                            + malzemeKarti.DBErrorDesc);
                        }
                        else if (malzemeKarti.ValidateErrors.Count > 0)
                        {
                            string result = "XML ErrorList:";
                            for (int j = 0; j < malzemeKarti.ValidateErrors.Count; j++)
                            {
                                result += "("
                                + malzemeKarti.ValidateErrors[j].ID.ToString()
                                + ") - "
                                + malzemeKarti.ValidateErrors[j].Error;
                            }
                            MessageBox.Show(result);
                        }
                    }
                }

            }
        }
    }
}
