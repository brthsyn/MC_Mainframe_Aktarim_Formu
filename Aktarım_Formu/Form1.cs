using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft;
using System.Reflection;
using System.Resources;
using Microsoft.Office.Interop.Word;

namespace Aktarım_Formu
{
    public partial class Form1 : Form
    {
        
        string selectedCicsNames = " ";
        bool cicsNameMust = false;
        //string mainsavepath = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + "\\MF_Prod_Aktarim_Formu_";
        string mainsavepath = "C:\\Users\\" + Environment.UserName + "\\Desktop\\MF_Prod_Aktarim_Formu_";
        //string templateWordPath = @"V:\BilgiTeknolojileri\KartveIsyeriYazilimAnaliz\PROJE\_MF_Yazılım\Dökümantasyon\Aktarım Formu\Aktarım_Formu_Template.docx";
        string templateWordPath = @"C:\Users\" + Environment.UserName + @"\Aktarım_Formu_Template.docx";
        string savepath = "";


        int selectedrow = 0;
        
        
        public Form1()
        {
            InitializeComponent();
            NewcopyGroup.Visible = false;
            nameOfEngineerTb.Text = takeNameOfUser();
            updateButton.Enabled = false;
            insertButton.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Value_Control_Insert())
            {
                dataGridView1.Rows.Add(memberNameTb.Text, memberTypeCb.GetItemText(memberTypeCb.SelectedItem), selectedCicsNames);
                Value_Clear();

            }

        }

        public bool Value_Control_Insert()
        {
            if (memberNameTb.Text == "" )
            {
                MessageBox.Show("Aktarılacak Olan Member Name boş olamaz!");
                memberNameTb.Focus();
                return false;
            }

            if (memberTypeCb.SelectedIndex < 0)
            {
                MessageBox.Show("Aktarılacak olan Member Tipi seçiniz!");
                memberTypeCb.Focus();
                return false;
            }

            if (cicsNameMust)
            {
                if (Genlcics.Checked == false && akkcics.Checked == false)
                {
                    MessageBox.Show("Newcopy geçilmesi gereken Cics seçimini yapınız!");
                    return false;
                }
                else
                {
                    selectedCicsNames = " ";
                    if (Genlcics.Checked == true && akkcics.Checked == true)
                    {
                        selectedCicsNames = "GENLCICS - AKKCICS";
                    }
                    else
                    {
                        if (Genlcics.Checked == true)
                        {
                            selectedCicsNames = "GENLCICS";
                        }

                        if (akkcics.Checked == true)
                        {
                            selectedCicsNames = "AKKCICS";
                        }
                    }
                }
            }
            else
            {
                selectedCicsNames = "";
            }

            return true;

        }
        public bool Value_Control_Word()
        {
            /*
            if(nameofengineer.SelectedIndex < 0)
            {
                MessageBox.Show("Aktarım yapan Yazılımcı ismini seçiniz!");
                nameofengineer.Focus();
                return false;
            }*/

            if(dataGridView1.Rows.Count == 0 )
            {
                MessageBox.Show("Aktarım Listesine en az bir tane giriş yapınız!");
                return false;
            }

            if (timeofchange.SelectedIndex < 0)
            {
                MessageBox.Show("Aktarım saatini seçiniz!");
                timeofchange.Focus();
                return false;
            }

            return true;

        }
        public void Value_Clear()
        {
            memberNameTb.Text = "";
            memberTypeCb.SelectedIndex = -1;
            akkcics.Checked = false;
            Genlcics.Checked = false;
            cicsNameMust = false;
            selectedCicsNames = "";
            
        }

