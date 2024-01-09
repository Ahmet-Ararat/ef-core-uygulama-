using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        VtContex veriler = new VtContex();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            Ogrenci yeni_ogr = new Ogrenci();
            yeni_ogr.Okulno = Int32.Parse(txt_okulNo.Text);
            yeni_ogr.Ad = txt_ad.Text;
            yeni_ogr.Soyad = txt_soyad.Text;

            //kayýyt ekleme
            veriler.Add(yeni_ogr);
            veriler.SaveChanges();




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veriler.Ogrenciler.Load();
            dataGridView1.DataSource = veriler.Ogrenciler.Local.ToBindingList();



        }

        private void btn_sil_Click(object sender, EventArgs e)
        
            {

                if
    (dataGridView1.SelectedRows.Count > 0)

                {

                    //seçili satýrý siliyoruz.


                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                }
                else
                {


                    veriler.SaveChanges();
                }


            }
        }
    }