using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Drawing;
using System.Drawing.Imaging;
using org.pdfclown.tools;

namespace WolviesWindowsTools
{
    public partial class frmMain : Form
    {
        public string combineName = "";
        public string fileDirectory = "";
        public List<string> fileList = new List<string>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void onEnter_PDF(object sender, DragEventArgs e)
        {
            if (sender.GetType() == typeof(ListView))
            {
                ListView lv = (ListView)sender;
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    this.Activate();
                    lblDrag_pdf.Visible = false;
                    e.Effect = DragDropEffects.Copy;
                } 
            }
        }

        private void onLeave_PDF(object sender, EventArgs e)
        {
            if (lv_files_cmb.Items.Count == 0)
            {
                lblDrag_pdf.Visible = true;
            }
        }

        private void onDrop_PDF(object sender, DragEventArgs e)
        {
            if (sender.GetType() == typeof(ListView))
            {
                ListView lv = (ListView)sender;
                bool warning = false;
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                {
                    if (Path.GetExtension(file).ToLower().Contains(".pdf"))
                    {
                        lv.Items.Add(Path.GetFileName(file));
                        fileList.Add(file);
                        lv.Items[0].Selected = true;
                        fileDirectory = Path.GetDirectoryName(file).ToString();
                    }
                    else
                    {
                        warning = true;
                    }
                }
                if (warning == true)
                {
                    MessageBox.Show("Some files were not added\ndue to them not being documents");
                }
                if (lv.Items.Count != 0)
                {
                    lblDrag_pdf.Visible = false;
                }                
            }
        }

        private void MoveUp(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lv_files_cmb.SelectedItems)
            {
                if (lvi.Index > 0)
                {
                    int index = lvi.Index - 1;
                    string file = fileList[lvi.Index];
                    fileList.RemoveAt(lvi.Index);
                    lv_files_cmb.Items.RemoveAt(lvi.Index);
                    lv_files_cmb.Items.Insert(index, lvi);
                    fileList.Insert(index, file);
                    lv_files_cmb.Focus();
                }
            }
        }


        private void MoveDn(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lv_files_cmb.SelectedItems)
            {
                if (lvi.Index < lv_files_cmb.Items.Count - 1)
                {
                    int index = lvi.Index + 1;
                    string file = fileList[lvi.Index];
                    fileList.RemoveAt(lvi.Index);
                    lv_files_cmb.Items.RemoveAt(lvi.Index);
                    lv_files_cmb.Items.Insert(index, lvi);
                    fileList.Insert(index, file);
                    lv_files_cmb.Focus();
                }
            }
        }

        private void Remove(object sender, EventArgs e)
        {
            if (lv_files_cmb.Items.Count == 0)
            {
                MessageBox.Show("Please drap files into the box on the left");
            }
            else
            {
                foreach (ListViewItem lvi in lv_files_cmb.SelectedItems)
                {
                    //remove selected entities
                    fileList.RemoveAt(lvi.Index);
                    lv_files_cmb.Items.RemoveAt(lvi.Index);
                }
                if (lv_files_cmb.Items.Count == 0)
                {
                    lblDrag_pdf.Visible = true;
                }
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            lv_files_cmb.Clear();
            fileList.Clear();
            lblDrag_pdf.Visible = true;
        }
        
        private void Combine(object sender, EventArgs e)
        {
            SaveFileDialog sfile = new SaveFileDialog();
            sfile.Filter = "PDF (*.pdf)|*.pdf";
            sfile.InitialDirectory = fileDirectory;
            if (sfile.ShowDialog(this) == DialogResult.OK)
            {
                if (sfile.FileName != null)
                {
                    combineName = sfile.FileName.ToString();
                }
                backgroundWorker.WorkerReportsProgress = true;
                backgroundWorker.RunWorkerAsync(fileList);
            }        
        }
       
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (lv_files_cmb.Items.Count != 0)
            {
                PdfDocument outputDocument = new PdfDocument();
                List<string> flist = (List<string>)e.Argument;
                int n = 1;
                foreach (string file in flist)
                {
                    string path = Path.GetFullPath(file);

                    try
                    {
                        PdfDocument inputDocument = CompatiblePdfReader.Open(path);
                        for (int i = 0; i < inputDocument.PageCount; i++)
                        {
                            PdfPage page = inputDocument.PageCount > i ?
                                inputDocument.Pages[i] : new PdfPage();  
                            
                            outputDocument.AddPage(page);
                            
                        }
                        backgroundWorker.ReportProgress(
                            Convert.ToInt32((decimal)n++ / lv_files_cmb.Items.Count * 100));
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("file: " + path + " cannot be combined" + ex.Message);
                    }
                    
                }
                try
                {
                    //for (int i = 0; i < flist.Count; i++)
                    //{
                    //    string f = Path.GetFileNameWithoutExtension(flist[i]);
                    //    outputDocument.Outlines.Add(f, )
                    //}                    
                    outputDocument.Save(combineName);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.ToString());
                }
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        private void backgroundWorker_Complete(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Complete");
            progressBar1.Value = 0;
        }
      
        private void onEnter_doc(object sender, DragEventArgs e)
        {
            if (sender.GetType() == typeof(ListView))
            {
                ListView lv = (ListView)sender;
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    this.Activate();
                    lblDrag_doc.Visible = false;
                    e.Effect = DragDropEffects.Copy;
                }
            }
        }

        private void onLeave_doc(object sender, EventArgs e)
        {
            if (lv_files_doc.Items.Count == 0)
            {
                lblDrag_doc.Visible = true;
            }
        }

        private void onDrop_doc(object sender, DragEventArgs e)
        {
            if (sender.GetType() == typeof(ListView))
            {
                ListView lv = (ListView)sender;
                
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files.Length == 1)
                {
                    if (Path.GetExtension(files[0]).ToLower().Contains(".pdf"))
                    {
                        //This only seems to work with
                        using (org.pdfclown.files.File Cfile = new org.pdfclown.files.File(files[0]))
                        {
                            org.pdfclown.documents.Document document = Cfile.Document;
                            org.pdfclown.documents.Pages Cpages = document.Pages;
                            foreach (org.pdfclown.documents.Page Cpage in Cpages)
                            {
                                Renderer renderer = new Renderer();
                                SizeF imageSize = new SizeF();
                                imageSize.Height = Cpage.Size.Height / 3;
                                imageSize.Width = Cpage.Size.Width / 3;
                                Image Cimage = renderer.Render(Cpage, imageSize);
                                imageList1.Images.Add(Cimage);
                            }
                        }
                    }

                    else
                    {
                        MessageBox.Show("Pleas only drop PDF's here.");
                    }

                    lv_files_doc.View = View.LargeIcon;
                    lv_files_doc.Columns.Add("File");
                    lv_files_doc.Columns[0].Width = lv_files_doc.Width - 4;
                    lv_files_doc.HeaderStyle = ColumnHeaderStyle.None;
                    imageList1.ImageSize = new Size(180, 128);
                    lv_files_doc.Scrollable = true;
                    
                    lv_files_doc.LargeImageList = imageList1;
                    
                    for (int j = 0; j < this.imageList1.Images.Count; j++)
                    {
                        ListViewItem item = new ListViewItem();
                        item.ImageIndex = j;
                        lv.Items.Add(item);
                    }

                    lv.Items[0].Selected = true;
                }
                //process single file


                else
                {
                    MessageBox.Show("Please drop only one file.");
                    return;
                }       

                if (lv.Items.Count != 0)
                {
                    lblDrag_pdf.Visible = false;
                }
            }
        }
        
        private void Apply_doc(object sender, EventArgs e)
        {

        }
    }
}