        private void memberTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memberTypeCb.GetItemText(memberTypeCb.SelectedItem) == "ISP" ||
                memberTypeCb.GetItemText(memberTypeCb.SelectedItem) == "Online")
            {
                cicsNameMust = true;
                NewcopyGroup.Visible = true;
            }
            else
            {
                cicsNameMust = false;
                NewcopyGroup.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            if (Value_Control_Insert())
            {
                dataGridView1.Rows[selectedrow].Cells[0].Value = memberNameTb.Text;
                dataGridView1.Rows[selectedrow].Cells[1].Value = memberTypeCb.GetItemText(memberTypeCb.SelectedItem);
                dataGridView1.Rows[selectedrow].Cells[2].Value = selectedCicsNames;
                Value_Clear();
                updateButton.Enabled = false;
                insertButton.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if(Value_Control_Word())
            {                
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                object fileName = templateWordPath;
                object confirmConversions = Type.Missing;
                object readOnly = Type.Missing;
                object addToRecentFiles = Type.Missing;
                object passwordDoc = Type.Missing;
                object passwordTemplate = Type.Missing;
                object revert = Type.Missing;
                object writepwdoc = Type.Missing;
                object writepwTemplate = Type.Missing;
                object format = Type.Missing;
                object encoding = Type.Missing;
                object visible = Type.Missing;
                object openRepair = Type.Missing;
                object docDirection = Type.Missing;
                object notEncoding = Type.Missing;
                object xmlTransform = Type.Missing;
                
                Microsoft.Office.Interop.Word.Document doc = wordApp.Documents.Open(
                    ref fileName, ref confirmConversions, ref readOnly, ref addToRecentFiles,
                    ref passwordDoc, ref passwordTemplate, ref revert, ref writepwdoc,
                    ref writepwTemplate, ref format, ref encoding, ref visible, ref openRepair,
                    ref docDirection, ref notEncoding, ref xmlTransform);

                ReplaceBookmarkText(doc, "transferdatetime", dateTimePicker1.Value.Date.Day.ToString() + "/" +
                                                             dateTimePicker1.Value.Date.Month.ToString() + "/" +
                                                             dateTimePicker1.Value.Date.Year.ToString() + "   -   " +
                                                             timeofchange.GetItemText(timeofchange.SelectedItem));
                ReplaceBookmarkText(doc, "nameofprogrammer", nameOfEngineerTb.Text);
                ReplaceBookmarkText(doc, "responsibleleadername", "Fatih VAN");
                ReplaceBookmarkText(doc, "explanationofchanges", explanation.Text);

                for (int i = 1; i < dataGridView1.RowCount + 1 ; i++)
                {
                    ReplaceBookmarkText(doc, "member"+i.ToString(), dataGridView1.Rows[i-1].Cells[0].Value.ToString());
                    ReplaceBookmarkText(doc, "membertype" + i.ToString(), dataGridView1.Rows[i-1].Cells[1].Value.ToString());
                    ReplaceBookmarkText(doc, "membercics" + i.ToString(), dataGridView1.Rows[i-1].Cells[2].Value.ToString());
                }

                savepath = mainsavepath + takeNameOfUser().Replace(" ", "_") +"_" + DateTime.Now.ToString("yyyyMMddTHHmmss") + ".docx";
                doc.SaveAs2(savepath);
                
                ((Microsoft.Office.Interop.Word._Document)doc).Close
                    (Microsoft.Office.Interop.Word.WdSaveOptions.wdDoNotSaveChanges, Microsoft.Office.Interop.Word.WdOriginalFormat.wdOriginalDocumentFormat, true);
                ((Microsoft.Office.Interop.Word._Application)wordApp).Quit();


                dataGridView1.Rows.Clear();
                dateTimePicker1.Value = DateTime.Now;
                timeofchange.SelectedIndex = -1;
                explanation.Text = "";
                updateButton.Enabled = false;
                insertButton.Enabled = true;
                
                            
                            
            }
        }

        private void ReplaceBookmarkText(Microsoft.Office.Interop.Word.Document doc,string bookmarkName,string text)
        {

            if (doc.Bookmarks.Exists(bookmarkName))
            {

                Object name = bookmarkName;

                Microsoft.Office.Interop.Word.Range range =

                doc.Bookmarks.get_Item(ref name).Range;



                range.Text = text;

                object newRange = range;

                doc.Bookmarks.Add(bookmarkName, ref newRange);

            }

        }

        /*private void nameofengineer_SelectedIndexChanged(object sender, EventArgs e)
        {
            savepath = mainsavepath + nameofengineer.GetItemText(nameofengineer.SelectedItem).ToString() + "_" +
                        DateTime.Now.ToString("yyyyMMddTHHmmss") + ".docx";
        }*/

        public string takeNameOfUser()
        {
            switch (Environment.UserName.ToUpper())
            {
                case "E060109":
                    return "Berat Hüseyin ÇİÇEK";
                case "E062131":
                    return "Berna YILMAZ";
                case "E066568":
                    return "Burçin EVCEN";
                case "E081206":
                    return "Bülent DERECİ";
                case "E048359":
                    return "Elif CEREYAN";
                case "E048383":
                    return "Fatih VAN";
                case "E048401":
                    return "Hamit NEBİ";
                case "E069371":
                    return "Hüseyin ŞEN";
                case "E069526":
                    return "Mustafa Sami DÜNDAR";
                case "E059107":
                    return "Muzaffer DAĞLIOĞLU";
                case "E048524":
                    return "Tamer MUTLU";
                case "E056087":
                    return "Tuğberk KARA ";
                default:
                    return "Tanımsız Kullanıcı";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = 0;
            if (e.RowIndex >= 0)
            {
                updateButton.Enabled = true;
                insertButton.Enabled = false;
                
                selectedrow = e.RowIndex;

                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                memberNameTb.Text = row.Cells[0].Value.ToString();
                memberTypeCb.SelectedItem = row.Cells[1].Value.ToString();

                NewcopyGroup.Visible = false;

                if (row.Cells[2].Value.ToString().Contains("GENLCICS"))
                {
                    Genlcics.Checked = true;
                    NewcopyGroup.Visible = true;
                }
                else
                    Genlcics.Checked = false;

                if (row.Cells[2].Value.ToString().Contains("AKKCICS"))
                {
                    akkcics.Checked = true;
                    NewcopyGroup.Visible = true;
                }
                else
                    akkcics.Checked = false;
                
            }
        }


    }
}