namespace PdfSharp.Pdf.IO
{
    static public class CompatiblePdfReader
    {
        /// <summary>
        /// uses itextsharp 4.1.6 to convert any pdf to 1.4 compatible pdf, called instead of PdfReader.open
        /// </summary>
        static public PdfDocument Open(string pdfPath)
        {
            using (var fileStream = new FileStream(pdfPath, FileMode.Open, FileAccess.Read))
            {
                var len = (int)fileStream.Length;
                var fileArray = new Byte[len];
                fileStream.Read(fileArray, 0, len);
                fileStream.Close();

                return Open(fileArray);
            }
        }

        /// <summary>
        /// uses itextsharp 4.1.6 to convert any pdf to 1.4 compatible pdf, called instead of PdfReader.open
        /// </summary>
        static public PdfDocument Open(byte[] fileArray)
        {
            return Open(new MemoryStream(fileArray));
        }

        /// <summary>
        /// uses itextsharp 4.1.6 to convert any pdf to 1.4 compatible pdf, called instead of PdfReader.open
        /// </summary>
        static public PdfDocument Open(MemoryStream sourceStream)
        {
            PdfDocument outDoc;
            sourceStream.Position = 0;

            try
            {
                outDoc = PdfReader.Open(sourceStream, PdfDocumentOpenMode.Import);
            }
            catch (PdfReaderException)
            {
                //workaround if pdfsharp doesn't support this pdf
                sourceStream.Position = 0;
                var outputStream = new MemoryStream();
                var reader = new iTextSharp.text.pdf.PdfReader(sourceStream);
                var pdfStamper = new iTextSharp.text.pdf.PdfStamper(reader, outputStream) { FormFlattening = true };
                pdfStamper.Writer.SetPdfVersion(iTextSharp.text.pdf.PdfWriter.PDF_VERSION_1_4);
                pdfStamper.Writer.CloseStream = false;
                pdfStamper.Close();

                outDoc = PdfReader.Open(outputStream, PdfDocumentOpenMode.Import);
            }

            return outDoc;
        }
    }
}
